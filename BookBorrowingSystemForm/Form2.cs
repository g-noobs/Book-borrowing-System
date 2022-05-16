using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookBorrowingSystemForm
{
    public partial class AdminPageForm : Form
    {
        public AdminPageForm()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toStudentPageLLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }
    }
}
