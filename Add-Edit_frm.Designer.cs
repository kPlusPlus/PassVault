namespace PassVault
{
    partial class Add_Edit_frm
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
            this.Clients_botun = new System.Windows.Forms.Button();
            this.Pass_Vault_Records_botun = new System.Windows.Forms.Button();
            this.LIcense_Types_botun = new System.Windows.Forms.Button();
            this.Certificates_botun = new System.Windows.Forms.Button();
            this.Exit_botun = new System.Windows.Forms.Button();
            this.Heading_lbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Clients_botun
            // 
            this.Clients_botun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Clients_botun.Location = new System.Drawing.Point(12, 108);
            this.Clients_botun.Name = "Clients_botun";
            this.Clients_botun.Size = new System.Drawing.Size(220, 30);
            this.Clients_botun.TabIndex = 1;
            this.Clients_botun.Text = "Clients";
            this.Clients_botun.UseVisualStyleBackColor = true;
            this.Clients_botun.Click += new System.EventHandler(this.button1_Click);
            // 
            // Pass_Vault_Records_botun
            // 
            this.Pass_Vault_Records_botun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Pass_Vault_Records_botun.Location = new System.Drawing.Point(11, 144);
            this.Pass_Vault_Records_botun.Name = "Pass_Vault_Records_botun";
            this.Pass_Vault_Records_botun.Size = new System.Drawing.Size(220, 30);
            this.Pass_Vault_Records_botun.TabIndex = 2;
            this.Pass_Vault_Records_botun.Text = "Pass Vault Records";
            this.Pass_Vault_Records_botun.UseVisualStyleBackColor = true;
            this.Pass_Vault_Records_botun.Click += new System.EventHandler(this.button2_Click);
            // 
            // LIcense_Types_botun
            // 
            this.LIcense_Types_botun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LIcense_Types_botun.Location = new System.Drawing.Point(12, 180);
            this.LIcense_Types_botun.Name = "LIcense_Types_botun";
            this.LIcense_Types_botun.Size = new System.Drawing.Size(220, 30);
            this.LIcense_Types_botun.TabIndex = 3;
            this.LIcense_Types_botun.Text = "LIcense Types";
            this.LIcense_Types_botun.UseVisualStyleBackColor = true;
            this.LIcense_Types_botun.Click += new System.EventHandler(this.LIcense_Types_botun_Click);
            // 
            // Certificates_botun
            // 
            this.Certificates_botun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Certificates_botun.Location = new System.Drawing.Point(12, 216);
            this.Certificates_botun.Name = "Certificates_botun";
            this.Certificates_botun.Size = new System.Drawing.Size(220, 30);
            this.Certificates_botun.TabIndex = 4;
            this.Certificates_botun.Text = "Certificates";
            this.Certificates_botun.UseVisualStyleBackColor = true;
            this.Certificates_botun.Click += new System.EventHandler(this.Certificates_botun_Click);
            // 
            // Exit_botun
            // 
            this.Exit_botun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Exit_botun.Location = new System.Drawing.Point(11, 252);
            this.Exit_botun.Name = "Exit_botun";
            this.Exit_botun.Size = new System.Drawing.Size(70, 30);
            this.Exit_botun.TabIndex = 5;
            this.Exit_botun.Text = "Exit";
            this.Exit_botun.UseVisualStyleBackColor = true;
            this.Exit_botun.Click += new System.EventHandler(this.button5_Click);
            // 
            // Heading_lbl
            // 
            this.Heading_lbl.AutoSize = true;
            this.Heading_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Heading_lbl.Location = new System.Drawing.Point(55, 70);
            this.Heading_lbl.Name = "Heading_lbl";
            this.Heading_lbl.Size = new System.Drawing.Size(142, 20);
            this.Heading_lbl.TabIndex = 16;
            this.Heading_lbl.Text = "Add / Edit Records";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PassVault.Properties.Resources.AkdamarLogo2023_100;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 34);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Add_Edit_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 301);
            this.Controls.Add(this.Heading_lbl);
            this.Controls.Add(this.Exit_botun);
            this.Controls.Add(this.Certificates_botun);
            this.Controls.Add(this.LIcense_Types_botun);
            this.Controls.Add(this.Pass_Vault_Records_botun);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Clients_botun);
            this.Name = "Add_Edit_frm";
            this.Text = "Akdamar Pass Vault";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Clients_botun;
        private System.Windows.Forms.Button Pass_Vault_Records_botun;
        private System.Windows.Forms.Button LIcense_Types_botun;
        private System.Windows.Forms.Button Certificates_botun;
        private System.Windows.Forms.Button Exit_botun;
        private System.Windows.Forms.Label Heading_lbl;
    }
}