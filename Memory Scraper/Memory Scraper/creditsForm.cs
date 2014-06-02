using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryScraper
{
    public partial class creditsForm : Form
    {
        public creditsForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            FirstPage obj1 = new FirstPage();
            obj1.Show();
            this.Hide(); 
        }
    }
}
