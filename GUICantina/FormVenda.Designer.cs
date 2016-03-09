namespace GUICantina
{
    partial class FormVenda
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
            this.dataGridViewProdutos = new System.Windows.Forms.DataGridView();
            this.colProduto = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecoUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).BeginInit();
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
            this.groupBox1.Size = new System.Drawing.Size(678, 153);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados da Venda";
            // 
            // textBoxValorTotal
            // 
            this.textBoxValorTotal.Location = new System.Drawing.Point(358, 99);
            this.textBoxValorTotal.Name = "textBoxValorTotal";
            this.textBoxValorTotal.Size = new System.Drawing.Size(100, 22);
            this.textBoxValorTotal.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(307, 99);
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
            this.dateTimePickerDataVenda.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerDataVenda.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 99);
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
            this.label2.Location = new System.Drawing.Point(10, 67);
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
            this.textBoxFuncionario.TextChanged += new System.EventHandler(this.textBoxFuncionario_TextChanged);
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
            // dataGridViewProdutos
            // 
            this.dataGridViewProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProduto,
            this.colQuantidade,
            this.colPrecoUnitario,
            this.colSubtotal});
            this.dataGridViewProdutos.Location = new System.Drawing.Point(21, 171);
            this.dataGridViewProdutos.Name = "dataGridViewProdutos";
            this.dataGridViewProdutos.RowTemplate.Height = 24;
            this.dataGridViewProdutos.Size = new System.Drawing.Size(669, 262);
            this.dataGridViewProdutos.TabIndex = 1;
            this.dataGridViewProdutos.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProdutos_CellValueChanged);
            this.dataGridViewProdutos.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridViewProdutos_EditingControlShowing);
            // 
            // colProduto
            // 
            this.colProduto.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.colProduto.HeaderText = "Produto";
            this.colProduto.Name = "colProduto";
            this.colProduto.Width = 200;
            // 
            // colQuantidade
            // 
            this.colQuantidade.HeaderText = "Quantidade";
            this.colQuantidade.Name = "colQuantidade";
            // 
            // colPrecoUnitario
            // 
            this.colPrecoUnitario.HeaderText = "Preço Unitário";
            this.colPrecoUnitario.Name = "colPrecoUnitario";
            this.colPrecoUnitario.ReadOnly = true;
            // 
            // colSubtotal
            // 
            this.colSubtotal.HeaderText = "Subtotal";
            this.colSubtotal.Name = "colSubtotal";
            this.colSubtotal.ReadOnly = true;
            // 
            // FormVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 445);
            this.Controls.Add(this.dataGridViewProdutos);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registro de Vendas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.DataGridView dataGridViewProdutos;
        private System.Windows.Forms.DataGridViewComboBoxColumn colProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecoUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubtotal;
    }
}