namespace BookBorrowingSystemForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toAdminPageLLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new AdminPageForm().Show();
            this.Hide();
        }
    }
}