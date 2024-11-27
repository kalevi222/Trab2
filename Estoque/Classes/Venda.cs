using Estoque.Formularios;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Azure.Core.HttpHeader;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Estoque.Classes
{
    internal class Venda
    {
        private int _Id;
        private int _Id2;
        private int _Lote;
        private int _QTD;
        private long _Barra;
        private string _Nome;
        private double _Preco;
        private DateTime _Data2;

        public double Valor { get; set; }

        public double ValorTotal { get; set; }

        public double ValorVenda { get; set; }
        public DateTime Data2
        {
            get { return _Data2; }
            set { _Data2 = value; }
        }
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }
        public int Id3
        {
            get { return _Id2; }
            set { _Id2 = value; }
        }
        public int Lote
        {
            get { return _Lote; }
            set { _Lote = value; }
        }
        public int QTD
        {
            get { return _QTD; }
            set { _QTD = value; }
        }
        public double Preco
        {
            get { return _Preco; }
            set { _Preco = value; }
        }
        public string Nome { get => _Nome; set => _Nome = value.Replace("'", ""); }
        public long Barra { get => _Barra; set => _Barra = value; }

        public static int Id2;
        public static int Id4;
        public static Double ValorVenda2;
        public static DateTime Date3;
        public static void PegarID()
        {
            using (var oCn = Data.Conexao())
            {
                Venda? Retorno = null;
                string SQL1 = $"select id from Venda";
                SqlCommand comando1 = new SqlCommand(SQL1, oCn);
                SqlDataReader oDr = comando1.ExecuteReader();
                while (oDr.Read())
                {
                    Retorno = new Venda();
                    Retorno.Id = oDr.GetInt32(oDr.GetOrdinal("id"));
                }
                oDr.Close();

                if (Retorno == null)
                {
                    Id2 = 1;
                }
                else
                {
                    Id2 = Retorno.Id;
                    Id2 = Id2 + 1;
                }
                
            }
        }
        public static List<Venda> SelecionaProduto(int Codigo)
        {

            using (var oCn = Data.Conexao())
            {

                List<Venda> Retorno = new List<Venda>();
                string SQL = $"SELECT PE.Produto_id, PE.Estoque_id, P.Nome as Produto, P.CodigoBarra, E.Preco, E.Lote, E.QuantidadeAdicionada FROM Produto_has_Estoque AS PE  join Produto as P on PE.Produto_id = P.id join Estoque as E on PE.Estoque_id = E.id where PE.Produto_id = {Codigo}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                SqlDataReader oDr = comando.ExecuteReader();
                while (oDr.Read())
                {
                    Venda oVenda = new Venda();
                    oVenda.Id = oDr.GetInt32(oDr.GetOrdinal("Estoque_id"));
                    oVenda.Nome = oDr.GetString(oDr.GetOrdinal("Produto"));
                    oVenda.Preco = oDr.GetDouble(oDr.GetOrdinal("Preco"));
                    oVenda.Lote = oDr.GetInt32(oDr.GetOrdinal("Lote"));
                    oVenda.Barra = oDr.GetInt64(oDr.GetOrdinal("CodigoBarra"));
                    oVenda.QTD = oDr.GetInt32(oDr.GetOrdinal("QuantidadeAdicionada"));
                    Retorno.Add(oVenda);

                }
                oDr.Close();
                return Retorno;
            }
        }

        public static List<Venda> ListarTodos()
        {
            using (var oCn = Data.Conexao())
            {
                List<Venda> Retorno = new List<Venda>();
                string SQL = "select id, ValorTotalVenda, DataVenda from Venda";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                SqlDataReader oDr = comando.ExecuteReader();
                while (oDr.Read())
                {
                    Venda oVenda = new Venda();
                    oVenda.Id = oDr.GetInt32(oDr.GetOrdinal("id"));
                    oVenda.Valor = oDr.GetDouble(oDr.GetOrdinal("ValorTotalVenda"));
                    oVenda.Data2 = oDr.GetDateTime(oDr.GetOrdinal("DataVenda"));
                    Retorno.Add(oVenda);
                }
                oDr.Close();
                return Retorno;
            }
        }

        public static List<Venda> ListarTodos2(int Codigo)
        {

            using (var oCn = Data.Conexao())
            {

                List<Venda> Retorno = new List<Venda>();
                string SQL = $"select VP.Venda_id, VP.Produto_id, P.Nome, VP.Quantidade, VP.ValorUnitario, VP.ValorTotal , VP.Lote, V.ValorTotalVenda, V.DataVenda from Venda_has_Produto as VP join Produto as P on VP.Produto_id = P.id join Venda as V on VP.Venda_id = V.id where VP.Venda_id = {Codigo}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                SqlDataReader oDr = comando.ExecuteReader();
                while (oDr.Read())
                {
                    Venda oVenda = new Venda();
                    oVenda.Id = oDr.GetInt32(oDr.GetOrdinal("Venda_id"));
                    oVenda.ValorVenda = oDr.GetDouble(oDr.GetOrdinal("ValorTotalVenda"));
                    oVenda.Data2 = oDr.GetDateTime(oDr.GetOrdinal("DataVenda"));
                    oVenda.Id3 = oDr.GetInt32(oDr.GetOrdinal("Produto_id"));
                    oVenda.Nome = oDr.GetString(oDr.GetOrdinal("Nome"));
                    oVenda.QTD = oDr.GetInt32(oDr.GetOrdinal("Quantidade"));
                    oVenda.ValorTotal = oDr.GetDouble(oDr.GetOrdinal("ValorUnitario"));
                    oVenda.Lote = oDr.GetInt32(oDr.GetOrdinal("Lote"));
                    oVenda.Valor = oDr.GetDouble(oDr.GetOrdinal("ValorTotal"));
                    Retorno.Add(oVenda);

                    Id4 = oVenda.Id;
                    Date3 = oVenda.Data2.Date;
                    ValorVenda2 = oVenda.ValorVenda;

                }
                oDr.Close();
                return Retorno;
            }
        }

        public static List<Venda> Seleciona2(string tipoPesquisa, string codigo)
        {
            using (var oCn = Data.Conexao())
            {
                var retorno = new List<Venda>();
                string sql = $"select id, ValorTotalVenda, DataVenda from Venda where {tipoPesquisa} = @Codigo";

                using (var comando = new SqlCommand(sql, oCn))
                {

                    comando.Parameters.AddWithValue("@Codigo", codigo);

                    using (var oDr = comando.ExecuteReader())
                    {


                        while (oDr.Read())
                        {
                            var oVenda = new Venda
                            {
                                Id = oDr.GetInt32(oDr.GetOrdinal("id")),
                                Valor = oDr.GetDouble(oDr.GetOrdinal("ValorTotalVenda")),
                                Data2 = oDr.GetDateTime(oDr.GetOrdinal("DataVenda")),

                            };
                            retorno.Add(oVenda);
                        }
                    }
                }
                return retorno;
            }
        }

        public static List<Venda> Seleciona3(string tipoPesquisa, string codigo, int idpesquisa)
        {
            using (var oCn = Data.Conexao())
            {
                var retorno = new List<Venda>();
                string sql = $"select VP.Venda_id, VP.Produto_id, P.Nome, VP.Quantidade, VP.ValorUnitario, VP.ValorTotal , VP.Lote, V.ValorTotalVenda, V.DataVenda from Venda_has_Produto as VP join Produto as P on VP.Produto_id = P.id join Venda as V on VP.Venda_id = V.id where {tipoPesquisa} = @Codigo And VP.Venda_id = {idpesquisa}";

                using (var comando = new SqlCommand(sql, oCn))
                {

                    comando.Parameters.AddWithValue("@Codigo", codigo);

                    using (var oDr = comando.ExecuteReader())
                    {


                        while (oDr.Read())
                        {
                            var oVenda = new Venda
                            {
                                
                                Id = oDr.GetInt32(oDr.GetOrdinal("Venda_id")),                              
                                Id3 = oDr.GetInt32(oDr.GetOrdinal("Produto_id")),
                                Nome = oDr.GetString(oDr.GetOrdinal("Nome")),
                                QTD = oDr.GetInt32(oDr.GetOrdinal("Quantidade")),
                                ValorTotal = oDr.GetDouble(oDr.GetOrdinal("ValorUnitario")),
                                Lote = oDr.GetInt32(oDr.GetOrdinal("Lote")),
                                Valor = oDr.GetDouble(oDr.GetOrdinal("ValorTotal")),
                                
                            };
                            retorno.Add(oVenda);
                        }
                    }
                }
                return retorno;
            }
        }

        public void Excluir()
        {
            using (var oCn = Data.Conexao())
            {
                string SQL = $"Delete from Venda_has_Produto Where Venda_id = {this.Id}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();

            }

            using (var oCn = Data.Conexao())
            {
                string SQL3 = $"Delete from Venda Where id= {this.Id}";
                SqlCommand comando3 = new SqlCommand(SQL3, oCn);
                comando3.ExecuteNonQuery();

            }
        }

    }
}
