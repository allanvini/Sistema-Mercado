using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Sistema_Mercado.Connection
{
    class Connection
    {
        private string connectionString;

        public String getConnectionString()
        {
            connectionString = ConfigurationManager.ConnectionStrings["Sistema-Mercado.Properties.Settings.dbConnectionString"].ConnectionString;
            return connectionString;
        }
    }
}
