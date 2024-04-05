namespace PassVault
{
    partial class Search_Clients
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
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            dgvClients = new System.Windows.Forms.DataGridView();
            bindingSource1 = new System.Windows.Forms.BindingSource(components);
            Client_Name_lbl = new System.Windows.Forms.Label();
            Client_Name_txt = new System.Windows.Forms.TextBox();
            btnExit = new System.Windows.Forms.Button();
            btnClear = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            cmbClientID = new System.Windows.Forms.ComboBox();
            cmbOIB = new System.Windows.Forms.ComboBox();
            label3 = new System.Windows.Forms.Label();
            cmbCity = new System.Windows.Forms.ComboBox();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvClients).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.AkdamarLogo2023_100;
            pictureBox1.Location = new System.Drawing.Point(3, -2);
            pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(117, 39);
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            label1.Location = new System.Drawing.Point(127, 9);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(145, 24);
            label1.TabIndex = 19;
            label1.Text = "Search Clients";
            // 
            // dgvClients
            // 
            dgvClients.AllowUserToAddRows = false;
            dgvClients.AllowUserToDeleteRows = false;
            dgvClients.AllowUserToOrderColumns = true;
            dgvClients.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dgvClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dgvClients.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClients.Location = new System.Drawing.Point(12, 97);
            dgvClients.MultiSelect = false;
            dgvClients.Name = "dgvClients";
            dgvClients.Size = new System.Drawing.Size(1053, 341);
            dgvClients.TabIndex = 43;
            dgvClients.DoubleClick += dgvClients_DoubleClick;
            // 
            // Client_Name_lbl
            // 
            Client_Name_lbl.AutoSize = true;
            Client_Name_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
            Client_Name_lbl.Location = new System.Drawing.Point(16, 36);
            Client_Name_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Client_Name_lbl.Name = "Client_Name_lbl";
            Client_Name_lbl.Size = new System.Drawing.Size(95, 20);
            Client_Name_lbl.TabIndex = 45;
            Client_Name_lbl.Text = "Client Name";
            Client_Name_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Client_Name_txt
            // 
            Client_Name_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
            Client_Name_txt.Location = new System.Drawing.Point(16, 59);
            Client_Name_txt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Client_Name_txt.Name = "Client_Name_txt";
            Client_Name_txt.Size = new System.Drawing.Size(225, 26);
            Client_Name_txt.TabIndex = 44;
            Client_Name_txt.KeyUp += Client_Name_txt_KeyUp;
            // 
            // btnExit
            // 
            btnExit.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnExit.Location = new System.Drawing.Point(1015, 12);
            btnExit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(49, 46);
            btnExit.TabIndex = 46;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnClear
            // 
            btnClear.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnClear.Location = new System.Drawing.Point(956, 12);
            btnClear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(49, 46);
            btnClear.TabIndex = 47;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
            label2.Location = new System.Drawing.Point(271, 36);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(66, 20);
            label2.TabIndex = 48;
            label2.Text = "ClientID";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbClientID
            // 
            cmbClientID.FormattingEnabled = true;
            cmbClientID.Location = new System.Drawing.Point(248, 59);
            cmbClientID.Name = "cmbClientID";
            cmbClientID.Size = new System.Drawing.Size(121, 23);
            cmbClientID.TabIndex = 49;
            cmbClientID.SelectedIndexChanged += cmbClientID_SelectedIndexChanged;
            // 
            // cmbOIB
            // 
            cmbOIB.FormattingEnabled = true;
            cmbOIB.Location = new System.Drawing.Point(375, 59);
            cmbOIB.Name = "cmbOIB";
            cmbOIB.Size = new System.Drawing.Size(121, 23);
            cmbOIB.TabIndex = 51;
            cmbOIB.SelectedIndexChanged += cmbOIB_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
            label3.Location = new System.Drawing.Point(399, 36);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(37, 20);
            label3.TabIndex = 50;
            label3.Text = "OIB";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbCity
            // 
            cmbCity.FormattingEnabled = true;
            cmbCity.Location = new System.Drawing.Point(502, 59);
            cmbCity.Name = "cmbCity";
            cmbCity.Size = new System.Drawing.Size(121, 23);
            cmbCity.TabIndex = 53;
            cmbCity.SelectedIndexChanged += cmbCity_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
            label4.Location = new System.Drawing.Point(526, 36);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(35, 20);
            label4.TabIndex = 52;
            label4.Text = "City";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Search_Clients
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1077, 450);
            Controls.Add(cmbCity);
            Controls.Add(label4);
            Controls.Add(cmbOIB);
            Controls.Add(label3);
            Controls.Add(cmbClientID);
            Controls.Add(label2);
            Controls.Add(btnClear);
            Controls.Add(btnExit);
            Controls.Add(Client_Name_lbl);
            Controls.Add(Client_Name_txt);
            Controls.Add(dgvClients);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "Search_Clients";
            Text = "Search_Clients";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvClients).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dgvClients;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label Client_Name_lbl;
        private System.Windows.Forms.TextBox Client_Name_txt;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbClientID;
        private System.Windows.Forms.ComboBox cmbOIB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.Label label4;
    }
}