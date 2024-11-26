namespace Estoque.Formularios
{
    partial class FrmAdEstoque
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            TxtID = new TextBox();
            CBProduto = new ComboBox();
            DTValidade = new DateTimePicker();
            DTFabricacao = new DateTimePicker();
            TxtPreco = new TextBox();
            TxtQtd = new TextBox();
            BtnSalvar = new Button();
            BtnFechar = new Button();
            GrdItens = new DataGridView();
            IdEstoque = new DataGridViewTextBoxColumn();
            ProdutoEstoque = new DataGridViewTextBoxColumn();
            PrecoEstoque = new DataGridViewTextBoxColumn();
            QTDEStoque = new DataGridViewTextBoxColumn();
            LoteEstoque = new DataGridViewTextBoxColumn();
            DATAFABESTO = new DataGridViewTextBoxColumn();
            DATAVALIDADE = new DataGridViewTextBoxColumn();
            AlterarEstoque = new DataGridViewButtonColumn();
            ExcluirEstoque = new DataGridViewButtonColumn();
            TxtLote = new TextBox();
            label7 = new Label();
            BtnPesquisar = new Button();
            TxtPesquisa = new TextBox();
            CBPesquisa = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            DTPesquisa = new DateTimePicker();
            BtnLimpar = new Button();
            BtnRegistros = new Button();
            BtnCadastrar = new Button();
            ((System.ComponentModel.ISupportInitialize)GrdItens).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(313, 6);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 0;
            label1.Text = "Preço";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(726, 6);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 1;
            label2.Text = "Fabricação";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(88, 6);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 2;
            label3.Text = "Produto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(450, 6);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 3;
            label4.Text = "Quantidade";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 6);
            label5.Name = "label5";
            label5.Size = new Size(18, 15);
            label5.TabIndex = 4;
            label5.Text = "ID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(848, 6);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 5;
            label6.Text = "Validade";
            // 
            // TxtID
            // 
            TxtID.Location = new Point(13, 24);
            TxtID.MaxLength = 4;
            TxtID.Name = "TxtID";
            TxtID.Size = new Size(69, 23);
            TxtID.TabIndex = 6;
            // 
            // CBProduto
            // 
            CBProduto.FormattingEnabled = true;
            CBProduto.Location = new Point(88, 24);
            CBProduto.Name = "CBProduto";
            CBProduto.Size = new Size(219, 23);
            CBProduto.TabIndex = 7;
            CBProduto.SelectedIndexChanged += CBProduto_SelectedIndexChanged;
            // 
            // DTValidade
            // 
            DTValidade.Format = DateTimePickerFormat.Short;
            DTValidade.Location = new Point(848, 24);
            DTValidade.Name = "DTValidade";
            DTValidade.RightToLeft = RightToLeft.No;
            DTValidade.Size = new Size(108, 23);
            DTValidade.TabIndex = 9;
            // 
            // DTFabricacao
            // 
            DTFabricacao.Format = DateTimePickerFormat.Short;
            DTFabricacao.Location = new Point(726, 24);
            DTFabricacao.Name = "DTFabricacao";
            DTFabricacao.RightToLeft = RightToLeft.No;
            DTFabricacao.Size = new Size(116, 23);
            DTFabricacao.TabIndex = 10;
            DTFabricacao.Value = new DateTime(2024, 11, 23, 0, 0, 0, 0);
            // 
            // TxtPreco
            // 
            TxtPreco.Location = new Point(313, 24);
            TxtPreco.MaxLength = 30;
            TxtPreco.Name = "TxtPreco";
            TxtPreco.Size = new Size(131, 23);
            TxtPreco.TabIndex = 11;
            // 
            // TxtQtd
            // 
            TxtQtd.Location = new Point(450, 24);
            TxtQtd.MaxLength = 50;
            TxtQtd.Name = "TxtQtd";
            TxtQtd.Size = new Size(128, 23);
            TxtQtd.TabIndex = 12;
            // 
            // BtnSalvar
            // 
            BtnSalvar.Location = new Point(13, 67);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(135, 53);
            BtnSalvar.TabIndex = 13;
            BtnSalvar.Text = "Salvar";
            BtnSalvar.UseVisualStyleBackColor = true;
            BtnSalvar.Click += BtnSalvar_Click;
            // 
            // BtnFechar
            // 
            BtnFechar.Location = new Point(821, 67);
            BtnFechar.Name = "BtnFechar";
            BtnFechar.Size = new Size(135, 53);
            BtnFechar.TabIndex = 14;
            BtnFechar.Text = "Fechar";
            BtnFechar.UseVisualStyleBackColor = true;
            BtnFechar.Click += BtnFechar_Click;
            // 
            // GrdItens
            // 
            GrdItens.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GrdItens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GrdItens.Columns.AddRange(new DataGridViewColumn[] { IdEstoque, ProdutoEstoque, PrecoEstoque, QTDEStoque, LoteEstoque, DATAFABESTO, DATAVALIDADE, AlterarEstoque, ExcluirEstoque });
            GrdItens.Location = new Point(12, 126);
            GrdItens.Name = "GrdItens";
            GrdItens.Size = new Size(944, 312);
            GrdItens.TabIndex = 15;
            GrdItens.CellClick += GrdItens_CellClick;
            GrdItens.CellContentClick += dataGridView1_CellContentClick;
            // 
            // IdEstoque
            // 
            IdEstoque.DataPropertyName = "Id";
            IdEstoque.HeaderText = "ID";
            IdEstoque.Name = "IdEstoque";
            IdEstoque.Width = 70;
            // 
            // ProdutoEstoque
            // 
            ProdutoEstoque.DataPropertyName = "Nome";
            ProdutoEstoque.HeaderText = "Produto";
            ProdutoEstoque.Name = "ProdutoEstoque";
            ProdutoEstoque.Width = 140;
            // 
            // PrecoEstoque
            // 
            PrecoEstoque.DataPropertyName = "Preco";
            PrecoEstoque.HeaderText = "Preço";
            PrecoEstoque.Name = "PrecoEstoque";
            PrecoEstoque.Width = 90;
            // 
            // QTDEStoque
            // 
            QTDEStoque.DataPropertyName = "QTD";
            QTDEStoque.HeaderText = "QTD";
            QTDEStoque.Name = "QTDEStoque";
            QTDEStoque.Width = 90;
            // 
            // LoteEstoque
            // 
            LoteEstoque.DataPropertyName = "Lote";
            LoteEstoque.HeaderText = "Lote";
            LoteEstoque.Name = "LoteEstoque";
            LoteEstoque.Width = 90;
            // 
            // DATAFABESTO
            // 
            DATAFABESTO.DataPropertyName = "Data2";
            DATAFABESTO.HeaderText = "Data Fabricação";
            DATAFABESTO.Name = "DATAFABESTO";
            DATAFABESTO.Width = 110;
            // 
            // DATAVALIDADE
            // 
            DATAVALIDADE.DataPropertyName = "Data3";
            DATAVALIDADE.HeaderText = "Data Validade";
            DATAVALIDADE.Name = "DATAVALIDADE";
            DATAVALIDADE.Width = 110;
            // 
            // AlterarEstoque
            // 
            AlterarEstoque.HeaderText = "Alterar";
            AlterarEstoque.Name = "AlterarEstoque";
            // 
            // ExcluirEstoque
            // 
            ExcluirEstoque.HeaderText = "Excluir";
            ExcluirEstoque.Name = "ExcluirEstoque";
            // 
            // TxtLote
            // 
            TxtLote.Location = new Point(584, 24);
            TxtLote.Name = "TxtLote";
            TxtLote.Size = new Size(136, 23);
            TxtLote.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(584, 6);
            label7.Name = "label7";
            label7.Size = new Size(30, 15);
            label7.TabIndex = 17;
            label7.Text = "Lote";
            // 
            // BtnPesquisar
            // 
            BtnPesquisar.Location = new Point(962, 132);
            BtnPesquisar.Name = "BtnPesquisar";
            BtnPesquisar.Size = new Size(100, 53);
            BtnPesquisar.TabIndex = 18;
            BtnPesquisar.Text = "Pesquisar";
            BtnPesquisar.UseVisualStyleBackColor = true;
            BtnPesquisar.Click += BtnPesquisar_Click;
            // 
            // TxtPesquisa
            // 
            TxtPesquisa.Location = new Point(962, 74);
            TxtPesquisa.Name = "TxtPesquisa";
            TxtPesquisa.Size = new Size(210, 23);
            TxtPesquisa.TabIndex = 19;
            // 
            // CBPesquisa
            // 
            CBPesquisa.FormattingEnabled = true;
            CBPesquisa.Items.AddRange(new object[] { "ID", "Produto", "Preço", "Quantidade", "Lote", "Data Fabricação", "Data Validade" });
            CBPesquisa.Location = new Point(962, 24);
            CBPesquisa.Name = "CBPesquisa";
            CBPesquisa.Size = new Size(210, 23);
            CBPesquisa.TabIndex = 20;
            CBPesquisa.SelectedIndexChanged += CBPesquisa_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(962, 6);
            label8.Name = "label8";
            label8.Size = new Size(78, 15);
            label8.TabIndex = 21;
            label8.Text = "Pesquisar por";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(962, 56);
            label9.Name = "label9";
            label9.Size = new Size(111, 15);
            label9.TabIndex = 22;
            label9.Text = "Criterio de pesquisa";
            // 
            // DTPesquisa
            // 
            DTPesquisa.Format = DateTimePickerFormat.Short;
            DTPesquisa.Location = new Point(962, 103);
            DTPesquisa.Name = "DTPesquisa";
            DTPesquisa.Size = new Size(210, 23);
            DTPesquisa.TabIndex = 23;
            // 
            // BtnLimpar
            // 
            BtnLimpar.Location = new Point(1079, 132);
            BtnLimpar.Name = "BtnLimpar";
            BtnLimpar.Size = new Size(102, 53);
            BtnLimpar.TabIndex = 24;
            BtnLimpar.Text = "Limpar";
            BtnLimpar.UseVisualStyleBackColor = true;
            BtnLimpar.Click += BtnLimpar_Click;
            // 
            // BtnRegistros
            // 
            BtnRegistros.Location = new Point(965, 201);
            BtnRegistros.Name = "BtnRegistros";
            BtnRegistros.Size = new Size(216, 41);
            BtnRegistros.TabIndex = 25;
            BtnRegistros.Text = "Ver Registro de Produtos";
            BtnRegistros.UseVisualStyleBackColor = true;
            BtnRegistros.Click += BtnRegistros_Click;
            // 
            // BtnCadastrar
            // 
            BtnCadastrar.Location = new Point(965, 248);
            BtnCadastrar.Name = "BtnCadastrar";
            BtnCadastrar.Size = new Size(216, 41);
            BtnCadastrar.TabIndex = 26;
            BtnCadastrar.Text = "Cadastrar Produtos";
            BtnCadastrar.UseVisualStyleBackColor = true;
            BtnCadastrar.Click += BtnCadastrar_Click;
            // 
            // FrmAdEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1193, 450);
            Controls.Add(BtnCadastrar);
            Controls.Add(BtnRegistros);
            Controls.Add(BtnLimpar);
            Controls.Add(DTPesquisa);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(CBPesquisa);
            Controls.Add(TxtPesquisa);
            Controls.Add(BtnPesquisar);
            Controls.Add(label7);
            Controls.Add(TxtLote);
            Controls.Add(GrdItens);
            Controls.Add(BtnFechar);
            Controls.Add(BtnSalvar);
            Controls.Add(TxtQtd);
            Controls.Add(TxtPreco);
            Controls.Add(DTFabricacao);
            Controls.Add(DTValidade);
            Controls.Add(CBProduto);
            Controls.Add(TxtID);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmAdEstoque";
            Text = "Estoque";
            Load += FrmEstoque_Load;
            ((System.ComponentModel.ISupportInitialize)GrdItens).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox TxtID;
        private ComboBox CBProduto;
        private DateTimePicker DTValidade;
        private DateTimePicker DTFabricacao;
        private TextBox TxtPreco;
        private TextBox TxtQtd;
        private Button BtnSalvar;
        private Button BtnFechar;
        private DataGridView GrdItens;
        private TextBox TxtLote;
        private Label label7;
        private DataGridViewTextBoxColumn IdEstoque;
        private DataGridViewTextBoxColumn ProdutoEstoque;
        private DataGridViewTextBoxColumn PrecoEstoque;
        private DataGridViewTextBoxColumn QTDEStoque;
        private DataGridViewTextBoxColumn LoteEstoque;
        private DataGridViewTextBoxColumn DATAFABESTO;
        private DataGridViewTextBoxColumn DATAVALIDADE;
        private DataGridViewButtonColumn AlterarEstoque;
        private DataGridViewButtonColumn ExcluirEstoque;
        private Button BtnPesquisar;
        private TextBox TxtPesquisa;
        private ComboBox CBPesquisa;
        private Label label8;
        private Label label9;
        private DateTimePicker DTPesquisa;
        private Button BtnLimpar;
        private Button BtnRegistros;
        private Button BtnCadastrar;
    }
}