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
    public partial class FrmSelecionaProduto : Form
    {
        public string Lote { get; private set; }
        public int EmEstoque { get; private set; }
        public string CodigoBarras { get; private set; }
        public double ValorUnitario { get; private set; }

        private string IdProduto;
        public FrmSelecionaProduto(string idProduto)
        {
            InitializeComponent();
            this.IdProduto = idProduto;
        }

        private void FrmSelecionaProduto_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void CarregaGrid()
        {
            int IdProduto2 = int.Parse(IdProduto);
            GrdItens.AutoGenerateColumns = false;
            GrdItens.DataSource = Venda.SelecionaProduto(IdProduto2);
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GrdItens_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && GrdItens.Columns[e.ColumnIndex].Name == "BtnSelecionar")
            {
                // Obtem os dados da linha selecionada
                Lote = GrdItens.Rows[e.RowIndex].Cells["LoteProduto"].Value.ToString();
                EmEstoque = Convert.ToInt32(GrdItens.Rows[e.RowIndex].Cells["QuantidadeProduto"].Value);
                CodigoBarras =GrdItens.Rows[e.RowIndex].Cells["CodigoBarrasProduto"].Value.ToString();
                ValorUnitario = Convert.ToDouble(GrdItens.Rows[e.RowIndex].Cells["ValorUnitarioProduto"].Value);

                // Fecha o formulário e retorna OK
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
