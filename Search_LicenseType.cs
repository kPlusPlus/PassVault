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
    public partial class Search_LicenseType : Form
    {
        private Common common = new Common();
        public int ReturnValue = 0;
        public Search_LicenseType()
        {
            InitializeComponent();
            FillDataGridView();
            FillCombo();
        }

        private void FillDataGridView()
        {
            string Query = "SELECT * FROM dbo.License_Type_tbl;";
            common.ds = common.GetDataSet(Query);

            dgvLicenseType.DataSource = common.ds.Tables[0];

        }

        private void FillCombo()
        {
            DataSet dataSet = new DataSet();
            string Query = @"
-- cmbbox 1
SELECT 0 as ID,' ODABERI' as Name
UNION ALL
SELECT ID,Name FROM dbo.License_Type_tbl ORDER BY Name;
-- cmbbox 2
SELECT 0 as ID,' ODABERI' as Version
UNION ALL
SELECT ID,Version + ' ' + Comment AS Version FROM dbo.License_Type_tbl ORDER BY Version;
";
            dataSet = common.GetDataSet(Query);
            DataTable dt = dataSet.Tables[0];

            cmbName.DisplayMember = "Name";
            cmbName.ValueMember = "ID";
            cmbName.DataSource = dt;

            DataTable dtA = dataSet.Tables[1];
            cmbVersion.DisplayMember = "Version";
            cmbVersion.ValueMember = "ID";
            cmbVersion.DataSource = dtA;

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

        private void cmbName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbName.SelectedIndex > 0)
            {
                SearchClient(cmbName.SelectedValue.ToString());
            }
            else if (cmbName.SelectedIndex == 0)
            {
                btnClear_Click(sender, e);
            }
        }

        private void cmbVersion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbVersion.SelectedIndex > 0)
            {
                SearchClient(cmbVersion.SelectedValue.ToString());
            }
            else if (cmbVersion.SelectedIndex == 0)
            {
                btnClear_Click(sender, e);
            }
        }

        private void SearchClient(String SearchByLicenseTypeID = null)
        {
            bool bWhere = false;
            string sWhere = string.Empty;
            string Query = "SELECT * FROM dbo.License_Type_tbl";

            if (txtComment.Text != string.Empty)
            {
                bWhere = true;
                sWhere = "Comment LIKE '%" + txtComment.Text + "%'";
            }
            else if (SearchByLicenseTypeID != null)
            {
                bWhere = true;
                sWhere = "ID = " + SearchByLicenseTypeID;
            }

            if (bWhere)
            {
                Query += " WHERE " + sWhere;
                common.ds = common.GetDataSet(Query);
                dgvLicenseType.DataSource = common.ds.Tables[0];
            }

        }

        private void txtComment_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchClient();
            }
        }

        private void dgvLicenseType_DoubleClick(object sender, EventArgs e)
        {
            if (dgvLicenseType.SelectedRows.Count > 0)
            {
                ReturnValue = int.Parse(dgvLicenseType.SelectedRows[0].Cells["ID"].Value.ToString());
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
