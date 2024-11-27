namespace Estoque.Formularios
{
    partial class FrmAlterarPedido
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
            TxtId = new TextBox();
            TxtNome = new TextBox();
            TxtNPedido = new TextBox();
            TxtStatus = new TextBox();
            TxtData = new TextBox();
            GrdItens = new DataGridView();
            CBProduto = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            TxtPreco = new TextBox();
            numQtd = new NumericUpDown();
            label7 = new Label();
            label8 = new Label();
            BtnSalvar = new Button();
            BtnFechar = new Button();
            IdProd = new DataGridViewTextBoxColumn();
            NomeProduto = new DataGridViewTextBoxColumn();
            Quantidade = new DataGridViewTextBoxColumn();
            PrecoProduto = new DataGridViewTextBoxColumn();
            ExcluirProduto = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)GrdItens).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numQtd).BeginInit();
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
            // TxtId
            // 
            TxtId.Enabled = false;
            TxtId.Location = new Point(12, 27);
            TxtId.Name = "TxtId";
            TxtId.Size = new Size(70, 23);
            TxtId.TabIndex = 1;
            // 
            // TxtNome
            // 
            TxtNome.Enabled = false;
            TxtNome.Location = new Point(88, 27);
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(302, 23);
            TxtNome.TabIndex = 2;
            // 
            // TxtNPedido
            // 
            TxtNPedido.Enabled = false;
            TxtNPedido.Location = new Point(396, 27);
            TxtNPedido.Name = "TxtNPedido";
            TxtNPedido.Size = new Size(122, 23);
            TxtNPedido.TabIndex = 3;
            // 
            // TxtStatus
            // 
            TxtStatus.Enabled = false;
            TxtStatus.Location = new Point(653, 27);
            TxtStatus.Name = "TxtStatus";
            TxtStatus.Size = new Size(135, 23);
            TxtStatus.TabIndex = 4;
            // 
            // TxtData
            // 
            TxtData.Enabled = false;
            TxtData.Location = new Point(524, 27);
            TxtData.Name = "TxtData";
            TxtData.Size = new Size(123, 23);
            TxtData.TabIndex = 5;
            // 
            // GrdItens
            // 
            GrdItens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GrdItens.Columns.AddRange(new DataGridViewColumn[] { IdProd, NomeProduto, Quantidade, PrecoProduto, ExcluirProduto });
            GrdItens.Location = new Point(12, 103);
            GrdItens.Name = "GrdItens";
            GrdItens.Size = new Size(776, 335);
            GrdItens.TabIndex = 6;
            GrdItens.CellClick += GrdItens_CellClick;
            // 
            // CBProduto
            // 
            CBProduto.FormattingEnabled = true;
            CBProduto.Location = new Point(12, 74);
            CBProduto.Name = "CBProduto";
            CBProduto.Size = new Size(207, 23);
            CBProduto.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(88, 9);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 8;
            label2.Text = "Fornecedor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(396, 9);
            label3.Name = "label3";
            label3.Size = new Size(108, 15);
            label3.TabIndex = 9;
            label3.Text = "Numero do pedido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(524, 9);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 10;
            label4.Text = "Data do pedido";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(653, 9);
            label5.Name = "label5";
            label5.Size = new Size(96, 15);
            label5.TabIndex = 11;
            label5.Text = "Status do pedido";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 56);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 12;
            label6.Text = "Produto";
            // 
            // TxtPreco
            // 
            TxtPreco.Location = new Point(351, 72);
            TxtPreco.Name = "TxtPreco";
            TxtPreco.Size = new Size(100, 23);
            TxtPreco.TabIndex = 14;
            // 
            // numQtd
            // 
            numQtd.Location = new Point(225, 73);
            numQtd.Name = "numQtd";
            numQtd.Size = new Size(120, 23);
            numQtd.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(225, 55);
            label7.Name = "label7";
            label7.Size = new Size(69, 15);
            label7.TabIndex = 16;
            label7.Text = "Quantidade";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(351, 53);
            label8.Name = "label8";
            label8.Size = new Size(37, 15);
            label8.TabIndex = 17;
            label8.Text = "Preço";
            // 
            // BtnSalvar
            // 
            BtnSalvar.Location = new Point(457, 63);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(114, 38);
            BtnSalvar.TabIndex = 18;
            BtnSalvar.Text = "Salvar";
            BtnSalvar.UseVisualStyleBackColor = true;
            BtnSalvar.Click += BtnSalvar_Click;
            // 
            // BtnFechar
            // 
            BtnFechar.Location = new Point(674, 63);
            BtnFechar.Name = "BtnFechar";
            BtnFechar.Size = new Size(114, 38);
            BtnFechar.TabIndex = 19;
            BtnFechar.Text = "Fechar";
            BtnFechar.UseVisualStyleBackColor = true;
            BtnFechar.Click += BtnFechar_Click;
            // 
            // IdProd
            // 
            IdProd.DataPropertyName = "IdProduto";
            IdProd.HeaderText = "Id Produto";
            IdProd.Name = "IdProd";
            IdProd.Width = 80;
            // 
            // NomeProduto
            // 
            NomeProduto.DataPropertyName = "Produto";
            NomeProduto.HeaderText = "Nome do Produto";
            NomeProduto.Name = "NomeProduto";
            NomeProduto.Width = 240;
            // 
            // Quantidade
            // 
            Quantidade.DataPropertyName = "QTD";
            Quantidade.HeaderText = "Quantidade";
            Quantidade.Name = "Quantidade";
            // 
            // PrecoProduto
            // 
            PrecoProduto.DataPropertyName = "Valor";
            PrecoProduto.HeaderText = "Preço";
            PrecoProduto.Name = "PrecoProduto";
            PrecoProduto.Width = 110;
            // 
            // ExcluirProduto
            // 
            ExcluirProduto.HeaderText = "Excluir";
            ExcluirProduto.Name = "ExcluirProduto";
            // 
            // FrmAlterarPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnFechar);
            Controls.Add(BtnSalvar);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(numQtd);
            Controls.Add(TxtPreco);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(CBProduto);
            Controls.Add(GrdItens);
            Controls.Add(TxtData);
            Controls.Add(TxtStatus);
            Controls.Add(TxtNPedido);
            Controls.Add(TxtNome);
            Controls.Add(TxtId);
            Controls.Add(label1);
            Name = "FrmAlterarPedido";
            Text = "Alterar Pedido";
            Load += FrmAlterarPedido_Load;
            ((System.ComponentModel.ISupportInitialize)GrdItens).EndInit();
            ((System.ComponentModel.ISupportInitialize)numQtd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TxtId;
        private TextBox TxtNome;
        private TextBox TxtNPedido;
        private TextBox TxtStatus;
        private TextBox TxtData;
        private DataGridView GrdItens;
        private ComboBox CBProduto;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox TxtPreco;
        private NumericUpDown numQtd;
        private Label label7;
        private Label label8;
        private Button BtnSalvar;
        private Button BtnFechar;
        private DataGridViewTextBoxColumn IdProd;
        private DataGridViewTextBoxColumn NomeProduto;
        private DataGridViewTextBoxColumn Quantidade;
        private DataGridViewTextBoxColumn PrecoProduto;
        private DataGridViewButtonColumn ExcluirProduto;
    }
}