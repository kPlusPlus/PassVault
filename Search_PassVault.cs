using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassVault
{
    public partial class Search_PassVault : Form
    {
        private Common common = new Common();
        public int ReturnValue = 0;
        public Search_PassVault()
        {
            InitializeComponent();
            FillDataGridView();
            FillCombo();
        }

        private void FillDataGridView()
        {            
            string Query = "SELECT * FROM dbo.PassVault_tbl WHERE AL <= " + Globals.Access_Level.Trim() + " ;";
            common.ds = common.GetDataSet(Query);

            dgvPassVault.DataSource = common.ds.Tables[0];
        }

        private void FillCombo()
        {
            DataSet dataSet = new DataSet();
            string Query = @"
-- cmbbox 1
SELECT 0 as ClientID,' ODABERI' as Name
UNION ALL
SELECT ClientID,Name FROM dbo.Clients_tbl 
WHERE ClientID IN (SELECT ClientID FROM dbo.PassVault_tbl WHERE AL <= " + Globals.Access_Level.Trim() + @")
ORDER BY Name;
-- cmbbox 2
SELECT 0 as ID,' ODABERI' as [Username]
UNION ALL
SELECT ID,[Username] FROM dbo.PassVault_tbl 
WHERE ID IN (SELECT ID FROM dbo.PassVault_tbl WHERE AL <= " + Globals.Access_Level.Trim() + @")
ORDER BY [Username];
-- cmbbox 3
SELECT 0 as ClientID,' ODABERI' as Name
UNION ALL
SELECT ClientID, CAST(ClientID as varchar) + '   ' + Name as Name  FROM dbo.Clients_tbl 
WHERE ClientID IN (SELECT ClientID FROM dbo.PassVault_tbl WHERE AL <= " + Globals.Access_Level.Trim() + @")
ORDER BY Name;
";
            dataSet = common.GetDataSet(Query);
            DataTable dt = dataSet.Tables[0];

            cmbClientName.DisplayMember = "Name";
            cmbClientName.ValueMember = "ClientID";
            cmbClientName.DataSource = dt;

            DataTable dtA = dataSet.Tables[1];
            cmbUsername.DisplayMember = "Username";
            cmbUsername.ValueMember = "ID";
            cmbUsername.DataSource = dtA;

            DataTable dtB = dataSet.Tables[2];
            cmbClientID.DisplayMember = "Name";
            cmbClientID.ValueMember = "ClientID";
            cmbClientID.DataSource = dtB;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDescription.Text = string.Empty;
            FillDataGridView();
            FillCombo();
        }

        private void txtDescription_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchClient();
            }
        }

        private void SearchClient(String SearchByClientID = null, String SearchByUserName = null, String SearchByCity = null)
        {
            bool bWhere = false;
            string sWhere = string.Empty;
            string Query = "SELECT * FROM dbo.PassVault_tbl";

            if (txtDescription.Text != string.Empty)
            {
                bWhere = true;
                sWhere = "Description LIKE '%" + txtDescription.Text + "%'";
            }
            else if (SearchByClientID != null)
            {
                bWhere = true;
                sWhere = "ClientID = " + SearchByClientID;
            }
            else if (SearchByUserName != null)
            {
                bWhere = true;
                sWhere = "ID = " + SearchByUserName;
            }
            else if (SearchByCity != null)
            {
                bWhere = true;
                sWhere = "Address_City = '" + SearchByCity + "'";
            }

            if (bWhere)
            {
                Query += " WHERE " + sWhere;
                Query += " AND AL <= " + Globals.Access_Level.Trim() + "; ";
                common.ds = common.GetDataSet(Query);
                dgvPassVault.DataSource = common.ds.Tables[0];
            }

        }

        private void cmbClientName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbClientName.SelectedIndex > 0)
            {
                SearchClient(cmbClientName.SelectedValue.ToString());
            }
            else if (cmbClientName.SelectedIndex == 0)
            {
                btnClear_Click(sender, e);
            }
        }

        private void cmbUsername_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUsername.SelectedIndex > 0)
            {
                SearchClient(null, cmbUsername.SelectedValue.ToString(), null);
            }
            else if (cmbUsername.SelectedIndex == 0)
            {
                btnClear_Click(sender, e);
            }
        }

        private void cmbClientID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbClientID.SelectedIndex > 0)
            {
                SearchClient(cmbClientID.SelectedValue.ToString(), null, null);
            }
            else if (cmbClientID.SelectedIndex == 0)
            {
                btnClear_Click(sender, e);
            }
        }

        private void dgvPassVault_DoubleClick(object sender, EventArgs e)
        {
            if (dgvPassVault.SelectedRows.Count > 0)
            {
                ReturnValue = int.Parse(dgvPassVault.SelectedRows[0].Cells[0].Value.ToString());
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
