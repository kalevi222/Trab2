namespace Estoque.Formularios
{
    partial class FrmEstoqueConsulta
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
            GrdItens = new DataGridView();
            IdEstoque = new DataGridViewTextBoxColumn();
            ProdutoNome = new DataGridViewTextBoxColumn();
            ProdutoID = new DataGridViewTextBoxColumn();
            MarcaProduto = new DataGridViewTextBoxColumn();
            CategoriaProduto = new DataGridViewTextBoxColumn();
            ProdutoPreco = new DataGridViewTextBoxColumn();
            QtdEmEstoque = new DataGridViewTextBoxColumn();
            ProdutoBarras = new DataGridViewTextBoxColumn();
            ProdutoLote = new DataGridViewTextBoxColumn();
            DataProd = new DataGridViewTextBoxColumn();
            DataValidade = new DataGridViewTextBoxColumn();
            CBPesquisa = new ComboBox();
            TxtPesquisa = new TextBox();
            DTPesquisa = new DateTimePicker();
            BtnPesquisar = new Button();
            label1 = new Label();
            label2 = new Label();
            BtnFechar = new Button();
            ((System.ComponentModel.ISupportInitialize)GrdItens).BeginInit();
            SuspendLayout();
            // 
            // GrdItens
            // 
            GrdItens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GrdItens.Columns.AddRange(new DataGridViewColumn[] { IdEstoque, ProdutoNome, ProdutoID, MarcaProduto, CategoriaProduto, ProdutoPreco, QtdEmEstoque, ProdutoBarras, ProdutoLote, DataProd, DataValidade });
            GrdItens.Location = new Point(12, 106);
            GrdItens.Name = "GrdItens";
            GrdItens.Size = new Size(1174, 429);
            GrdItens.TabIndex = 0;
            // 
            // IdEstoque
            // 
            IdEstoque.DataPropertyName = "Id";
            IdEstoque.HeaderText = "Id Estoque";
            IdEstoque.Name = "IdEstoque";
            IdEstoque.Width = 70;
            // 
            // ProdutoNome
            // 
            ProdutoNome.DataPropertyName = "Nome";
            ProdutoNome.HeaderText = "Produto";
            ProdutoNome.Name = "ProdutoNome";
            ProdutoNome.Width = 160;
            // 
            // ProdutoID
            // 
            ProdutoID.DataPropertyName = "PId";
            ProdutoID.HeaderText = "Id Produto";
            ProdutoID.Name = "ProdutoID";
            ProdutoID.Width = 70;
            // 
            // MarcaProduto
            // 
            MarcaProduto.DataPropertyName = "Marca";
            MarcaProduto.HeaderText = "Marca";
            MarcaProduto.Name = "MarcaProduto";
            // 
            // CategoriaProduto
            // 
            CategoriaProduto.DataPropertyName = "Categoria";
            CategoriaProduto.HeaderText = "Categoria";
            CategoriaProduto.Name = "CategoriaProduto";
            // 
            // ProdutoPreco
            // 
            ProdutoPreco.DataPropertyName = "Preco";
            ProdutoPreco.HeaderText = "Preço";
            ProdutoPreco.Name = "ProdutoPreco";
            // 
            // QtdEmEstoque
            // 
            QtdEmEstoque.DataPropertyName = "QTD";
            QtdEmEstoque.HeaderText = "Qtd em Estoque";
            QtdEmEstoque.Name = "QtdEmEstoque";
            QtdEmEstoque.Width = 70;
            // 
            // ProdutoBarras
            // 
            ProdutoBarras.DataPropertyName = "Barra";
            ProdutoBarras.HeaderText = "CodigoBarras";
            ProdutoBarras.Name = "ProdutoBarras";
            ProdutoBarras.Width = 160;
            // 
            // ProdutoLote
            // 
            ProdutoLote.DataPropertyName = "Lote";
            ProdutoLote.HeaderText = "Lote";
            ProdutoLote.Name = "ProdutoLote";
            // 
            // DataProd
            // 
            DataProd.DataPropertyName = "Data2";
            DataProd.HeaderText = "Data Produção";
            DataProd.Name = "DataProd";
            // 
            // DataValidade
            // 
            DataValidade.DataPropertyName = "Data3";
            DataValidade.HeaderText = "Validade";
            DataValidade.Name = "DataValidade";
            // 
            // CBPesquisa
            // 
            CBPesquisa.FormattingEnabled = true;
            CBPesquisa.Items.AddRange(new object[] { "Estoque ID", "Produto", "Produto ID", "Marca", "Categoria", "Preço", "Codigo de Barras", "Lote", "Data de Produção", "Validade" });
            CBPesquisa.Location = new Point(149, 12);
            CBPesquisa.Name = "CBPesquisa";
            CBPesquisa.Size = new Size(334, 23);
            CBPesquisa.TabIndex = 1;
            CBPesquisa.SelectedIndexChanged += CBPesquisa_SelectedIndexChanged;
            // 
            // TxtPesquisa
            // 
            TxtPesquisa.Location = new Point(149, 41);
            TxtPesquisa.Name = "TxtPesquisa";
            TxtPesquisa.Size = new Size(334, 23);
            TxtPesquisa.TabIndex = 2;
            // 
            // DTPesquisa
            // 
            DTPesquisa.Format = DateTimePickerFormat.Short;
            DTPesquisa.Location = new Point(149, 70);
            DTPesquisa.Name = "DTPesquisa";
            DTPesquisa.Size = new Size(334, 23);
            DTPesquisa.TabIndex = 3;
            // 
            // BtnPesquisar
            // 
            BtnPesquisar.Location = new Point(515, 25);
            BtnPesquisar.Name = "BtnPesquisar";
            BtnPesquisar.Size = new Size(164, 52);
            BtnPesquisar.TabIndex = 4;
            BtnPesquisar.Text = "Pesquisar";
            BtnPesquisar.UseVisualStyleBackColor = true;
            BtnPesquisar.Click += BtnPesquisar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 15);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 5;
            label1.Text = "Tipo de pesquisa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 44);
            label2.Name = "label2";
            label2.Size = new Size(111, 15);
            label2.TabIndex = 6;
            label2.Text = "Criterio de pesquisa";
            // 
            // BtnFechar
            // 
            BtnFechar.Location = new Point(1022, 25);
            BtnFechar.Name = "BtnFechar";
            BtnFechar.Size = new Size(164, 52);
            BtnFechar.TabIndex = 7;
            BtnFechar.Text = "Fechar";
            BtnFechar.UseVisualStyleBackColor = true;
            BtnFechar.Click += BtnFechar_Click;
            // 
            // FrmEstoqueConsulta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1192, 547);
            Controls.Add(BtnFechar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnPesquisar);
            Controls.Add(DTPesquisa);
            Controls.Add(TxtPesquisa);
            Controls.Add(CBPesquisa);
            Controls.Add(GrdItens);
            Name = "FrmEstoqueConsulta";
            Text = "Registro de produtos";
            Load += FrmEstoqueConsulta_Load;
            ((System.ComponentModel.ISupportInitialize)GrdItens).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView GrdItens;
        private ComboBox CBPesquisa;
        private TextBox TxtPesquisa;
        private DateTimePicker DTPesquisa;
        private Button BtnPesquisar;
        private DataGridViewTextBoxColumn IdEstoque;
        private DataGridViewTextBoxColumn ProdutoNome;
        private DataGridViewTextBoxColumn ProdutoID;
        private DataGridViewTextBoxColumn MarcaProduto;
        private DataGridViewTextBoxColumn CategoriaProduto;
        private DataGridViewTextBoxColumn ProdutoPreco;
        private DataGridViewTextBoxColumn QtdEmEstoque;
        private DataGridViewTextBoxColumn ProdutoBarras;
        private DataGridViewTextBoxColumn ProdutoLote;
        private DataGridViewTextBoxColumn DataProd;
        private DataGridViewTextBoxColumn DataValidade;
        private Label label1;
        private Label label2;
        private Button BtnFechar;
    }
}