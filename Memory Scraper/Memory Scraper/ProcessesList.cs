using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;


namespace MemoryScraper
{
    
    public partial class ProcessesList : Form
    {
        public ProcessesList()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            comboBoxProcesses.Items.Clear();
            Process[] MyProcess = Process.GetProcesses();
            for (int i = 0; i < MyProcess.Length; i++)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = MyProcess[i].ProcessName;
                item.Value = MyProcess[i].Id;
                comboBoxProcesses.Items.Add(item);

            }      
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
           FirstPage obj1 = new FirstPage();
           obj1.Show();
           this.Hide();          
        }

       

        private void ExitBtn_Click(object sender, EventArgs e)
        {    
            this.Close();
        }

        private void scanBtn_Click(object sender, EventArgs e)
        {
            if ((comboBoxProcesses.SelectedIndex.ToString()).CompareTo("-1") != 0)
            {
                int PidNumber = ((ComboboxItem)comboBoxProcesses.SelectedItem).Value;
                Form1 obj1 = new Form1(PidNumber);
                obj1.Show();
                this.Hide();
            }
                
        }

        private void ProcessesList_Load(object sender, EventArgs e)
        {

        }

        

       

       
    }
}
