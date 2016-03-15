namespace GUICantina
{
    partial class FormVendaAutocomplete
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxValorTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerDataVenda = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFuncionario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewVendas = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxProduto = new System.Windows.Forms.TextBox();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.buttonRemover = new System.Windows.Forms.Button();
            this.textBoxQuantidade = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVendas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxValorTotal);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateTimePickerDataVenda);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxCliente);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxFuncionario);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(686, 141);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados da Venda";
            // 
            // textBoxValorTotal
            // 
            this.textBoxValorTotal.Location = new System.Drawing.Point(501, 101);
            this.textBoxValorTotal.Name = "textBoxValorTotal";
            this.textBoxValorTotal.Size = new System.Drawing.Size(102, 22);
            this.textBoxValorTotal.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(450, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total:";
            // 
            // dateTimePickerDataVenda
            // 
            this.dateTimePickerDataVenda.CustomFormat = "dd/mm/yyyy";
            this.dateTimePickerDataVenda.Location = new System.Drawing.Point(100, 99);
            this.dateTimePickerDataVenda.Name = "dateTimePickerDataVenda";
            this.dateTimePickerDataVenda.Size = new System.Drawing.Size(284, 22);
            this.dateTimePickerDataVenda.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data:";
            // 
            // textBoxCliente
            // 
            this.textBoxCliente.Location = new System.Drawing.Point(100, 67);
            this.textBoxCliente.Name = "textBoxCliente";
            this.textBoxCliente.Size = new System.Drawing.Size(513, 22);
            this.textBoxCliente.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cliente:";
            // 
            // textBoxFuncionario
            // 
            this.textBoxFuncionario.Location = new System.Drawing.Point(100, 33);
            this.textBoxFuncionario.Name = "textBoxFuncionario";
            this.textBoxFuncionario.Size = new System.Drawing.Size(513, 22);
            this.textBoxFuncionario.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Funcionário:";
            // 
            // dataGridViewVendas
            // 
            this.dataGridViewVendas.AllowUserToAddRows = false;
            this.dataGridViewVendas.AllowUserToDeleteRows = false;
            this.dataGridViewVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVendas.Location = new System.Drawing.Point(12, 197);
            this.dataGridViewVendas.Name = "dataGridViewVendas";
            this.dataGridViewVendas.RowTemplate.Height = 24;
            this.dataGridViewVendas.Size = new System.Drawing.Size(686, 178);
            this.dataGridViewVendas.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Produto:";
            // 
            // textBoxProduto
            // 
            this.textBoxProduto.Location = new System.Drawing.Point(112, 169);
            this.textBoxProduto.Name = "textBoxProduto";
            this.textBoxProduto.Size = new System.Drawing.Size(331, 22);
            this.textBoxProduto.TabIndex = 4;
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.Location = new System.Drawing.Point(542, 169);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(75, 23);
            this.buttonAdicionar.TabIndex = 5;
            this.buttonAdicionar.Text = "Adicionar";
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            this.buttonAdicionar.Click += new System.EventHandler(this.buttonAdicionar_Click);
            // 
            // buttonRemover
            // 
            this.buttonRemover.Location = new System.Drawing.Point(623, 169);
            this.buttonRemover.Name = "buttonRemover";
            this.buttonRemover.Size = new System.Drawing.Size(75, 23);
            this.buttonRemover.TabIndex = 6;
            this.buttonRemover.Text = "Remover";
            this.buttonRemover.UseVisualStyleBackColor = true;
            // 
            // textBoxQuantidade
            // 
            this.textBoxQuantidade.Location = new System.Drawing.Point(450, 169);
            this.textBoxQuantidade.Name = "textBoxQuantidade";
            this.textBoxQuantidade.Size = new System.Drawing.Size(86, 22);
            this.textBoxQuantidade.TabIndex = 7;
            // 
            // FormVendaAutocomplete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 387);
            this.Controls.Add(this.textBoxQuantidade);
            this.Controls.Add(this.buttonRemover);
            this.Controls.Add(this.buttonAdicionar);
            this.Controls.Add(this.textBoxProduto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridViewVendas);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormVendaAutocomplete";
            this.Text = "FormVendaAutocomplete";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVendas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxValorTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataVenda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFuncionario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewVendas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxProduto;
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.Button buttonRemover;
        private System.Windows.Forms.TextBox textBoxQuantidade;
    }
}