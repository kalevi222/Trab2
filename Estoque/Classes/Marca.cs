using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.Classes
{
    internal class Marca
    {
        private string _Nome;
        private int _Id;

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }
        public string Nome { get => _Nome; set => _Nome = value.Replace("'", ""); }

        public static List<Marca> ListarTodos()
        {
            using (var oCn = Data.Conexao())
            {
                List<Marca> Retorno = new List<Marca>();
                string SQL = "select ID, Nome from Marca";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                SqlDataReader oDr = comando.ExecuteReader();
                while (oDr.Read())
                {
                    Marca oMarca = new Marca();
                    oMarca.Id = oDr.GetInt32(oDr.GetOrdinal("ID"));
                    oMarca.Nome = oDr.GetString(oDr.GetOrdinal("Nome"));

                    Retorno.Add(oMarca);
                }
                oDr.Close();
                return Retorno;
            }
        }

        public static Marca? Seleciona(int Codigo)
        {

            using (var oCn = Data.Conexao())
            {
                Marca? Retorno = null;
                string SQL = $"select ID, Nome from Marca Where Id={Codigo}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                SqlDataReader oDr = comando.ExecuteReader();
                while (oDr.Read())
                {
                    Retorno = new Marca();
                    Retorno.Id = oDr.GetInt32(oDr.GetOrdinal("ID"));
                    Retorno.Nome = oDr.GetString(oDr.GetOrdinal("Nome"));
                }
                oDr.Close();
                return Retorno;
            }
        }
        public static List<Marca> Seleciona(string tipoPesquisa, string codigo)
        {
            using (var oCn = Data.Conexao()) // Obtém a conexão
            {
                var retorno = new List<Marca>(); // Lista para armazenar as marcas retornadas
                string sql = $"SELECT M.Id, M.Nome " +
                             $"FROM Marca AS M " +
                             $"WHERE {tipoPesquisa} = @Codigo"; // Query com tipo de pesquisa dinâmico

                using (var comando = new SqlCommand(sql, oCn))
                {
                    comando.Parameters.AddWithValue("@Codigo", codigo); // Substitui o parâmetro no SQL

                    using (var oDr = comando.ExecuteReader()) // Executa a leitura dos dados
                    {
                        while (oDr.Read())
                        {
                            retorno.Add(new Marca
                            {
                                Id = oDr.GetInt32(oDr.GetOrdinal("id")), // Obtém o ID
                                Nome = oDr.GetString(oDr.GetOrdinal("Nome")) // Obtém o Nome
                            });
                        }
                    }
                }

                return retorno; // Retorna a lista de marcas
            }
        }

        public void Incluir()
        {

            using (var oCn = Data.Conexao())
            {
                string SQL = $"insert into Marca values ('{this.Nome.Replace("'", "")}')";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }

        }

        public static void AlterarMarca(Marca oMarca)
        {

            using (var oCn = Data.Conexao())
            {
                string SQL = $"Update Marca Set Nome= '{oMarca.Nome.Replace("'", "")}' where ID = {oMarca.Id}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
        }

        public void Excluir()
        {
            using (var oCn = Data.Conexao())
            {
                string SQL = $"Delete from Marca Where ID= {this.Id}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
        }
        private string ObterPesquisaTipo(ComboBox comboBox)
        {
            switch (comboBox.SelectedIndex)
            {
                case 0:
                    return "ID";
                case 1:
                    return "Nome";
                default:
                    return string.Empty; // Valor padrão, caso necessário
            }
        }


    }
}

