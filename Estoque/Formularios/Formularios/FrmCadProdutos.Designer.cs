namespace Estoque.Formularios
{
    partial class FrmCadProdutos
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
            label5 = new Label();
            TxtID = new TextBox();
            TxtNome = new TextBox();
            CBCat = new ComboBox();
            TxtBarra = new TextBox();
            GrdItens = new DataGridView();
            IdProdutos = new DataGridViewTextBoxColumn();
            NomeProduto = new DataGridViewTextBoxColumn();
            CategoriaProduto = new DataGridViewTextBoxColumn();
            MarcaProduto = new DataGridViewTextBoxColumn();
            CodProduto = new DataGridViewTextBoxColumn();
            AlterarProduto = new DataGridViewButtonColumn();
            ExcluirProduto = new DataGridViewButtonColumn();
            BtnSalvar = new Button();
            BtnFechar = new Button();
            BtnPesquisar = new Button();
            CBMarca = new ComboBox();
            label6 = new Label();
            CBPesquisa = new ComboBox();
            label4 = new Label();
            TxtPesquisa = new TextBox();
            BtnLimpar = new Button();
            ((System.ComponentModel.ISupportInitialize)GrdItens).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 9);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 1;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(374, 9);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 2;
            label3.Text = "Categoria";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 56);
            label5.Name = "label5";
            label5.Size = new Size(83, 15);
            label5.TabIndex = 4;
            label5.Text = "Cod. de Barras";
            // 
            // TxtID
            // 
            TxtID.Enabled = false;
            TxtID.Location = new Point(12, 27);
            TxtID.MaxLength = 4;
            TxtID.Name = "TxtID";
            TxtID.Size = new Size(36, 23);
            TxtID.TabIndex = 5;
            // 
            // TxtNome
            // 
            TxtNome.Location = new Point(54, 27);
            TxtNome.MaxLength = 50;
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(314, 23);
            TxtNome.TabIndex = 6;
            // 
            // CBCat
            // 
            CBCat.FormattingEnabled = true;
            CBCat.Location = new Point(374, 27);
            CBCat.Name = "CBCat";
            CBCat.Size = new Size(218, 23);
            CBCat.TabIndex = 7;
            // 
            // TxtBarra
            // 
            TxtBarra.Location = new Point(12, 74);
            TxtBarra.MaxLength = 50;
            TxtBarra.Name = "TxtBarra";
            TxtBarra.Size = new Size(225, 23);
            TxtBarra.TabIndex = 9;
            // 
            // GrdItens
            // 
            GrdItens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GrdItens.Columns.AddRange(new DataGridViewColumn[] { IdProdutos, NomeProduto, CategoriaProduto, MarcaProduto, CodProduto, AlterarProduto, ExcluirProduto });
            GrdItens.Location = new Point(12, 180);
            GrdItens.Name = "GrdItens";
            GrdItens.Size = new Size(1053, 379);
            GrdItens.TabIndex = 10;
            GrdItens.CellClick += GrdItens_CellClick;
            GrdItens.CellContentClick += GrdItens_CellContentClick;
            // 
            // IdProdutos
            // 
            IdProdutos.DataPropertyName = "Id";
            IdProdutos.HeaderText = "ID";
            IdProdutos.Name = "IdProdutos";
            IdProdutos.Width = 60;
            // 
            // NomeProduto
            // 
            NomeProduto.DataPropertyName = "Nome";
            NomeProduto.HeaderText = "Produto";
            NomeProduto.Name = "NomeProduto";
            NomeProduto.Width = 150;
            // 
            // CategoriaProduto
            // 
            CategoriaProduto.DataPropertyName = "CatId2";
            CategoriaProduto.HeaderText = "Categoria";
            CategoriaProduto.Name = "CategoriaProduto";
            CategoriaProduto.Width = 150;
            // 
            // MarcaProduto
            // 
            MarcaProduto.DataPropertyName = "MarcaId2";
            MarcaProduto.HeaderText = "Marca";
            MarcaProduto.Name = "MarcaProduto";
            MarcaProduto.Width = 150;
            // 
            // CodProduto
            // 
            CodProduto.DataPropertyName = "Barra";
            CodProduto.HeaderText = "Cod. de barras";
            CodProduto.Name = "CodProduto";
            CodProduto.Width = 150;
            // 
            // AlterarProduto
            // 
            AlterarProduto.HeaderText = "Alterar";
            AlterarProduto.Name = "AlterarProduto";
            // 
            // ExcluirProduto
            // 
            ExcluirProduto.HeaderText = "Excluir";
            ExcluirProduto.Name = "ExcluirProduto";
            // 
            // BtnSalvar
            // 
            BtnSalvar.Location = new Point(12, 103);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(127, 55);
            BtnSalvar.TabIndex = 11;
            BtnSalvar.Text = "Salvar";
            BtnSalvar.UseVisualStyleBackColor = true;
            BtnSalvar.Click += BtnSalvar_Click;
            // 
            // BtnFechar
            // 
            BtnFechar.Location = new Point(626, 103);
            BtnFechar.Name = "BtnFechar";
            BtnFechar.Size = new Size(127, 55);
            BtnFechar.TabIndex = 12;
            BtnFechar.Text = "Fechar";
            BtnFechar.UseVisualStyleBackColor = true;
            BtnFechar.Click += BtnFechar_Click;
            // 
            // BtnPesquisar
            // 
            BtnPesquisar.Location = new Point(797, 103);
            BtnPesquisar.Name = "BtnPesquisar";
            BtnPesquisar.Size = new Size(127, 55);
            BtnPesquisar.TabIndex = 13;
            BtnPesquisar.Text = "pesquisar";
            BtnPesquisar.UseVisualStyleBackColor = true;
            BtnPesquisar.Click += BtnPesquisar_Click;
            // 
            // CBMarca
            // 
            CBMarca.FormattingEnabled = true;
            CBMarca.Location = new Point(598, 27);
            CBMarca.Name = "CBMarca";
            CBMarca.Size = new Size(192, 23);
            CBMarca.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(598, 9);
            label6.Name = "label6";
            label6.Size = new Size(40, 15);
            label6.TabIndex = 15;
            label6.Text = "Marca";
            // 
            // CBPesquisa
            // 
            CBPesquisa.FormattingEnabled = true;
            CBPesquisa.Items.AddRange(new object[] { "ID", "Nome", "Categoria", "Marca", "Codigo de barras" });
            CBPesquisa.Location = new Point(797, 27);
            CBPesquisa.Name = "CBPesquisa";
            CBPesquisa.Size = new Size(260, 23);
            CBPesquisa.TabIndex = 16;
            CBPesquisa.Text = "Tipo de pesquisa";
            CBPesquisa.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(908, 9);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 17;
            label4.Text = "Pesquisar";
            // 
            // TxtPesquisa
            // 
            TxtPesquisa.Location = new Point(797, 74);
            TxtPesquisa.Name = "TxtPesquisa";
            TxtPesquisa.Size = new Size(260, 23);
            TxtPesquisa.TabIndex = 18;
            TxtPesquisa.Text = "Valor de pesquisa";
            TxtPesquisa.TextChanged += TxtPesquisa_TextChanged;
            // 
            // BtnLimpar
            // 
            BtnLimpar.Location = new Point(930, 103);
            BtnLimpar.Name = "BtnLimpar";
            BtnLimpar.Size = new Size(127, 55);
            BtnLimpar.TabIndex = 19;
            BtnLimpar.Text = "Limpar";
            BtnLimpar.UseVisualStyleBackColor = true;
            BtnLimpar.Click += BtnLimpar_Click;
            // 
            // FrmCadProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1069, 571);
            Controls.Add(BtnLimpar);
            Controls.Add(TxtPesquisa);
            Controls.Add(label4);
            Controls.Add(CBPesquisa);
            Controls.Add(label6);
            Controls.Add(CBMarca);
            Controls.Add(BtnPesquisar);
            Controls.Add(BtnFechar);
            Controls.Add(BtnSalvar);
            Controls.Add(GrdItens);
            Controls.Add(TxtBarra);
            Controls.Add(CBCat);
            Controls.Add(TxtNome);
            Controls.Add(TxtID);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmCadProdutos";
            Text = "FrmCadProdutos";
            Load += FrmCadProdutos_Load;
            ((System.ComponentModel.ISupportInitialize)GrdItens).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private TextBox TxtID;
        private TextBox TxtNome;
        private ComboBox CBCat;
        private TextBox TxtBarra;
        private DataGridView GrdItens;
        private Button BtnSalvar;
        private Button BtnFechar;
        private Button BtnPesquisar;
        private ComboBox CBMarca;
        private Label label6;
        private ComboBox CBPesquisa;
        private Label label4;
        private TextBox TxtPesquisa;
        private DataGridViewTextBoxColumn IdProdutos;
        private DataGridViewTextBoxColumn NomeProduto;
        private DataGridViewTextBoxColumn CategoriaProduto;
        private DataGridViewTextBoxColumn MarcaProduto;
        private DataGridViewTextBoxColumn CodProduto;
        private DataGridViewButtonColumn AlterarProduto;
        private DataGridViewButtonColumn ExcluirProduto;
        private Button BtnLimpar;
    }
}