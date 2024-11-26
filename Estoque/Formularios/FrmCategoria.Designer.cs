namespace Estoque.Formularios
{
    partial class FrmCategoria
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
            label1 = new Label();
            label2 = new Label();
            TxtNome = new TextBox();
            TxtID = new TextBox();
            GrdItens = new DataGridView();
            IDCat = new DataGridViewTextBoxColumn();
            CategoriaNome = new DataGridViewTextBoxColumn();
            AlterarCategoria = new DataGridViewButtonColumn();
            ExcluirCategoria = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)GrdItens).BeginInit();
            SuspendLayout();
            // 
            // BtnSalvar
            // 
            BtnSalvar.Location = new Point(12, 61);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(129, 56);
            BtnSalvar.TabIndex = 0;
            BtnSalvar.Text = "Salvar";
            BtnSalvar.UseVisualStyleBackColor = true;
            BtnSalvar.Click += BtnSalvar_Click;
            // 
            // BtnFechar
            // 
            BtnFechar.Location = new Point(659, 61);
            BtnFechar.Name = "BtnFechar";
            BtnFechar.Size = new Size(129, 56);
            BtnFechar.TabIndex = 1;
            BtnFechar.Text = "Fechar";
            BtnFechar.UseVisualStyleBackColor = true;
            BtnFechar.Click += BtnFechar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 14);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 2;
            label1.Text = "Categoria";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 14);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 3;
            label2.Text = "ID";
            // 
            // TxtNome
            // 
            TxtNome.Location = new Point(83, 32);
            TxtNome.MaxLength = 50;
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(705, 23);
            TxtNome.TabIndex = 4;
            // 
            // TxtID
            // 
            TxtID.Location = new Point(12, 32);
            TxtID.Name = "TxtID";
            TxtID.Size = new Size(65, 23);
            TxtID.TabIndex = 5;
            // 
            // GrdItens
            // 
            GrdItens.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GrdItens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GrdItens.Columns.AddRange(new DataGridViewColumn[] { IDCat, CategoriaNome, AlterarCategoria, ExcluirCategoria });
            GrdItens.Location = new Point(12, 123);
            GrdItens.Name = "GrdItens";
            GrdItens.Size = new Size(776, 315);
            GrdItens.TabIndex = 6;
            GrdItens.CellClick += GrdItens_CellClick;
            // 
            // IDCat
            // 
            IDCat.DataPropertyName = "ID";
            IDCat.HeaderText = "ID";
            IDCat.Name = "IDCat";
            // 
            // CategoriaNome
            // 
            CategoriaNome.DataPropertyName = "Nome";
            CategoriaNome.HeaderText = "Categoria";
            CategoriaNome.Name = "CategoriaNome";
            CategoriaNome.Width = 430;
            // 
            // AlterarCategoria
            // 
            AlterarCategoria.HeaderText = "Alterar";
            AlterarCategoria.Name = "AlterarCategoria";
            // 
            // ExcluirCategoria
            // 
            ExcluirCategoria.HeaderText = "Excluir";
            ExcluirCategoria.Name = "ExcluirCategoria";
            // 
            // FrmCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(GrdItens);
            Controls.Add(TxtID);
            Controls.Add(TxtNome);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnFechar);
            Controls.Add(BtnSalvar);
            Name = "FrmCategoria";
            Text = "FrmCategoria";
            Load += FrmCategoria_Load;
            ((System.ComponentModel.ISupportInitialize)GrdItens).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnSalvar;
        private Button BtnFechar;
        private Label label1;
        private Label label2;
        private TextBox TxtNome;
        private TextBox TxtID;
        private DataGridView GrdItens;
        private DataGridViewTextBoxColumn IDCat;
        private DataGridViewTextBoxColumn CategoriaNome;
        private DataGridViewButtonColumn AlterarCategoria;
        private DataGridViewButtonColumn ExcluirCategoria;
    }
}