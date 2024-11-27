using Estoque.Formularios;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.Classes
{
    internal class EstoqueC
    {
        private string _Nome;
        private int _Id;
        private Int64 _Barra;
        private int _QTD;
        private int _Lote;
        private double _Preco;
        private DateTime _Data2;
        private DateTime _Data3;
        private string _IdProduto;
        private string _Marca;
        private string _Categoria;
        private int _PId;

        public DateTime Data2
        {
            get { return _Data2; }
            set { _Data2 = value; }
        }

        public DateTime Data3
        {
            get { return _Data3; }
            set { _Data3 = value; }
        }
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        public int PId
        {
            get { return _PId; }
            set { _PId = value; }
        }
        public int QTD
        {
            get { return _QTD; }
            set { _QTD = value; }
        }
        public int Lote
        {
            get { return _Lote; }
            set { _Lote = value; }
        }

        public double Preco
        {
            get { return _Preco; }
            set { _Preco = value; }
        }
        public Int64 Barra
        {
            get { return _Barra; }
            set { _Barra = value; }
        }

        public string Nome { get => _Nome; set => _Nome = value.Replace("'", ""); }

        public string Marca { get => _Marca; set => _Marca = value.Replace("'", ""); }

        public string Categoria { get => _Categoria; set => _Categoria = value.Replace("'", ""); }
        public string IdProduto { get => _IdProduto; set => _IdProduto = value.Replace("'", ""); }
        public static List<EstoqueC> ListarTodos()
        {
            using (var oCn = Data.Conexao())
            {
                List<EstoqueC> Retorno = new List<EstoqueC>();
                string SQL = "Select P.Nome, E.id, E.DataAdicao, E.Lote, E.Preco, E.QuantidadeAdicionada as QTD, E.Validade, PE.Produto_id as Pid, M.Nome as Marca, C.Nome as Categoria, P.CodigoBarra From Estoque as E join Produto_has_Estoque as PE on E.id = PE.Estoque_id  join Produto as P on PE.Produto_id = P.id join Categoria as C on C.id = P.id join Marca as M on M.id = P.id";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                SqlDataReader oDr = comando.ExecuteReader();
                while (oDr.Read())
                {
                    EstoqueC oEstoque = new EstoqueC();
                    oEstoque.Id = oDr.GetInt32(oDr.GetOrdinal("id"));
                    oEstoque.Nome = oDr.GetString(oDr.GetOrdinal("Nome"));
                    oEstoque.Data2 = oDr.GetDateTime(oDr.GetOrdinal("DataAdicao"));
                    oEstoque.Data3 = oDr.GetDateTime(oDr.GetOrdinal("Validade"));
                    oEstoque.QTD = oDr.GetInt32(oDr.GetOrdinal("QTD"));
                    oEstoque.Lote = oDr.GetInt32(oDr.GetOrdinal("Lote"));
                    oEstoque.Preco = oDr.GetDouble(oDr.GetOrdinal("Preco"));
                    oEstoque.Marca = oDr.GetString(oDr.GetOrdinal("Marca"));
                    oEstoque.Categoria = oDr.GetString(oDr.GetOrdinal("Categoria"));
                    oEstoque.PId = oDr.GetInt32(oDr.GetOrdinal("Pid"));
                    oEstoque.Barra = oDr.GetInt64(oDr.GetOrdinal("CodigoBarra"));
                    Retorno.Add(oEstoque);
                }
                oDr.Close();
                return Retorno;
            }
        }
        public void Incluir()
        {

            using (var oCn = Data.Conexao())
            {
                string SQL = $"insert into Estoque (Validade, Lote, Preco, QuantidadeAdicionada, DataAdicao) values (@Data1, {this.Lote},  @Valor,  {this.QTD}, @Data2)";
                SqlCommand comando = new SqlCommand(SQL, oCn);
               
                comando.Parameters.AddWithValue("@Valor", Preco);
                comando.Parameters.AddWithValue("@Data1", Data2);
                comando.Parameters.AddWithValue("@Data2", Data3);
                comando.ExecuteNonQuery();
            }

        }

        public void Incluir2()
        {
            using (var oCn = Data.Conexao())
            {
                EstoqueC? Retorno = null;
                string SQL2 = $"select id from Estoque";
                SqlCommand comando2 = new SqlCommand(SQL2, oCn);
                SqlDataReader oDr = comando2.ExecuteReader();
                while (oDr.Read())
                {
                    Retorno = new EstoqueC();
                    Retorno.Id = oDr.GetInt32(oDr.GetOrdinal("id"));
                }
                oDr.Close();

                Id = Retorno.Id;

                string SQL3 = $"insert into Produto_has_Estoque values ({IdProduto}, {Id})";
                SqlCommand comando3 = new SqlCommand(SQL3, oCn);
                comando3.ExecuteNonQuery();
            }
        }

        public static void AlterarEstoque(EstoqueC oEstoque)
        {

            using (var oCn = Data.Conexao())
            {
                string SQL = $"Update Estoque Set Validade = @Data1, Preco = @Valor, Lote = {oEstoque.Lote}, QuantidadeAdicionada = {oEstoque.QTD}, DataAdicao = @Data2 where id = {oEstoque.Id}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.Parameters.AddWithValue("@Valor", oEstoque.Preco);
                comando.Parameters.AddWithValue("@Data1", oEstoque.Data2);
                comando.Parameters.AddWithValue("@Data2", oEstoque.Data3);
                comando.ExecuteNonQuery();

                string SQL2 = $"Update Produto_has_Estoque Set Produto_id = {oEstoque.IdProduto}, Estoque_id = {oEstoque.Id} where Estoque_id = {oEstoque.Id}";
                SqlCommand comando2 = new SqlCommand(SQL2, oCn);
                comando2.ExecuteNonQuery();
            }
        }

        public void Excluir()
        {
            using (var oCn = Data.Conexao())
            {
                string SQL2 = $"Delete from Produto_has_Estoque Where Estoque_id= {this.Id}";
                SqlCommand comando2 = new SqlCommand(SQL2, oCn);
                comando2.ExecuteNonQuery();

                string SQL = $"Delete from Estoque Where id= {this.Id}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
                
            }
        }
        public static List<EstoqueC> Seleciona(string tipoPesquisa, string codigo)
        {
            using (var oCn = Data.Conexao())
            {
                var retorno = new List<EstoqueC>();
                string sql = $"Select P.Nome, E.id, E.DataAdicao, E.Lote, E.Preco, E.QuantidadeAdicionada as QTD, E.Validade, PE.Produto_id as Pid, M.Nome as Marca, C.Nome as Categoria, P.CodigoBarra From Estoque as E join Produto_has_Estoque as PE on E.id = PE.Estoque_id  join Produto as P on PE.Produto_id = P.id join Categoria as C on C.id = P.id join Marca as M on M.id = P.id where {tipoPesquisa} = @Codigo";

                using (var comando = new SqlCommand(sql, oCn))
                {
                    if (tipoPesquisa == "DataAdicao")
                    {
                        comando.Parameters.AddWithValue("@Codigo", FrmAdEstoque.Data4.Date);
                    }
                    else if (tipoPesquisa == "Validade")
                    {
                        comando.Parameters.AddWithValue("@Codigo", FrmAdEstoque.Data4.Date);
                    }
                    else
                    {
                        comando.Parameters.AddWithValue("@Codigo", codigo);
                    }
                    using (var oDr = comando.ExecuteReader())
                    {
                        

                        while (oDr.Read())
                        {
                            var oEstoque = new EstoqueC
                            {
                                Id = oDr.GetInt32(oDr.GetOrdinal("id")),
                                Nome = oDr.GetString(oDr.GetOrdinal("Nome")),
                                Data2 = oDr.GetDateTime(oDr.GetOrdinal("DataAdicao")),
                                Data3 = oDr.GetDateTime(oDr.GetOrdinal("Validade")),
                                QTD = oDr.GetInt32(oDr.GetOrdinal("QTD")),
                                Lote = oDr.GetInt32(oDr.GetOrdinal("Lote")),
                                Preco = oDr.GetDouble(oDr.GetOrdinal("Preco")),
                                Marca = oDr.GetString(oDr.GetOrdinal("Marca")),
                                Categoria = oDr.GetString(oDr.GetOrdinal("Categoria")),
                                PId = oDr.GetInt32(oDr.GetOrdinal("Pid")),
                                Barra = oDr.GetInt64(oDr.GetOrdinal("CodigoBarra")),
                            };
                            retorno.Add(oEstoque);
                        }
                    }
                }
                return retorno;
            }
        }

        public static List<EstoqueC> Seleciona2(string tipoPesquisa, string codigo)
        {
            using (var oCn = Data.Conexao())
            {
                var retorno = new List<EstoqueC>();
                string sql = $"Select P.Nome, E.id, E.DataAdicao, E.Lote, E.Preco, E.QuantidadeAdicionada as QTD, E.Validade, PE.Produto_id as Pid, M.Nome as Marca, C.Nome as Categoria, P.CodigoBarra From Estoque as E join Produto_has_Estoque as PE on E.id = PE.Estoque_id  join Produto as P on PE.Produto_id = P.id join Categoria as C on C.id = P.id join Marca as M on M.id = P.id where {tipoPesquisa} BETWEEN @Hoje AND @Codigo";

                using (var comando = new SqlCommand(sql, oCn))
                {

                    
                    comando.Parameters.AddWithValue("@Codigo", FrmAdEstoque.Data4.Date);
                    comando.Parameters.AddWithValue("@Hoje", DateTime.Now);


                    using (var oDr = comando.ExecuteReader())
                    {


                        while (oDr.Read())
                        {
                            var oEstoque = new EstoqueC
                            {
                                Id = oDr.GetInt32(oDr.GetOrdinal("id")),
                                Nome = oDr.GetString(oDr.GetOrdinal("Nome")),
                                Data2 = oDr.GetDateTime(oDr.GetOrdinal("DataAdicao")),
                                Data3 = oDr.GetDateTime(oDr.GetOrdinal("Validade")),
                                QTD = oDr.GetInt32(oDr.GetOrdinal("QTD")),
                                Lote = oDr.GetInt32(oDr.GetOrdinal("Lote")),
                                Preco = oDr.GetDouble(oDr.GetOrdinal("Preco")),
                                Marca = oDr.GetString(oDr.GetOrdinal("Marca")),
                                Categoria = oDr.GetString(oDr.GetOrdinal("Categoria")),
                                PId = oDr.GetInt32(oDr.GetOrdinal("Pid")),
                                Barra = oDr.GetInt64(oDr.GetOrdinal("CodigoBarra")),
                            };
                            retorno.Add(oEstoque);
                        }
                    }
                }
                return retorno;
            }
        }
    }
}
