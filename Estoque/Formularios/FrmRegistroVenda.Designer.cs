namespace Estoque.Formularios
{
    partial class FrmRegistroVenda
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
            IdVenda = new DataGridViewTextBoxColumn();
            ValorVenda = new DataGridViewTextBoxColumn();
            DataVenda = new DataGridViewTextBoxColumn();
            VerProdutos = new DataGridViewButtonColumn();
            ExcluirVenda = new DataGridViewButtonColumn();
            GrdItens2 = new DataGridView();
            IdProduto = new DataGridViewTextBoxColumn();
            ProdutoNome = new DataGridViewTextBoxColumn();
            QtdProduto = new DataGridViewTextBoxColumn();
            ValorUnitarioProduto = new DataGridViewTextBoxColumn();
            ValorTotalProduto = new DataGridViewTextBoxColumn();
            LoteProduto = new DataGridViewTextBoxColumn();
            BtnVoltar = new Button();
            label7 = new Label();
            CBPesquisa = new ComboBox();
            TxtPesquisa = new TextBox();
            label6 = new Label();
            BtnPesquisar = new Button();
            BtnLimpar = new Button();
            BtnFechar = new Button();
            label1 = new Label();
            TxtId = new TextBox();
            TxtValor = new TextBox();
            TxtData = new TextBox();
            label2 = new Label();
            label3 = new Label();
            DTPesquisa = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)GrdItens).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GrdItens2).BeginInit();
            SuspendLayout();
            // 
            // GrdItens
            // 
            GrdItens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GrdItens.Columns.AddRange(new DataGridViewColumn[] { IdVenda, ValorVenda, DataVenda, VerProdutos, ExcluirVenda });
            GrdItens.Location = new Point(12, 119);
            GrdItens.Name = "GrdItens";
            GrdItens.Size = new Size(785, 403);
            GrdItens.TabIndex = 0;
            GrdItens.CellClick += GrdItens_CellClick;
            // 
            // IdVenda
            // 
            IdVenda.DataPropertyName = "Id";
            IdVenda.HeaderText = "Id Venda";
            IdVenda.Name = "IdVenda";
            IdVenda.Width = 150;
            // 
            // ValorVenda
            // 
            ValorVenda.DataPropertyName = "Valor";
            ValorVenda.HeaderText = "Valor da venda";
            ValorVenda.Name = "ValorVenda";
            ValorVenda.Width = 150;
            // 
            // DataVenda
            // 
            DataVenda.DataPropertyName = "Data2";
            DataVenda.HeaderText = "Data da Venda";
            DataVenda.Name = "DataVenda";
            DataVenda.Width = 150;
            // 
            // VerProdutos
            // 
            VerProdutos.HeaderText = "Ver Produtos da Venda";
            VerProdutos.Name = "VerProdutos";
            VerProdutos.Width = 160;
            // 
            // ExcluirVenda
            // 
            ExcluirVenda.HeaderText = "Excluir";
            ExcluirVenda.Name = "ExcluirVenda";
            ExcluirVenda.Width = 130;
            // 
            // GrdItens2
            // 
            GrdItens2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GrdItens2.Columns.AddRange(new DataGridViewColumn[] { IdProduto, ProdutoNome, QtdProduto, ValorUnitarioProduto, ValorTotalProduto, LoteProduto });
            GrdItens2.Location = new Point(12, 119);
            GrdItens2.Name = "GrdItens2";
            GrdItens2.Size = new Size(785, 403);
            GrdItens2.TabIndex = 1;
            // 
            // IdProduto
            // 
            IdProduto.DataPropertyName = "Id3";
            IdProduto.HeaderText = "Id Produto";
            IdProduto.Name = "IdProduto";
            IdProduto.Width = 80;
            // 
            // ProdutoNome
            // 
            ProdutoNome.DataPropertyName = "Nome";
            ProdutoNome.HeaderText = "Produto";
            ProdutoNome.Name = "ProdutoNome";
            ProdutoNome.Width = 190;
            // 
            // QtdProduto
            // 
            QtdProduto.DataPropertyName = "QTD";
            QtdProduto.HeaderText = "Quantidade Vendida";
            QtdProduto.Name = "QtdProduto";
            QtdProduto.Width = 140;
            // 
            // ValorUnitarioProduto
            // 
            ValorUnitarioProduto.DataPropertyName = "Valor";
            ValorUnitarioProduto.HeaderText = "Valor Unitario";
            ValorUnitarioProduto.Name = "ValorUnitarioProduto";
            ValorUnitarioProduto.Width = 110;
            // 
            // ValorTotalProduto
            // 
            ValorTotalProduto.DataPropertyName = "ValorTotal";
            ValorTotalProduto.HeaderText = "Valor Total";
            ValorTotalProduto.Name = "ValorTotalProduto";
            // 
            // LoteProduto
            // 
            LoteProduto.DataPropertyName = "Lote";
            LoteProduto.HeaderText = "Lote vendido";
            LoteProduto.Name = "LoteProduto";
            LoteProduto.Width = 120;
            // 
            // BtnVoltar
            // 
            BtnVoltar.Location = new Point(555, 12);
            BtnVoltar.Name = "BtnVoltar";
            BtnVoltar.Size = new Size(101, 51);
            BtnVoltar.TabIndex = 43;
            BtnVoltar.Text = "Voltar";
            BtnVoltar.UseVisualStyleBackColor = true;
            BtnVoltar.Click += BtnVoltar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(33, 15);
            label7.Name = "label7";
            label7.Size = new Size(95, 15);
            label7.TabIndex = 42;
            label7.Text = "Tipo de pesquisa";
            // 
            // CBPesquisa
            // 
            CBPesquisa.FormattingEnabled = true;
            CBPesquisa.Location = new Point(134, 12);
            CBPesquisa.Name = "CBPesquisa";
            CBPesquisa.Size = new Size(194, 23);
            CBPesquisa.TabIndex = 41;
            CBPesquisa.SelectedIndexChanged += CBPesquisa_SelectedIndexChanged;
            // 
            // TxtPesquisa
            // 
            TxtPesquisa.Location = new Point(134, 40);
            TxtPesquisa.Name = "TxtPesquisa";
            TxtPesquisa.Size = new Size(194, 23);
            TxtPesquisa.TabIndex = 40;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 43);
            label6.Name = "label6";
            label6.Size = new Size(111, 15);
            label6.TabIndex = 39;
            label6.Text = "Criterio de pesquisa";
            // 
            // BtnPesquisar
            // 
            BtnPesquisar.Location = new Point(340, 12);
            BtnPesquisar.Name = "BtnPesquisar";
            BtnPesquisar.Size = new Size(101, 51);
            BtnPesquisar.TabIndex = 38;
            BtnPesquisar.Text = "Pesquisar";
            BtnPesquisar.UseVisualStyleBackColor = true;
            BtnPesquisar.Click += BtnPesquisar_Click;
            // 
            // BtnLimpar
            // 
            BtnLimpar.Location = new Point(447, 12);
            BtnLimpar.Name = "BtnLimpar";
            BtnLimpar.Size = new Size(101, 51);
            BtnLimpar.TabIndex = 37;
            BtnLimpar.Text = "Limpar";
            BtnLimpar.UseVisualStyleBackColor = true;
            BtnLimpar.Click += BtnLimpar_Click;
            // 
            // BtnFechar
            // 
            BtnFechar.Location = new Point(679, 12);
            BtnFechar.Name = "BtnFechar";
            BtnFechar.Size = new Size(118, 51);
            BtnFechar.TabIndex = 36;
            BtnFechar.Text = "Fechar";
            BtnFechar.UseVisualStyleBackColor = true;
            BtnFechar.Click += BtnFechar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 72);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 44;
            label1.Text = "Id da venda";
            // 
            // TxtId
            // 
            TxtId.Enabled = false;
            TxtId.Location = new Point(17, 90);
            TxtId.Name = "TxtId";
            TxtId.Size = new Size(111, 23);
            TxtId.TabIndex = 45;
            // 
            // TxtValor
            // 
            TxtValor.Enabled = false;
            TxtValor.Location = new Point(134, 90);
            TxtValor.Name = "TxtValor";
            TxtValor.Size = new Size(154, 23);
            TxtValor.TabIndex = 46;
            // 
            // TxtData
            // 
            TxtData.Enabled = false;
            TxtData.Location = new Point(294, 90);
            TxtData.Name = "TxtData";
            TxtData.Size = new Size(147, 23);
            TxtData.TabIndex = 47;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(134, 72);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 48;
            label2.Text = "Valor da venda";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(294, 72);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 49;
            label3.Text = "Data da venda";
            // 
            // DTPesquisa
            // 
            DTPesquisa.Format = DateTimePickerFormat.Short;
            DTPesquisa.Location = new Point(134, 40);
            DTPesquisa.Name = "DTPesquisa";
            DTPesquisa.Size = new Size(194, 23);
            DTPesquisa.TabIndex = 50;
            // 
            // FrmRegistroVenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(817, 550);
            Controls.Add(DTPesquisa);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(TxtData);
            Controls.Add(TxtValor);
            Controls.Add(TxtId);
            Controls.Add(label1);
            Controls.Add(BtnVoltar);
            Controls.Add(label7);
            Controls.Add(CBPesquisa);
            Controls.Add(TxtPesquisa);
            Controls.Add(label6);
            Controls.Add(BtnPesquisar);
            Controls.Add(BtnLimpar);
            Controls.Add(BtnFechar);
            Controls.Add(GrdItens2);
            Controls.Add(GrdItens);
            Name = "FrmRegistroVenda";
            Text = "FrmRegistroVenda";
            Load += FrmRegistroVenda_Load;
            ((System.ComponentModel.ISupportInitialize)GrdItens).EndInit();
            ((System.ComponentModel.ISupportInitialize)GrdItens2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView GrdItens;
        private DataGridView GrdItens2;
        private Button BtnVoltar;
        private Label label7;
        private ComboBox CBPesquisa;
        private TextBox TxtPesquisa;
        private Label label6;
        private Button BtnPesquisar;
        private Button BtnLimpar;
        private Button BtnFechar;
        private Label label1;
        private TextBox TxtId;
        private TextBox TxtValor;
        private TextBox TxtData;
        private Label label2;
        private Label label3;
        private DataGridViewTextBoxColumn IdProduto;
        private DataGridViewTextBoxColumn ProdutoNome;
        private DataGridViewTextBoxColumn QtdProduto;
        private DataGridViewTextBoxColumn ValorUnitarioProduto;
        private DataGridViewTextBoxColumn ValorTotalProduto;
        private DataGridViewTextBoxColumn LoteProduto;
        private DataGridViewTextBoxColumn IdVenda;
        private DataGridViewTextBoxColumn ValorVenda;
        private DataGridViewTextBoxColumn DataVenda;
        private DataGridViewButtonColumn VerProdutos;
        private DataGridViewButtonColumn ExcluirVenda;
        private DateTimePicker DTPesquisa;
    }
}