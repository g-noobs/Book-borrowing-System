namespace BookBorrowingSystemForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.closeBtn = new System.Windows.Forms.Button();
            this.studentUsernameTxtBox = new System.Windows.Forms.TextBox();
            this.studentPasswordTxtbox = new System.Windows.Forms.TextBox();
            this.stdntLoginBtn = new System.Windows.Forms.Button();
            this.stdntResetBtn = new System.Windows.Forms.Button();
            this.toAdminPageLLabel = new System.Windows.Forms.LinkLabel();
            this.StudentReportLLabel = new System.Windows.Forms.LinkLabel();
            this.StudentAboutLLabel = new System.Windows.Forms.LinkLabel();
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
            this.closeBtn.Location = new System.Drawing.Point(823, -2);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(30, 25);
            this.closeBtn.TabIndex = 1;
            this.closeBtn.Text = "X";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // studentUsernameTxtBox
            // 
            this.studentUsernameTxtBox.BackColor = System.Drawing.Color.Gainsboro;
            this.studentUsernameTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.studentUsernameTxtBox.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.studentUsernameTxtBox.Location = new System.Drawing.Point(378, 216);
            this.studentUsernameTxtBox.Multiline = true;
            this.studentUsernameTxtBox.Name = "studentUsernameTxtBox";
            this.studentUsernameTxtBox.Size = new System.Drawing.Size(203, 25);
            this.studentUsernameTxtBox.TabIndex = 2;
            this.studentUsernameTxtBox.Text = "Enter your Username";
            // 
            // studentPasswordTxtbox
            // 
            this.studentPasswordTxtbox.BackColor = System.Drawing.Color.Gainsboro;
            this.studentPasswordTxtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.studentPasswordTxtbox.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.studentPasswordTxtbox.Location = new System.Drawing.Point(378, 267);
            this.studentPasswordTxtbox.Multiline = true;
            this.studentPasswordTxtbox.Name = "studentPasswordTxtbox";
            this.studentPasswordTxtbox.Size = new System.Drawing.Size(203, 25);
            this.studentPasswordTxtbox.TabIndex = 3;
            this.studentPasswordTxtbox.Text = "Enter your Password";
            // 
            // stdntLoginBtn
            // 
            this.stdntLoginBtn.BackColor = System.Drawing.Color.RosyBrown;
            this.stdntLoginBtn.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral;
            this.stdntLoginBtn.FlatAppearance.BorderSize = 0;
            this.stdntLoginBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.stdntLoginBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.stdntLoginBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.stdntLoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.stdntLoginBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.stdntLoginBtn.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.stdntLoginBtn.Location = new System.Drawing.Point(348, 303);
            this.stdntLoginBtn.Name = "stdntLoginBtn";
            this.stdntLoginBtn.Size = new System.Drawing.Size(85, 29);
            this.stdntLoginBtn.TabIndex = 4;
            this.stdntLoginBtn.Text = "Login";
            this.stdntLoginBtn.UseVisualStyleBackColor = false;
            // 
            // stdntResetBtn
            // 
            this.stdntResetBtn.BackColor = System.Drawing.Color.RosyBrown;
            this.stdntResetBtn.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral;
            this.stdntResetBtn.FlatAppearance.BorderSize = 0;
            this.stdntResetBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.stdntResetBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.stdntResetBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.stdntResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.stdntResetBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.stdntResetBtn.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.stdntResetBtn.Location = new System.Drawing.Point(463, 303);
            this.stdntResetBtn.Name = "stdntResetBtn";
            this.stdntResetBtn.Size = new System.Drawing.Size(85, 29);
            this.stdntResetBtn.TabIndex = 5;
            this.stdntResetBtn.Text = "Reset";
            this.stdntResetBtn.UseVisualStyleBackColor = false;
            // 
            // toAdminPageLLabel
            // 
            this.toAdminPageLLabel.AutoSize = true;
            this.toAdminPageLLabel.BackColor = System.Drawing.Color.Transparent;
            this.toAdminPageLLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toAdminPageLLabel.Location = new System.Drawing.Point(490, 183);
            this.toAdminPageLLabel.Name = "toAdminPageLLabel";
            this.toAdminPageLLabel.Size = new System.Drawing.Size(118, 21);
            this.toAdminPageLLabel.TabIndex = 6;
            this.toAdminPageLLabel.TabStop = true;
            this.toAdminPageLLabel.Text = "Login as Admin";
            this.toAdminPageLLabel.VisitedLinkColor = System.Drawing.Color.Red;
            this.toAdminPageLLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.toAdminPageLLabel_LinkClicked);
            // 
            // StudentReportLLabel
            // 
            this.StudentReportLLabel.BackColor = System.Drawing.Color.Transparent;
            this.StudentReportLLabel.LinkColor = System.Drawing.Color.Silver;
            this.StudentReportLLabel.Location = new System.Drawing.Point(11, 420);
            this.StudentReportLLabel.Name = "StudentReportLLabel";
            this.StudentReportLLabel.Size = new System.Drawing.Size(89, 21);
            this.StudentReportLLabel.TabIndex = 7;
            this.StudentReportLLabel.TabStop = true;
            this.StudentReportLLabel.Text = "Report";
            // 
            // StudentAboutLLabel
            // 
            this.StudentAboutLLabel.BackColor = System.Drawing.Color.Transparent;
            this.StudentAboutLLabel.LinkColor = System.Drawing.Color.Silver;
            this.StudentAboutLLabel.Location = new System.Drawing.Point(12, 441);
            this.StudentAboutLLabel.Name = "StudentAboutLLabel";
            this.StudentAboutLLabel.Size = new System.Drawing.Size(89, 21);
            this.StudentAboutLLabel.TabIndex = 8;
            this.StudentAboutLLabel.TabStop = true;
            this.StudentAboutLLabel.Text = "About Us";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::BookBorrowingSystemForm.Properties.Resources.LBBS_Design1_student;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(852, 469);
            this.Controls.Add(this.StudentAboutLLabel);
            this.Controls.Add(this.StudentReportLLabel);
            this.Controls.Add(this.toAdminPageLLabel);
            this.Controls.Add(this.stdntResetBtn);
            this.Controls.Add(this.stdntLoginBtn);
            this.Controls.Add(this.studentPasswordTxtbox);
            this.Controls.Add(this.studentUsernameTxtBox);
            this.Controls.Add(this.closeBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button closeBtn;
        private TextBox studentUsernameTxtBox;
        private TextBox studentPasswordTxtbox;
        private Button stdntLoginBtn;
        private Button stdntResetBtn;
        private LinkLabel toAdminPageLLabel;
        private LinkLabel StudentReportLLabel;
        private LinkLabel StudentAboutLLabel;
    }
}