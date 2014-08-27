using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;


namespace MemoryScraper
{
    
    public partial class ProcessesList : Form
    {
        public ProcessesList()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            RefreshProcessList();
                
        }
        public void RefreshProcessList()
        {
            comboBoxProcesses.Items.Clear();
            var myProcess = Process.GetProcesses();
            for (var i = 0; i < myProcess.Length; i++)
            {
                var item = new ComboboxItem();
                item.Text = myProcess[i].ProcessName;
                item.Value = myProcess[i].Id;
                comboBoxProcesses.Items.Add(item);

            }  
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
           var firstPage = new FirstPage();
           firstPage.Show();
           Hide();          
        }


        private bool isThisSpecialProgram(string str)
        {
            var list = new List<string>();
            list.Clear();
            list.Add("chrome");
            if (list.Contains(str))
                return true;
            else
                return false;
        }

        private void scanBtn_Click(object sender, EventArgs e)
        {
            
            if ((comboBoxProcesses.SelectedIndex.ToString()).CompareTo("-1") != 0)
            {
                var pidNumber = ((ComboboxItem)comboBoxProcesses.SelectedItem).Value;
                Process myProcess;
            
                try
                {
                   myProcess = Process.GetProcessById(pidNumber);
                }
                catch
                {
                    MessageBox.Show("The selected process no longer exists.\nPlease choose another one.", "Memory Scraper", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshProcessList();
                    return;
                }

                
                if(isThisSpecialProgram(myProcess.ProcessName))
                {
                    pidNumber = myProcess.Parent().Id;
                    var scrapPage = new ScrapingPage(pidNumber, false);
                    scrapPage.Show();
                }
                    
                else
                {

                    var procs = Process.GetProcessesByName(myProcess.ProcessName);

                    if (procs.Count() > 1)
                    {

                        var multi = new MultiThreadSearch(myProcess.ProcessName);
                        multi.Show();
                    }
                    else
                    {
                        var scrapPage = new ScrapingPage(pidNumber, false);
                        scrapPage.Show();
                    }
                }
                Hide();
            }
            else
            {
                MessageBox.Show("The selected process is not on the list.\nPlease choose another one.", "Memory Scraper", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            RefreshProcessList();
        }

        

        

       

       
    }
}
