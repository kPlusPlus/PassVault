using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PassVault
{
    public partial class Search_Clients : Form
    {
        private Common common = new Common();
        public Search_Clients()
        {
            InitializeComponent();
            FillDataGridView();
            FillCombo();
        }

        private void FillDataGridView()
        {
            string Query = "SELECT * FROM dbo.Clients_tbl;";
            common.ds = common.GetDataSet(Query);

            /*
            bindingSource1.DataSource = common.ds;
            bindingSource1.DataMember = common.ds.Tables[0].TableName;
            dgvClients.DataSource = bindingSource1;

            OdbcCommandBuilder updateCommand = new OdbcCommandBuilder(common.adapter);
            common.adapter.UpdateCommand = updateCommand.GetUpdateCommand();
            OdbcCommandBuilder insertCommand = new OdbcCommandBuilder(common.adapter);
            common.adapter.InsertCommand = insertCommand.GetInsertCommand();
            OdbcCommandBuilder deleteCommand = new OdbcCommandBuilder(common.adapter);
            common.adapter.DeleteCommand = deleteCommand.GetDeleteCommand();
            */

            dgvClients.DataSource = common.ds.Tables[0];

        }

        private void btnExit_Click(object sender, EventArgs e)
        {            
            this.Close();            
        }

        private void Client_Name_txt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchClient();
            }
        }

        private void SearchClient(String SearchByClientID = null, String SearchByOIB = null, String SearchByCity = null)
        {
            bool bWhere = false;
            string sWhere = string.Empty;
            string Query = "SELECT * FROM dbo.Clients_tbl";

            if (Client_Name_txt.Text != string.Empty)
            {
                bWhere = true;
                sWhere = "Name LIKE '%" + Client_Name_txt.Text + "%'";
            }
            else if (SearchByClientID != null)
            {
                bWhere = true;
                sWhere = "ClientID = " + SearchByClientID;
            }
            else if (SearchByOIB != null)
            {
                bWhere = true;
                sWhere = "OIB = " + SearchByOIB;
            }
            else if (SearchByCity != null)
            {
                bWhere = true;
                sWhere = "Address_City = '" + SearchByCity + "'";
            }


            if (bWhere)
            {
                Query += " WHERE " + sWhere;
                common.ds = common.GetDataSet(Query);
                dgvClients.DataSource = common.ds.Tables[0];
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Client_Name_txt.Text = string.Empty;
            string Query = "SELECT * FROM dbo.Clients_tbl;";
            common.ds = common.GetDataSet(Query);
            dgvClients.DataSource = common.ds.Tables[0];
            FillCombo();
        }

        private void FillCombo()
        {
            DataSet dataSet = new DataSet();
            string Query = @"SELECT ' ODABERI' as Pikula
                                UNION ALL
                            SELECT Cast(ClientID as varchar) as Pikula FROM dbo.Clients_tbl ORDER BY Pikula;

SELECT ' ODABERI' as Pikula
                                UNION ALL
                            SELECT Cast(OIB as varchar) as Pikula FROM dbo.Clients_tbl ORDER BY Pikula;

SELECT ' ODABERI' as Pikula
                                UNION ALL
                            SELECT DISTINCT Cast(Address_City as varchar) as Pikula FROM dbo.Clients_tbl ORDER BY Pikula;

";
            dataSet = common.GetDataSet(Query);
            DataTable dt = dataSet.Tables[0];

            cmbClientID.DisplayMember = "Pikula";
            cmbClientID.ValueMember = "Pikula";
            cmbClientID.DataSource = dt;

            DataTable dtA = dataSet.Tables[1];
            cmbOIB.DisplayMember = "Pikula";
            cmbOIB.ValueMember = "Pikula";
            cmbOIB.DataSource = dtA;

            DataTable dtB = dataSet.Tables[2];
            cmbCity.DisplayMember = "Pikula";
            cmbCity.ValueMember = "Pikula";
            cmbCity.DataSource = dtB;

        }

        private void cmbClientID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbClientID.SelectedIndex > 0)
            {
                SearchClient(cmbClientID.Text,null,null);
            }
        }

        private void cmbOIB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOIB.SelectedIndex > 0)
            {
                SearchClient(null, cmbOIB.Text, null);
            }
        }

        private void cmbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCity.SelectedIndex > 0)
            {
                SearchClient(null,null,cmbCity.Text);
            }
        }
    }
}
