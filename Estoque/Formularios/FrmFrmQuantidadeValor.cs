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
    public partial class FrmFrmQuantidadeValor : Form
    {
        public int Quantidade { get; private set; }
        public double Valor { get; private set; }

        public FrmFrmQuantidadeValor(string produtoNome)
        {
            InitializeComponent();
            lblProduto.Text = produtoNome; // Exibe o nome do produto
        }

        private bool validacontroles()
        {
            double Codigo;
            if (double.TryParse(nudValor.Text, out Codigo) == false)
            {
                return false;
            }

            return true;
        }
        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (validacontroles())
            {
                Quantidade = (int)nudQuantidade.Value;
                Valor = double.Parse(nudValor.Text);

                if (Quantidade <= 0 || Valor <= 0)
                {
                    MessageBox.Show("Quantidade e valor devem ser maiores que zero.");
                    return;
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Quantidade ou valor invalidos.");
                return;
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void nudValor_ValueChanged(object sender, EventArgs e)
        {
            double Codigo;

            if (double.TryParse(nudValor.Text, out Codigo) == true)
            {
                int valor1 = (int)nudQuantidade.Value;
                double valor2 = Double.Parse(nudValor.Text);

                TxtTotal.Text = (valor1 * valor2).ToString();
            }
            
        }
    }
}
