﻿namespace PassVault
{
    partial class Search_LicenseType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search_LicenseType));
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            btnClear = new System.Windows.Forms.Button();
            btnExit = new System.Windows.Forms.Button();
            label5 = new System.Windows.Forms.Label();
            txtComment = new System.Windows.Forms.TextBox();
            cmbVersion = new System.Windows.Forms.ComboBox();
            label4 = new System.Windows.Forms.Label();
            cmbName = new System.Windows.Forms.ComboBox();
            label2 = new System.Windows.Forms.Label();
            dgvLicenseType = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvLicenseType).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.AkdamarLogo2023_100;
            pictureBox1.Location = new System.Drawing.Point(13, 12);
            pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(119, 39);
            pictureBox1.TabIndex = 67;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            label1.Location = new System.Drawing.Point(132, 16);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(208, 24);
            label1.TabIndex = 66;
            label1.Text = "Search License Type";
            // 
            // btnClear
            // 
            btnClear.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnClear.Location = new System.Drawing.Point(681, 12);
            btnClear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(49, 46);
            btnClear.TabIndex = 69;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnExit.Location = new System.Drawing.Point(738, 12);
            btnExit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(49, 46);
            btnExit.TabIndex = 68;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
            label5.Location = new System.Drawing.Point(446, 65);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(78, 20);
            label5.TabIndex = 81;
            label5.Text = "Comment";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtComment
            // 
            txtComment.Location = new System.Drawing.Point(357, 88);
            txtComment.Name = "txtComment";
            txtComment.Size = new System.Drawing.Size(278, 23);
            txtComment.TabIndex = 80;
            txtComment.KeyUp += txtComment_KeyUp;
            // 
            // cmbVersion
            // 
            cmbVersion.FormattingEnabled = true;
            cmbVersion.Location = new System.Drawing.Point(144, 88);
            cmbVersion.Name = "cmbVersion";
            cmbVersion.Size = new System.Drawing.Size(207, 23);
            cmbVersion.TabIndex = 79;
            cmbVersion.SelectedIndexChanged += cmbVersion_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
            label4.Location = new System.Drawing.Point(216, 65);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(63, 20);
            label4.TabIndex = 78;
            label4.Text = "Version";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbName
            // 
            cmbName.FormattingEnabled = true;
            cmbName.Location = new System.Drawing.Point(14, 88);
            cmbName.Name = "cmbName";
            cmbName.Size = new System.Drawing.Size(121, 23);
            cmbName.TabIndex = 77;
            cmbName.SelectedIndexChanged += cmbName_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
            label2.Location = new System.Drawing.Point(37, 65);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(51, 20);
            label2.TabIndex = 76;
            label2.Text = "Name";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvLicenseType
            // 
            dgvLicenseType.AllowUserToAddRows = false;
            dgvLicenseType.AllowUserToDeleteRows = false;
            dgvLicenseType.AllowUserToOrderColumns = true;
            dgvLicenseType.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dgvLicenseType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dgvLicenseType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dgvLicenseType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLicenseType.Location = new System.Drawing.Point(14, 117);
            dgvLicenseType.MultiSelect = false;
            dgvLicenseType.Name = "dgvLicenseType";
            dgvLicenseType.Size = new System.Drawing.Size(774, 321);
            dgvLicenseType.TabIndex = 82;
            dgvLicenseType.DoubleClick += dgvLicenseType_DoubleClick;
            // 
            // Search_LicenseType
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(dgvLicenseType);
            Controls.Add(label5);
            Controls.Add(txtComment);
            Controls.Add(cmbVersion);
            Controls.Add(label4);
            Controls.Add(cmbName);
            Controls.Add(label2);
            Controls.Add(btnClear);
            Controls.Add(btnExit);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "Search_LicenseType";
            Text = "Search_LicenseType";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvLicenseType).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.ComboBox cmbVersion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbName;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView dgvLicenseType;
    }
}