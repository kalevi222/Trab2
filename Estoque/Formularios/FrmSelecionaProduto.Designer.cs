namespace Estoque.Formularios
{
    partial class FrmSelecionaProduto
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
            BtnFechar = new Button();
            ID = new DataGridViewTextBoxColumn();
            ProdutoNome = new DataGridViewTextBoxColumn();
            LoteProduto = new DataGridViewTextBoxColumn();
            QuantidadeProduto = new DataGridViewTextBoxColumn();
            CodigoBarrasProduto = new DataGridViewTextBoxColumn();
            ValorUnitarioProduto = new DataGridViewTextBoxColumn();
            BtnSelecionar = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)GrdItens).BeginInit();
            SuspendLayout();
            // 
            // GrdItens
            // 
            GrdItens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GrdItens.Columns.AddRange(new DataGridViewColumn[] { ID, ProdutoNome, LoteProduto, QuantidadeProduto, CodigoBarrasProduto, ValorUnitarioProduto, BtnSelecionar });
            GrdItens.Location = new Point(12, 12);
            GrdItens.Name = "GrdItens";
            GrdItens.Size = new Size(767, 351);
            GrdItens.TabIndex = 0;
            GrdItens.CellClick += GrdItens_CellClick;
            // 
            // BtnFechar
            // 
            BtnFechar.Location = new Point(592, 369);
            BtnFechar.Name = "BtnFechar";
            BtnFechar.Size = new Size(187, 52);
            BtnFechar.TabIndex = 1;
            BtnFechar.Text = "Fechar";
            BtnFechar.UseVisualStyleBackColor = true;
            BtnFechar.Click += BtnFechar_Click;
            // 
            // ID
            // 
            ID.DataPropertyName = "Id";
            ID.HeaderText = "Id Estoque";
            ID.Name = "ID";
            ID.Width = 70;
            // 
            // ProdutoNome
            // 
            ProdutoNome.DataPropertyName = "Nome";
            ProdutoNome.HeaderText = "Produto";
            ProdutoNome.Name = "ProdutoNome";
            ProdutoNome.Width = 150;
            // 
            // LoteProduto
            // 
            LoteProduto.DataPropertyName = "Lote";
            LoteProduto.HeaderText = "Lote";
            LoteProduto.Name = "LoteProduto";
            LoteProduto.Width = 80;
            // 
            // QuantidadeProduto
            // 
            QuantidadeProduto.DataPropertyName = "QTD";
            QuantidadeProduto.HeaderText = "Quantidade em estoque";
            QuantidadeProduto.Name = "QuantidadeProduto";
            QuantidadeProduto.Width = 80;
            // 
            // CodigoBarrasProduto
            // 
            CodigoBarrasProduto.DataPropertyName = "Barra";
            CodigoBarrasProduto.HeaderText = "Codigo de Barras";
            CodigoBarrasProduto.Name = "CodigoBarrasProduto";
            CodigoBarrasProduto.Width = 150;
            // 
            // ValorUnitarioProduto
            // 
            ValorUnitarioProduto.DataPropertyName = "Preco";
            ValorUnitarioProduto.HeaderText = "Preço";
            ValorUnitarioProduto.Name = "ValorUnitarioProduto";
            ValorUnitarioProduto.Width = 90;
            // 
            // BtnSelecionar
            // 
            BtnSelecionar.HeaderText = "Selecionar";
            BtnSelecionar.Name = "BtnSelecionar";
            // 
            // FrmSelecionaProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 431);
            Controls.Add(BtnFechar);
            Controls.Add(GrdItens);
            Name = "FrmSelecionaProduto";
            Text = "FrmSelecionaProduto";
            Load += FrmSelecionaProduto_Load;
            ((System.ComponentModel.ISupportInitialize)GrdItens).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView GrdItens;
        private Button BtnFechar;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn ProdutoNome;
        private DataGridViewTextBoxColumn LoteProduto;
        private DataGridViewTextBoxColumn QuantidadeProduto;
        private DataGridViewTextBoxColumn CodigoBarrasProduto;
        private DataGridViewTextBoxColumn ValorUnitarioProduto;
        private DataGridViewButtonColumn BtnSelecionar;
    }
}