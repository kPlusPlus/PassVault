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
    public partial class Search_Certificates : Form
    {
        private Common common = new Common();
        public int ReturnValue = 0;
        public Search_Certificates()
        {
            InitializeComponent();
            FillDataGridView();
            FillCombo();
        }

        private void FillDataGridView()
        {
            string Query = "SELECT * FROM dbo.Cert_tbl;";
            common.ds = common.GetDataSet(Query);

            dgvCertificates.DataSource = common.ds.Tables[0];

        }

        private void FillCombo()
        {
            DataSet dataSet = new DataSet();
            string Query = @"
-- cmbbox 1
SELECT 0 as ClientID,' ODABERI' as Name
UNION ALL
SELECT ClientID,Name FROM dbo.Clients_tbl ORDER BY Name;
-- cmbbox 2
SELECT 0 as ID,' ODABERI' as Address
UNION ALL
SELECT ID,Address FROM dbo.Cert_tbl ORDER BY Address;
";
            dataSet = common.GetDataSet(Query);
            DataTable dt = dataSet.Tables[0];

            cmbClientName.DisplayMember = "Name";
            cmbClientName.ValueMember = "ClientID";
            cmbClientName.DataSource = dt;

            DataTable dtA = dataSet.Tables[1];
            cmbAddress.DisplayMember = "Address";
            cmbAddress.ValueMember = "ID";
            cmbAddress.DataSource = dtA;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtComment.Text = string.Empty;
            FillDataGridView();
            FillCombo();
        }

        private void SearchClient(String SearchByClientID = null, String SearchByAddress = null, String SearchByCity = null)
        {
            bool bWhere = false;
            string sWhere = string.Empty;
            string Query = "SELECT * FROM dbo.Cert_tbl";

            if (txtComment.Text != string.Empty)
            {
                bWhere = true;
                sWhere = "Comment LIKE '%" + txtComment.Text + "%'";
            }
            else if (SearchByClientID != null)
            {
                bWhere = true;
                sWhere = "Client = " + SearchByClientID;
            }
            else if (SearchByAddress != null)
            {
                bWhere = true;
                sWhere = "ID = " + SearchByAddress;
            }

            if (bWhere)
            {
                Query += " WHERE " + sWhere;
                common.ds = common.GetDataSet(Query);
                dgvCertificates.DataSource = common.ds.Tables[0];
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

        private void cmbAddress_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAddress.SelectedIndex > 0)
            {
                SearchClient(cmbAddress.SelectedValue.ToString());
            }
            else if (cmbAddress.SelectedIndex == 0)
            {
                btnClear_Click(sender, e);
            }

        }

        private void dgvCertificates_DoubleClick(object sender, EventArgs e)
        {
            if (dgvCertificates.SelectedRows.Count > 0)
            {
                ReturnValue = int.Parse(dgvCertificates.SelectedRows[0].Cells["ID"].Value.ToString());
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
