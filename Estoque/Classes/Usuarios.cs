using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.Classes
{
    internal class Usuarios
    {
        private string _Nome;
        private string _Senha;
        private int _Id;
        private Boolean _ADM;
        private Boolean _CadPro;
        private Boolean _CadCat;
        private Boolean _PAddPro;
        private Boolean _CadMarca;
        private Boolean _CadFor;
        private Boolean _CadUsuario;
        private Boolean _Venda;
        private Boolean _Pedido;
        public int CadPro2;
        public int CadCat2;
        public int PAddPro2;
        public int CadUsuario2;
        public int CadMarca2;
        public int CadFor2;
        public int PADM2;
        public int PVenda2;
        public int PPedido2;

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        public Boolean PADM
        {
            get { return _ADM; }
            set { _ADM = value; }
        }
        public Boolean CadPro
        {
            get { return _CadPro; }
            set { _CadPro = value; }
        }

        public Boolean CadCat
        {
            get { return _CadCat; }
            set { _CadCat = value; }
        }
        public Boolean CadUsuario
        {
            get { return _CadUsuario; }
            set { _CadUsuario = value; }
        }
        public Boolean CadFor
        {
            get { return _CadFor; }
            set { _CadFor = value; }
        }
        public Boolean CadMarca
        {
            get { return _CadMarca; }
            set { _CadMarca = value; }
        }
        public Boolean PAddPro
         {
            get { return _PAddPro; }
            set { _PAddPro = value; }
        }
        public Boolean PVenda
        {
            get { return _Venda; }
            set { _Venda = value; }
        }
        public Boolean PPedido
        {
            get { return _Pedido; }
            set { _Pedido = value; }
        }

        public string Nome { get => _Nome; set => _Nome = value.Replace("'", ""); }

        public string Senha { get => _Senha; set => _Senha = value.Replace("'", ""); }

        public static List<Usuarios> ListarTodosUsuarios()
        {
            using (var oCn = Data.Conexao())
            {
                List<Usuarios> Retorno = new List<Usuarios>();
                string SQL = "select id, Nome, Senha, PermissaoProduto, PermissaoCategoria, PermissaoAdiRemProduto, PermissaoADM, PermissaoFornecedor, PermissaoMarca, PermissaoGerirVenda, PermissaoGerirPedido from Usuario";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                SqlDataReader oDr = comando.ExecuteReader();
                while (oDr.Read())
                {
                    Usuarios oUsuario = new Usuarios();
                    oUsuario.Id = oDr.GetInt32(oDr.GetOrdinal("id"));
                    oUsuario.Nome = oDr.GetString(oDr.GetOrdinal("Nome"));
                    oUsuario.Senha = oDr.GetString(oDr.GetOrdinal("Senha"));
                    oUsuario.PADM = oDr.GetBoolean(oDr.GetOrdinal("PermissaoADM"));
                    oUsuario.CadPro = oDr.GetBoolean(oDr.GetOrdinal("PermissaoProduto"));
                    oUsuario.CadCat = oDr.GetBoolean(oDr.GetOrdinal("PermissaoCategoria"));
                    oUsuario.CadFor = oDr.GetBoolean(oDr.GetOrdinal("PermissaoFornecedor"));
                    oUsuario.CadMarca = oDr.GetBoolean(oDr.GetOrdinal("PermissaoMarca"));
                    oUsuario.PAddPro = oDr.GetBoolean(oDr.GetOrdinal("PermissaoAdiRemProduto"));
                    oUsuario.PVenda = oDr.GetBoolean(oDr.GetOrdinal("PermissaoGerirVenda"));
                    oUsuario.PPedido = oDr.GetBoolean(oDr.GetOrdinal("PermissaoGerirPedido"));

                    Retorno.Add(oUsuario);
                }
                oDr.Close();
                return Retorno;
            }
        }

        public void Incluir()
        {
            using (var oCn = Data.Conexao())
            {
                string SQL = $"INSERT INTO Usuario (Nome, Senha, PermissaoProduto, PermissaoCategoria, PermissaoAdiRemProduto, PermissaoADM, PermissaoFornecedor, PermissaoMarca, PermissaoGerirVenda, PermissaoGerirPedido, PermissaoCadastroUsuario) values ('{this.Nome.Replace("'", "")}','{this.Senha.Replace("'", "")}', {this.CadPro2}, {this.CadCat2}, {this.PAddPro2}, {this.PADM2}, {this.CadFor2}, {this.CadMarca2}, {this.PVenda2}, {this.PPedido2}, 0)";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }

        }

        public static void AlterarUsuario(Usuarios oUsuario)
        {
            using (var oCn = Data.Conexao())
            {
                string SQL = $"Update Usuario Set Nome= '{oUsuario.Nome.Replace("'", "")}', Senha='{oUsuario.Senha}', PermissaoProduto ={oUsuario.CadPro2}, PermissaoCategoria = {oUsuario.CadCat2}, PermissaoAdiRemProduto= {oUsuario.PAddPro2}, PermissaoADM= {oUsuario.PADM2}, PermissaoMarca= {oUsuario.CadMarca2}, PermissaoFornecedor= {oUsuario.CadFor2}, PermissaoGerirVenda = {oUsuario.PVenda2}, PermissaoGerirPedido = {oUsuario.PPedido2} where id = {oUsuario.Id}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
        }

        public void Excluir()
        {
            using (var oCn = Data.Conexao())
            {
                string SQL = $"Delete from Usuario Where id= {this.Id}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
        }
        public static Boolean NomeJaExiste(string nome)
        {
            using (var oCn = Data.Conexao())
            {
                string SQL = "SELECT COUNT(*) FROM Usuario WHERE Nome = @Nome";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.Parameters.AddWithValue("@Nome", nome);

                int count = (int)comando.ExecuteScalar();
                return count > 0;
            }
        }
    }
}
