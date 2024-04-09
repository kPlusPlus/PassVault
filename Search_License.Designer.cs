namespace PassVault
{
    partial class Search_License
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search_License));
            txtMAC = new System.Windows.Forms.TextBox();
            cmbClientName = new System.Windows.Forms.ComboBox();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            cmbLicenseType = new System.Windows.Forms.ComboBox();
            label2 = new System.Windows.Forms.Label();
            btnClear = new System.Windows.Forms.Button();
            btnExit = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            dgvLicense = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvLicense).BeginInit();
            SuspendLayout();
            // 
            // txtMAC
            // 
            txtMAC.Location = new System.Drawing.Point(311, 75);
            txtMAC.Name = "txtMAC";
            txtMAC.Size = new System.Drawing.Size(278, 23);
            txtMAC.TabIndex = 72;
            // 
            // cmbClientName
            // 
            cmbClientName.FormattingEnabled = true;
            cmbClientName.Location = new System.Drawing.Point(145, 75);
            cmbClientName.Name = "cmbClientName";
            cmbClientName.Size = new System.Drawing.Size(160, 23);
            cmbClientName.TabIndex = 71;
            cmbClientName.SelectedIndexChanged += cmbClientName_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
            label4.Location = new System.Drawing.Point(178, 52);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(95, 20);
            label4.TabIndex = 70;
            label4.Text = "Client Name";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
            label3.Location = new System.Drawing.Point(428, 52);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(44, 20);
            label3.TabIndex = 68;
            label3.Text = "MAC";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbLicenseType
            // 
            cmbLicenseType.FormattingEnabled = true;
            cmbLicenseType.Location = new System.Drawing.Point(13, 75);
            cmbLicenseType.Name = "cmbLicenseType";
            cmbLicenseType.Size = new System.Drawing.Size(121, 23);
            cmbLicenseType.TabIndex = 67;
            cmbLicenseType.SelectedIndexChanged += cmbLicenseType_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
            label2.Location = new System.Drawing.Point(22, 52);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(102, 20);
            label2.TabIndex = 66;
            label2.Text = "License Type";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnClear
            // 
            btnClear.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnClear.Location = new System.Drawing.Point(687, 16);
            btnClear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(49, 46);
            btnClear.TabIndex = 65;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnExit.Location = new System.Drawing.Point(744, 16);
            btnExit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(49, 46);
            btnExit.TabIndex = 64;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.AkdamarLogo2023_100;
            pictureBox1.Location = new System.Drawing.Point(13, 12);
            pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(119, 39);
            pictureBox1.TabIndex = 63;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            label1.Location = new System.Drawing.Point(132, 16);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(155, 24);
            label1.TabIndex = 62;
            label1.Text = "Search License";
            // 
            // dgvLicense
            // 
            dgvLicense.AllowUserToAddRows = false;
            dgvLicense.AllowUserToDeleteRows = false;
            dgvLicense.AllowUserToOrderColumns = true;
            dgvLicense.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dgvLicense.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dgvLicense.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dgvLicense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLicense.Location = new System.Drawing.Point(12, 104);
            dgvLicense.MultiSelect = false;
            dgvLicense.Name = "dgvLicense";
            dgvLicense.Size = new System.Drawing.Size(776, 334);
            dgvLicense.TabIndex = 73;
            dgvLicense.DoubleClick += dgvLicense_DoubleClick;
            // 
            // Search_License
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(dgvLicense);
            Controls.Add(txtMAC);
            Controls.Add(cmbClientName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cmbLicenseType);
            Controls.Add(label2);
            Controls.Add(btnClear);
            Controls.Add(btnExit);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "Search_License";
            Text = "Search_License";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvLicense).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.TextBox txtMAC;
        private System.Windows.Forms.ComboBox cmbClientName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbLicenseType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dgvLicense;
    }
}