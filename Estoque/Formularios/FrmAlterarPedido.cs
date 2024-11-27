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
using static Azure.Core.HttpHeader;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Estoque.Formularios
{
    public partial class FrmAlterarPedido : Form
    {
        private bool incluir = true;
        public FrmAlterarPedido()
        {
            InitializeComponent();
        }

        private void FrmAlterarPedido_Load(object sender, EventArgs e)
        {
            CarregaGrid();
            CarregarCB();
            CarregaTxtBox();
        }

        private void CarregaTxtBox()
        {
            TxtId.Text = Pedido.Id3.ToString();
            TxtData.Text = Pedido.Date3.ToString();
            TxtNome.Text = Pedido.Nome2;
            TxtNPedido.Text = Pedido.NumPedido.ToString();
            TxtStatus.Text = Pedido.Status2;
        }

        private void CarregaGrid()
        {

            GrdItens.AutoGenerateColumns = false;
            GrdItens.DataSource = Pedido.ListarTodos2();

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

        private void LimpaControles()
        {
            TxtPreco.Text = "";
            numQtd.Value = 0;
        }

        private bool ValidaControles()
        {

            double valor2;


            if (double.TryParse(TxtPreco.Text, out valor2) != true)
            {
                MessageBox.Show("O campo preço não é numerico ou esta incorreto.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaControles())
            {
                if (incluir)
                {

                    Pedido oPedido = new Pedido
                    {

                        Id = int.Parse(TxtId.Text),
                        Produto = CBProduto.SelectedValue.ToString(),
                        Valor = Double.Parse(TxtPreco.Text, System.Globalization.CultureInfo.InvariantCulture),
                        QTD = (int)numQtd.Value,
                    };

                    try
                    {
                        oPedido.Incluir3();
                        CarregaGrid();
                        LimpaControles();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Um erro ocorreu ao incluir o Produto: {ex.Message}.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxtId.Focus();
                    }
                }
                else
                {
                    try
                    {
                        Pedido oPedido = new Pedido
                        {
                            Id = int.Parse(TxtId.Text),
                            Produto = CBProduto.SelectedValue.ToString(),
                            Valor = Double.Parse(TxtPreco.Text, System.Globalization.CultureInfo.InvariantCulture),
                            QTD = (int)numQtd.Value,

                        };
                        Pedido.AlterarPedido2(oPedido);
                        incluir = true;
                        LimpaControles();
                        CarregaGrid();
                        TxtId.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Um erro ocorreu ao alterar o Pedido: {ex.Message}.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxtId.Focus();
                    }

                }
            }
        }

        private void GrdItens_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GrdItens.Rows[e.RowIndex].DataBoundItem != null)
            {
                Pedido ObjSelecionado = (Pedido)GrdItens.Rows[e.RowIndex].DataBoundItem;

                //if (GrdItens.Columns[e.ColumnIndex].Name == "AlterarProduto")
                //{
                //    //TxtID.Text = ObjSelecionado.Id.ToString();
                //    //ObjSelecionado.IdProduto.
                //    incluir = false;
                //}
                if (GrdItens.Columns[e.ColumnIndex].Name == "ExcluirProduto")
                {
                    if (MessageBox.Show("Confirme a exclusao.", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            ObjSelecionado.Excluir2();
                            CarregaGrid();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Um erro ocorreu ao e excluir o Produto: {ex.Message}.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
    }
}
