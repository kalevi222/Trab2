using Estoque.Formularios;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Estoque.Classes
{
    internal class Pedido
    {
        private string _Nome;
        private string _Status;
        private string _Produto;
        private int _Id;
        private int _IdProduto;
        private int _QTD;
        private int _NPedido;
        private DateTime _Data2;

        public DateTime Data2
        {
            get { return _Data2; }
            set { _Data2 = value; }
        }
        public int Quantidade { get; set; } // Nova propriedade para quantidade
        public double Valor { get; set; } // Nova propriedade para valor
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }
        public int QTD
        {
            get { return _QTD; }
            set { _QTD = value; }
        }
        public int IdProduto
        {
            get { return _IdProduto; }
            set { _IdProduto = value; }
        }

        public int NPedido
        {
            get { return _NPedido; }
            set { _NPedido = value; }
        }
        public string Nome { get; set; }

        public string Status { get => _Status; set => _Status = value.Replace("'", ""); }

        public string Produto { get => _Produto; set => _Produto = value.Replace("'", ""); }

        public override string ToString()
        {
            return Nome; // O que será exibido na CheckedListBox
        }

        public static int Id2;
        public static int Id3;
        public static int NumPedido;
        public static int IdProduto2;
        public static int QTD2;
        public static string Nome2;
        public static string Status2;
        public static string Produto2;
        public static DateTime Date3;

        public static List<Pedido> ObterProdutos()
        {

            using (var oCn = Data.Conexao()) 
            {
                List<Pedido> Retorno = new List<Pedido>();
                string SQL = "SELECT id, Nome FROM Produto";

                using (SqlCommand comando = new SqlCommand(SQL, oCn))
                {
                    using (SqlDataReader oDr = comando.ExecuteReader())
                    {
                        while (oDr.Read())
                        {
                            Pedido oPedido = new Pedido
                            {
                                Id = oDr.GetInt32(oDr.GetOrdinal("id")),
                                Nome = oDr.GetString(oDr.GetOrdinal("Nome"))
                            };

                            Retorno.Add(oPedido);
                        }
                    }
                }
                return Retorno;
            }
        }

        public static List<Pedido> ListarTodos()
        {
            using (var oCn = Data.Conexao())
            {
                List<Pedido> Retorno = new List<Pedido>();
                string SQL = "select P.id, F.Nome, NumPedido, DataPedido, Status_2 from Pedido as P join Fornecedor as F on P.Fornecedor_id = F.id";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                SqlDataReader oDr = comando.ExecuteReader();
                while (oDr.Read())
                {
                    Pedido oPedido = new Pedido();
                    oPedido.Id = oDr.GetInt32(oDr.GetOrdinal("id"));
                    oPedido.Nome = oDr.GetString(oDr.GetOrdinal("Nome"));
                    oPedido.NPedido = oDr.GetInt32(oDr.GetOrdinal("NumPedido"));
                    oPedido.Data2 = oDr.GetDateTime(oDr.GetOrdinal("DataPedido"));
                    oPedido.Status = oDr.GetString(oDr.GetOrdinal("Status_2"));
                    Retorno.Add(oPedido);
                }
                oDr.Close();
                return Retorno;
            }
        }
        public void Incluir()
        {

            using (var oCn = Data.Conexao())
            {
                string SQL = $"insert into Pedido (DataPedido, Fornecedor_id, NumPedido, Status_2, ValorTotalPedido) values (@Data, {this.Nome}, {this.NPedido}, @Valor, 1)";
                SqlCommand comando = new SqlCommand(SQL, oCn);

                comando.Parameters.AddWithValue("@Data", Data2);
                comando.Parameters.AddWithValue("@Valor", Status);
                comando.ExecuteNonQuery();
            }

        }
        public void Incluir2()
        {
            using (var oCn = Data.Conexao())
            {
                EstoqueC? Retorno = null;
                string SQL2 = $"select id from Pedido";
                SqlCommand comando2 = new SqlCommand(SQL2, oCn);
                SqlDataReader oDr = comando2.ExecuteReader();
                while (oDr.Read())
                {
                    Retorno = new EstoqueC();
                    Retorno.Id = oDr.GetInt32(oDr.GetOrdinal("id"));
                }
                oDr.Close();

                Id2 = Retorno.Id;
            }
        }

        public static void AlterarPedido(Pedido oPedido)
        {

            using (var oCn = Data.Conexao())
            {
                string SQL = $"Update Pedido Set DataPedido = @Data, Fornecedor_id = {oPedido.Nome}, NumPedido = {oPedido.NPedido}, Status_2 = @Estatu where id = {oPedido.Id}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.Parameters.AddWithValue("@Data", oPedido.Data2);
                comando.Parameters.AddWithValue("@Estatu", oPedido.Status);
                comando.ExecuteNonQuery();
            }
        }

        public void Excluir()
        {
            using (var oCn = Data.Conexao())
            {
                string SQL2 = $"Delete from Pedido Where id= {this.Id}";
                SqlCommand comando2 = new SqlCommand(SQL2, oCn);
                comando2.ExecuteNonQuery();

            }
        }

        public static List<Pedido> ListarTodos2()
        {
            int Codigo;

            if (FrmConsultarPedido.Cod == true)
            {
                Codigo = FrmConsultarPedido.CodigoPedido2;
            }
            else
            {
                Codigo = FrmAddPedido.CodigoPedido;
            }
            
            using (var oCn = Data.Conexao())
            {
                
                List<Pedido> Retorno = new List<Pedido>();
                string SQL = $"select PP.Pedido_id, F.Nome as Fornecedor, P.NumPedido, P.DataPedido, P.Status_2, PP.Produto_id, PP.Quantidade, PP.Valor, Pro.Nome as Produto from Pedido as P join Fornecedor as F on P.Fornecedor_id = F.id join Pedido_has_Produto as PP on PP.Pedido_id = P.id join Produto as Pro on PP.Produto_id = Pro.id where P.id = {Codigo}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                SqlDataReader oDr = comando.ExecuteReader();
                while (oDr.Read())
                {
                    Pedido oPedido = new Pedido();
                    oPedido.Id = oDr.GetInt32(oDr.GetOrdinal("Pedido_id"));
                    oPedido.Nome = oDr.GetString(oDr.GetOrdinal("Fornecedor"));
                    oPedido.NPedido = oDr.GetInt32(oDr.GetOrdinal("NumPedido"));
                    oPedido.Data2 = oDr.GetDateTime(oDr.GetOrdinal("DataPedido"));
                    oPedido.Status = oDr.GetString(oDr.GetOrdinal("Status_2"));
                    oPedido.IdProduto = oDr.GetInt32(oDr.GetOrdinal("Produto_id"));
                    oPedido.QTD = oDr.GetInt32(oDr.GetOrdinal("Quantidade"));
                    oPedido.Produto = oDr.GetString(oDr.GetOrdinal("Produto"));
                    oPedido.Valor = oDr.GetDouble(oDr.GetOrdinal("Valor"));
                    Retorno.Add(oPedido);

                    Id3 = oPedido.Id;
                    Nome2 = oPedido.Nome;
                    NumPedido = oPedido.NPedido;
                    Date3 = oPedido.Data2.Date;
                    Status2 = oPedido.Status;
                    IdProduto2 = oPedido.IdProduto;
                    QTD2 = oPedido.QTD;
                    Produto2 = oPedido.Produto;
                 }
                oDr.Close();
                return Retorno;
            }
        }
        public void Incluir3()
        {

            using (var oCn = Data.Conexao())
            {
                string SQL = $"insert into Pedido_has_Produto (Produto_id, Pedido_id, Quantidade, Valor) values ({this.Produto}, {this.Id}, {this.QTD}, @Preco)";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.Parameters.AddWithValue("@Preco", this.Valor);
                comando.ExecuteNonQuery();
            }

        }

        public static void AlterarPedido2(Pedido oPedido)
        {

            using (var oCn = Data.Conexao())
            {
                string SQL = $"Update Pedido_has_produto Set Quantidade = {oPedido.QTD}, Valor = @Preco where Estoque_id = {oPedido.Id} and Produto_id = @IdProd";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.Parameters.AddWithValue("@Preco", oPedido.Valor);
                comando.Parameters.AddWithValue("@IdProd", oPedido.IdProduto);
                comando.ExecuteNonQuery();
            }
        }
        public void Excluir2()
        {
            using (var oCn = Data.Conexao())
            {
                string SQL2 = $"Delete from Pedido_has_Produto Where Pedido_id = {this.Id} and Produto_id = {this.IdProduto}";
                SqlCommand comando2 = new SqlCommand(SQL2, oCn);
                comando2.ExecuteNonQuery();

            }
        }

        public static List<Pedido> Seleciona(string tipoPesquisa, string codigo)
        {
            using (var oCn = Data.Conexao())
            {
                var retorno = new List<Pedido>();
                string sql = $"select PP.Pedido_id, F.Nome as Fornecedor, P.NumPedido, P.DataPedido, P.Status_2, PP.Produto_id, PP.Quantidade, PP.Valor, Pro.Nome as Produto from Pedido as P join Fornecedor as F on P.Fornecedor_id = F.id join Pedido_has_Produto as PP on PP.Pedido_id = P.id join Produto as Pro on PP.Produto_id = Pro.id where{tipoPesquisa} = @Codigo";

                using (var comando = new SqlCommand(sql, oCn))
                {
                    
                    comando.Parameters.AddWithValue("@Codigo", codigo);
                    
                    using (var oDr = comando.ExecuteReader())
                    {


                        while (oDr.Read())
                        {
                            var oPedido = new Pedido
                            {
                               Id = oDr.GetInt32(oDr.GetOrdinal("Pedido_id")),
                               Nome = oDr.GetString(oDr.GetOrdinal("Fornecedor")),
                               NPedido = oDr.GetInt32(oDr.GetOrdinal("NumPedido")),
                               Data2 = oDr.GetDateTime(oDr.GetOrdinal("DataPedido")),
                               Status = oDr.GetString(oDr.GetOrdinal("Status_2")),
                               IdProduto = oDr.GetInt32(oDr.GetOrdinal("Produto_id")),
                               QTD = oDr.GetInt32(oDr.GetOrdinal("Quantidade")),
                               Produto = oDr.GetString(oDr.GetOrdinal("Produto")),
                               Valor = oDr.GetDouble(oDr.GetOrdinal("Valor"))
                            };
                            retorno.Add(oPedido);
                        }
                    }
                }
                return retorno;
            }
        }
    }
}
