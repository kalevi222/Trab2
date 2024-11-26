using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Estoque
{
    internal class Data
    {
        public static SqlConnection Conexao()
        {
            //string strconnection = "Data Source = DESKTOP-IF7IPKC\\MSSQLSERVER01; Initial Catalog = Estoque; Integrated Security = True; Encrypt = True; Trust Server Certificate = True";
            string strconnection = "Data Source=PC17-LAB1\\SQLEXPRESS;Initial Catalog=Estoque;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
            SqlConnection oCn = new SqlConnection(strconnection);
            oCn.Open();
            return oCn;
        }
    }

}
