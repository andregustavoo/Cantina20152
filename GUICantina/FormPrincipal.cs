using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUICantina
{
    public partial class FormPrincipal : Form
    {
        private FormFuncionario formFuncionario;
        private FormVenda formVenda;
        private FormVendaAutocomplete formVendaAutocomplete;
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formFuncionario == null)
                formFuncionario = new FormFuncionario();
            formFuncionario.ShowDialog(this);
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formVendaAutocomplete == null)
                formVendaAutocomplete = new FormVendaAutocomplete();
            formVendaAutocomplete.ShowDialog(this);
        }
    }
}
