namespace Estoque.Formularios
{
    partial class FrmConsultarPedido
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
            TxtData = new TextBox();
            TxtStatus = new TextBox();
            TxtNPedido = new TextBox();
            TxtNome = new TextBox();
            TxtID = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            GrdItens = new DataGridView();
            idProduto = new DataGridViewTextBoxColumn();
            FronecedorFo = new DataGridViewTextBoxColumn();
            NumPedido = new DataGridViewTextBoxColumn();
            DataPedido = new DataGridViewTextBoxColumn();
            StatusPedido = new DataGridViewTextBoxColumn();
            VerMais = new DataGridViewButtonColumn();
            BtnFechar = new Button();
            BtnLimpar = new Button();
            BtnPesquisar = new Button();
            label6 = new Label();
            TxtPesquisa = new TextBox();
            CBPesquisa = new ComboBox();
            label7 = new Label();
            GrdItens2 = new DataGridView();
            IdProd = new DataGridViewTextBoxColumn();
            ProdutoNome = new DataGridViewTextBoxColumn();
            QTDPRoduto = new DataGridViewTextBoxColumn();
            PrecoProduto = new DataGridViewTextBoxColumn();
            BtnVoltar = new Button();
            ((System.ComponentModel.ISupportInitialize)GrdItens).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GrdItens2).BeginInit();
            SuspendLayout();
            // 
            // TxtData
            // 
            TxtData.Enabled = false;
            TxtData.Location = new Point(528, 84);
            TxtData.Name = "TxtData";
            TxtData.Size = new Size(123, 23);
            TxtData.TabIndex = 20;
            // 
            // TxtStatus
            // 
            TxtStatus.Enabled = false;
            TxtStatus.Location = new Point(657, 84);
            TxtStatus.Name = "TxtStatus";
            TxtStatus.Size = new Size(135, 23);
            TxtStatus.TabIndex = 19;
            // 
            // TxtNPedido
            // 
            TxtNPedido.Enabled = false;
            TxtNPedido.Location = new Point(400, 84);
            TxtNPedido.Name = "TxtNPedido";
            TxtNPedido.Size = new Size(122, 23);
            TxtNPedido.TabIndex = 18;
            // 
            // TxtNome
            // 
            TxtNome.Enabled = false;
            TxtNome.Location = new Point(92, 84);
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(302, 23);
            TxtNome.TabIndex = 17;
            // 
            // TxtID
            // 
            TxtID.Enabled = false;
            TxtID.Location = new Point(16, 84);
            TxtID.Name = "TxtID";
            TxtID.Size = new Size(70, 23);
            TxtID.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(657, 66);
            label5.Name = "label5";
            label5.Size = new Size(96, 15);
            label5.TabIndex = 25;
            label5.Text = "Status do pedido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(528, 66);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 24;
            label4.Text = "Data do pedido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(400, 66);
            label3.Name = "label3";
            label3.Size = new Size(108, 15);
            label3.TabIndex = 23;
            label3.Text = "Numero do pedido";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(92, 66);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 22;
            label2.Text = "Fornecedor";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 66);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 21;
            label1.Text = "ID";
            // 
            // GrdItens
            // 
            GrdItens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GrdItens.Columns.AddRange(new DataGridViewColumn[] { idProduto, FronecedorFo, NumPedido, DataPedido, StatusPedido, VerMais });
            GrdItens.Location = new Point(16, 113);
            GrdItens.Name = "GrdItens";
            GrdItens.Size = new Size(776, 325);
            GrdItens.TabIndex = 26;
            GrdItens.CellClick += GrdItens_CellClick;
            GrdItens.CellContentClick += GrdItens_CellContentClick;
            // 
            // idProduto
            // 
            idProduto.DataPropertyName = "id";
            idProduto.HeaderText = "Id do pedido";
            idProduto.Name = "idProduto";
            idProduto.Width = 80;
            // 
            // FronecedorFo
            // 
            FronecedorFo.DataPropertyName = "Nome";
            FronecedorFo.HeaderText = "Fornecedor";
            FronecedorFo.Name = "FronecedorFo";
            FronecedorFo.Width = 180;
            // 
            // NumPedido
            // 
            NumPedido.DataPropertyName = "NPedido";
            NumPedido.HeaderText = "Numero do pedido";
            NumPedido.Name = "NumPedido";
            NumPedido.Width = 140;
            // 
            // DataPedido
            // 
            DataPedido.DataPropertyName = "Data2";
            DataPedido.HeaderText = "Data do Pedido";
            DataPedido.Name = "DataPedido";
            DataPedido.Width = 120;
            // 
            // StatusPedido
            // 
            StatusPedido.DataPropertyName = "Status";
            StatusPedido.HeaderText = "Status";
            StatusPedido.Name = "StatusPedido";
            // 
            // VerMais
            // 
            VerMais.HeaderText = "Ver Produtos do pedido";
            VerMais.Name = "VerMais";
            // 
            // BtnFechar
            // 
            BtnFechar.Location = new Point(674, 12);
            BtnFechar.Name = "BtnFechar";
            BtnFechar.Size = new Size(118, 51);
            BtnFechar.TabIndex = 27;
            BtnFechar.Text = "Fechar";
            BtnFechar.UseVisualStyleBackColor = true;
            BtnFechar.Click += BtnFechar_Click;
            // 
            // BtnLimpar
            // 
            BtnLimpar.Location = new Point(442, 12);
            BtnLimpar.Name = "BtnLimpar";
            BtnLimpar.Size = new Size(101, 51);
            BtnLimpar.TabIndex = 28;
            BtnLimpar.Text = "Limpar";
            BtnLimpar.UseVisualStyleBackColor = true;
            BtnLimpar.Click += button2_Click;
            // 
            // BtnPesquisar
            // 
            BtnPesquisar.Location = new Point(335, 12);
            BtnPesquisar.Name = "BtnPesquisar";
            BtnPesquisar.Size = new Size(101, 51);
            BtnPesquisar.TabIndex = 29;
            BtnPesquisar.Text = "Pesquisar";
            BtnPesquisar.UseVisualStyleBackColor = true;
            BtnPesquisar.Click += BtnPesquisar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 43);
            label6.Name = "label6";
            label6.Size = new Size(111, 15);
            label6.TabIndex = 30;
            label6.Text = "Criterio de pesquisa";
            // 
            // TxtPesquisa
            // 
            TxtPesquisa.Location = new Point(129, 40);
            TxtPesquisa.Name = "TxtPesquisa";
            TxtPesquisa.Size = new Size(194, 23);
            TxtPesquisa.TabIndex = 31;
            // 
            // CBPesquisa
            // 
            CBPesquisa.FormattingEnabled = true;
            CBPesquisa.Location = new Point(129, 12);
            CBPesquisa.Name = "CBPesquisa";
            CBPesquisa.Size = new Size(194, 23);
            CBPesquisa.TabIndex = 32;
            CBPesquisa.SelectedIndexChanged += CBPesquisa_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(28, 15);
            label7.Name = "label7";
            label7.Size = new Size(95, 15);
            label7.TabIndex = 33;
            label7.Text = "Tipo de pesquisa";
            // 
            // GrdItens2
            // 
            GrdItens2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GrdItens2.Columns.AddRange(new DataGridViewColumn[] { IdProd, ProdutoNome, QTDPRoduto, PrecoProduto });
            GrdItens2.Location = new Point(16, 113);
            GrdItens2.Name = "GrdItens2";
            GrdItens2.Size = new Size(776, 325);
            GrdItens2.TabIndex = 34;
            // 
            // IdProd
            // 
            IdProd.DataPropertyName = "IdProduto";
            IdProd.HeaderText = "Id Produto";
            IdProd.Name = "IdProd";
            // 
            // ProdutoNome
            // 
            ProdutoNome.DataPropertyName = "Produto";
            ProdutoNome.HeaderText = "Produto";
            ProdutoNome.Name = "ProdutoNome";
            ProdutoNome.Width = 200;
            // 
            // QTDPRoduto
            // 
            QTDPRoduto.DataPropertyName = "QTD";
            QTDPRoduto.HeaderText = "Quantidade";
            QTDPRoduto.Name = "QTDPRoduto";
            // 
            // PrecoProduto
            // 
            PrecoProduto.DataPropertyName = "Valor";
            PrecoProduto.HeaderText = "Preço unitario";
            PrecoProduto.Name = "PrecoProduto";
            PrecoProduto.Width = 120;
            // 
            // BtnVoltar
            // 
            BtnVoltar.Location = new Point(550, 12);
            BtnVoltar.Name = "BtnVoltar";
            BtnVoltar.Size = new Size(101, 51);
            BtnVoltar.TabIndex = 35;
            BtnVoltar.Text = "Voltar";
            BtnVoltar.UseVisualStyleBackColor = true;
            BtnVoltar.Click += BtnVoltar_Click;
            // 
            // FrmConsultarPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnVoltar);
            Controls.Add(GrdItens2);
            Controls.Add(label7);
            Controls.Add(CBPesquisa);
            Controls.Add(TxtPesquisa);
            Controls.Add(label6);
            Controls.Add(BtnPesquisar);
            Controls.Add(BtnLimpar);
            Controls.Add(BtnFechar);
            Controls.Add(GrdItens);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TxtData);
            Controls.Add(TxtStatus);
            Controls.Add(TxtNPedido);
            Controls.Add(TxtNome);
            Controls.Add(TxtID);
            Name = "FrmConsultarPedido";
            Text = "Consultar Pedidos";
            Load += FrmConsultarPedido_Load;
            ((System.ComponentModel.ISupportInitialize)GrdItens).EndInit();
            ((System.ComponentModel.ISupportInitialize)GrdItens2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox TxtData;
        private TextBox TxtStatus;
        private TextBox TxtNPedido;
        private TextBox TxtNome;
        private TextBox TxtID;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView GrdItens;
        private Button BtnFechar;
        private Button BtnLimpar;
        private Button BtnPesquisar;
        private Label label6;
        private TextBox TxtPesquisa;
        private ComboBox CBPesquisa;
        private Label label7;
        private DataGridView GrdItens2;
        private DataGridViewTextBoxColumn idProduto;
        private DataGridViewTextBoxColumn FronecedorFo;
        private DataGridViewTextBoxColumn NumPedido;
        private DataGridViewTextBoxColumn DataPedido;
        private DataGridViewTextBoxColumn StatusPedido;
        private DataGridViewButtonColumn VerMais;
        private DataGridViewTextBoxColumn IdProd;
        private DataGridViewTextBoxColumn ProdutoNome;
        private DataGridViewTextBoxColumn QTDPRoduto;
        private DataGridViewTextBoxColumn PrecoProduto;
        private Button BtnVoltar;
    }
}