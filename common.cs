using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassVault
{   

    public class Common
    {
        public static string dsnName = "xPVS";
        public static string connectionString = $"DSN={dsnName};";
        public OdbcDataAdapter adapter;
        public DataSet ds;

        public DataSet GetDataSet(string Query)
        {
            DataSet dataSet = new DataSet();

            adapter = new OdbcDataAdapter(Query,connectionString);
            adapter.AcceptChangesDuringUpdate = true;
            adapter.Fill(dataSet);
            return dataSet;
        }

    }
}
