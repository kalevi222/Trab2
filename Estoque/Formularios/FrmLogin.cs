﻿using Estoque.Classes;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estoque
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void LimpaControles()
        {
            txtSenha.Text = "";
            txtUsuario.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login.loginUsuario = txtUsuario.Text;
            Login.Logar();
        
                if (txtUsuario.Text == Login.Nome2 && txtSenha.Text == Login.Senha2)
                {

                    LblAviso.Text = "";
                    this.Close();
                }
                else
                {
                    LblAviso.Text = "Senha ou Usuario Incorreto";
                };
            
        }
        private void FrmLogin_KeyPress(object sender, KeyPressEventArgs e)
        {


        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}