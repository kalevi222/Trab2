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

namespace Estoque.Formularios
{
    public partial class FrmRegistroVenda : Form
    {
        public static bool Cod;
        public static int CodigoPedido2;
        private string PesquisaTipo;
        private int GrdPesquisa = 0;
        public int PesquisaData = 0;
        public FrmRegistroVenda()
        {
            InitializeComponent();
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (GrdPesquisa == 0)
                {
                    if (PesquisaData == 1)
                    {
                        var oPedido = Venda.Seleciona2(PesquisaTipo, DTPesquisa.Value.Date.ToString()); // Chamando o método estático
                        GrdItens.DataSource = null; // Limpa qualquer fonte anterior
                        GrdItens.DataSource = oPedido; // Vincula a lista ao DataGridView
                    }
                    else
                    {
                        var oPedido = Venda.Seleciona2(PesquisaTipo, TxtPesquisa.Text); // Chamando o método estático
                        GrdItens.DataSource = null; // Limpa qualquer fonte anterior
                        GrdItens.DataSource = oPedido; // Vincula a lista ao DataGridView
                    }
                }
                else if (GrdPesquisa == 1)
                {
                    var oPedido = Venda.Seleciona3(PesquisaTipo, TxtPesquisa.Text, int.Parse(TxtId.Text)); // Chamando o método estático
                    GrdItens2.DataSource = null; // Limpa qualquer fonte anterior
                    GrdItens2.DataSource = oPedido; // Vincula a lista ao DataGridView
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar produtos: {ex.Message}");
            }
        }

        private void FrmRegistroVenda_Load(object sender, EventArgs e)
        {
            CarregaGrid();
            GrdItens2.Visible = false;
            CBPesquisa.Items.Add("Id Venda");
            CBPesquisa.Items.Add("Valor Venda");
            CBPesquisa.Items.Add("Data da Venda");
            DTPesquisa.Visible = false;
        }

        private void CarregaGrid()
        {
            GrdItens.AutoGenerateColumns = false;
            GrdItens.DataSource = Venda.ListarTodos();
        }

        private void CarregaGrid2()
        {
            GrdItens2.AutoGenerateColumns = false;
            GrdItens2.DataSource = Venda.ListarTodos2(CodigoPedido2);
        }

        private void CarregaTxtBox()
        {
            TxtId.Text = Venda.Id4.ToString();
            TxtData.Text = Venda.Date3.ToString();
            TxtValor.Text = Venda.ValorVenda2.ToString();

        }

        private void GrdItens_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GrdItens.Rows[e.RowIndex].DataBoundItem != null)
            {
                Venda ObjSelecionado = (Venda)GrdItens.Rows[e.RowIndex].DataBoundItem;

                if (GrdItens.Columns[e.ColumnIndex].Name == "VerProdutos")
                {

                    Cod = true;
                    TxtId.Text = ObjSelecionado.Id.ToString();
                    CodigoPedido2 = int.Parse(TxtId.Text);
                    CarregaGrid2();
                    CarregaTxtBox();
                    GrdItens.Visible = false;
                    GrdItens2.Visible = true;
                    GrdPesquisa = 1;
                    CBPesquisa.Items.Clear();
                    CBPesquisa.Items.Add("Id Produto");
                    CBPesquisa.Items.Add("Nome do Produto");
                    CBPesquisa.Items.Add("Lote");
                }
                else if (GrdItens.Columns[e.ColumnIndex].Name == "ExcluirVenda" && Login.PADM2 == true)
                {
                    if (MessageBox.Show("Confirme a exclusao.", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            ObjSelecionado.Excluir();
                            CarregaGrid();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Um erro ocorreu ao e excluir o Produto: {ex.Message}.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            TxtId.Focus();
                        }
                    }
                }
                else if (GrdItens.Columns[e.ColumnIndex].Name == "ExcluirVenda" && Login.PADM2 == false) 
                {

                    MessageBox.Show($"Voce nao possui permissão para essa função.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtId.Focus();
                }



                Cod = false;
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            int Codigo;
            Cod = true;
            if (int.TryParse(TxtId.Text, out Codigo))
            {
                CodigoPedido2 = int.Parse(TxtId.Text);
                CarregaGrid2();
            }
            CarregaGrid();
            TxtPesquisa.Text = "";
            Cod = false;
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            CarregaGrid();
            GrdItens2.Visible = false;
            GrdItens.Visible = true;
            GrdPesquisa = 0;
            CBPesquisa.Items.Clear();
            CBPesquisa.Items.Add("Id Venda");
            CBPesquisa.Items.Add("Valor Venda");
            CBPesquisa.Items.Add("Data da Venda");
        }

        private void CBPesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GrdPesquisa == 0)
            {
                if (CBPesquisa.SelectedIndex == 0)
                {
                    PesquisaTipo = "id";
                    TxtPesquisa.Visible = true;
                    DTPesquisa.Visible = false;
                    PesquisaData = 0;
                }
                else if (CBPesquisa.SelectedIndex == 1)
                {
                    PesquisaTipo = "ValorTotalVenda";
                    TxtPesquisa.Visible = true;
                    DTPesquisa.Visible = false;
                    PesquisaData = 0;
                }
                else if (CBPesquisa.SelectedIndex == 2)
                {
                    PesquisaTipo = "DataVenda";
                    TxtPesquisa.Visible = false;
                    DTPesquisa.Visible = true;
                    PesquisaData = 1;

                }
            };

            if (GrdPesquisa == 1)
            {
                if (CBPesquisa.SelectedIndex == 0)
                {
                    PesquisaTipo = "VP.Produto_id";
                    TxtPesquisa.Visible = true;
                    DTPesquisa.Visible = false;
                    PesquisaData = 0;
                }
                else if (CBPesquisa.SelectedIndex == 1)
                {
                    PesquisaTipo = "P.Nome";
                    TxtPesquisa.Visible = true;
                    DTPesquisa.Visible = false;
                    PesquisaData = 0;
                }
                else if (CBPesquisa.SelectedIndex == 2)
                {
                    PesquisaTipo = "VP.Lote";
                    TxtPesquisa.Visible = true;
                    DTPesquisa.Visible = false;
                    PesquisaData = 0;
                }

            };
        }
    }
}
