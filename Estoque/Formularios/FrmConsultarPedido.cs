using Estoque.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Estoque.Formularios
{
    public partial class FrmConsultarPedido : Form
    {
        public static bool Cod;
        public static int CodigoPedido2;
        private string PesquisaTipo;
        private int GrdPesquisa;
        public FrmConsultarPedido()
        {
            InitializeComponent();
        }

        private void FrmConsultarPedido_Load(object sender, EventArgs e)
        {
            CarregaGrid();
            GrdItens2.Visible = false;
            CBPesquisa.Items.Add("Id Pedido");
            CBPesquisa.Items.Add("Fornecedor");
            CBPesquisa.Items.Add("Numero do Pedido");
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CarregaGrid()
        {
            GrdItens.AutoGenerateColumns = false;
            GrdItens.DataSource = Pedido.ListarTodos();
        }
        private void CarregaTxtBox()
        {
            TxtID.Text = Pedido.Id3.ToString();
            TxtData.Text = Pedido.Date3.ToString();
            TxtNome.Text = Pedido.Nome2;
            TxtNPedido.Text = Pedido.NumPedido.ToString();
            TxtStatus.Text = Pedido.Status2;
        }

        private void GrdItens_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cod = true;
            CodigoPedido2 = int.Parse(TxtID.Text);
            CarregaGrid2();
            CarregaGrid();
            TxtPesquisa.Text = "";
            Cod = false;

        }

        private void GrdItens_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (GrdItens.Rows[e.RowIndex].DataBoundItem != null)
            {
                Pedido ObjSelecionado = (Pedido)GrdItens.Rows[e.RowIndex].DataBoundItem;

                if (GrdItens.Columns[e.ColumnIndex].Name == "VerMais")
                {

                    Cod = true;
                    TxtID.Text = ObjSelecionado.Id.ToString();
                    CodigoPedido2 = int.Parse(TxtID.Text);
                    CarregaGrid2();
                    CarregaTxtBox();
                    GrdItens.Visible = false;
                    GrdItens2.Visible = true;
                    GrdPesquisa = 1;
                    CBPesquisa.Items.Clear();
                    CBPesquisa.Items.Add("Id Produto");
                    CBPesquisa.Items.Add("Nome do Produto");
                }

                Cod = false;
            }
        }

        private void CarregaGrid2()
        {

            GrdItens2.AutoGenerateColumns = false;
            GrdItens2.DataSource = Pedido.ListarTodos2();

        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            CarregaGrid();
            GrdItens2.Visible = false;
            GrdItens.Visible = true;
            GrdPesquisa = 0;
            CBPesquisa.Items.Clear();
            CBPesquisa.Items.Add("Id Pedido");
            CBPesquisa.Items.Add("Fornecedor");
            CBPesquisa.Items.Add("Numero do Pedido");
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (GrdPesquisa == 0)
                {
                    var oPedido = Pedido.Seleciona2(PesquisaTipo, TxtPesquisa.Text); // Chamando o método estático
                    GrdItens.DataSource = null; // Limpa qualquer fonte anterior
                    GrdItens.DataSource = oPedido; // Vincula a lista ao DataGridView
                }
                else if (GrdPesquisa == 1)
                {
                    var oPedido = Pedido.Seleciona3(PesquisaTipo, TxtPesquisa.Text, int.Parse(TxtID.Text)); // Chamando o método estático
                    GrdItens2.DataSource = null; // Limpa qualquer fonte anterior
                    GrdItens2.DataSource = oPedido; // Vincula a lista ao DataGridView
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar produtos: {ex.Message}");
            }
        }

        private void CBPesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GrdPesquisa == 0)
            {
                if (CBPesquisa.SelectedIndex == 0)
                {
                    PesquisaTipo = "P.id";
                }
                else if (CBPesquisa.SelectedIndex == 1)
                {
                    PesquisaTipo = "F.Nome";
                }
                else if (CBPesquisa.SelectedIndex == 2)
                {
                    PesquisaTipo = "NumPedido";
                }
            };
            
            if (GrdPesquisa == 1)
            {
                if (CBPesquisa.SelectedIndex == 0)
                {
                    PesquisaTipo = "PP.Produto_id";
                }
                else if (CBPesquisa.SelectedIndex == 1)
                {
                    PesquisaTipo = "Pro.Nome";
                }

            };
            
        }
    }
}
