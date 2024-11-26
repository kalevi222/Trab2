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

    }
}

