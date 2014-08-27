using System;
using System.Windows.Forms;

namespace MemoryScraper
{
    public partial class FirstPage : Form
    {
        public FirstPage()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void procsListBtn_Click(object sender, EventArgs e)
        {
            var procPage = new ProcessesList();
            procPage.Show();
            Hide();
        }

        private void creditLbl_Click(object sender, EventArgs e)
        {
            var cred = new CreditsForm();
            cred.Show();
            Hide();
        }

        

    }
}
