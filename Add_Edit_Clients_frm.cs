using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassVault
{
    public partial class Add_Edit_Clients_frm : Form
    {
        private Common common = new Common();
        public Add_Edit_Clients_frm()
        {
            InitializeComponent();
            FillDataGridView();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void FillDataGridView()
        {
            //DataSet ds = new DataSet();
            string Query = "SELECT * FROM dbo.Clients_tbl;";
            common.ds = common.GetDataSet(Query);            

            bindingSource1.DataSource = common.ds;
            bindingSource1.DataMember = common.ds.Tables[0].TableName;
            dgvClients.DataSource = bindingSource1;

            OdbcCommandBuilder updateCommand = new OdbcCommandBuilder(common.adapter);
            common.adapter.UpdateCommand = updateCommand.GetUpdateCommand();
            OdbcCommandBuilder insertCommand = new OdbcCommandBuilder(common.adapter);
            common.adapter.InsertCommand = insertCommand.GetInsertCommand();
            OdbcCommandBuilder deleteCommand = new OdbcCommandBuilder(common.adapter);
            common.adapter.DeleteCommand = deleteCommand.GetDeleteCommand();

            ID_txt.DataBindings.Add("Text", bindingSource1, "ID");
            Client_ID_txt.DataBindings.Add("Text", bindingSource1, "ClientID");
            Client_Name_txt.DataBindings.Add("Text", bindingSource1, "Name");
            OIB_txt.DataBindings.Add("Text",bindingSource1, "OIB");
            City_txt.DataBindings.Add("Text", bindingSource1, "Address_City");
            PO_txt.DataBindings.Add("Text", bindingSource1, "PO");
            Street_txt.DataBindings.Add("Text", bindingSource1, "Address_Street");
            StreetNo_txt.DataBindings.Add("Text", bindingSource1, "Address_Street_number");
            Ext_txt.DataBindings.Add("Text", bindingSource1, "Address_ext");
            Contact_txt.DataBindings.Add("Text", bindingSource1, "Contact");
            Email_txt.DataBindings.Add("Text", bindingSource1, "Email");
            Tel_txt.DataBindings.Add("Text", bindingSource1, "Tel");
        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                bindingSource1.EndEdit();
                common.adapter.Update(common.ds, common.ds.Tables[0].TableName);
                MessageBox.Show("Data saved successfully. ");
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
        }
    }
}
