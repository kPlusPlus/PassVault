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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PassVault
{
    public partial class Add_Edit_License : Form
    {
        private Common common = new Common();
        public Add_Edit_License()
        {
            InitializeComponent();
            FillCombo();
            FillDataGridView();
        }

        private void FillDataGridView()
        {
            string Query = "SELECT * FROM dbo.Licenses_tbl;";
            common.ds = common.GetDataSet(Query);

            bindingSource1.DataSource = common.ds;
            bindingSource1.DataMember = common.ds.Tables[0].TableName;
            dgvLicence.DataSource = bindingSource1;

            OdbcCommandBuilder updateCommand = new OdbcCommandBuilder(common.adapter);
            common.adapter.UpdateCommand = updateCommand.GetUpdateCommand();
            OdbcCommandBuilder insertCommand = new OdbcCommandBuilder(common.adapter);
            common.adapter.InsertCommand = insertCommand.GetInsertCommand();
            OdbcCommandBuilder deleteCommand = new OdbcCommandBuilder(common.adapter);
            common.adapter.DeleteCommand = deleteCommand.GetDeleteCommand();

            ID_txt.DataBindings.Add("Text", bindingSource1, "ID");
            ClientID_txt.DataBindings.Add("Text", bindingSource1, "ClientID");
            LicenseTypeID_txt.DataBindings.Add("Text", bindingSource1, "TypeID");
            Installkey_txt.DataBindings.Add("Text", bindingSource1, "InstallKey");
            AuthKey_txt.DataBindings.Add("Text", bindingSource1, "AuthKey");
            UserName_txt.DataBindings.Add("Text", bindingSource1, "Username");
            DeviceName_txt.DataBindings.Add("Text", bindingSource1, "DeviceName");
            MAC_txt.DataBindings.Add("Text", bindingSource1, "MAC");
            Comment_txt.DataBindings.Add("Text", bindingSource1, "Comment");
            dtpDatum.DataBindings.Add("Text", bindingSource1, "Datum");
        }

        private void FillCombo()
        {
            DataSet dataSet = new DataSet();
            string Query = @"SELECT Name,ID FROM dbo.License_Type_tbl;
                            SELECT ClientID,Name FROM dbo.Clients_tbl ORDER BY Name;
";
            dataSet = common.GetDataSet(Query);
            DataTable dt = dataSet.Tables[0];

            cmbLicenceType.DisplayMember = "Name";
            cmbLicenceType.ValueMember = "ID";
            cmbLicenceType.DataSource = dt;

            DataTable dtA = dataSet.Tables[1];
            cmbClientID.DisplayMember = "Name";
            cmbClientID.ValueMember = "ClientID";
            cmbClientID.DataSource = dtA;
        }

        private void cmbLicenceType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLicenceType.SelectedIndex > -1)
            {
                LicenseTypeID_txt.Text = cmbLicenceType.SelectedValue.ToString();
            }

        }

        private void cmbClientID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbClientID.SelectedIndex > -1)
            {
                ClientID_txt.Text = cmbClientID.SelectedValue.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                bindingSource1.EndEdit();
                common.adapter.Update(common.ds, common.ds.Tables[0].TableName);
                MessageBox.Show("Data saved successfully. ");
                dgvLicence.Refresh();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dgvLicence.ClearSelection();
            if (dgvLicence.Rows.Count > 0)
            {
                int lastIndex = dgvLicence.Rows.Count - 1;
                dgvLicence.Rows[lastIndex].Selected = true;
                dgvLicence.CurrentCell = dgvLicence.Rows[lastIndex].Cells[0];
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            dgvLicence.ClearSelection();
            if (dgvLicence.Rows.Count > 0)
            {
                dgvLicence.Rows[0].Selected = true;
                dgvLicence.CurrentCell = dgvLicence.Rows[0].Cells[0];
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bindingSource1.CancelEdit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (dgvLicence.CurrentRow != null)
            {
                int currentIndex = dgvLicence.CurrentRow.Index;
                int previousIndex = currentIndex - 1;

                if (previousIndex >= 0)
                {
                    dgvLicence.ClearSelection();
                    dgvLicence.Rows[previousIndex].Selected = true;
                    dgvLicence.CurrentCell = dgvLicence.Rows[previousIndex].Cells[0];
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (dgvLicence.CurrentRow == null)
            {
                DataGridViewRow row = dgvLicence.Rows[0];
                dgvLicence.ClearSelection();
                row.Selected = true;
                dgvLicence.FirstDisplayedScrollingRowIndex = row.Index;
                row.Cells[0].Selected = true;
            }
            int currentRowIndex = dgvLicence.CurrentRow.Index;
            int nextIndex = currentRowIndex + 1;

            if (nextIndex < dgvLicence.Rows.Count)
            {
                dgvLicence.ClearSelection();
                dgvLicence.Rows[nextIndex].Selected = true;
                dgvLicence.CurrentCell = dgvLicence.Rows[nextIndex].Cells[0];
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dgvLicence.ClearSelection();
            if (dgvLicence.Rows.Count > 0)
            {
                int lastIndex = dgvLicence.Rows.Count - 2;
                dgvLicence.Rows[lastIndex].Selected = true;
                dgvLicence.CurrentCell = dgvLicence.Rows[lastIndex].Cells[0];
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bindingSource1_PositionChanged(object sender, EventArgs e)
        {
            if (LicenseTypeID_txt.Text != string.Empty)
            {
                cmbLicenceType.SelectedValue = LicenseTypeID_txt.Text;
            }

            if (ClientID_txt.Text != string.Empty)
            {
                cmbClientID.SelectedValue = ClientID_txt.Text;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Search_License search_License = new Search_License();
            if (search_License.ShowDialog() == DialogResult.OK)
            {
                int returnValue = search_License.ReturnValue;
                SelectRowByValue("ID", returnValue.ToString());
            }
        }

        private void SelectRowByValue(string columnName, string value)
        {
            foreach (DataGridViewRow row in dgvLicence.Rows)
            {
                if (row.Cells[columnName].Value != null && row.Cells[columnName].Value.ToString() == value)
                {
                    dgvLicence.ClearSelection();
                    row.Selected = true;
                    dgvLicence.FirstDisplayedScrollingRowIndex = row.Index;
                    row.Cells[0].Selected = true;
                    break;
                }
            }
        }
    }
}
