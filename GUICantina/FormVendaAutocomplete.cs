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
    public partial class FormVendaAutocomplete : Form
    {
        private Venda vendaAtual;
        private ControllerProduto controllerProduto;
        private AutoCompleteStringCollection produtos;
        private List<Produto> listaProdutos;
        public FormVendaAutocomplete()
        {
            InitializeComponent();
            vendaAtual = new Venda();
            controllerProduto = new ControllerProduto();
            autocompleteProduto();
        }

        private void autocompleteProduto()
        {
            textBoxProduto.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBoxProduto.AutoCompleteSource = AutoCompleteSource.CustomSource;
            produtos = new AutoCompleteStringCollection();
            listaProdutos = controllerProduto.BuscarProduto("");
            foreach (Produto prod in listaProdutos)
            {
                produtos.Add(prod.Descricao);
            }
            textBoxProduto.AutoCompleteCustomSource = produtos;
        }
        private void AtualizarDataGrid()
        {
            dataGridViewVendas.DataSource = vendaAtual.Items;
        }
        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            //Primeiro verifica se o produto já existe na lista e foi selecionado;
            int posicao;
            if ((posicao=produtos.IndexOf(textBoxProduto.Text)) != -1)
            {
                Produto p = listaProdutos[posicao];
                //Verifique se esse produto já existe na listagem

                foreach (VendaProduto vp in vendaAtual.Items)
                {
                    if (vp.Produto.IdProduto == p.IdProduto)
                    {
                        MessageBox.Show("Produto já foi adicionado");
                        return;
                    }
                }
                VendaProduto item = new VendaProduto();
                item.Produto = p;
                item.Venda = vendaAtual;
                item.Quantidade = Convert.ToDouble(textBoxQuantidade.Text);
                vendaAtual.Items.Add(item);
                AtualizarDataGrid();//Não está atualizando o Grid depois da primeira execução.
            }
            
        }
    }
}
