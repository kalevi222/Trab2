using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.Classes
{
    internal class Produto
    {
        private string _Nome;
        private int _Id;
        private Int64 _Barra;
        private int _CatId;
        private int _MarcaId;
        private string _MarcaId2;
        private string _CatId2;
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        public int CatId
        {
            get { return _CatId; }
            set { _CatId = value; }
        }
        public int MarcaId
        {
            get { return _MarcaId; }
            set { _MarcaId = value; }
        }
        public Int64 Barra
        {
            get { return _Barra; }
            set { _Barra = value; }
        }

        public string Nome { get => _Nome; set => _Nome = value.Replace("'", ""); }
        public string MarcaId2 { get => _MarcaId2; set => _MarcaId2 = value.Replace("'", ""); }

        public string CatId2 { get => _CatId2; set => _CatId2 = value.Replace("'", ""); }

        public static List<Produto> ListarTodos()
        {
            using (var oCn = Data.Conexao())
            {
                List<Produto> Retorno = new List<Produto>();
                string SQL = "select P.id, P.Nome, M.Nome as Marca_id, C.Nome as Categoria_id, P.CodigoBarra from Produto as P join Marca as M on M.id = P.Marca_id join Categoria as C on C.id = P.Categoria_id";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                SqlDataReader oDr = comando.ExecuteReader();
                while (oDr.Read())
                {
                    Produto oProduto = new Produto();
                    oProduto.Id = oDr.GetInt32(oDr.GetOrdinal("id"));
                    oProduto.Nome = oDr.GetString(oDr.GetOrdinal("Nome"));
                    //oProduto.CatId = oDr.GetInt32(oDr.GetOrdinal("Categoria_id"));
                    //oProduto.MarcaId = oDr.GetInt32(oDr.GetOrdinal("Marca_id"));
                    oProduto.MarcaId2 = oDr.GetString(oDr.GetOrdinal("Marca_id"));
                    oProduto.CatId2 = oDr.GetString(oDr.GetOrdinal("Categoria_id"));
                    oProduto.Barra = oDr.GetInt64(oDr.GetOrdinal("CodigoBarra"));

                    Retorno.Add(oProduto);
                }
                oDr.Close();
                return Retorno;
            }
        }

        public static List<Produto> Seleciona(string tipoPesquisa, string codigo)
        {
            using (var oCn = Data.Conexao())
            {
                var retorno = new List<Produto>();
                string sql = $"select P.id, P.Nome, M.Nome as Marca_id, C.Nome as Categoria_id, P.CodigoBarra from Produto as P join Marca as M on M.id = P.Marca_id join Categoria as C on C.id = P.Categoria_id where {tipoPesquisa} = @Codigo";

                using (var comando = new SqlCommand(sql, oCn))
                {
                    comando.Parameters.AddWithValue("@Codigo", codigo);
                    using (var oDr = comando.ExecuteReader())
                    {
                        while (oDr.Read())
                        {
                            var produto = new Produto
                            {
                                Id = oDr.GetInt32(oDr.GetOrdinal("id")),
                                Nome = oDr.GetString(oDr.GetOrdinal("Nome")),
                                CatId2 = oDr.GetString(oDr.GetOrdinal("Categoria_id")),
                                MarcaId2 = oDr.GetString(oDr.GetOrdinal("Marca_id")),
                                Barra = oDr.GetInt64(oDr.GetOrdinal("CodigoBarra"))
                            };
                            retorno.Add(produto);
                        }
                    }
                }
                return retorno;
            }
        }
        public void Incluir()
        {

            using (var oCn = Data.Conexao())
            {
                string SQL = $"insert into Produto (Nome, Categoria_id, Marca_id, CodigoBarra) values ('{this.Nome.Replace("'", "")}', {this.CatId2}, {this.MarcaId2}, {this.Barra})";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                //@Valor, 
                //comando.Parameters.AddWithValue("@Valor", Preco);
                comando.ExecuteNonQuery();
            }

        }

        public static void AlterarProduto(Produto oProduto)
        {

            using (var oCn = Data.Conexao())
            {
                string SQL = $"Update Produto Set Nome= '{oProduto.Nome.Replace("'", "")}', Categoria_id = {oProduto.CatId2}, Marca_id = {oProduto.MarcaId2}, CodigoBarra= {oProduto.Barra} where id = {oProduto.Id}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
        }

        public void Excluir()
        {
            using (var oCn = Data.Conexao())
            {
                string SQL = $"Delete from Produto Where ID= {this.Id}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
        }
    }
}

