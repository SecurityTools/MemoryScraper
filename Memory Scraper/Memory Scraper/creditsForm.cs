using System;
using System.Windows.Forms;

namespace MemoryScraper
{
    public partial class CreditsForm : Form
    {
        public CreditsForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            var firstPage = new FirstPage();
            firstPage.Show();
            Hide(); 
        }

        private void creditsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var firstPage = new FirstPage();
            firstPage.Show();
            Hide(); 
        }
    }
}
