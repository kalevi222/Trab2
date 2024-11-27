namespace Estoque
{
    partial class FrmUsuario
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
            ckbCadPro = new CheckBox();
            CkbCadCat = new CheckBox();
            CkbAddPro = new CheckBox();
            CkbCadUsuario = new CheckBox();
            CkbADM = new CheckBox();
            txtNome = new TextBox();
            txtSenha = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            BtnSalvar = new Button();
            BtnSair = new Button();
            txtID = new TextBox();
            label4 = new Label();
            ckbMarcas = new CheckBox();
            CkbFornecedor = new CheckBox();
            GrdItem = new DataGridView();
            ID2 = new DataGridViewTextBoxColumn();
            Nome2 = new DataGridViewTextBoxColumn();
            CadProd = new DataGridViewTextBoxColumn();
            CadCate = new DataGridViewTextBoxColumn();
            AddRemProd = new DataGridViewTextBoxColumn();
            CadMarc = new DataGridViewTextBoxColumn();
            CadForn = new DataGridViewTextBoxColumn();
            CadUsua = new DataGridViewTextBoxColumn();
            PermissaPedidos = new DataGridViewTextBoxColumn();
            PerADM = new DataGridViewTextBoxColumn();
            AlterarUsuarios = new DataGridViewButtonColumn();
            ExcluirUsuarios = new DataGridViewButtonColumn();
            CkbAddPedidos = new CheckBox();
            BtnLimpar = new Button();
            TxtPesquisa = new TextBox();
            label5 = new Label();
            CBPesquisa = new ComboBox();
            BtnPesquisar = new Button();
            ((System.ComponentModel.ISupportInitialize)GrdItem).BeginInit();
            SuspendLayout();
            // 
            // ckbCadPro
            // 
            ckbCadPro.AutoSize = true;
            ckbCadPro.Location = new Point(12, 72);
            ckbCadPro.Name = "ckbCadPro";
            ckbCadPro.Size = new Size(127, 19);
            ckbCadPro.TabIndex = 0;
            ckbCadPro.Text = "Cadastrar produtos";
            ckbCadPro.UseVisualStyleBackColor = true;
            ckbCadPro.CheckedChanged += ckbCadPro_CheckedChanged;
            // 
            // CkbCadCat
            // 
            CkbCadCat.AutoSize = true;
            CkbCadCat.Location = new Point(157, 72);
            CkbCadCat.Name = "CkbCadCat";
            CkbCadCat.Size = new Size(135, 19);
            CkbCadCat.TabIndex = 1;
            CkbCadCat.Text = "Cadastrar Categorias";
            CkbCadCat.UseVisualStyleBackColor = true;
            CkbCadCat.CheckedChanged += CkbCadCat_CheckedChanged;
            // 
            // CkbAddPro
            // 
            CkbAddPro.AutoSize = true;
            CkbAddPro.Location = new Point(314, 72);
            CkbAddPro.Name = "CkbAddPro";
            CkbAddPro.Size = new Size(96, 19);
            CkbAddPro.TabIndex = 2;
            CkbAddPro.Text = "Gerir Estoque";
            CkbAddPro.UseVisualStyleBackColor = true;
            CkbAddPro.CheckedChanged += CkbAddPro_CheckedChanged;
            // 
            // CkbCadUsuario
            // 
            CkbCadUsuario.AutoSize = true;
            CkbCadUsuario.Location = new Point(12, 97);
            CkbCadUsuario.Name = "CkbCadUsuario";
            CkbCadUsuario.Size = new Size(91, 19);
            CkbCadUsuario.TabIndex = 3;
            CkbCadUsuario.Text = "Gerir Vendas";
            CkbCadUsuario.UseVisualStyleBackColor = true;
            CkbCadUsuario.CheckedChanged += CkbCadUsuario_CheckedChanged;
            // 
            // CkbADM
            // 
            CkbADM.AutoSize = true;
            CkbADM.Location = new Point(470, 95);
            CkbADM.Name = "CkbADM";
            CkbADM.Size = new Size(53, 19);
            CkbADM.TabIndex = 4;
            CkbADM.Text = "ADM";
            CkbADM.UseVisualStyleBackColor = true;
            CkbADM.CheckedChanged += CkbADM_CheckedChanged;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(101, 21);
            txtNome.MaxLength = 60;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(363, 23);
            txtNome.TabIndex = 5;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(470, 21);
            txtSenha.MaxLength = 50;
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(254, 23);
            txtSenha.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(101, 3);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 7;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(470, 3);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 8;
            label2.Text = "Senha";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 47);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 9;
            label3.Text = "Permissões";
            // 
            // BtnSalvar
            // 
            BtnSalvar.Location = new Point(12, 149);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(124, 44);
            BtnSalvar.TabIndex = 11;
            BtnSalvar.Text = "Salvar";
            BtnSalvar.UseVisualStyleBackColor = true;
            BtnSalvar.Click += BtnSalvar_Click;
            // 
            // BtnSair
            // 
            BtnSair.Location = new Point(600, 149);
            BtnSair.Name = "BtnSair";
            BtnSair.Size = new Size(124, 44);
            BtnSair.TabIndex = 12;
            BtnSair.Text = "Fechar";
            BtnSair.UseVisualStyleBackColor = true;
            BtnSair.Click += BtnSair_Click;
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(12, 21);
            txtID.MaxLength = 4;
            txtID.Name = "txtID";
            txtID.Size = new Size(75, 23);
            txtID.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 3);
            label4.Name = "label4";
            label4.Size = new Size(18, 15);
            label4.TabIndex = 14;
            label4.Text = "ID";
            // 
            // ckbMarcas
            // 
            ckbMarcas.AutoSize = true;
            ckbMarcas.Location = new Point(314, 97);
            ckbMarcas.Name = "ckbMarcas";
            ckbMarcas.Size = new Size(117, 19);
            ckbMarcas.TabIndex = 15;
            ckbMarcas.Text = "Cadastrar Marcas";
            ckbMarcas.UseVisualStyleBackColor = true;
            ckbMarcas.CheckedChanged += ckbMarcas_CheckedChanged;
            // 
            // CkbFornecedor
            // 
            CkbFornecedor.AutoSize = true;
            CkbFornecedor.Location = new Point(470, 70);
            CkbFornecedor.Name = "CkbFornecedor";
            CkbFornecedor.Size = new Size(150, 19);
            CkbFornecedor.TabIndex = 16;
            CkbFornecedor.Text = "Cadastrar Fornecedores";
            CkbFornecedor.UseVisualStyleBackColor = true;
            CkbFornecedor.CheckedChanged += CkbFornecedor_CheckedChanged;
            // 
            // GrdItem
            // 
            GrdItem.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GrdItem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GrdItem.Columns.AddRange(new DataGridViewColumn[] { ID2, Nome2, CadProd, CadCate, AddRemProd, CadMarc, CadForn, CadUsua, PermissaPedidos, PerADM, AlterarUsuarios, ExcluirUsuarios });
            GrdItem.Location = new Point(12, 211);
            GrdItem.Name = "GrdItem";
            GrdItem.Size = new Size(1010, 406);
            GrdItem.TabIndex = 17;
            GrdItem.CellClick += GrdItem_CellClick;
            GrdItem.CellContentClick += GrdItem_CellContentClick;
            // 
            // ID2
            // 
            ID2.DataPropertyName = "ID";
            ID2.HeaderText = "Id";
            ID2.Name = "ID2";
            ID2.Width = 80;
            // 
            // Nome2
            // 
            Nome2.DataPropertyName = "Nome";
            Nome2.HeaderText = "Usuario";
            Nome2.Name = "Nome2";
            Nome2.Width = 170;
            // 
            // CadProd
            // 
            CadProd.DataPropertyName = "CadPro";
            CadProd.HeaderText = "Cad. Produto";
            CadProd.Name = "CadProd";
            CadProd.Width = 60;
            // 
            // CadCate
            // 
            CadCate.DataPropertyName = "CadCat";
            CadCate.HeaderText = "Cad. Categoria";
            CadCate.Name = "CadCate";
            CadCate.Width = 65;
            // 
            // AddRemProd
            // 
            AddRemProd.DataPropertyName = "PAddPro";
            AddRemProd.HeaderText = "Gerir Estoque";
            AddRemProd.Name = "AddRemProd";
            AddRemProd.Width = 60;
            // 
            // CadMarc
            // 
            CadMarc.DataPropertyName = "CadMarca";
            CadMarc.HeaderText = "Cad. Marcas";
            CadMarc.Name = "CadMarc";
            CadMarc.Width = 60;
            // 
            // CadForn
            // 
            CadForn.DataPropertyName = "CadFor";
            CadForn.HeaderText = "Cad. Fornecedores";
            CadForn.Name = "CadForn";
            CadForn.Width = 70;
            // 
            // CadUsua
            // 
            CadUsua.DataPropertyName = "PVenda";
            CadUsua.HeaderText = "Gerir Vendas";
            CadUsua.Name = "CadUsua";
            CadUsua.Width = 60;
            // 
            // PermissaPedidos
            // 
            PermissaPedidos.DataPropertyName = "PPedido";
            PermissaPedidos.HeaderText = "Adcionar Pedidos";
            PermissaPedidos.Name = "PermissaPedidos";
            PermissaPedidos.Width = 80;
            // 
            // PerADM
            // 
            PerADM.DataPropertyName = "PADM";
            PerADM.HeaderText = "ADM";
            PerADM.Name = "PerADM";
            PerADM.Width = 60;
            // 
            // AlterarUsuarios
            // 
            AlterarUsuarios.HeaderText = "Editar";
            AlterarUsuarios.Name = "AlterarUsuarios";
            // 
            // ExcluirUsuarios
            // 
            ExcluirUsuarios.HeaderText = "Excluir";
            ExcluirUsuarios.Name = "ExcluirUsuarios";
            // 
            // CkbAddPedidos
            // 
            CkbAddPedidos.AutoSize = true;
            CkbAddPedidos.Location = new Point(157, 97);
            CkbAddPedidos.Name = "CkbAddPedidos";
            CkbAddPedidos.Size = new Size(119, 19);
            CkbAddPedidos.TabIndex = 18;
            CkbAddPedidos.Text = "Adcionar Pedidos";
            CkbAddPedidos.UseVisualStyleBackColor = true;
            CkbAddPedidos.CheckedChanged += CBAddPedidos_CheckedChanged;
            // 
            // BtnLimpar
            // 
            BtnLimpar.Location = new Point(891, 138);
            BtnLimpar.Name = "BtnLimpar";
            BtnLimpar.Size = new Size(127, 55);
            BtnLimpar.TabIndex = 24;
            BtnLimpar.Text = "Limpar";
            BtnLimpar.UseVisualStyleBackColor = true;
            BtnLimpar.Click += BtnLimpar_Click;
            // 
            // TxtPesquisa
            // 
            TxtPesquisa.Location = new Point(758, 68);
            TxtPesquisa.Name = "TxtPesquisa";
            TxtPesquisa.Size = new Size(260, 23);
            TxtPesquisa.TabIndex = 23;
            TxtPesquisa.Text = "Valor de pesquisa";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(869, 3);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 22;
            label5.Text = "Pesquisar";
            // 
            // CBPesquisa
            // 
            CBPesquisa.FormattingEnabled = true;
            CBPesquisa.Items.AddRange(new object[] { "ID", "Usuario" });
            CBPesquisa.Location = new Point(758, 21);
            CBPesquisa.Name = "CBPesquisa";
            CBPesquisa.Size = new Size(260, 23);
            CBPesquisa.TabIndex = 21;
            CBPesquisa.Text = "Tipo de pesquisa";
            CBPesquisa.SelectedIndexChanged += CBPesquisa_SelectedIndexChanged;
            // 
            // BtnPesquisar
            // 
            BtnPesquisar.Location = new Point(758, 138);
            BtnPesquisar.Name = "BtnPesquisar";
            BtnPesquisar.Size = new Size(127, 55);
            BtnPesquisar.TabIndex = 20;
            BtnPesquisar.Text = "pesquisar";
            BtnPesquisar.UseVisualStyleBackColor = true;
            BtnPesquisar.Click += BtnPesquisar_Click;
            // 
            // FrmUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 629);
            Controls.Add(BtnLimpar);
            Controls.Add(TxtPesquisa);
            Controls.Add(label5);
            Controls.Add(CBPesquisa);
            Controls.Add(BtnPesquisar);
            Controls.Add(CkbAddPedidos);
            Controls.Add(GrdItem);
            Controls.Add(CkbFornecedor);
            Controls.Add(ckbMarcas);
            Controls.Add(label4);
            Controls.Add(txtID);
            Controls.Add(BtnSair);
            Controls.Add(BtnSalvar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSenha);
            Controls.Add(txtNome);
            Controls.Add(CkbADM);
            Controls.Add(CkbCadUsuario);
            Controls.Add(CkbAddPro);
            Controls.Add(CkbCadCat);
            Controls.Add(ckbCadPro);
            Name = "FrmUsuario";
            Text = "FrmUsuario";
            Load += FrmUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)GrdItem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox ckbCadPro;
        private CheckBox CkbCadCat;
        private CheckBox CkbAddPro;
        private CheckBox CkbCadUsuario;
        private CheckBox CkbADM;
        private TextBox txtNome;
        private TextBox txtSenha;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button BtnSalvar;
        private Button BtnSair;
        private TextBox txtID;
        private Label label4;
        private CheckBox ckbMarcas;
        private CheckBox CkbFornecedor;
        private DataGridView GrdItem;
        private CheckBox CkbAddPedidos;
        private DataGridViewTextBoxColumn ID2;
        private DataGridViewTextBoxColumn Nome2;
        private DataGridViewTextBoxColumn CadProd;
        private DataGridViewTextBoxColumn CadCate;
        private DataGridViewTextBoxColumn AddRemProd;
        private DataGridViewTextBoxColumn CadMarc;
        private DataGridViewTextBoxColumn CadForn;
        private DataGridViewTextBoxColumn CadUsua;
        private DataGridViewTextBoxColumn PermissaPedidos;
        private DataGridViewTextBoxColumn PerADM;
        private DataGridViewButtonColumn AlterarUsuarios;
        private DataGridViewButtonColumn ExcluirUsuarios;
        private Button BtnLimpar;
        private TextBox TxtPesquisa;
        private Label label5;
        private ComboBox CBPesquisa;
        private Button BtnPesquisar;
    }
}