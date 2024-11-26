namespace Estoque.Formularios
{
    partial class FrmFornecedor
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
            TxtID = new TextBox();
            TxtNome = new TextBox();
            TxtContato = new TextBox();
            TxtEndereco = new TextBox();
            label1 = new Label();
            label2 = new Label();
            TxtCNPJ = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            BtnSalvar = new Button();
            BtnFehcar = new Button();
            GrdItens = new DataGridView();
            FornecedorID = new DataGridViewTextBoxColumn();
            FornecedorNome = new DataGridViewTextBoxColumn();
            FornecedorContato = new DataGridViewTextBoxColumn();
            FornecedorEndereco = new DataGridViewTextBoxColumn();
            FornecedorCNPJ = new DataGridViewTextBoxColumn();
            AlterarFornecedor = new DataGridViewButtonColumn();
            ExcluirFornecedor = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)GrdItens).BeginInit();
            SuspendLayout();
            // 
            // TxtID
            // 
            TxtID.Location = new Point(12, 23);
            TxtID.MaxLength = 4;
            TxtID.Name = "TxtID";
            TxtID.Size = new Size(69, 23);
            TxtID.TabIndex = 0;
            // 
            // TxtNome
            // 
            TxtNome.Location = new Point(87, 23);
            TxtNome.MaxLength = 50;
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(322, 23);
            TxtNome.TabIndex = 1;
            // 
            // TxtContato
            // 
            TxtContato.Location = new Point(415, 23);
            TxtContato.MaxLength = 50;
            TxtContato.Name = "TxtContato";
            TxtContato.Size = new Size(373, 23);
            TxtContato.TabIndex = 2;
            // 
            // TxtEndereco
            // 
            TxtEndereco.Location = new Point(12, 70);
            TxtEndereco.MaxLength = 255;
            TxtEndereco.Name = "TxtEndereco";
            TxtEndereco.Size = new Size(576, 23);
            TxtEndereco.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 5);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 4;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(87, 5);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 5;
            label2.Text = "Nome";
            // 
            // TxtCNPJ
            // 
            TxtCNPJ.Location = new Point(594, 70);
            TxtCNPJ.MaxLength = 50;
            TxtCNPJ.Name = "TxtCNPJ";
            TxtCNPJ.Size = new Size(194, 23);
            TxtCNPJ.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 52);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 7;
            label3.Text = "Endereço";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(415, 5);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 8;
            label4.Text = "Contato";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(594, 52);
            label5.Name = "label5";
            label5.Size = new Size(34, 15);
            label5.TabIndex = 9;
            label5.Text = "CNPJ";
            // 
            // BtnSalvar
            // 
            BtnSalvar.Location = new Point(12, 99);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(147, 49);
            BtnSalvar.TabIndex = 10;
            BtnSalvar.Text = "Salvar";
            BtnSalvar.UseVisualStyleBackColor = true;
            BtnSalvar.Click += BtnSalvar_Click;
            // 
            // BtnFehcar
            // 
            BtnFehcar.Location = new Point(641, 99);
            BtnFehcar.Name = "BtnFehcar";
            BtnFehcar.Size = new Size(147, 49);
            BtnFehcar.TabIndex = 11;
            BtnFehcar.Text = "Fechar";
            BtnFehcar.UseVisualStyleBackColor = true;
            BtnFehcar.Click += BtnFehcar_Click;
            // 
            // GrdItens
            // 
            GrdItens.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GrdItens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GrdItens.Columns.AddRange(new DataGridViewColumn[] { FornecedorID, FornecedorNome, FornecedorContato, FornecedorEndereco, FornecedorCNPJ, AlterarFornecedor, ExcluirFornecedor });
            GrdItens.Location = new Point(12, 154);
            GrdItens.Name = "GrdItens";
            GrdItens.Size = new Size(776, 284);
            GrdItens.TabIndex = 12;
            GrdItens.CellClick += GrdItens_CellClick;
            // 
            // FornecedorID
            // 
            FornecedorID.DataPropertyName = "Id";
            FornecedorID.HeaderText = "ID";
            FornecedorID.Name = "FornecedorID";
            FornecedorID.Width = 60;
            // 
            // FornecedorNome
            // 
            FornecedorNome.DataPropertyName = "Nome";
            FornecedorNome.HeaderText = "Nome";
            FornecedorNome.Name = "FornecedorNome";
            FornecedorNome.Width = 130;
            // 
            // FornecedorContato
            // 
            FornecedorContato.DataPropertyName = "Contato";
            FornecedorContato.HeaderText = "Contato";
            FornecedorContato.Name = "FornecedorContato";
            // 
            // FornecedorEndereco
            // 
            FornecedorEndereco.DataPropertyName = "Endereco";
            FornecedorEndereco.HeaderText = "Endereço";
            FornecedorEndereco.Name = "FornecedorEndereco";
            FornecedorEndereco.Width = 140;
            // 
            // FornecedorCNPJ
            // 
            FornecedorCNPJ.DataPropertyName = "CNPJ";
            FornecedorCNPJ.HeaderText = "CNPJ";
            FornecedorCNPJ.Name = "FornecedorCNPJ";
            // 
            // AlterarFornecedor
            // 
            AlterarFornecedor.HeaderText = "Alterar";
            AlterarFornecedor.Name = "AlterarFornecedor";
            // 
            // ExcluirFornecedor
            // 
            ExcluirFornecedor.HeaderText = "Excluir";
            ExcluirFornecedor.Name = "ExcluirFornecedor";
            // 
            // FrmFornecedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(GrdItens);
            Controls.Add(BtnFehcar);
            Controls.Add(BtnSalvar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(TxtCNPJ);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TxtEndereco);
            Controls.Add(TxtContato);
            Controls.Add(TxtNome);
            Controls.Add(TxtID);
            Name = "FrmFornecedor";
            Text = "FrmFornecedor";
            Load += FrmFornecedor_Load;
            ((System.ComponentModel.ISupportInitialize)GrdItens).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtID;
        private TextBox TxtNome;
        private TextBox TxtContato;
        private TextBox TxtEndereco;
        private Label label1;
        private Label label2;
        private TextBox TxtCNPJ;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button BtnSalvar;
        private Button BtnFehcar;
        private DataGridView GrdItens;
        private DataGridViewTextBoxColumn FornecedorID;
        private DataGridViewTextBoxColumn FornecedorNome;
        private DataGridViewTextBoxColumn FornecedorContato;
        private DataGridViewTextBoxColumn FornecedorEndereco;
        private DataGridViewTextBoxColumn FornecedorCNPJ;
        private DataGridViewButtonColumn AlterarFornecedor;
        private DataGridViewButtonColumn ExcluirFornecedor;
    }
}