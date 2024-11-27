using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.Classes
{
    internal class Fornecedor
    {
        private string _Nome;
        private int _Id;
        private string _Contato;
        private string _Endereco;
        private string _CNPJ;
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }
        public string Nome { get => _Nome; set => _Nome = value.Replace("'", ""); }
        public string Contato { get => _Contato; set => _Contato = value.Replace("'", ""); }
        public string Endereco { get => _Endereco; set => _Endereco = value.Replace("'", ""); }
        public string CNPJ { get => _CNPJ; set => _CNPJ = value.Replace("'", ""); }
        public static List<Fornecedor> ListarTodos()
        {
            using (var oCn = Data.Conexao())
            {
                List<Fornecedor> Retorno = new List<Fornecedor>();
                string SQL = "select ID, Nome, Contato, Endereco, CNPJ from Fornecedor";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                SqlDataReader oDr = comando.ExecuteReader();
                while (oDr.Read())
                {
                    Fornecedor oFornecedor = new Fornecedor();
                    oFornecedor.Id = oDr.GetInt32(oDr.GetOrdinal("ID"));
                    oFornecedor.Nome = oDr.GetString(oDr.GetOrdinal("Nome"));
                    oFornecedor.Contato = oDr.GetString(oDr.GetOrdinal("Contato"));
                    oFornecedor.Endereco = oDr.GetString(oDr.GetOrdinal("Endereco"));
                    oFornecedor.CNPJ = oDr.GetString(oDr.GetOrdinal("CNPJ"));

                    Retorno.Add(oFornecedor);
                }
                oDr.Close();
                return Retorno;
            }
        }

        public static Fornecedor? Seleciona(int Codigo)
        {

            using (var oCn = Data.Conexao())
            {
                Fornecedor? Retorno = null;
                string SQL = $"select ID, Nome, Contato, Endereco, CNPJ from Fornecedor Where Id={Codigo}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                SqlDataReader oDr = comando.ExecuteReader();
                while (oDr.Read())
                {
                    Retorno = new Fornecedor();
                    Retorno.Id = oDr.GetInt32(oDr.GetOrdinal("ID"));
                    Retorno.Nome = oDr.GetString(oDr.GetOrdinal("Nome"));
                    Retorno.Contato = oDr.GetString(oDr.GetOrdinal("Contato"));
                    Retorno.Endereco = oDr.GetString(oDr.GetOrdinal("Endereco"));
                    Retorno.CNPJ = oDr.GetString(oDr.GetOrdinal("CNPJ"));
                }
                oDr.Close();
                return Retorno;
            }
        }
        public static List<Fornecedor> Seleciona(string tipoPesquisa, string codigo)
        {
            using (var oCn = Data.Conexao()) // Obtém a conexão
            {
                var retorno = new List<Fornecedor>(); // Lista para armazenar as marcas retornadas
                string sql = $"SELECT Id, Nome, CNPJ, Contato, Endereco from Fornecedor WHERE {tipoPesquisa} = @Codigo"; // Query com tipo de pesquisa dinâmico

                using (var comando = new SqlCommand(sql, oCn))
                {
                    comando.Parameters.AddWithValue("@Codigo", codigo); // Substitui o parâmetro no SQL

                    using (var oDr = comando.ExecuteReader()) // Executa a leitura dos dados
                    {
                        while (oDr.Read())
                        {
                            retorno.Add(new Fornecedor
                            {
                                Id = oDr.GetInt32(oDr.GetOrdinal("id")), // Obtém o ID
                                Nome = oDr.GetString(oDr.GetOrdinal("Nome")), // Obtém o Nome
                                Contato = oDr.GetString(oDr.GetOrdinal("Contato")),
                                Endereco = oDr.GetString(oDr.GetOrdinal("Endereco")),
                                CNPJ = oDr.GetString(oDr.GetOrdinal("CNPJ")) // Obtém o CNPJ
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
                string SQL = $"insert into Fornecedor values ('{this.Nome.Replace("'", "")}', '{this.Contato.Replace("'", "")}', '{this.Endereco.Replace("'", "")}','{this.CNPJ.Replace("'", "")}')";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }

        }

        public static void AlterarFornecedor(Fornecedor oFornecedor)
        {

            using (var oCn = Data.Conexao())
            {
                string SQL = $"Update Fornecedor Set Nome= '{oFornecedor.Nome.Replace("'", "")}', Contato= '{oFornecedor.Contato.Replace("'", "")}', Endereco= '{oFornecedor.Endereco.Replace("'", "")}', CNPJ= '{oFornecedor.CNPJ.Replace("'", "")}' where ID = {oFornecedor.Id}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
        }

        public void Excluir()
        {
            using (var oCn = Data.Conexao())
            {
                string SQL = $"Delete from Fornecedor Where ID= {this.Id}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
        }

    }
}
