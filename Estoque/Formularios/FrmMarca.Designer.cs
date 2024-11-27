namespace Estoque.Formularios
{
    partial class FrmMarca
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
            BtnSalvar = new Button();
            BtnFechar = new Button();
            TxtID = new TextBox();
            TxtNome = new TextBox();
            label1 = new Label();
            label2 = new Label();
            GrdItens = new DataGridView();
            IdMarca = new DataGridViewTextBoxColumn();
            NomeMarca = new DataGridViewTextBoxColumn();
            AlterarMarca = new DataGridViewButtonColumn();
            ExcluirMarca = new DataGridViewButtonColumn();
            BtnLimpar = new Button();
            TxtPesquisa = new TextBox();
            label4 = new Label();
            CBPesquisa = new ComboBox();
            BtnPesquisar = new Button();
            ((System.ComponentModel.ISupportInitialize)GrdItens).BeginInit();
            SuspendLayout();
            // 
            // BtnSalvar
            // 
            BtnSalvar.Location = new Point(12, 63);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(133, 52);
            BtnSalvar.TabIndex = 0;
            BtnSalvar.Text = "Salvar";
            BtnSalvar.UseVisualStyleBackColor = true;
            BtnSalvar.Click += BtnSalvar_Click;
            // 
            // BtnFechar
            // 
            BtnFechar.Location = new Point(177, 63);
            BtnFechar.Name = "BtnFechar";
            BtnFechar.Size = new Size(133, 52);
            BtnFechar.TabIndex = 1;
            BtnFechar.Text = "Fechar";
            BtnFechar.UseVisualStyleBackColor = true;
            BtnFechar.Click += BtnFechar_Click;
            // 
            // TxtID
            // 
            TxtID.Enabled = false;
            TxtID.Location = new Point(12, 34);
            TxtID.MaxLength = 4;
            TxtID.Name = "TxtID";
            TxtID.Size = new Size(100, 23);
            TxtID.TabIndex = 2;
            // 
            // TxtNome
            // 
            TxtNome.Location = new Point(118, 34);
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(361, 23);
            TxtNome.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 4;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(118, 16);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 5;
            label2.Text = "Marca";
            // 
            // GrdItens
            // 
            GrdItens.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GrdItens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GrdItens.Columns.AddRange(new DataGridViewColumn[] { IdMarca, NomeMarca, AlterarMarca, ExcluirMarca });
            GrdItens.Location = new Point(12, 162);
            GrdItens.Name = "GrdItens";
            GrdItens.Size = new Size(786, 317);
            GrdItens.TabIndex = 6;
            GrdItens.CellClick += GrdItens_CellClick;
            GrdItens.CellContentClick += GrdItens_CellContentClick;
            // 
            // IdMarca
            // 
            IdMarca.DataPropertyName = "Id";
            IdMarca.HeaderText = "ID";
            IdMarca.Name = "IdMarca";
            // 
            // NomeMarca
            // 
            NomeMarca.DataPropertyName = "Nome";
            NomeMarca.HeaderText = "Marca";
            NomeMarca.Name = "NomeMarca";
            NomeMarca.Width = 430;
            // 
            // AlterarMarca
            // 
            AlterarMarca.HeaderText = "Alterar";
            AlterarMarca.Name = "AlterarMarca";
            // 
            // ExcluirMarca
            // 
            ExcluirMarca.HeaderText = "Excluir";
            ExcluirMarca.Name = "ExcluirMarca";
            // 
            // BtnLimpar
            // 
            BtnLimpar.Location = new Point(651, 101);
            BtnLimpar.Name = "BtnLimpar";
            BtnLimpar.Size = new Size(127, 55);
            BtnLimpar.TabIndex = 24;
            BtnLimpar.Text = "Limpar";
            BtnLimpar.UseVisualStyleBackColor = true;
            BtnLimpar.Click += BtnLimpar_Click;
            // 
            // TxtPesquisa
            // 
            TxtPesquisa.Location = new Point(518, 72);
            TxtPesquisa.Name = "TxtPesquisa";
            TxtPesquisa.Size = new Size(260, 23);
            TxtPesquisa.TabIndex = 23;
            TxtPesquisa.Text = "Valor de pesquisa";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(631, 7);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 22;
            label4.Text = "Pesquisar";
            // 
            // CBPesquisa
            // 
            CBPesquisa.FormattingEnabled = true;
            CBPesquisa.Items.AddRange(new object[] { "ID", "Marca" });
            CBPesquisa.Location = new Point(518, 25);
            CBPesquisa.Name = "CBPesquisa";
            CBPesquisa.Size = new Size(260, 23);
            CBPesquisa.TabIndex = 21;
            CBPesquisa.Text = "Tipo de pesquisa";
            CBPesquisa.SelectedIndexChanged += CBPesquisa_SelectedIndexChanged;
            // 
            // BtnPesquisar
            // 
            BtnPesquisar.Location = new Point(518, 101);
            BtnPesquisar.Name = "BtnPesquisar";
            BtnPesquisar.Size = new Size(127, 55);
            BtnPesquisar.TabIndex = 20;
            BtnPesquisar.Text = "pesquisar";
            BtnPesquisar.UseVisualStyleBackColor = true;
            BtnPesquisar.Click += BtnPesquisar_Click;
            // 
            // FrmMarca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnLimpar);
            Controls.Add(TxtPesquisa);
            Controls.Add(label4);
            Controls.Add(CBPesquisa);
            Controls.Add(BtnPesquisar);
            Controls.Add(GrdItens);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TxtNome);
            Controls.Add(TxtID);
            Controls.Add(BtnFechar);
            Controls.Add(BtnSalvar);
            Name = "FrmMarca";
            Text = "FrmMarca";
            Load += FrmMarca_Load;
            ((System.ComponentModel.ISupportInitialize)GrdItens).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnSalvar;
        private Button BtnFechar;
        private TextBox TxtID;
        private TextBox TxtNome;
        private Label label1;
        private Label label2;
        private DataGridView GrdItens;
        private DataGridViewTextBoxColumn IdMarca;
        private DataGridViewTextBoxColumn NomeMarca;
        private DataGridViewButtonColumn AlterarMarca;
        private DataGridViewButtonColumn ExcluirMarca;
        private Button BtnLimpar;
        private TextBox TxtPesquisa;
        private Label label4;
        private ComboBox CBPesquisa;
        private Button BtnPesquisar;
    }
}