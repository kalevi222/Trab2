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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Estoque.Formularios
{
    public partial class FrmEstoqueConsulta : Form
    {
        public string PesquisaTipo;
        public FrmEstoqueConsulta()
        {
            InitializeComponent();
        }

        private void FrmEstoqueConsulta_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }
        private void CarregaGrid()
        {

            GrdItens.AutoGenerateColumns = false;
            GrdItens.DataSource = EstoqueC.ListarTodos();

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
                PesquisaTipo = "P.ID";
                TxtPesquisa.Enabled = true;
                DTPesquisa.Enabled = false;
            }
            else if (CBPesquisa.SelectedIndex == 3)
            {
                PesquisaTipo = "M.Nome";
                TxtPesquisa.Enabled = true;
                DTPesquisa.Enabled = false;
            }
            else if (CBPesquisa.SelectedIndex == 4)
            {
                PesquisaTipo = "C.Nome";
                TxtPesquisa.Enabled = true;
                DTPesquisa.Enabled = false;
            }
            else if (CBPesquisa.SelectedIndex == 5)
            {
                PesquisaTipo = "Preco";
                TxtPesquisa.Enabled = true;
                DTPesquisa.Enabled = false;
            }
            else if (CBPesquisa.SelectedIndex == 6)
            {
                PesquisaTipo = "CodigoBarra";
                TxtPesquisa.Enabled = true;
                DTPesquisa.Enabled = false;
            }
            else if (CBPesquisa.SelectedIndex == 7)
            {
                PesquisaTipo = "Lote";
                TxtPesquisa.Enabled = true;
                DTPesquisa.Enabled = false;
            }
            else if (CBPesquisa.SelectedIndex == 8)
            {
                PesquisaTipo = "DataAdicao";
                TxtPesquisa.Enabled = false;
                DTPesquisa.Enabled = true;
            }
            else if (CBPesquisa.SelectedIndex == 9)
            {
                PesquisaTipo = "Validade";
                TxtPesquisa.Enabled = false;
                DTPesquisa.Enabled = true;
            }
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            FrmAdEstoque.Data4 = DTPesquisa.Value;

            var oEstoque = EstoqueC.Seleciona(PesquisaTipo, TxtPesquisa.Text); // Chamando o método estático
            GrdItens.DataSource = null; // Limpa qualquer fonte anterior
            GrdItens.DataSource = oEstoque; // Vincula a lista ao DataGridView
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
