using Estoque.Classes;
using Microsoft.Data.SqlClient;
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
    public partial class FrmAddPedido : Form
    {
        private int QTD;
        private string valor;
        private bool incluir = true;
        private string StatusPedido;

        public static int CodigoPedido;
        public FrmAddPedido()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CarregarCB()
        {
            CBFornecedor.DataSource = Fornecedor.ListarTodos();
            CBFornecedor.ValueMember = "Id";
            CBFornecedor.DisplayMember = "Nome";

        }
        private void FrmAddPedido_Load(object sender, EventArgs e)
        {
            CarregarCB();
            CarregaGrid();
            CarregarProdutos();
        }

        private void CarregarProdutos()
        {
            List<Pedido> produtos = Pedido.ObterProdutos();

            // Adicionando os produtos ao CheckedListBox
            CListProdutos.Items.Clear(); // Limpa os itens anteriores
            foreach (var produto in produtos)
            {
                CListProdutos.Items.Add(produto, false); // Adiciona o objeto com o estado "não marcado"
            }
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {

        }

        private void AdicionarProdutosSelecionados(int pedidoId)
        {

            using (var oCn = Data.Conexao())
            {

                foreach (var item in CListProdutos.CheckedItems)
                {
                    Pedido produtoSelecionado = (Pedido)item;

                    // Exibe o formulário para obter a quantidade e o valor
                    using (var form = new FrmFrmQuantidadeValor(produtoSelecionado.Nome))
                    {
                        var resultado = form.ShowDialog();

                        if (resultado == DialogResult.OK)
                        {
                            int quantidade = form.Quantidade;
                            double valor = form.Valor;

                            string sql = "INSERT INTO Pedido_has_Produto (Pedido_id, Produto_id, Quantidade, Valor) " +
                                         "VALUES (@PedidoId, @ProdutoId, @Quantidade, @Valor)";
                            using (SqlCommand comando = new SqlCommand(sql, oCn))
                            {
                                comando.Parameters.AddWithValue("@PedidoId", pedidoId);
                                comando.Parameters.AddWithValue("@ProdutoId", produtoSelecionado.Id);
                                comando.Parameters.AddWithValue("@Quantidade", quantidade);
                                comando.Parameters.AddWithValue("@Valor", valor);

                                comando.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            MessageBox.Show($"A operação para o produto '{produtoSelecionado.Nome}' foi cancelada.");
                        }
                    }
                }
            }
        }

        private void ObterItensSelecionados()
        {
            foreach (var item in CListProdutos.CheckedItems)
            {
                Pedido produtoSelecionado = (Pedido)item;
                MessageBox.Show($"Id: {produtoSelecionado.Id}, Nome: {produtoSelecionado.Nome}");
            }
        }

        private bool ValidaControles()
        {
            //int codigo;
            //double valor;
            //DateTime DataAtual = DateTime.Now;

            //if (int.TryParse(TxtLote.Text, out codigo) && double.TryParse(TxtPreco.Text, out valor) && int.TryParse(TxtQtd.Text, out codigo)
            //    && DTValidade.Value.Date > DataAtual.Date && DTFabricacao.Value.Date <= DataAtual.Date)
            //{
            //    return true;
            //}
            //else if (int.TryParse(TxtLote.Text, out codigo) != true)
            //{
            //    MessageBox.Show("O campo lote não é numerico.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return false;
            //}
            //else if (double.TryParse(TxtPreco.Text, out valor) != true)
            //{
            //    MessageBox.Show("O campo preço não é numerico ou esta incorreto.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return false;
            //}
            //else if (int.TryParse(TxtQtd.Text, out codigo) != true)
            //{
            //    MessageBox.Show("O campo Quantidade não é numerico.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return false;
            //}
            //else if (DTValidade.Value.Date <= DataAtual.Date)
            //{
            //    MessageBox.Show("O campo validade não pode ser aceito por ser anterior ou iqual ao dia de hoje.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return false;
            //}
            //else if (DTFabricacao.Value.Date > DataAtual.Date)
            //{
            //    MessageBox.Show("O campo data de fabricação não pode ser aceito por ser posterior ao dia de hoje.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return false;
            //}
            return true;
        }

        private void LimpaControles()
        {
            TxtID.Text = "";
        }
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            int pedidoId = Pedido.Id2;

            if (ValidaControles())
            {
                if (incluir)
                {

                    Pedido oPedido = new Pedido
                    {
                        Data2 = DTPedido.Value,
                        NPedido = int.Parse(TxtNPedido.Text),
                        Nome = CBFornecedor.SelectedValue.ToString(),
                        Status = StatusPedido,
                    };

                    try
                    {
                        oPedido.Incluir();
                        oPedido.Incluir2();
                        CarregaGrid();
                        LimpaControles();
                        pedidoId = Pedido.Id2;
                        AdicionarProdutosSelecionados(pedidoId);
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
                        Pedido oPedido = new Pedido
                        {
                            Id = int.Parse(TxtID.Text),
                            Data2 = DTPedido.Value,
                            NPedido = int.Parse(TxtNPedido.Text),
                            Nome = CBFornecedor.SelectedValue.ToString(),
                            Status = StatusPedido,


                        };
                        Pedido.AlterarPedido(oPedido);
                        incluir = true;
                        LimpaControles();
                        CarregaGrid();
                        TxtID.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Um erro ocorreu ao alterar o Pedido: {ex.Message}.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxtID.Focus();
                    }

                }
            }

        }

        private void CarregaGrid()
        {

            GrdItens.AutoGenerateColumns = false;
            GrdItens.DataSource = Pedido.ListarTodos();

        }
        private void checkedListBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GrdItens_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GrdItens.Rows[e.RowIndex].DataBoundItem != null)
            {
                Pedido ObjSelecionado = (Pedido)GrdItens.Rows[e.RowIndex].DataBoundItem;

                if (GrdItens.Columns[e.ColumnIndex].Name == "AlterarPedido")
                {
                    TxtID.Text = ObjSelecionado.Id.ToString();
                    TxtNPedido.Text = ObjSelecionado.NPedido.ToString();
                    DTPedido.Value = ObjSelecionado.Data2.ToLocalTime();
                    TxtID.Enabled = false;
                    TxtID.Focus();
                    incluir = false;
                }
                else if (GrdItens.Columns[e.ColumnIndex].Name == "ExcluirPedido")
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
                else if (GrdItens.Columns[e.ColumnIndex].Name == "AlterarPedidoProduto")
                {
                   
                        TxtID.Text = ObjSelecionado.Id.ToString();
                        TxtNPedido.Text = ObjSelecionado.NPedido.ToString();
                        DTPedido.Value = ObjSelecionado.Data2.ToLocalTime();
                        TxtID.Enabled = false;
                        TxtID.Focus();
                        incluir = false;
                        CodigoPedido = int.Parse(TxtID.Text);
                        FrmAlterarPedido oFrm = new FrmAlterarPedido();
                        oFrm.Show();
          
                }
            }
        }

        private void CBStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBStatus.SelectedIndex == 0)
            {
                StatusPedido = "Incompleto";

            }
            else if (CBStatus.SelectedIndex == 1)
            {
                StatusPedido = "Aguardando";

            }
            else if (CBStatus.SelectedIndex == 2)
            {
                StatusPedido = "Completo";
            }
        }
    }
}
