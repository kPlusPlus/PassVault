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
    public partial class Search_License : Form
    {
        private Common common = new Common();
        public int ReturnValue = 0;
        public Search_License()
        {
            InitializeComponent();
            FillDataGridView();
            FillCombo();
        }

        private void FillDataGridView()
        {
            string Query = "SELECT * FROM dbo.Licenses_tbl;";
            common.ds = common.GetDataSet(Query);

            dgvLicense.DataSource = common.ds.Tables[0];
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FillCombo()
        {
            DataSet dataSet = new DataSet();
            string Query = @"
-- cmbbox 1
SELECT 0 as ID,' ODABERI' as Name
UNION ALL
SELECT ID, Name + ' ' + Version + '  ' + Comment as Name FROM dbo.License_Type_tbl;
-- cmbbox 2
SELECT 0 as ClientID,' ODABERI' as Name
UNION ALL
select ClientID,Name from dbo.Clients_tbl ORDER BY Name;
";
            dataSet = common.GetDataSet(Query);
            DataTable dt = dataSet.Tables[0];

            cmbLicenseType.DisplayMember = "Name";
            cmbLicenseType.ValueMember = "ID";
            cmbLicenseType.DataSource = dt;

            DataTable dtA = dataSet.Tables[1];
            cmbClientName.DisplayMember = "Name";
            cmbClientName.ValueMember = "ClientID";
            cmbClientName.DataSource = dtA;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMAC.Text = String.Empty;
            FillDataGridView();
            FillCombo();
        }

        private void SearchClient(String SearchByClientID = null, String SearchByLicenseType = null)
        {
            bool bWhere = false;
            string sWhere = string.Empty;
            string Query = "SELECT * FROM dbo.Licenses_tbl";

            if (txtMAC.Text != string.Empty)
            {
                bWhere = true;
                sWhere = "MAC LIKE '%" + txtMAC.Text + "%'";
            }
            else if (SearchByClientID != null)
            {
                bWhere = true;
                sWhere = "ClientID = " + SearchByClientID;
            }
            else if (SearchByLicenseType != null)
            {
                bWhere = true;
                sWhere = "TypeID = " + SearchByLicenseType;
            }

            if (bWhere)
            {
                Query += " WHERE " + sWhere;
                common.ds = common.GetDataSet(Query);
                dgvLicense.DataSource = common.ds.Tables[0];
            }

        }

        private void cmbLicenseType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLicenseType.SelectedIndex > 0)
            {
                SearchClient(null, cmbLicenseType.SelectedValue.ToString());
            }
            else if (cmbLicenseType.SelectedIndex == 0)
            {
                btnClear_Click(sender, e);
            }
        }

        private void cmbClientName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbClientName.SelectedIndex > 0)
            {
                SearchClient(cmbClientName.SelectedValue.ToString(), null);
            }
            else if (cmbClientName.SelectedIndex == 0)
            {
                btnClear_Click(sender, e);
            }
        }

        private void dgvLicense_DoubleClick(object sender, EventArgs e)
        {
            if (dgvLicense.SelectedRows.Count > 0)
            {
                ReturnValue = int.Parse(dgvLicense.SelectedRows[0].Cells[0].Value.ToString());
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
