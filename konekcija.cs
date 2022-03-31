using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace EDnevnik
{
    class Konekcija
    {
        static public SqlConnection Povezivanje()
        {
            string CS;
            CS = ConfigurationManager.ConnectionStrings["kucni"].ConnectionString;
            SqlConnection veza = new SqlConnection(CS);
            return veza;
        }
    }
}
