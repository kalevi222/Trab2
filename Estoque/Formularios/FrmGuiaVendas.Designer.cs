namespace Estoque.Formularios
{
    partial class FrmGuiaVendas
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
            GrdVendas = new DataGridView();
            Idvenda = new DataGridViewTextBoxColumn();
            idProduto = new DataGridViewTextBoxColumn();
            ProdutoVenda = new DataGridViewTextBoxColumn();
            CodigoBarra = new DataGridViewTextBoxColumn();
            QuantidadeVenda = new DataGridViewTextBoxColumn();
            ValorUnitarioVenda = new DataGridViewTextBoxColumn();
            ValorTotalVenda = new DataGridViewTextBoxColumn();
            BtnRemover = new DataGridViewButtonColumn();
            CBProduto = new ComboBox();
            TxtId = new TextBox();
            TxtLote = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            TxtBarra = new TextBox();
            label4 = new Label();
            TxtEstoque = new TextBox();
            label5 = new Label();
            TxtValorTotal = new TextBox();
            TxtValorUnitario = new TextBox();
            BtnAdicionar = new Button();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            BtnVenda = new Button();
            BtnRegistro = new Button();
            BtnFechar = new Button();
            TxtQuantidade = new TextBox();
            ((System.ComponentModel.ISupportInitialize)GrdVendas).BeginInit();
            SuspendLayout();
            // 
            // GrdVendas
            // 
            GrdVendas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GrdVendas.Columns.AddRange(new DataGridViewColumn[] { Idvenda, idProduto, ProdutoVenda, CodigoBarra, QuantidadeVenda, ValorUnitarioVenda, ValorTotalVenda, BtnRemover });
            GrdVendas.Location = new Point(12, 159);
            GrdVendas.Name = "GrdVendas";
            GrdVendas.Size = new Size(827, 398);
            GrdVendas.TabIndex = 0;
            GrdVendas.CellClick += GrdVendas_CellClick;
            GrdVendas.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Idvenda
            // 
            Idvenda.DataPropertyName = "Id";
            Idvenda.HeaderText = "Id Venda";
            Idvenda.Name = "Idvenda";
            Idvenda.Width = 60;
            // 
            // idProduto
            // 
            idProduto.HeaderText = "Id do produto";
            idProduto.Name = "idProduto";
            idProduto.Width = 60;
            // 
            // ProdutoVenda
            // 
            ProdutoVenda.DataPropertyName = "Produto";
            ProdutoVenda.HeaderText = "Produto";
            ProdutoVenda.Name = "ProdutoVenda";
            ProdutoVenda.Width = 158;
            // 
            // CodigoBarra
            // 
            CodigoBarra.DataPropertyName = "Lote";
            CodigoBarra.HeaderText = "Codigo de Barras";
            CodigoBarra.Name = "CodigoBarra";
            CodigoBarra.Width = 150;
            // 
            // QuantidadeVenda
            // 
            QuantidadeVenda.DataPropertyName = "Quantidade";
            QuantidadeVenda.HeaderText = "Quantidade";
            QuantidadeVenda.Name = "QuantidadeVenda";
            QuantidadeVenda.Width = 75;
            // 
            // ValorUnitarioVenda
            // 
            ValorUnitarioVenda.DataPropertyName = "ValorUnitario";
            ValorUnitarioVenda.HeaderText = "Valor Unitario";
            ValorUnitarioVenda.Name = "ValorUnitarioVenda";
            // 
            // ValorTotalVenda
            // 
            ValorTotalVenda.DataPropertyName = "ValorTotal";
            ValorTotalVenda.HeaderText = "Valor Total";
            ValorTotalVenda.Name = "ValorTotalVenda";
            // 
            // BtnRemover
            // 
            BtnRemover.HeaderText = "Remover";
            BtnRemover.Name = "BtnRemover";
            BtnRemover.Width = 80;
            // 
            // CBProduto
            // 
            CBProduto.FormattingEnabled = true;
            CBProduto.Location = new Point(89, 25);
            CBProduto.Name = "CBProduto";
            CBProduto.Size = new Size(264, 23);
            CBProduto.TabIndex = 1;
            CBProduto.SelectedIndexChanged += CBProduto_SelectedIndexChanged;
            // 
            // TxtId
            // 
            TxtId.Enabled = false;
            TxtId.Location = new Point(12, 25);
            TxtId.Name = "TxtId";
            TxtId.Size = new Size(71, 23);
            TxtId.TabIndex = 2;
            // 
            // TxtLote
            // 
            TxtLote.Enabled = false;
            TxtLote.Location = new Point(12, 68);
            TxtLote.Name = "TxtLote";
            TxtLote.Size = new Size(104, 23);
            TxtLote.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 7);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 4;
            label1.Text = "ID Venda";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(89, 7);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 5;
            label2.Text = "Produto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 50);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 6;
            label3.Text = "Lote";
            // 
            // TxtBarra
            // 
            TxtBarra.Enabled = false;
            TxtBarra.Location = new Point(122, 68);
            TxtBarra.Name = "TxtBarra";
            TxtBarra.Size = new Size(337, 23);
            TxtBarra.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(122, 51);
            label4.Name = "label4";
            label4.Size = new Size(97, 15);
            label4.TabIndex = 8;
            label4.Text = "Codigo de Barras";
            // 
            // TxtEstoque
            // 
            TxtEstoque.Enabled = false;
            TxtEstoque.Location = new Point(359, 25);
            TxtEstoque.Name = "TxtEstoque";
            TxtEstoque.Size = new Size(100, 23);
            TxtEstoque.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(359, 9);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 10;
            label5.Text = "Em estoque";
            // 
            // TxtValorTotal
            // 
            TxtValorTotal.Location = new Point(317, 116);
            TxtValorTotal.Name = "TxtValorTotal";
            TxtValorTotal.Size = new Size(143, 23);
            TxtValorTotal.TabIndex = 11;
            TxtValorTotal.TextChanged += textBox5_TextChanged;
            // 
            // TxtValorUnitario
            // 
            TxtValorUnitario.Location = new Point(162, 116);
            TxtValorUnitario.Name = "TxtValorUnitario";
            TxtValorUnitario.Size = new Size(149, 23);
            TxtValorUnitario.TabIndex = 12;
            // 
            // BtnAdicionar
            // 
            BtnAdicionar.Location = new Point(479, 12);
            BtnAdicionar.Name = "BtnAdicionar";
            BtnAdicionar.Size = new Size(177, 54);
            BtnAdicionar.TabIndex = 13;
            BtnAdicionar.Text = "Adicionar";
            BtnAdicionar.UseVisualStyleBackColor = true;
            BtnAdicionar.Click += BtnAdicionar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 99);
            label6.Name = "label6";
            label6.Size = new Size(117, 15);
            label6.TabIndex = 15;
            label6.Text = "Quantidade a vender";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(162, 98);
            label7.Name = "label7";
            label7.Size = new Size(78, 15);
            label7.TabIndex = 16;
            label7.Text = "Valor Unitario";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(317, 98);
            label8.Name = "label8";
            label8.Size = new Size(61, 15);
            label8.TabIndex = 17;
            label8.Text = "Valor Total";
            // 
            // BtnVenda
            // 
            BtnVenda.Location = new Point(479, 86);
            BtnVenda.Name = "BtnVenda";
            BtnVenda.Size = new Size(177, 54);
            BtnVenda.TabIndex = 18;
            BtnVenda.Text = "Confirmar Venda";
            BtnVenda.UseVisualStyleBackColor = true;
            // 
            // BtnRegistro
            // 
            BtnRegistro.Location = new Point(662, 12);
            BtnRegistro.Name = "BtnRegistro";
            BtnRegistro.Size = new Size(177, 54);
            BtnRegistro.TabIndex = 19;
            BtnRegistro.Text = "Ver Registro de Produtos";
            BtnRegistro.UseVisualStyleBackColor = true;
            // 
            // BtnFechar
            // 
            BtnFechar.Location = new Point(662, 86);
            BtnFechar.Name = "BtnFechar";
            BtnFechar.Size = new Size(177, 54);
            BtnFechar.TabIndex = 20;
            BtnFechar.Text = "Fechar";
            BtnFechar.UseVisualStyleBackColor = true;
            BtnFechar.Click += BtnFechar_Click;
            // 
            // TxtQuantidade
            // 
            TxtQuantidade.Location = new Point(12, 116);
            TxtQuantidade.Name = "TxtQuantidade";
            TxtQuantidade.Size = new Size(144, 23);
            TxtQuantidade.TabIndex = 21;
            // 
            // FrmGuiaVendas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(846, 569);
            Controls.Add(TxtQuantidade);
            Controls.Add(BtnFechar);
            Controls.Add(BtnRegistro);
            Controls.Add(BtnVenda);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(BtnAdicionar);
            Controls.Add(TxtValorUnitario);
            Controls.Add(TxtValorTotal);
            Controls.Add(label5);
            Controls.Add(TxtEstoque);
            Controls.Add(label4);
            Controls.Add(TxtBarra);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TxtLote);
            Controls.Add(TxtId);
            Controls.Add(CBProduto);
            Controls.Add(GrdVendas);
            Name = "FrmGuiaVendas";
            Text = "Vendas";
            Load += FrmGuiaVendas_Load;
            ((System.ComponentModel.ISupportInitialize)GrdVendas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView GrdVendas;
        private ComboBox CBProduto;
        private TextBox TxtId;
        private TextBox TxtLote;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox TxtBarra;
        private Label label4;
        private TextBox TxtEstoque;
        private Label label5;
        private TextBox TxtValorTotal;
        private TextBox TxtValorUnitario;
        private Button BtnAdicionar;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button BtnVenda;
        private Button BtnRegistro;
        private Button BtnFechar;
        private TextBox TxtQuantidade;
        private DataGridViewTextBoxColumn Idvenda;
        private DataGridViewTextBoxColumn idProduto;
        private DataGridViewTextBoxColumn ProdutoVenda;
        private DataGridViewTextBoxColumn CodigoBarra;
        private DataGridViewTextBoxColumn QuantidadeVenda;
        private DataGridViewTextBoxColumn ValorUnitarioVenda;
        private DataGridViewTextBoxColumn ValorTotalVenda;
        private DataGridViewButtonColumn BtnExcluir;
        private DataGridViewButtonColumn BtnRemover;
    }
}