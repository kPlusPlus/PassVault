using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.Odbc;
using System.Net.NetworkInformation;

namespace PassVault
{
    public partial class Login_frm : Form
    {
        // Specify the name of the DSN you want to connect to
        public static string dsnName = "xPVS";
        public static string connectionString = $"DSN={dsnName};";

        public static string username = string.Empty ;
        public static string password = string.Empty ;
        public static string Access_Level = string.Empty ;
        public static int userid = 0 ;

        public Login_frm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty )
            {
                MessageBox.Show("Treba uspisati user");
                return;
            }
            if (textBox2.Text == string.Empty)
            {
                MessageBox.Show("Treba uspisati password");
                return;
            }
            userid = 0;
            OdbcConnection connection = new OdbcConnection(connectionString);
            connection.Open();
            string query = "SELECT * FROM dbo.Login_tbl WHERE Username = '" + textBox1.Text 
                + "' and Password = '" + textBox2.Text + "';";
            OdbcCommand command = new OdbcCommand(query, connection);
            OdbcDataReader reader = command.ExecuteReader();
            int iCount = 0;
            while (reader.Read())
            {
                iCount++;
                if (iCount == 1)
                {
                    userid = Convert.ToInt32(reader["ID"]);
                    Globals.userid = userid;
                    Globals.username = reader["Username"].ToString();
                    Globals.Access_Level = reader["Access_Level"].ToString();
                }
            }

            if(userid == 0) {
                MessageBox.Show("Pogrešni username i password !!!");
            }
            else
            {
                Main_frm main_Frm = new Main_frm();
                main_Frm.Show();
                this.Hide();
            }
        }
    }
}
