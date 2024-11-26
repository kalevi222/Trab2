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
    public partial class FrmFornecedor : Form
    {
        private bool incluir = true;
        public FrmFornecedor()
        {
            InitializeComponent();
        }

        private void BtnFehcar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CarregaGrid()
        {

            GrdItens.AutoGenerateColumns = false;
            GrdItens.DataSource = Fornecedor.ListarTodos();

        }

        private void FrmFornecedor_Load(object sender, EventArgs e)
        {
            CarregaGrid();
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
            TxtCNPJ.Text = "";
            TxtContato.Text = "";
            TxtEndereco.Text = "";
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaControles())
            {
                if (incluir)
                {

                    Fornecedor oFornecedor = new Fornecedor
                    {
                        Nome = TxtNome.Text,
                        Contato = TxtContato.Text,
                        Endereco = TxtEndereco.Text,
                        CNPJ = TxtCNPJ.Text,

                    };

                    try
                    {
                        oFornecedor.Incluir();
                        CarregaGrid();
                        LimpaControles();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Um erro ocorreu ao incluir o Fornecedor: {ex.Message}.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxtNome.Focus();
                    }
                }
                else
                {
                    try
                    {
                        Fornecedor oFornecedor = new Fornecedor
                        {
                            Id = int.Parse(TxtID.Text),
                            Nome = TxtNome.Text,
                            Contato = TxtContato.Text,
                            Endereco = TxtEndereco.Text,
                            CNPJ = TxtCNPJ.Text,

                        };
                        Fornecedor.AlterarFornecedor(oFornecedor);
                        incluir = true;
                        LimpaControles();
                        CarregaGrid();
                        TxtID.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Um erro ocorreu ao alterar o Fornecedor: {ex.Message}.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxtID.Focus();
                    }

                }
            }
        }

        private void GrdItens_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GrdItens.Rows[e.RowIndex].DataBoundItem != null)
            {
                Fornecedor ObjSelecionado = (Fornecedor)GrdItens.Rows[e.RowIndex].DataBoundItem;

                if (GrdItens.Columns[e.ColumnIndex].Name == "AlterarFornecedor")
                {
                    TxtID.Text = ObjSelecionado.Id.ToString();
                    TxtNome.Text = ObjSelecionado.Nome;
                    TxtContato.Text = ObjSelecionado.Contato;
                    TxtEndereco.Text = ObjSelecionado.Endereco;
                    TxtCNPJ.Text = ObjSelecionado.CNPJ;
                    TxtID.Enabled = false;
                    TxtNome.Focus();
                    incluir = false;
                }
                else if (GrdItens.Columns[e.ColumnIndex].Name == "ExcluirFornecedor")
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
                            MessageBox.Show($"Um erro ocorreu ao e excluir o Fornecedor: {ex.Message}.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            TxtID.Focus();
                        }
                    }
                }
            }
        }
    }
}
