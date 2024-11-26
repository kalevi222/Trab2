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
        private long _Barra;
        private int _CatId;
        private int _MarcaId;
        private string _MarcaId2;
        private string _CatId2;

        public int Id { get => _Id; set => _Id = value; }
        public int CatId { get => _CatId; set => _CatId = value; }
        public int MarcaId { get => _MarcaId; set => _MarcaId = value; }
        public long Barra { get => _Barra; set => _Barra = value; }
        public string Nome { get => _Nome; set => _Nome = value.Replace("'", ""); }
        public string MarcaId2 { get => _MarcaId2; set => _MarcaId2 = value.Replace("'", ""); }
        public string CatId2 { get => _CatId2; set => _CatId2 = value.Replace("'", ""); }

        public static List<Produto> ListarTodos()
        {
            using (var oCn = Data.Conexao())
            {
                var retorno = new List<Produto>();
                string sql = "SELECT P.id, P.Nome, M.Nome AS Marca_id, C.Nome AS Categoria_id, P.CodigoBarra " +
                             "FROM Produto AS P " +
                             "JOIN Marca AS M ON M.id = P.Marca_id " +
                             "JOIN Categoria AS C ON C.id = P.Categoria_id";

                using (var comando = new SqlCommand(sql, oCn))
                {
                    using (var oDr = comando.ExecuteReader())
                    {
                        while (oDr.Read())
                        {
                            retorno.Add(new Produto
                            {
                                Id = oDr.GetInt32(oDr.GetOrdinal("id")),
                                Nome = oDr.GetString(oDr.GetOrdinal("Nome")),
                                MarcaId2 = oDr.GetString(oDr.GetOrdinal("Marca_id")),
                                CatId2 = oDr.GetString(oDr.GetOrdinal("Categoria_id")),
                                Barra = oDr.GetInt64(oDr.GetOrdinal("CodigoBarra"))
                            });
                        }
                    }
                }

                return retorno;
            }
        }

        public static List<Produto> Seleciona(string tipoPesquisa, string codigo)
        {
            using (var oCn = Data.Conexao())
            {
                var retorno = new List<Produto>();
                string sql = $"SELECT P.id, P.Nome, M.Nome AS Marca_id, C.Nome AS Categoria_id, P.CodigoBarra " +
                             $"FROM Produto AS P " +
                             $"JOIN Marca AS M ON M.id = P.Marca_id " +
                             $"JOIN Categoria AS C ON C.id = P.Categoria_id " +
                             $"WHERE {tipoPesquisa} = @Codigo";

                using (var comando = new SqlCommand(sql, oCn))
                {
                    comando.Parameters.AddWithValue("@Codigo", codigo);

                    using (var oDr = comando.ExecuteReader())
                    {
                        while (oDr.Read())
                        {
                            retorno.Add(new Produto
                            {
                                Id = oDr.GetInt32(oDr.GetOrdinal("id")),
                                Nome = oDr.GetString(oDr.GetOrdinal("Nome")),
                                CatId2 = oDr.GetString(oDr.GetOrdinal("Categoria_id")),
                                MarcaId2 = oDr.GetString(oDr.GetOrdinal("Marca_id")),
                                Barra = oDr.GetInt64(oDr.GetOrdinal("CodigoBarra"))
                            });
                        }
                    }
                }

                return retorno;
            }
        }

        public void Incluir()
        {
            if (ProdutoJaExiste(this.Nome, this.Barra))
            {
                throw new Exception("Produto com o mesmo nome ou código de barras já existe.");
            }

            using (var oCn = Data.Conexao())
            {
                string sql = "INSERT INTO Produto (Nome, Categoria_id, Marca_id, CodigoBarra) " +
                             "VALUES (@Nome, @CategoriaId, @MarcaId, @CodigoBarra)";

                using (var comando = new SqlCommand(sql, oCn))
                {
                    comando.Parameters.AddWithValue("@Nome", this.Nome);
                    comando.Parameters.AddWithValue("@CategoriaId", this.CatId2);
                    comando.Parameters.AddWithValue("@MarcaId", this.MarcaId2);
                    comando.Parameters.AddWithValue("@CodigoBarra", this.Barra);
                    comando.ExecuteNonQuery();
                }
            }
        }

        public static void AlterarProduto(Produto oProduto)
        {
            if (ProdutoJaExiste(oProduto.Nome, oProduto.Barra, oProduto.Id))
            {
                throw new Exception("Outro produto com o mesmo nome ou código de barras já existe.");
            }

            using (var oCn = Data.Conexao())
            {
                string sql = "UPDATE Produto SET Nome = @Nome, Categoria_id = @CategoriaId, Marca_id = @MarcaId, CodigoBarra = @CodigoBarra " +
                             "WHERE id = @Id";

                using (var comando = new SqlCommand(sql, oCn))
                {
                    comando.Parameters.AddWithValue("@Nome", oProduto.Nome);
                    comando.Parameters.AddWithValue("@CategoriaId", oProduto.CatId2);
                    comando.Parameters.AddWithValue("@MarcaId", oProduto.MarcaId2);
                    comando.Parameters.AddWithValue("@CodigoBarra", oProduto.Barra);
                    comando.Parameters.AddWithValue("@Id", oProduto.Id);
                    comando.ExecuteNonQuery();
                }
            }
        }

        public void Excluir()
        {
            using (var oCn = Data.Conexao())
            {
                string sql = "DELETE FROM Produto WHERE ID = @Id";

                using (var comando = new SqlCommand(sql, oCn))
                {
                    comando.Parameters.AddWithValue("@Id", this.Id);
                    comando.ExecuteNonQuery();
                }
            }
        }
        private static bool ProdutoJaExiste(string nome, long codigoBarra, int id = 0)
        {
            using (var oCn = Data.Conexao())
            {
                string sql = "SELECT COUNT(*) FROM Produto WHERE (Nome = @Nome OR CodigoBarra = @CodigoBarra) AND id <> @Id";

                using (var comando = new SqlCommand(sql, oCn))
                {
                    comando.Parameters.AddWithValue("@Nome", nome);
                    comando.Parameters.AddWithValue("@CodigoBarra", codigoBarra);
                    comando.Parameters.AddWithValue("@Id", id);

                    int count = (int)comando.ExecuteScalar();
                    return count > 0;
                }
            }
        }
    }
}

