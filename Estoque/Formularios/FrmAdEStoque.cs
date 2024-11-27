using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Estoque.Classes;

namespace Estoque.Formularios
{
    public partial class FrmAdEstoque : Form
    {
        private bool incluir = true;
        public string PesquisaTipo;
        public static DateTime Data4;
        public FrmAdEstoque()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {


            if (ValidaControles())
            {
                if (incluir)
                {

                    EstoqueC oEstoque = new EstoqueC
                    {
                        Data2 = DTValidade.Value,
                        Data3 = DTFabricacao.Value,
                        QTD = int.Parse(TxtQtd.Text),
                        IdProduto = CBProduto.SelectedValue.ToString(),
                        Lote = int.Parse(TxtLote.Text),
                        Preco = Double.Parse(TxtPreco.Text, System.Globalization.CultureInfo.InvariantCulture),
                    };

                    try
                    {
                        oEstoque.Incluir();
                        oEstoque.Incluir2();
                        CarregaGrid();
                        LimpaControles();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Um erro ocorreu ao incluir o Produto: {ex.Message}.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxtID.Focus();
                    }
                }
                else
                {
                    try
                    {
                        EstoqueC oEstoque = new EstoqueC
                        {
                            Id = int.Parse(TxtID.Text),
                            Data2 = DTValidade.Value,
                            Data3 = DTFabricacao.Value,
                            QTD = int.Parse(TxtQtd.Text),
                            IdProduto = CBProduto.SelectedValue.ToString(),
                            Lote = int.Parse(TxtLote.Text),
                            Preco = Double.Parse(TxtPreco.Text, System.Globalization.CultureInfo.InvariantCulture),

                        };
                        EstoqueC.AlterarEstoque(oEstoque);
                        incluir = true;
                        LimpaControles();
                        CarregaGrid();
                        TxtID.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Um erro ocorreu ao alterar o Produto: {ex.Message}.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxtID.Focus();
                    }

                }
            }
        }

        private void CarregaGrid()
        {

            GrdItens.AutoGenerateColumns = false;
            GrdItens.DataSource = EstoqueC.ListarTodos();

        }

