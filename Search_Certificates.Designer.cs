namespace PassVault
{
    partial class Search_Certificates
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
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            btnClear = new System.Windows.Forms.Button();
            btnExit = new System.Windows.Forms.Button();
            label5 = new System.Windows.Forms.Label();
            txtComment = new System.Windows.Forms.TextBox();
            cmbAddress = new System.Windows.Forms.ComboBox();
            label4 = new System.Windows.Forms.Label();
            cmbClientName = new System.Windows.Forms.ComboBox();
            label2 = new System.Windows.Forms.Label();
            dgvCertificates = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCertificates).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.AkdamarLogo2023_100;
            pictureBox1.Location = new System.Drawing.Point(13, 12);
            pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(119, 39);
            pictureBox1.TabIndex = 65;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            label1.Location = new System.Drawing.Point(132, 16);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(184, 24);
            label1.TabIndex = 64;
            label1.Text = "Search Certificates";
            // 
            // btnClear
            // 
            btnClear.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnClear.Location = new System.Drawing.Point(681, 12);
            btnClear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(49, 46);
            btnClear.TabIndex = 67;
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
            btnExit.TabIndex = 66;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
            label5.Location = new System.Drawing.Point(360, 54);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(78, 20);
            label5.TabIndex = 75;
            label5.Text = "Comment";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtComment
            // 
            txtComment.Location = new System.Drawing.Point(271, 77);
            txtComment.Name = "txtComment";
            txtComment.Size = new System.Drawing.Size(278, 23);
            txtComment.TabIndex = 74;
            // 
            // cmbAddress
            // 
            cmbAddress.FormattingEnabled = true;
            cmbAddress.Location = new System.Drawing.Point(144, 77);
            cmbAddress.Name = "cmbAddress";
            cmbAddress.Size = new System.Drawing.Size(121, 23);
            cmbAddress.TabIndex = 73;
            cmbAddress.SelectedIndexChanged += cmbAddress_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
            label4.Location = new System.Drawing.Point(168, 54);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(68, 20);
            label4.TabIndex = 72;
            label4.Text = "Address";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbClientName
            // 
            cmbClientName.FormattingEnabled = true;
            cmbClientName.Location = new System.Drawing.Point(14, 77);
            cmbClientName.Name = "cmbClientName";
            cmbClientName.Size = new System.Drawing.Size(121, 23);
            cmbClientName.TabIndex = 69;
            cmbClientName.SelectedIndexChanged += cmbClientName_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
            label2.Location = new System.Drawing.Point(37, 54);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(95, 20);
            label2.TabIndex = 68;
            label2.Text = "Client Name";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvCertificates
            // 
            dgvCertificates.AllowUserToAddRows = false;
            dgvCertificates.AllowUserToDeleteRows = false;
            dgvCertificates.AllowUserToOrderColumns = true;
            dgvCertificates.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dgvCertificates.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dgvCertificates.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dgvCertificates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCertificates.Location = new System.Drawing.Point(14, 106);
            dgvCertificates.MultiSelect = false;
            dgvCertificates.Name = "dgvCertificates";
            dgvCertificates.Size = new System.Drawing.Size(773, 332);
            dgvCertificates.TabIndex = 76;
            dgvCertificates.DoubleClick += dgvCertificates_DoubleClick;
            // 
            // Search_Certificates
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(dgvCertificates);
            Controls.Add(label5);
            Controls.Add(txtComment);
            Controls.Add(cmbAddress);
            Controls.Add(label4);
            Controls.Add(cmbClientName);
            Controls.Add(label2);
            Controls.Add(btnClear);
            Controls.Add(btnExit);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "Search_Certificates";
            Text = "Search_Certificates";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCertificates).EndInit();
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
        private System.Windows.Forms.ComboBox cmbAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbClientName;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView dgvCertificates;
    }
}