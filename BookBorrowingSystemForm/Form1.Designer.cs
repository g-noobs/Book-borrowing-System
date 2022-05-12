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
            this.LoginPagTestLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // LoginPagTestLabel
            // 
            this.LoginPagTestLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginPagTestLabel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LoginPagTestLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.LoginPagTestLabel.Location = new System.Drawing.Point(52, 34);
            this.LoginPagTestLabel.Name = "LoginPagTestLabel";
            this.LoginPagTestLabel.Size = new System.Drawing.Size(272, 120);
            this.LoginPagTestLabel.TabIndex = 0;
            this.LoginPagTestLabel.Text = "Login Page Test";
            this.LoginPagTestLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LoginPagTestLabel.Click += new System.EventHandler(this.LoginPagTestLabel_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(87, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 66);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(109, 293);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(159, 40);
            this.checkedListBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 450);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LoginPagTestLabel);
            this.Name = "Form1";
            this.Text = "Login";
            this.ResumeLayout(false);

        }

        #endregion

        private Label LoginPagTestLabel;
        private Button button1;
        private CheckedListBox checkedListBox1;
    }
}