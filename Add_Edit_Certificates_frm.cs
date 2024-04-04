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
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PassVault
{
    public partial class Add_Edit_Certificates_frm : Form
    {
        private Common common = new Common();
        public Add_Edit_Certificates_frm()
        {
            InitializeComponent();

            FillCombo();
            FillDataGridView();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bindingSource1.CancelEdit();
        }

        private void FillDataGridView()
        {
            string Query = "SELECT * FROM dbo.Cert_tbl";
            common.ds = common.GetDataSet(Query);

            bindingSource1.DataSource = common.ds;
            bindingSource1.DataMember = common.ds.Tables[0].TableName;
            dgvCertificates.DataSource = bindingSource1;

            OdbcCommandBuilder updateCommand = new OdbcCommandBuilder(common.adapter);
            common.adapter.UpdateCommand = updateCommand.GetUpdateCommand();
            OdbcCommandBuilder insertCommand = new OdbcCommandBuilder(common.adapter);
            common.adapter.InsertCommand = insertCommand.GetInsertCommand();
            OdbcCommandBuilder deleteCommand = new OdbcCommandBuilder(common.adapter);
            common.adapter.DeleteCommand = deleteCommand.GetDeleteCommand();

            ID_txt.DataBindings.Add("Text", bindingSource1, "ID");
            dtpCreated.DataBindings.Add("Text", bindingSource1, "Date");
            //OIB_txt.DataBindings.Add("Text", bindingSource1, "Client");
            CliendID_txt.DataBindings.Add("Text", bindingSource1, "Client");
            City_txt.DataBindings.Add("Text", bindingSource1, "Address");
            CertPass_txt.DataBindings.Add("Text", bindingSource1, "CertPass");
            PfxPass_txt.DataBindings.Add("Text", bindingSource1, "PfxPass");
            dtpExpire.DataBindings.Add("Text", bindingSource1, "DateExp");
            Comment_txt.DataBindings.Add("Text", bindingSource1, "Comment");

        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                bindingSource1.EndEdit();
                common.adapter.Update(common.ds, common.ds.Tables[0].TableName);
                MessageBox.Show("Data saved successfully. ");
                dgvCertificates.Refresh();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dgvCertificates.ClearSelection();
            if (dgvCertificates.Rows.Count > 0)
            {
                int lastIndex = dgvCertificates.Rows.Count - 1;
                dgvCertificates.Rows[lastIndex].Selected = true;
                dgvCertificates.CurrentCell = dgvCertificates.Rows[lastIndex].Cells[0];
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            bindingSource1.CancelEdit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            dgvCertificates.ClearSelection();
            if (dgvCertificates.Rows.Count > 0)
            {
                dgvCertificates.Rows[0].Selected = true;
                dgvCertificates.CurrentCell = dgvCertificates.Rows[0].Cells[0];
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (dgvCertificates.CurrentRow != null)
            {
                int currentIndex = dgvCertificates.CurrentRow.Index;
                int previousIndex = currentIndex - 1;

                if (previousIndex >= 0)
                {
                    dgvCertificates.ClearSelection();
                    dgvCertificates.Rows[previousIndex].Selected = true;
                    dgvCertificates.CurrentCell = dgvCertificates.Rows[previousIndex].Cells[0];
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (dgvCertificates.CurrentRow == null)
            {
                DataGridViewRow row = dgvCertificates.Rows[0];
                dgvCertificates.ClearSelection();
                row.Selected = true;
                dgvCertificates.FirstDisplayedScrollingRowIndex = row.Index;
                row.Cells[0].Selected = true;
            }
            int currentRowIndex = dgvCertificates.CurrentRow.Index;
            int nextIndex = currentRowIndex + 1;

            if (nextIndex < dgvCertificates.Rows.Count)
            {
                dgvCertificates.ClearSelection();
                dgvCertificates.Rows[nextIndex].Selected = true;
                dgvCertificates.CurrentCell = dgvCertificates.Rows[nextIndex].Cells[0];
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dgvCertificates.ClearSelection();
            if (dgvCertificates.Rows.Count > 0)
            {
                int lastIndex = dgvCertificates.Rows.Count - 2;
                dgvCertificates.Rows[lastIndex].Selected = true;
                dgvCertificates.CurrentCell = dgvCertificates.Rows[lastIndex].Cells[0];
            }
        }

        private void FillCombo()
        {
            DataSet dataSet = new DataSet();
            string Query = "SELECT * FROM dbo.Clients_tbl ORDER BY Name;";
            dataSet = common.GetDataSet(Query);
            DataTable dt = dataSet.Tables[0];

            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "ClientID";
            comboBox1.DataSource = dt;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > -1)
            {
                CliendID_txt.Text = comboBox1.SelectedValue.ToString();
            }
        }

        private void bindingSource1_PositionChanged(object sender, EventArgs e)
        {
            if (CliendID_txt.Text != string.Empty)
            {
                comboBox1.SelectedValue = CliendID_txt.Text;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Search_Certificates search_Certificates = new Search_Certificates();
            if (search_Certificates.ShowDialog() == DialogResult.OK)
            {
                int returnValue = search_Certificates.ReturnValue;
                SelectRowByValue("ID", returnValue.ToString());
            }
        }

        private void SelectRowByValue(string columnName, string value)
        {
            foreach (DataGridViewRow row in dgvCertificates.Rows)
            {
                if (row.Cells[columnName].Value != null && row.Cells[columnName].Value.ToString() == value)
                {
                    dgvCertificates.ClearSelection();
                    row.Selected = true;
                    dgvCertificates.FirstDisplayedScrollingRowIndex = row.Index;
                    row.Cells[0].Selected = true;
                    break;
                }
            }
        }

    }
}
