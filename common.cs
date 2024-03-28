using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassVault
{   

    public class common
    {
        public static string dsnName = "xPVS";
        public static string connectionString = $"DSN={dsnName};";

        public DataSet GetDataSet(string Query)
        {
            DataSet dataSet = new DataSet();

            OdbcDataAdapter adapter = new OdbcDataAdapter(Query,connectionString);
            adapter.Fill(dataSet);
            return dataSet;
        }

    }
}
