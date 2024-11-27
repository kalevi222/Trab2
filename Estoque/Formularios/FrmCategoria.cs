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
    public partial class FrmCategoria : Form
    {
        public string PesquisaTipo;
        private bool incluir = true;
        public FrmCategoria()
        {
            InitializeComponent();
        }

        private void CarregaGrid()
        {

            GrdItens.AutoGenerateColumns = false;
            GrdItens.DataSource = Categoria.ListarTodos();

        }

        private bool ValidaControles()
        {
            int Codigo;

            if (TxtNome.Text.Trim() == "")
            {
                MessageBox.Show("O campo nome é obrigatorio.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtNome.Focus();
                return false;
            }
            return true;
        }

        private void LimpaControles()
        {
            TxtID.Text = "";
            TxtNome.Text = "";
        }
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaControles())
            {
                if (incluir)
                {

                    Categoria oCategoria = new Categoria
                    {
                        Nome = TxtNome.Text,

                    };

                    try
                    {
                        oCategoria.Incluir();
                        MessageBox.Show("Categoria incluída com sucesso!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CarregaGrid();
                        LimpaControles();
                    }
                    catch (Exception ex)
                    {
                        // Diferenciar mensagens para duplicidade e outros erros
                        if (ex.Message.Contains("Já existe uma categoria com este nome"))
                        {
                            MessageBox.Show(ex.Message, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            MessageBox.Show($"Um erro ocorreu ao incluir a Categoria: {ex.Message}.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        TxtNome.Focus();
                    }
                }
                else
                {
                    try
                    {
                        Categoria oCategoria = new Categoria
                        {
                            Id = int.Parse(TxtID.Text),
                            Nome = TxtNome.Text,

                        };
                        Categoria.AlterarCategoria(oCategoria);
                        incluir = true;
                        MessageBox.Show("Categoria alterada com sucesso!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpaControles();
                        CarregaGrid();
                        TxtID.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Um erro ocorreu ao alterar a Categoria: {ex.Message}.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxtID.Focus();
                    }

                }
            }

        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GrdItens_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GrdItens.Rows[e.RowIndex].DataBoundItem != null)
            {
                Categoria ObjSelecionado = (Categoria)GrdItens.Rows[e.RowIndex].DataBoundItem;

                if (GrdItens.Columns[e.ColumnIndex].Name == "AlterarCategoria")
                {
                    TxtID.Text = ObjSelecionado.Id.ToString();
                    TxtNome.Text = ObjSelecionado.Nome;
                    TxtID.Enabled = false;
                    TxtNome.Focus();
                    incluir = false;
                }
                else if (GrdItens.Columns[e.ColumnIndex].Name == "ExcluirCategoria")
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
                            MessageBox.Show($"Um erro ocorreu ao e excluir a Categoria: {ex.Message}.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            TxtID.Focus();
                        }
                    }
                }

            }
        }

        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void CBPesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                if (CBPesquisa.SelectedIndex == 0)
                {
                    PesquisaTipo = "C.Id";
                }
                else if (CBPesquisa.SelectedIndex == 1)
                {
                    PesquisaTipo = "C.Nome";
                }

            }
        }

        private void BtnPesquisar_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Obtém os dados de acordo com o tipo de pesquisa e o texto informado
                var categoria = Categoria.Seleciona(PesquisaTipo, TxtPesquisa.Text);
                GrdItens.DataSource = null; // Limpa qualquer fonte anterior
                GrdItens.DataSource = categoria; // Vincula a lista ao DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar marcas: {ex.Message}");
            }

        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            CarregaGrid();
        }
    }
}
