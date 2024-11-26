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
    public partial class FrmMarca : Form
    {
        private bool incluir = true;
        public FrmMarca()
        {
            InitializeComponent();
        }

        private void CarregaGrid()
        {

            GrdItens.AutoGenerateColumns = false;
            GrdItens.DataSource = Marca.ListarTodos();

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

                    Marca oMarca = new Marca
                    {
                        Nome = TxtNome.Text,

                    };

                    try
                    {
                        oMarca.Incluir();
                        CarregaGrid();
                        LimpaControles();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Um erro ocorreu ao incluir a Marca: {ex.Message}.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxtID.Focus();
                    }
                }
                else
                {
                    try
                    {
                        Marca oMarca = new Marca
                        {
                            Id = int.Parse(TxtID.Text),
                            Nome = TxtNome.Text,

                        };
                        Marca.AlterarMarca(oMarca);
                        incluir = true;
                        LimpaControles();
                        CarregaGrid();
                        TxtID.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Um erro ocorreu ao alterar a Marca: {ex.Message}.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxtID.Focus();
                    }

                }
            }
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmMarca_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void GrdItens_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GrdItens.Rows[e.RowIndex].DataBoundItem != null)
            {
                Marca ObjSelecionado = (Marca)GrdItens.Rows[e.RowIndex].DataBoundItem;

                if (GrdItens.Columns[e.ColumnIndex].Name == "AlterarMarca")
                {
                    TxtID.Text = ObjSelecionado.Id.ToString();
                    TxtNome.Text = ObjSelecionado.Nome;
                    TxtID.Enabled = false;
                    TxtNome.Focus();
                    incluir = false;
                }
                else if (GrdItens.Columns[e.ColumnIndex].Name == "ExcluirMarca")
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
                            MessageBox.Show($"Um erro ocorreu ao e excluir a Marca: {ex.Message}.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            TxtID.Focus();
                        }
                    }
                }

            }
        }

        private void GrdItens_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
