using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControllerCantina.ADO;
using ModelCantina;
namespace GUICantina
{
    public partial class FormVenda : Form
    {
        ControllerFuncionario controllerFuncionario;
        ControllerProduto controllerProduto;
        List<Produto> listaProduto;
        AutoCompleteStringCollection listFuncionarios;//Mantém a lista autocomplete
        public FormVenda()
        {
            InitializeComponent();
            controllerFuncionario = new ControllerFuncionario();
            controllerProduto = new ControllerProduto();
            autoCompleteFuncionario();
            autoCompleteProduto();
        }
        private void autoCompleteFuncionario()
        {
            textBoxFuncionario.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBoxFuncionario.AutoCompleteSource = AutoCompleteSource.CustomSource;
           listFuncionarios = new AutoCompleteStringCollection();
            IList<Funcionario> listaFuncionarios=controllerFuncionario.BuscarFuncionarios("");
            foreach (Funcionario f in listaFuncionarios)
            {
                listFuncionarios.Add(f.Nome);//Adiciona o nome de funcionários na lista
            }
            textBoxFuncionario.AutoCompleteCustomSource = listFuncionarios; //Define a origem dos dados
            
        }

        private void autoCompleteProduto()
        {
            DataGridViewComboBoxColumn combo = (DataGridViewComboBoxColumn)dataGridViewProdutos.Columns[0];

            listaProduto = controllerProduto.BuscarProduto("");
            foreach (Produto p in listaProduto)
            {
                combo.Items.Add(p);
            }
            combo.DisplayMember = "Descricao";
            combo.ValueMember = "IdProduto";//Define qual o valor que será capturado

        }

        private void textBoxFuncionario_TextChanged(object sender, EventArgs e)
        {
            textBoxValorTotal.Text=listFuncionarios.IndexOf(textBoxFuncionario.Text).ToString();//Pega o indíce
        }

        private void dataGridViewProdutos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && dataGridViewProdutos.CurrentRow!=null)
            {
                int idProduto=Convert.ToInt32(dataGridViewProdutos.CurrentRow.Cells[0].Value.ToString());
                Produto p=listaProduto.Find(prod=>prod.IdProduto==idProduto);
                if (p != null)
                {
                    dataGridViewProdutos.CurrentRow.Cells[2].Value = p.PrecoUnitario;
                }

            }
            else if (e.ColumnIndex == 1 && dataGridViewProdutos.CurrentRow != null)
            {
                double quantidade,precoUnitario;
                if (Double.TryParse(dataGridViewProdutos.CurrentRow.Cells[2].Value.ToString(), out precoUnitario) &&
                    Double.TryParse(dataGridViewProdutos.CurrentRow.Cells[1].Value.ToString(), out quantidade))
                {
                    double valorTotal = precoUnitario * quantidade;
                    dataGridViewProdutos.CurrentRow.Cells[3].Value = String.Format("{0:C}", valorTotal);//Formata com currency
                }
            }
        }

        private void dataGridViewProdutos_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            //Define que todas as colunas do tipo Combobox são com auto complete
            if (e.Control is DataGridViewComboBoxEditingControl)
            {
                ((ComboBox)e.Control).DropDownStyle = ComboBoxStyle.DropDown;
                ((ComboBox)e.Control).AutoCompleteSource = AutoCompleteSource.ListItems;
                ((ComboBox)e.Control).AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            }
        }

    }
}
