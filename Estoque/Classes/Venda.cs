using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.Classes
{
    internal class Venda
    {
        private int _Id;
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        public static int Id2;
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



    }
}
