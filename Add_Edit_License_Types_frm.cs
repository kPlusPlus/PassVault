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
    public partial class Add_Edit_License_Types_frm : Form
    {
        private Common common = new Common();
        public Add_Edit_License_Types_frm()
        {
            InitializeComponent();
            FillDataGridView();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FillDataGridView()
        {
            string Query = "SELECT * FROM dbo.License_Type_tbl;";
            common.ds = common.GetDataSet(Query);

            bindingSource1.DataSource = common.ds;
            bindingSource1.DataMember = common.ds.Tables[0].TableName;
            dgvLicenceType.DataSource = bindingSource1;

            OdbcCommandBuilder updateCommand = new OdbcCommandBuilder(common.adapter);
            common.adapter.UpdateCommand = updateCommand.GetUpdateCommand();
            OdbcCommandBuilder insertCommand = new OdbcCommandBuilder(common.adapter);
            common.adapter.InsertCommand = insertCommand.GetInsertCommand();
            OdbcCommandBuilder deleteCommand = new OdbcCommandBuilder(common.adapter);
            common.adapter.DeleteCommand = deleteCommand.GetDeleteCommand();

            ID_txt.DataBindings.Add("Text", bindingSource1, "ID");
            Name_txt.DataBindings.Add("Text", bindingSource1, "Name");
            Version_txt.DataBindings.Add("Text", bindingSource1, "Version");
            Comment_txt.DataBindings.Add("Text", bindingSource1, "Comment");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                bindingSource1.EndEdit();
                common.adapter.Update(common.ds, common.ds.Tables[0].TableName);
                MessageBox.Show("Data saved successfully. ");
                dgvLicenceType.Refresh();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dgvLicenceType.ClearSelection();
            if (dgvLicenceType.Rows.Count > 0)
            {
                int lastIndex = dgvLicenceType.Rows.Count - 1;
                dgvLicenceType.Rows[lastIndex].Selected = true;
                dgvLicenceType.CurrentCell = dgvLicenceType.Rows[lastIndex].Cells[0];
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bindingSource1.CancelEdit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            dgvLicenceType.ClearSelection();
            if (dgvLicenceType.Rows.Count > 0)
            {
                dgvLicenceType.Rows[0].Selected = true;
                dgvLicenceType.CurrentCell = dgvLicenceType.Rows[0].Cells[0];
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (dgvLicenceType.CurrentRow != null)
            {
                int currentIndex = dgvLicenceType.CurrentRow.Index;
                int previousIndex = currentIndex - 1;

                if (previousIndex >= 0)
                {
                    dgvLicenceType.ClearSelection();
                    dgvLicenceType.Rows[previousIndex].Selected = true;
                    dgvLicenceType.CurrentCell = dgvLicenceType.Rows[previousIndex].Cells[0];
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int currentRowIndex = dgvLicenceType.CurrentRow.Index;
            int nextIndex = currentRowIndex + 1;

            if (nextIndex < dgvLicenceType.Rows.Count)
            {
                dgvLicenceType.ClearSelection();
                dgvLicenceType.Rows[nextIndex].Selected = true;
                dgvLicenceType.CurrentCell = dgvLicenceType.Rows[nextIndex].Cells[0];
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dgvLicenceType.ClearSelection();
            if (dgvLicenceType.Rows.Count > 0)
            {
                int lastIndex = dgvLicenceType.Rows.Count - 2;
                dgvLicenceType.Rows[lastIndex].Selected = true;
                dgvLicenceType.CurrentCell = dgvLicenceType.Rows[lastIndex].Cells[0];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
