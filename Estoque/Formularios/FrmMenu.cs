

using Estoque.Classes;
using Estoque.Formularios;

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
            if (Login.PADM2 == false)
            {

                CadUsuario.Enabled = false;

                if (Login.PPro2 == false)
                {
                    AddProduto.Enabled = false;
                };
                if (Login.CadCat2 == false)
                {
                    CadCategoria.Enabled = false;
                };
                if (Login.CadPro2 == false)
                {
                    CadProduto.Enabled = false;
                };
                if (Login.CadFor2 == false)
                {
                    CadFornecedor.Enabled = false;
                };
                if (Login.CadMarca2 == false)
                {
                    CadMarca.Enabled = false;
                };
                if (Login.PPedido2 == true)
                {
                    AddPedidos.Enabled = false;
                };
                if (Login.PVenda2 == false)
                {
                    GuiaVendas.Enabled = false;
                    HistoVendas.Enabled = false;
                };
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

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Close();
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

        }

        private void consultarPedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultarPedido oFrm = new FrmConsultarPedido();
            oFrm.MdiParent = this;
            oFrm.Show();
        }
    }
}
