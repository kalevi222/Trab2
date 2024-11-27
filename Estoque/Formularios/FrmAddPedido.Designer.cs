namespace Estoque.Formularios
{
    partial class FrmAddPedido
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
            TxtID = new TextBox();
            CBFornecedor = new ComboBox();
            label2 = new Label();
            label4 = new Label();
            BtnSalvar = new Button();
            CListProdutos = new CheckedListBox();
            TxtNPedido = new TextBox();
            DTPedido = new DateTimePicker();
            CBStatus = new ComboBox();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            BtnFechar = new Button();
            GrdItens = new DataGridView();
            IdPedido = new DataGridViewTextBoxColumn();
            FornecedorPedido = new DataGridViewTextBoxColumn();
            NPedido = new DataGridViewTextBoxColumn();
            DataPedido = new DataGridViewTextBoxColumn();
            StatusPedidio = new DataGridViewTextBoxColumn();
            AlterarPedido = new DataGridViewButtonColumn();
            AlterarPedidoProduto = new DataGridViewButtonColumn();
            ExcluirPedido = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)GrdItens).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // TxtID
            // 
            TxtID.Location = new Point(12, 27);
            TxtID.Name = "TxtID";
            TxtID.Size = new Size(74, 23);
            TxtID.TabIndex = 1;
            // 
            // CBFornecedor
            // 
            CBFornecedor.FormattingEnabled = true;
            CBFornecedor.Location = new Point(92, 27);
            CBFornecedor.Name = "CBFornecedor";
            CBFornecedor.Size = new Size(351, 23);
            CBFornecedor.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(92, 9);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 3;
            label2.Text = "Fornecedor";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(948, 9);
            label4.Name = "label4";
            label4.Size = new Size(98, 15);
            label4.TabIndex = 8;
            label4.Text = "Lista de produtos";
            // 
            // BtnSalvar
            // 
            BtnSalvar.Location = new Point(12, 75);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(134, 51);
            BtnSalvar.TabIndex = 11;
            BtnSalvar.Text = "Salvar";
            BtnSalvar.UseVisualStyleBackColor = true;
            BtnSalvar.Click += BtnSalvar_Click;
            // 
            // CListProdutos
            // 
            CListProdutos.FormattingEnabled = true;
            CListProdutos.Location = new Point(898, 27);
            CListProdutos.Name = "CListProdutos";
            CListProdutos.Size = new Size(194, 454);
            CListProdutos.TabIndex = 12;
            CListProdutos.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged_1;
            // 
            // TxtNPedido
            // 
            TxtNPedido.Location = new Point(449, 27);
            TxtNPedido.Name = "TxtNPedido";
            TxtNPedido.Size = new Size(133, 23);
            TxtNPedido.TabIndex = 13;
            // 
            // DTPedido
            // 
            DTPedido.Format = DateTimePickerFormat.Short;
            DTPedido.Location = new Point(588, 27);
            DTPedido.Name = "DTPedido";
            DTPedido.Size = new Size(112, 23);
            DTPedido.TabIndex = 14;
            // 
            // CBStatus
            // 
            CBStatus.FormattingEnabled = true;
            CBStatus.Items.AddRange(new object[] { "Incompleto", "Aguardando", "Completo" });
            CBStatus.Location = new Point(716, 27);
            CBStatus.Name = "CBStatus";
            CBStatus.Size = new Size(157, 23);
            CBStatus.TabIndex = 15;
            CBStatus.SelectedIndexChanged += CBStatus_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(449, 9);
            label3.Name = "label3";
            label3.Size = new Size(108, 15);
            label3.TabIndex = 16;
            label3.Text = "Numero do pedido";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(588, 9);
            label5.Name = "label5";
            label5.Size = new Size(88, 15);
            label5.TabIndex = 17;
            label5.Text = "Data do pedido";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(716, 9);
            label6.Name = "label6";
            label6.Size = new Size(96, 15);
            label6.TabIndex = 18;
            label6.Text = "Status do pedido";
            // 
            // BtnFechar
            // 
            BtnFechar.Location = new Point(739, 75);
            BtnFechar.Name = "BtnFechar";
            BtnFechar.Size = new Size(134, 51);
            BtnFechar.TabIndex = 19;
            BtnFechar.Text = "Fechar";
            BtnFechar.UseVisualStyleBackColor = true;
            BtnFechar.Click += BtnFechar_Click;
            // 
            // GrdItens
            // 
            GrdItens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GrdItens.Columns.AddRange(new DataGridViewColumn[] { IdPedido, FornecedorPedido, NPedido, DataPedido, StatusPedidio, AlterarPedido, AlterarPedidoProduto, ExcluirPedido });
            GrdItens.Location = new Point(12, 132);
            GrdItens.Name = "GrdItens";
            GrdItens.Size = new Size(861, 350);
            GrdItens.TabIndex = 20;
            GrdItens.CellClick += GrdItens_CellClick;
            // 
            // IdPedido
            // 
            IdPedido.DataPropertyName = "Id";
            IdPedido.HeaderText = "ID";
            IdPedido.Name = "IdPedido";
            // 
            // FornecedorPedido
            // 
            FornecedorPedido.DataPropertyName = "Nome";
            FornecedorPedido.HeaderText = "Fornecedor";
            FornecedorPedido.Name = "FornecedorPedido";
            // 
            // NPedido
            // 
            NPedido.DataPropertyName = "NPedido";
            NPedido.HeaderText = "Numero do Pedido";
            NPedido.Name = "NPedido";
            // 
            // DataPedido
            // 
            DataPedido.DataPropertyName = "Data2";
            DataPedido.HeaderText = "Data realizada";
            DataPedido.Name = "DataPedido";
            // 
            // StatusPedidio
            // 
            StatusPedidio.DataPropertyName = "Status";
            StatusPedidio.HeaderText = "Status do Pedido";
            StatusPedidio.Name = "StatusPedidio";
            // 
            // AlterarPedido
            // 
            AlterarPedido.HeaderText = "Alterar Pedido";
            AlterarPedido.Name = "AlterarPedido";
            // 
            // AlterarPedidoProduto
            // 
            AlterarPedidoProduto.HeaderText = "Alterar Produtos do Pedido";
            AlterarPedidoProduto.Name = "AlterarPedidoProduto";
            // 
            // ExcluirPedido
            // 
            ExcluirPedido.HeaderText = "Excluir";
            ExcluirPedido.Name = "ExcluirPedido";
            // 
            // FrmAddPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1104, 494);
            Controls.Add(GrdItens);
            Controls.Add(BtnFechar);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(CBStatus);
            Controls.Add(DTPedido);
            Controls.Add(TxtNPedido);
            Controls.Add(CListProdutos);
            Controls.Add(BtnSalvar);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(CBFornecedor);
            Controls.Add(TxtID);
            Controls.Add(label1);
            Name = "FrmAddPedido";
            Text = "Adicionar Pedido";
            Load += FrmAddPedido_Load;
            ((System.ComponentModel.ISupportInitialize)GrdItens).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TxtID;
        private ComboBox CBFornecedor;
        private Label label2;
        private Label label4;
        private Button BtnSalvar;
        private CheckedListBox CListProdutos;
        private TextBox TxtNPedido;
        private DateTimePicker DTPedido;
        private ComboBox CBStatus;
        private Label label3;
        private Label label5;
        private Label label6;
        private DataGridView GrdItens;
        private DataGridViewTextBoxColumn IdPedido;
        private DataGridViewTextBoxColumn FornecedorPedido;
        private DataGridViewTextBoxColumn NPedido;
        private DataGridViewTextBoxColumn DataPedido;
        private DataGridViewTextBoxColumn StatusPedidio;
        private DataGridViewButtonColumn AlterarPedido;
        private DataGridViewButtonColumn AlterarPedidoProduto;
        private DataGridViewButtonColumn ExcluirPedido;
        public Button BtnFechar;
    }
}