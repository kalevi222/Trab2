using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.Classes
{
    internal class Login
    {
        public static string? loginUsuario;

        private string Nome;
        private string Senha;

        public static string Nome2;
        public static string Senha2;
        public Boolean PADM;
        public Boolean CadPro;
        public Boolean CadCat;
        public Boolean CadFor;
        public Boolean CadMarca;
        public Boolean PPro;
        public Boolean PVenda;
        public Boolean PPedido;

        public static Boolean PADM2;
        public static Boolean CadPro2;
        public static Boolean CadCat2;
        public static Boolean CadFor2;
        public static Boolean CadMarca2;
        public static Boolean PPro2;
        public static Boolean PVenda2;
        public static Boolean PPedido2;

        public static Login? Logar()
        {
            using (var oCn = Data.Conexao())
            {
                Login? Retorno = null;
                string SQL = $"select Nome, Senha, PermissaoProduto, PermissaoCategoria, PermissaoAdiRemProduto, PermissaoADM, PermissaoFornecedor, PermissaoMarca, PermissaoGerirVenda, PermissaoGerirPedido from Usuario Where Nome='{loginUsuario}'";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                SqlDataReader oDr = comando.ExecuteReader();
                while (oDr.Read())
                {
                    Retorno = new Login();
                    Retorno.Nome = oDr.GetString(oDr.GetOrdinal("Nome"));
                    Retorno.Senha = oDr.GetString(oDr.GetOrdinal("Senha"));
                    Retorno.PADM = oDr.GetBoolean(oDr.GetOrdinal("PermissaoADM"));
                    Retorno.CadPro = oDr.GetBoolean(oDr.GetOrdinal("PermissaoProduto"));
                    Retorno.CadCat = oDr.GetBoolean(oDr.GetOrdinal("PermissaoCategoria"));
                    Retorno.CadFor = oDr.GetBoolean(oDr.GetOrdinal("PermissaoFornecedor"));
                    Retorno.CadMarca = oDr.GetBoolean(oDr.GetOrdinal("PermissaoMarca"));
                    Retorno.PPro = oDr.GetBoolean(oDr.GetOrdinal("PermissaoAdiRemProduto"));
                    Retorno.PVenda = oDr.GetBoolean(oDr.GetOrdinal("PermissaoGerirVenda"));
                    Retorno.PPedido = oDr.GetBoolean(oDr.GetOrdinal("PermissaoGerirPedido"));
                    Nome2 = Retorno.Nome;
                    Senha2 = Retorno.Senha;
                    PPedido2 = Retorno.PPedido;
                    PVenda2 = Retorno.PVenda;
                    PPro2 = Retorno.PPro;
                    PADM2 = Retorno.PADM;
                    CadCat2 = Retorno.CadCat;
                    CadFor2 = Retorno.CadFor;
                    CadMarca2 = Retorno.CadMarca;
                    CadPro2 = Retorno.CadPro;
                }
                oDr.Close();
                return Retorno;
            }
        }
    }
}
