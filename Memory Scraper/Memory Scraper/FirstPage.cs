using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryScraper
{
    public partial class FirstPage : Form
    {
        public FirstPage()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void procsListBtn_Click(object sender, EventArgs e)
        {
            ProcessesList obj1 = new ProcessesList();
            obj1.Show();
            this.Hide();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void creditLbl_Click(object sender, EventArgs e)
        {
            creditsForm cred = new creditsForm();
            cred.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
