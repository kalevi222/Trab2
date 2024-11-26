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
    public partial class FrmGuiaVendas : Form
    {
        public FrmGuiaVendas()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
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
                TxtBarra.Text,
                TxtQuantidade.Text,
                TxtValorUnitario.Text,
                valorTotal.ToString("F2")
            );

            // Limpa os campos após adicionar
            TxtId.Clear();
            CBProduto.SelectedIndex = -1;
            TxtLote.Clear();
            TxtBarra.Clear();
            TxtQuantidade.Clear();
            TxtValorUnitario.Clear();
            TxtValorTotal.Clear();
        }

        private void CarregarCB()
        {
            CBProduto.DataSource = Produto.ListarTodos();
            CBProduto.ValueMember = "Id";
            CBProduto.DisplayMember = "Nome";

        }
        private void FrmGuiaVendas_Load(object sender, EventArgs e)
        {
            CarregarCB();

            Venda.PegarID();

            TxtId.Text = Venda.Id2.ToString();
        }

        //private void CBProduto_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (CBProduto.SelectedValue != null)
        //    {
        //        // Obtem o ID do Produto da ComboBox
        //        string idProduto = CBProduto.SelectedValue.ToString();

        //        // Abre o novo formulário e passa o ID do Produto
        //        FrmSelecionaProduto formSelecao = new FrmSelecionaProduto(idProduto);
        //        if (formSelecao.ShowDialog() == DialogResult.OK)
        //        {
        //            // Recebe os valores do formulário filho
        //            TxtLote.Text = formSelecao.Lote;
        //            TxtEstoque.Text = formSelecao.EmEstoque.ToString();
        //            TxtBarra.Text = formSelecao.CodigoBarras;
        //            TxtValorUnitario.Text = formSelecao.ValorUnitario.ToString("F2");
        //        }
        //    }
        //}

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
                }
            }
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
