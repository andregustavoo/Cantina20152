using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelCantina;
using ControllerCantina.ADO;

namespace GUICantina
{
    public partial class FormFuncionario : Form
    {
       private ControllerFuncionario controller;
        public FormFuncionario()
        {
            InitializeComponent();
            controller = new ControllerCantina.ADO.ControllerFuncionario();
            AtualizarDataGrid();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            Novo();
        }

        private void Novo()
        {
            textBoxIDFuncionario.Text = "0";
            textBoxNomeFuncionario.Text = "";
            textBoxMatricula.Text = "";
            textBoxNomeFuncionario.Focus();
        }

        private void buttonGravar_Click(object sender, EventArgs e)
        {
            
            Funcionario funcionario = new Funcionario();
            //Colocar a validação aqui
            funcionario.Nome = textBoxNomeFuncionario.Text;
            funcionario.Matricula = textBoxMatricula.Text;
            funcionario.IdFuncionario = Convert.ToInt32(textBoxIDFuncionario.Text);
            if (funcionario.IdFuncionario==0)
            {
                if (controller.GravarFuncionario(funcionario))
                {
                    MessageBox.Show("Funcionário Inserido com Sucesso", "Cantina");
                    AtualizarDataGrid();
                    Novo();
                }
                else
                {
                    MessageBox.Show("Erro Inserindo Funcionário", "Cantina");
                }
            }
            else
            {
                if (controller.GravarFuncionario(funcionario))
                {
                    MessageBox.Show("Funcionário Atualizado com Sucesso", "Cantina");
                    AtualizarDataGrid();
                }
                else
                {
                    MessageBox.Show("Erro Atualizando Funcionário", "Cantina");
                }
            }

            

        }
        private void AtualizarDataGrid()
        {
            dataGridViewFuncionarios.DataSource = controller.BuscarFuncionarios("");
            dataGridViewFuncionarios.Columns[0].Visible = false;
        }

        private void dataGridViewFuncionarios_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewFuncionarios.CurrentRow != null)
            {
                Funcionario f = ((List<Funcionario>)dataGridViewFuncionarios.DataSource).ElementAt(dataGridViewFuncionarios.CurrentRow.Index);
                textBoxIDFuncionario.Text = f.IdFuncionario.ToString();
                textBoxNomeFuncionario.Text = f.Nome;
                textBoxMatricula.Text = f.Matricula;
            }
        }

        private void buttonRemover_Click(object sender, EventArgs e)
        {

            if (dataGridViewFuncionarios.CurrentRow == null)
            {
                MessageBox.Show("Selecione um Funcionário para Excluir", "Cantina");
                return;
            }
            //Solicita a confirmação do usuário
            DialogResult result = MessageBox.Show("Deseja Realmente Excluir?", "Cantina", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                Funcionario funcionario = new Funcionario();
                funcionario.IdFuncionario = Convert.ToInt32(textBoxIDFuncionario.Text);
                if (controller.ExcluirFuncionario(funcionario))
                {
                    MessageBox.Show("Funcionário Excluido com Sucesso", "Cantina");
                    Novo();
                    AtualizarDataGrid();
                }
                else
                {
                    MessageBox.Show("Erro Excluindo Funcionário", "Cantinha");
                }
            }
        }

        private void textBoxNomeFuncionario_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxNomeFuncionario.Text.Trim().Length < 10)
            {
                e.Cancel = true;
                errorProvider.SetError(textBoxNomeFuncionario, "O nome do funcionário deve ter pelo menos 10 caracteres");
                return;
            }
            errorProvider.SetError(textBoxNomeFuncionario, "");

        }
    }
}
