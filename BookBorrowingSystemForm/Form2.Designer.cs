namespace BookBorrowingSystemForm
{
    partial class AdminPageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPageForm));
            this.closeBtn = new System.Windows.Forms.Button();
            this.adminAboutLLabel = new System.Windows.Forms.LinkLabel();
            this.adminReportLLabel = new System.Windows.Forms.LinkLabel();
            this.toStudentPageLLabel = new System.Windows.Forms.LinkLabel();
            this.adminResetBtn = new System.Windows.Forms.Button();
            this.adminLoginBtn = new System.Windows.Forms.Button();
            this.adminPasswordTxtbox = new System.Windows.Forms.TextBox();
            this.adminUsernameTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.closeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.closeBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.closeBtn.Location = new System.Drawing.Point(823, 2);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(30, 25);
            this.closeBtn.TabIndex = 2;
            this.closeBtn.Text = "X";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // adminAboutLLabel
            // 
            this.adminAboutLLabel.BackColor = System.Drawing.Color.Transparent;
            this.adminAboutLLabel.LinkColor = System.Drawing.Color.Silver;
            this.adminAboutLLabel.Location = new System.Drawing.Point(12, 441);
            this.adminAboutLLabel.Name = "adminAboutLLabel";
            this.adminAboutLLabel.Size = new System.Drawing.Size(89, 21);
            this.adminAboutLLabel.TabIndex = 13;
            this.adminAboutLLabel.TabStop = true;
            this.adminAboutLLabel.Text = "About Us";
            // 
            // adminReportLLabel
            // 
            this.adminReportLLabel.BackColor = System.Drawing.Color.Transparent;
            this.adminReportLLabel.LinkColor = System.Drawing.Color.Silver;
            this.adminReportLLabel.Location = new System.Drawing.Point(11, 420);
            this.adminReportLLabel.Name = "adminReportLLabel";
            this.adminReportLLabel.Size = new System.Drawing.Size(89, 21);
            this.adminReportLLabel.TabIndex = 12;
            this.adminReportLLabel.TabStop = true;
            this.adminReportLLabel.Text = "Report";
            // 
            // toStudentPageLLabel
            // 
            this.toStudentPageLLabel.AutoSize = true;
            this.toStudentPageLLabel.BackColor = System.Drawing.Color.Transparent;
            this.toStudentPageLLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toStudentPageLLabel.Location = new System.Drawing.Point(490, 183);
            this.toStudentPageLLabel.Name = "toStudentPageLLabel";
            this.toStudentPageLLabel.Size = new System.Drawing.Size(125, 21);
            this.toStudentPageLLabel.TabIndex = 11;
            this.toStudentPageLLabel.TabStop = true;
            this.toStudentPageLLabel.Text = "Login as Student";
            this.toStudentPageLLabel.VisitedLinkColor = System.Drawing.Color.Red;
            this.toStudentPageLLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.toStudentPageLLabel_LinkClicked);
            // 
            // adminResetBtn
            // 
            this.adminResetBtn.BackColor = System.Drawing.Color.RosyBrown;
            this.adminResetBtn.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral;
            this.adminResetBtn.FlatAppearance.BorderSize = 0;
            this.adminResetBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.adminResetBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.adminResetBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.adminResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.adminResetBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.adminResetBtn.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.adminResetBtn.Location = new System.Drawing.Point(463, 303);
            this.adminResetBtn.Name = "adminResetBtn";
            this.adminResetBtn.Size = new System.Drawing.Size(85, 29);
            this.adminResetBtn.TabIndex = 10;
            this.adminResetBtn.Text = "Reset";
            this.adminResetBtn.UseVisualStyleBackColor = false;
            // 
            // adminLoginBtn
            // 
            this.adminLoginBtn.BackColor = System.Drawing.Color.RosyBrown;
            this.adminLoginBtn.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral;
            this.adminLoginBtn.FlatAppearance.BorderSize = 0;
            this.adminLoginBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.adminLoginBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.adminLoginBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.adminLoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.adminLoginBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.adminLoginBtn.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.adminLoginBtn.Location = new System.Drawing.Point(348, 303);
            this.adminLoginBtn.Name = "adminLoginBtn";
            this.adminLoginBtn.Size = new System.Drawing.Size(85, 29);
            this.adminLoginBtn.TabIndex = 9;
            this.adminLoginBtn.Text = "Login";
            this.adminLoginBtn.UseVisualStyleBackColor = false;
            // 
            // adminPasswordTxtbox
            // 
            this.adminPasswordTxtbox.BackColor = System.Drawing.Color.Gainsboro;
            this.adminPasswordTxtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.adminPasswordTxtbox.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.adminPasswordTxtbox.Location = new System.Drawing.Point(378, 267);
            this.adminPasswordTxtbox.Multiline = true;
            this.adminPasswordTxtbox.Name = "adminPasswordTxtbox";
            this.adminPasswordTxtbox.Size = new System.Drawing.Size(203, 25);
            this.adminPasswordTxtbox.TabIndex = 15;
            this.adminPasswordTxtbox.Text = "Enter your Password";
            // 
            // adminUsernameTxtBox
            // 
            this.adminUsernameTxtBox.BackColor = System.Drawing.Color.Gainsboro;
            this.adminUsernameTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.adminUsernameTxtBox.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.adminUsernameTxtBox.Location = new System.Drawing.Point(378, 216);
            this.adminUsernameTxtBox.Multiline = true;
            this.adminUsernameTxtBox.Name = "adminUsernameTxtBox";
            this.adminUsernameTxtBox.Size = new System.Drawing.Size(203, 25);
            this.adminUsernameTxtBox.TabIndex = 14;
            this.adminUsernameTxtBox.Text = "Enter your Username";
            // 
            // AdminPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BookBorrowingSystemForm.Properties.Resources.LBBS_design2_admin;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(852, 469);
            this.Controls.Add(this.adminPasswordTxtbox);
            this.Controls.Add(this.adminUsernameTxtBox);
            this.Controls.Add(this.adminAboutLLabel);
            this.Controls.Add(this.adminReportLLabel);
            this.Controls.Add(this.toStudentPageLLabel);
            this.Controls.Add(this.adminResetBtn);
            this.Controls.Add(this.adminLoginBtn);
            this.Controls.Add(this.closeBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminPageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button closeBtn;
        private LinkLabel adminAboutLLabel;
        private LinkLabel adminReportLLabel;
        private LinkLabel toStudentPageLLabel;
        private Button adminResetBtn;
        private Button adminLoginBtn;
        private TextBox adminPasswordTxtbox;
        private TextBox adminUsernameTxtBox;
    }
}