        private bool ValidaControles()
        {
            int codigo;
            double valor;
            DateTime DataAtual = DateTime.Now;

            if (int.TryParse(TxtLote.Text, out codigo) && double.TryParse(TxtPreco.Text, out valor) && int.TryParse(TxtQtd.Text, out codigo)
                && DTValidade.Value.Date > DataAtual.Date && DTFabricacao.Value.Date <= DataAtual.Date)
            {
                return true;
            }
            else if (int.TryParse(TxtLote.Text, out codigo) != true)
            {
                MessageBox.Show("O campo lote não é numerico.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (double.TryParse(TxtPreco.Text, out valor) != true)
            {
                MessageBox.Show("O campo preço não é numerico ou esta incorreto.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (int.TryParse(TxtQtd.Text, out codigo) != true)
            {
                MessageBox.Show("O campo Quantidade não é numerico.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (DTValidade.Value.Date <= DataAtual.Date)
            {
                MessageBox.Show("O campo validade não pode ser aceito por ser anterior ou iqual ao dia de hoje.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (DTFabricacao.Value.Date > DataAtual.Date)
            {
                MessageBox.Show("O campo data de fabricação não pode ser aceito por ser posterior ao dia de hoje.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return false;
        }

        private void LimpaControles()
        {
            TxtID.Text = "";
            TxtLote.Text = "";
            TxtPreco.Text = "";
            TxtQtd.Text = "";
        }

        private void FrmEstoque_Load(object sender, EventArgs e)
        {
            CarregarCB();
            CarregaGrid();


            if (Login.PADM2 == false)
            {
                if (Login.CadPro2 == false)
                {
                    BtnCadastrar.Enabled = false;
                }
            }
            
        }

        private void CarregarCB()
        {
            CBProduto.DataSource = Produto.ListarTodos();
            CBProduto.ValueMember = "Id";
            CBProduto.DisplayMember = "Nome";

        }
        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GrdItens_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GrdItens.Rows[e.RowIndex].DataBoundItem != null)
            {
                EstoqueC ObjSelecionado = (EstoqueC)GrdItens.Rows[e.RowIndex].DataBoundItem;

                if (GrdItens.Columns[e.ColumnIndex].Name == "AlterarEstoque")
                {
                    TxtID.Text = ObjSelecionado.Id.ToString();
                    TxtPreco.Text = ObjSelecionado.Preco.ToString();
                    TxtLote.Text = ObjSelecionado.Lote.ToString();
                    TxtQtd.Text = ObjSelecionado.QTD.ToString();
                    DTFabricacao.Value = ObjSelecionado.Data2.ToLocalTime();
                    DTValidade.Value = ObjSelecionado.Data3.ToLocalTime();
                    TxtID.Enabled = false;
                    TxtID.Focus();
                    incluir = false;
                }
                else if (GrdItens.Columns[e.ColumnIndex].Name == "ExcluirEstoque")
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
                            TxtID.Focus();
                        }
                    }
                }
            }
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                Data4 = DTPesquisa.Value;

                var oEstoque = EstoqueC.Seleciona(PesquisaTipo, TxtPesquisa.Text); // Chamando o método estático
                GrdItens.DataSource = null; // Limpa qualquer fonte anterior
                GrdItens.DataSource = oEstoque; // Vincula a lista ao DataGridView

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar produtos: {ex.Message}");
            }
        }

        private void CBPesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBPesquisa.SelectedIndex == 0)
            {
                PesquisaTipo = "E.ID";
                TxtPesquisa.Enabled = true;
                DTPesquisa.Enabled = false;
            }
            else if (CBPesquisa.SelectedIndex == 1)
            {
                PesquisaTipo = "P.Nome";
                TxtPesquisa.Enabled = true;
                DTPesquisa.Enabled = false;
            }
            else if (CBPesquisa.SelectedIndex == 2)
            {
                PesquisaTipo = "Preco";
                TxtPesquisa.Enabled = true;
                DTPesquisa.Enabled = false;
            }
            else if (CBPesquisa.SelectedIndex == 3)
            {
                PesquisaTipo = "QuantidadeAdicionada";
                TxtPesquisa.Enabled = true;
                DTPesquisa.Enabled = false;
            }
            else if (CBPesquisa.SelectedIndex == 4)
            {
                PesquisaTipo = "Lote";
                TxtPesquisa.Enabled = true;
                DTPesquisa.Enabled = false;
            }
            else if (CBPesquisa.SelectedIndex == 5)
            {
                PesquisaTipo = "DataAdicao";
                TxtPesquisa.Enabled = false;
                DTPesquisa.Enabled = true;
            }
            else if (CBPesquisa.SelectedIndex == 6)
            {
                PesquisaTipo = "Validade";
                TxtPesquisa.Enabled = false;
                DTPesquisa.Enabled = true;
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            CarregaGrid();
            TxtPesquisa.Text = "";
        }

        private void BtnRegistros_Click(object sender, EventArgs e)
        {
            FrmEstoqueConsulta oFrm = new FrmEstoqueConsulta();
            oFrm.StartPosition = FormStartPosition.CenterParent;
            oFrm.ShowDialog(this);
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            FrmCadProdutos oFrm = new FrmCadProdutos();
            oFrm.StartPosition = FormStartPosition.CenterParent;
            oFrm.ShowDialog(this);

        }

        private void CBProduto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnPedidos_Click(object sender, EventArgs e)
        {
            FrmConsultarPedido oFrm = new FrmConsultarPedido();
            oFrm.StartPosition = FormStartPosition.CenterParent;
            oFrm.ShowDialog(this);
        }
    }
}
