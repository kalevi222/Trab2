

using Estoque.Classes;
using Estoque.Formularios;
using System.Diagnostics.Eventing.Reader;

namespace Estoque
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();

        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            FrmLogin loginForm = new FrmLogin();


            loginForm.StartPosition = FormStartPosition.CenterParent;
            loginForm.ShowDialog(this);
            Permissoes();

        }
        private void Permissoes()
        {
            if (Login.PADM2 == false)
            {

                CadUsuario.Enabled = false;

                if (Login.PPro2 == false)
                {
                    AddProduto.Enabled = false;
                }
                else
                {
                    AddProduto.Enabled = true;
                }
                if (Login.CadCat2 == false)
                {
                    CadCategoria.Enabled = false;
                }
                else
                {
                    CadCategoria.Enabled = true;
                }
                if (Login.CadPro2 == false)
                {
                    CadProduto.Enabled = false;
                }
                else
                {
                    CadProduto.Enabled = true;
                }
                if (Login.CadFor2 == false)
                {
                    CadFornecedor.Enabled = false;
                }
                else
                {
                    CadFornecedor.Enabled = true;
                }
                if (Login.CadMarca2 == false)
                {
                    CadMarca.Enabled = false;
                }
                else
                {
                    CadMarca.Enabled = true;
                }
                if (Login.PPedido2 == false)
                {
                    AddPedidos.Enabled = false;
                }
                else
                {
                    AddPedidos.Enabled = true;
                }
                if (Login.PVenda2 == false)
                {
                    GuiaVendas.Enabled = false;
                    HistoVendas.Enabled = false;
                }
                else
                {
                    GuiaVendas.Enabled = true;
                    HistoVendas.Enabled = true;
                }
            }
            else
            {
                GuiaVendas.Enabled = true;
                HistoVendas.Enabled = true;
                AddPedidos.Enabled = true;
                CadMarca.Enabled = true;
                CadFornecedor.Enabled = true;
                CadProduto.Enabled = true;
                CadCategoria.Enabled = true;
                AddProduto.Enabled = true;
                CadUsuario.Enabled = true;
            }
        }
        private void gerirProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGerir oFrm = new FrmGerir();
            oFrm.MdiParent = this;
            oFrm.Show();
        }

        private void cadastrarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuario oFrm = new FrmUsuario();
            oFrm.MdiParent = this;
            oFrm.Show();
        }

        private void LimparPermissao()
        {
            Login.PPro2 = false;
            Login.PADM2 = false;
            Login.PPro2 = false;
            Login.CadCat2 = false;
            Login.CadPro2 = false;
            Login.CadFor2 = false;
            Login.CadMarca2 = false;
            Login.PPedido2 = false;
            Login.PVenda2 = false;

            Permissoes();
        
        }
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LimparPermissao();

            FrmLogin loginForm = new FrmLogin();


            loginForm.StartPosition = FormStartPosition.CenterParent;
            loginForm.ShowDialog(this);

            Permissoes();

        }

        private void cadastrarCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCategoria oFrm = new FrmCategoria();
            oFrm.MdiParent = this;
            oFrm.Show();

        }

        private void cadastrarMarcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMarca oFrm = new FrmMarca();
            oFrm.MdiParent = this;
            oFrm.Show();
        }

        private void cadastrarFornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFornecedor oFrm = new FrmFornecedor();
            oFrm.MdiParent = this;
            oFrm.Show();
        }

        private void cadastrarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadProdutos oFrm = new FrmCadProdutos();
            oFrm.MdiParent = this;
            oFrm.Show();
        }

        private void adcionarbaixarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAdEstoque oFrm = new FrmAdEstoque();
            oFrm.MdiParent = this;
            oFrm.Show();
        }

        private void gerirProdutosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmEstoqueConsulta oFrm = new FrmEstoqueConsulta();
            oFrm.MdiParent = this;
            oFrm.Show();
        }

        private void AddPedidos_Click(object sender, EventArgs e)
        {
            FrmAddPedido oFrm = new FrmAddPedido();
            oFrm.MdiParent = this;
            oFrm.Show();
        }

        private void GuiaVendas_Click(object sender, EventArgs e)
        {
            FrmGuiaVendas oFrm = new FrmGuiaVendas();
            oFrm.MdiParent = this;
            oFrm.Show();
        }

        private void consultarPedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultarPedido oFrm = new FrmConsultarPedido();
            oFrm.MdiParent = this;
            oFrm.Show();
        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
