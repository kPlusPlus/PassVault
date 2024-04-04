namespace PassVault
{
    partial class Search_PassVault
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
            components = new System.ComponentModel.Container();
            btnClear = new System.Windows.Forms.Button();
            btnExit = new System.Windows.Forms.Button();
            dgvPassVault = new System.Windows.Forms.DataGridView();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            cmbClientID = new System.Windows.Forms.ComboBox();
            label4 = new System.Windows.Forms.Label();
            cmbUsername = new System.Windows.Forms.ComboBox();
            label3 = new System.Windows.Forms.Label();
            cmbClientName = new System.Windows.Forms.ComboBox();
            label2 = new System.Windows.Forms.Label();
            txtDescription = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            bindingSource1 = new System.Windows.Forms.BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dgvPassVault).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // btnClear
            // 
            btnClear.Location = new System.Drawing.Point(687, 16);
            btnClear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(49, 46);
            btnClear.TabIndex = 52;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new System.Drawing.Point(744, 16);
            btnExit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(49, 46);
            btnExit.TabIndex = 51;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // dgvPassVault
            // 
            dgvPassVault.AllowUserToAddRows = false;
            dgvPassVault.AllowUserToDeleteRows = false;
            dgvPassVault.AllowUserToOrderColumns = true;
            dgvPassVault.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dgvPassVault.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dgvPassVault.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dgvPassVault.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPassVault.Location = new System.Drawing.Point(12, 104);
            dgvPassVault.MultiSelect = false;
            dgvPassVault.Name = "dgvPassVault";
            dgvPassVault.Size = new System.Drawing.Size(776, 334);
            dgvPassVault.TabIndex = 50;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.AkdamarLogo2023_100;
            pictureBox1.Location = new System.Drawing.Point(13, 12);
            pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(119, 39);
            pictureBox1.TabIndex = 49;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            label1.Location = new System.Drawing.Point(132, 16);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(173, 24);
            label1.TabIndex = 48;
            label1.Text = "Search PassVault";
            // 
            // cmbClientID
            // 
            cmbClientID.FormattingEnabled = true;
            cmbClientID.Location = new System.Drawing.Point(551, 75);
            cmbClientID.Name = "cmbClientID";
            cmbClientID.Size = new System.Drawing.Size(121, 23);
            cmbClientID.TabIndex = 59;
            cmbClientID.SelectedIndexChanged += cmbClientID_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
            label4.Location = new System.Drawing.Point(575, 52);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(66, 20);
            label4.TabIndex = 58;
            label4.Text = "ClientID";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbUsername
            // 
            cmbUsername.FormattingEnabled = true;
            cmbUsername.Location = new System.Drawing.Point(424, 75);
            cmbUsername.Name = "cmbUsername";
            cmbUsername.Size = new System.Drawing.Size(121, 23);
            cmbUsername.TabIndex = 57;
            cmbUsername.SelectedIndexChanged += cmbUsername_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
            label3.Location = new System.Drawing.Point(448, 52);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(83, 20);
            label3.TabIndex = 56;
            label3.Text = "Username";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbClientName
            // 
            cmbClientName.FormattingEnabled = true;
            cmbClientName.Location = new System.Drawing.Point(13, 75);
            cmbClientName.Name = "cmbClientName";
            cmbClientName.Size = new System.Drawing.Size(121, 23);
            cmbClientName.TabIndex = 55;
            cmbClientName.SelectedIndexChanged += cmbClientName_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
            label2.Location = new System.Drawing.Point(36, 52);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(95, 20);
            label2.TabIndex = 54;
            label2.Text = "Client Name";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDescription
            // 
            txtDescription.Location = new System.Drawing.Point(140, 75);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new System.Drawing.Size(278, 23);
            txtDescription.TabIndex = 60;
            txtDescription.KeyUp += txtDescription_KeyUp;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
            label5.Location = new System.Drawing.Point(229, 52);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(89, 20);
            label5.TabIndex = 61;
            label5.Text = "Description";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Search_PassVault
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(label5);
            Controls.Add(txtDescription);
            Controls.Add(cmbClientID);
            Controls.Add(label4);
            Controls.Add(cmbUsername);
            Controls.Add(label3);
            Controls.Add(cmbClientName);
            Controls.Add(label2);
            Controls.Add(btnClear);
            Controls.Add(btnExit);
            Controls.Add(dgvPassVault);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "Search_PassVault";
            Text = "Search_PassVault";
            ((System.ComponentModel.ISupportInitialize)dgvPassVault).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        public System.Windows.Forms.DataGridView dgvPassVault;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbClientID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbClientName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}