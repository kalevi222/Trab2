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
    public partial class FrmGuiaVendas : Form
    {
        public FrmGuiaVendas()
        {
            InitializeComponent();
            CBProduto.SelectedIndex = -1;
            CBProduto.SelectedValue = -1;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void AtualizarValorTotalVenda()
        {
            double valorTotalVenda = 0;

            foreach (DataGridViewRow row in GrdVendas.Rows)
            {
                // Ignora linhas inválidas ou em branco
                if (row.IsNewRow) continue;

                // Somar o valor da coluna "Valor Total"
                if (row.Cells["ValorTotalVenda"].Value != null)
                {
                    valorTotalVenda += Convert.ToDouble(row.Cells["ValorTotalVenda"].Value);
                }
            }

            // Atualiza o valor na TextBox
            TxtTotalVenda.Text = valorTotalVenda.ToString("F2");
        }
        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            int Verifica;

            Verifica = int.Parse(TxtEstoque.Text) - int.Parse(TxtQuantidade.Text);

            if (Verifica >= 0)
            {
                if (string.IsNullOrWhiteSpace(TxtId.Text) || string.IsNullOrWhiteSpace(CBProduto.Text) ||
      string.IsNullOrWhiteSpace(TxtQuantidade.Text) || string.IsNullOrWhiteSpace(TxtValorUnitario.Text))
                {
                    MessageBox.Show("Preencha todos os campos obrigatórios!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Calcula o valor total
                Double quantidade = double.Parse(TxtQuantidade.Text);
                Double valorUnitario = double.Parse(TxtValorUnitario.Text);
                Double valorTotal = quantidade * valorUnitario;
                string idProduto = CBProduto.SelectedValue.ToString();

                // Adiciona uma nova linha no DataGridView
                GrdVendas.Rows.Add(
                    TxtId.Text,
                    idProduto,
                    CBProduto.Text,
                    TxtLote.Text,
                    TxtBarra.Text,
                    TxtQuantidade.Text,
                    TxtEstoque.Text,
                    TxtValorUnitario.Text,
                    valorTotal.ToString("F2")
                );

                // Atualizar o valor total após adicionar o produto
                AtualizarValorTotalVenda();
                // Limpa os campos após adicionar
                CBProduto.SelectedIndex = -1;
                TxtLote.Clear();
                TxtBarra.Clear();
                TxtQuantidade.Clear();
                TxtValorUnitario.Clear();
                TxtValorTotal.Clear();
                TxtEstoque.Clear();
            }
            else
            {
                MessageBox.Show("Quantidade a vender é maior que tem em estoque!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }

        private void CarregarCB()
        {
            CBProduto.DataSource = Produto.ListarTodos();
            CBProduto.ValueMember = "Id";
            CBProduto.DisplayMember = "Nome";

            CBProduto.SelectedIndex = -1;
            CBProduto.SelectedValue = -1;

        }
        private void FrmGuiaVendas_Load(object sender, EventArgs e)
        {
            CarregarCB();

            Venda.PegarID();

            TxtId.Text = Venda.Id2.ToString();
        }

        private void CBProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBProduto.SelectedValue != null && CBProduto.SelectedIndex != -1)
            {
                // Obtem o ID do Produto da ComboBox
                string idProduto = CBProduto.SelectedValue.ToString();

                if (idProduto != "Estoque.Classes.Produto")
                {// Abre o novo formulário e passa o ID do Produto
                    FrmSelecionaProduto formSelecao = new FrmSelecionaProduto(idProduto);
                    if (formSelecao.ShowDialog() == DialogResult.OK)
                    {
                        // Recebe os valores do formulário filho
                        TxtLote.Text = formSelecao.Lote;
                        TxtEstoque.Text = formSelecao.EmEstoque.ToString();
                        TxtBarra.Text = formSelecao.CodigoBarras;
                        TxtValorUnitario.Text = formSelecao.ValorUnitario.ToString("F2");
                    }
                }
            }
        }

        private void GrdVendas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se a célula clicada pertence à coluna do botão "Remover"
            if (e.RowIndex >= 0 && GrdVendas.Columns[e.ColumnIndex].Name == "BtnRemover")
            {
                // Confirmação de exclusão
                var confirmResult = MessageBox.Show("Tem certeza que deseja remover esta linha?",
                                                    "Confirmar Remoção",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    // Remove a linha do DataGridView
                    GrdVendas.Rows.RemoveAt(e.RowIndex);
                    // Atualizar o valor total após remover o produto
                    AtualizarValorTotalVenda();
                }
            }
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtQuantidade_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(TxtQuantidade.Text, out var quantidade))
            {
                double Preco;
                double Total;
                Preco = Double.Parse(TxtValorUnitario.Text);
                Total = Preco * quantidade;
                TxtValorTotal.Text = Total.ToString();

            }
        }

        private void BtnVenda_Click(object sender, EventArgs e)
        {
            if (GrdVendas.Rows.Count == 0)
            {
                MessageBox.Show("Não há itens para confirmar a venda!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {

                // Comece uma transação
                using (var oCn = Data.Conexao())
                {
                    try
                    {
                        string query = @"
                            INSERT INTO Venda (ValorTotalVenda, DataVenda)
                            VALUES (@ValorTotalVenda, @DataVenda);";

                        using (SqlCommand command = new SqlCommand(query, oCn))
                        {
                            // Parâmetros para evitar SQL Injection
                            command.Parameters.AddWithValue("ValorTotalVenda", double.Parse(TxtTotalVenda.Text));
                            command.Parameters.AddWithValue("@DataVenda", DateTime.Now);


                            // Executa o comando
                            command.ExecuteNonQuery();
                        }
                        //command.Parameters.AddWithValue("@DataVenda", DateTime.Now); // Data da venda
                        foreach (DataGridViewRow row in GrdVendas.Rows)
                        {
                            // Ignorar linhas inválidas ou em branco
                            if (row.IsNewRow) continue;

                            // Extrair os valores do DataGridView
                            int idProduto = Convert.ToInt32(row.Cells["IDProduto"].Value);
                            int quantidade = Convert.ToInt32(row.Cells["QuantidadeVenda"].Value);
                            int quantidadeEstoque = Convert.ToInt32(row.Cells["QuantidadeEmEstoque"].Value);
                            int Lote = Convert.ToInt32(row.Cells["LoteVenda"].Value);
                            Double valorUnitario = Convert.ToDouble(row.Cells["ValorUnitarioVenda"].Value);
                            Double valorTotal = Convert.ToDouble(row.Cells["ValorTotalVenda"].Value);
                            int quantidadeReduzida = quantidadeEstoque - quantidade;

                            // Comando SQL de inserção
                            string query2 = @"
                            INSERT INTO Venda_has_Produto (Venda_id, Produto_id, Lote, Quantidade, ValorUnitario, ValorTotal)
                            VALUES (@IDVenda, @IDProduto, @Lote, @Quantidade, @ValorUnitario, @ValorTotal);";

                            using (SqlCommand command2 = new SqlCommand(query2, oCn))
                            {
                                // Parâmetros para evitar SQL Injection
                                command2.Parameters.AddWithValue("@IDVenda", int.Parse(TxtId.Text));
                                command2.Parameters.AddWithValue("@IDProduto", idProduto);
                                command2.Parameters.AddWithValue("@Lote", Lote);
                                command2.Parameters.AddWithValue("@Quantidade", quantidade);
                                command2.Parameters.AddWithValue("@ValorUnitario", valorUnitario);
                                command2.Parameters.AddWithValue("@ValorTotal", valorTotal);


                                // Executa o comando
                                command2.ExecuteNonQuery();
                            }

                            string query3 = @"
                             Update E Set E.QuantidadeAdicionada = @Quantidade From Produto_has_Estoque as PE join produto as P on PE.Produto_id = P.id join Estoque as E on PE.Estoque_id = E.id  where P.id = @Produtoid and E.lote = @Lote";

                            using (SqlCommand command3 = new SqlCommand(query3, oCn))
                            {
                                // Parâmetros para evitar SQL Injection
                                command3.Parameters.AddWithValue("@Quantidade", quantidadeReduzida);
                                command3.Parameters.AddWithValue("@Lote", Lote);
                                command3.Parameters.AddWithValue("@Produtoid", idProduto);


                                // Executa o comando
                                command3.ExecuteNonQuery();
                            }

                        }




                        GrdVendas.Rows.Clear();

                        Venda.PegarID();

                        TxtId.Text = Venda.Id2.ToString();

                        CBProduto.SelectedIndex = -1;
                        TxtLote.Clear();
                        TxtBarra.Clear();
                        TxtQuantidade.Clear();
                        TxtValorUnitario.Clear();
                        TxtValorTotal.Clear();
                        TxtEstoque.Clear();
                        TxtTotalVenda.Clear();

                    }
                    catch (Exception ex)
                    {
                        // Reverte a transação em caso de erro
                        //transaction.Rollback();
                        // MessageBox.Show($"Erro ao confirmar a venda: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao conectar ao banco de dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnRegistro_Click(object sender, EventArgs e)
        {
            FrmEstoqueConsulta oFrm = new FrmEstoqueConsulta();
            oFrm.StartPosition = FormStartPosition.CenterParent;
            oFrm.ShowDialog(this);
        }

        private void BtnRegistroVenda_Click(object sender, EventArgs e)
        {
            FrmRegistroVenda oFrm = new FrmRegistroVenda();
            oFrm.StartPosition = FormStartPosition.CenterParent;
            oFrm.ShowDialog(this);

        }
    }
}
