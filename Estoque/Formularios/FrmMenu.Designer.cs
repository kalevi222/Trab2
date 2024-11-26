namespace Estoque
{
    partial class FrmMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            vendaToolStripMenuItem = new ToolStripMenuItem();
            GuiaVendas = new ToolStripMenuItem();
            HistoVendas = new ToolStripMenuItem();
            gerirProdutosToolStripMenuItem = new ToolStripMenuItem();
            AddProduto = new ToolStripMenuItem();
            RegistroProduto = new ToolStripMenuItem();
            verificarValidadeDeProdutosToolStripMenuItem = new ToolStripMenuItem();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            CadCategoria = new ToolStripMenuItem();
            CadFornecedor = new ToolStripMenuItem();
            CadMarca = new ToolStripMenuItem();
            CadProduto = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            CadUsuario = new ToolStripMenuItem();
            pedidosToolStripMenuItem = new ToolStripMenuItem();
            AddPedidos = new ToolStripMenuItem();
            consultarPedidosToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            fecharToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { vendaToolStripMenuItem, gerirProdutosToolStripMenuItem, cadastrosToolStripMenuItem, pedidosToolStripMenuItem, sairToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1375, 24);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // vendaToolStripMenuItem
            // 
            vendaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { GuiaVendas, HistoVendas });
            vendaToolStripMenuItem.Name = "vendaToolStripMenuItem";
            vendaToolStripMenuItem.Size = new Size(51, 20);
            vendaToolStripMenuItem.Text = "Venda";
            // 
            // GuiaVendas
            // 
            GuiaVendas.Enabled = false;
            GuiaVendas.Name = "GuiaVendas";
            GuiaVendas.Size = new Size(183, 22);
            GuiaVendas.Text = "Abrir Guia de Vendas";
            GuiaVendas.Click += GuiaVendas_Click;
            // 
            // HistoVendas
            // 
            HistoVendas.Enabled = false;
            HistoVendas.Name = "HistoVendas";
            HistoVendas.Size = new Size(183, 22);
            HistoVendas.Text = "Historico de Vendas";
            // 
            // gerirProdutosToolStripMenuItem
            // 
            gerirProdutosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { AddProduto, RegistroProduto, verificarValidadeDeProdutosToolStripMenuItem });
            gerirProdutosToolStripMenuItem.Name = "gerirProdutosToolStripMenuItem";
            gerirProdutosToolStripMenuItem.Size = new Size(61, 20);
            gerirProdutosToolStripMenuItem.Text = "Estoque";
            // 
            // AddProduto
            // 
            AddProduto.Enabled = false;
            AddProduto.Name = "AddProduto";
            AddProduto.Size = new Size(230, 22);
            AddProduto.Text = "Adcionar Produto";
            AddProduto.Click += adcionarbaixarProdutoToolStripMenuItem_Click;
            // 
            // RegistroProduto
            // 
            RegistroProduto.Name = "RegistroProduto";
            RegistroProduto.Size = new Size(230, 22);
            RegistroProduto.Text = "Registro de produtos";
            RegistroProduto.Click += gerirProdutosToolStripMenuItem1_Click;
            // 
            // verificarValidadeDeProdutosToolStripMenuItem
            // 
            verificarValidadeDeProdutosToolStripMenuItem.Name = "verificarValidadeDeProdutosToolStripMenuItem";
            verificarValidadeDeProdutosToolStripMenuItem.Size = new Size(230, 22);
            verificarValidadeDeProdutosToolStripMenuItem.Text = "Verificar Validade de produtos";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { CadCategoria, CadFornecedor, CadMarca, CadProduto, toolStripMenuItem2, CadUsuario });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(71, 20);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // CadCategoria
            // 
            CadCategoria.Enabled = false;
            CadCategoria.Name = "CadCategoria";
            CadCategoria.Size = new Size(198, 22);
            CadCategoria.Text = "Cadastrar Categoria";
            CadCategoria.Click += cadastrarCategoriaToolStripMenuItem_Click;
            // 
            // CadFornecedor
            // 
            CadFornecedor.Enabled = false;
            CadFornecedor.Name = "CadFornecedor";
            CadFornecedor.Size = new Size(198, 22);
            CadFornecedor.Text = "Cadastrar Fornecedores";
            CadFornecedor.Click += cadastrarFornecedoresToolStripMenuItem_Click;
            // 
            // CadMarca
            // 
            CadMarca.Enabled = false;
            CadMarca.Name = "CadMarca";
            CadMarca.Size = new Size(198, 22);
            CadMarca.Text = "Cadastrar Marcas";
            CadMarca.Click += cadastrarMarcasToolStripMenuItem_Click;
            // 
            // CadProduto
            // 
            CadProduto.Enabled = false;
            CadProduto.Name = "CadProduto";
            CadProduto.Size = new Size(198, 22);
            CadProduto.Text = "Cadastrar Produto";
            CadProduto.Click += cadastrarProdutoToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(195, 6);
            // 
            // CadUsuario
            // 
            CadUsuario.Enabled = false;
            CadUsuario.Name = "CadUsuario";
            CadUsuario.Size = new Size(198, 22);
            CadUsuario.Text = "Cadastrar Usuarios";
            CadUsuario.Click += cadastrarUsuariosToolStripMenuItem_Click;
            // 
            // pedidosToolStripMenuItem
            // 
            pedidosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { AddPedidos, consultarPedidosToolStripMenuItem });
            pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            pedidosToolStripMenuItem.Size = new Size(61, 20);
            pedidosToolStripMenuItem.Text = "Pedidos";
            // 
            // AddPedidos
            // 
            AddPedidos.Enabled = false;
            AddPedidos.Name = "AddPedidos";
            AddPedidos.Size = new Size(180, 22);
            AddPedidos.Text = "Adcionar Pedidos";
            AddPedidos.Click += AddPedidos_Click;
            // 
            // consultarPedidosToolStripMenuItem
            // 
            consultarPedidosToolStripMenuItem.Name = "consultarPedidosToolStripMenuItem";
            consultarPedidosToolStripMenuItem.Size = new Size(180, 22);
            consultarPedidosToolStripMenuItem.Text = "Consultar Pedidos";
            consultarPedidosToolStripMenuItem.Click += consultarPedidosToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { logoutToolStripMenuItem, fecharToolStripMenuItem });
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(38, 20);
            sairToolStripMenuItem.Text = "Sair";
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(180, 22);
            logoutToolStripMenuItem.Text = "Voltar ao Login";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // fecharToolStripMenuItem
            // 
            fecharToolStripMenuItem.Name = "fecharToolStripMenuItem";
            fecharToolStripMenuItem.Size = new Size(180, 22);
            fecharToolStripMenuItem.Text = "Fechar o programa";
            fecharToolStripMenuItem.Click += fecharToolStripMenuItem_Click;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1375, 646);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FrmMenu";
            Text = "Estoque LPJMN";
            Load += FrmMenu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem gerirProdutosToolStripMenuItem;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem fecharToolStripMenuItem;
        private ToolStripMenuItem vendaToolStripMenuItem;
        private ToolStripMenuItem pedidosToolStripMenuItem;
        public ToolStripMenuItem RegistroProduto;
        public ToolStripMenuItem consultarPedidosToolStripMenuItem;
        private ToolStripMenuItem verificarValidadeDeProdutosToolStripMenuItem;
        private ToolStripMenuItem AddProduto;
        private ToolStripMenuItem CadCategoria;
        private ToolStripMenuItem CadFornecedor;
        private ToolStripMenuItem CadMarca;
        private ToolStripMenuItem CadUsuario;
        private ToolStripMenuItem CadProduto;
        private ToolStripMenuItem GuiaVendas;
        private ToolStripMenuItem HistoVendas;
        private ToolStripMenuItem AddPedidos;
    }
}
