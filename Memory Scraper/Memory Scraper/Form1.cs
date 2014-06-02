using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace MemoryScraper
{
    public partial class Form1 : Form
    {
        private int processID = 0;
        private string creditCardRegularExperssion;
        private string emailRegularExperssion;
        private string IpRegularExperssion;
        private string UrlRegularExperssion;
        private string homePhoneIsraelRegularExperssion;
        private string privatePhoneIsraelRegularExperssion;
        private string DatesRegularExperssion;
        private Scanning scan;
        Thread scanThread;
        Thread takingInfoThread;
        private bool takingResultsFlag = false;
        private bool isThreadsWereCreated = false;
    
        private bool isTheScanStopped;

        public Form1(int pid)
        {
            InitializeComponent();
            this.processID = pid;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.isTheScanStopped = true;
            


            // Regular expressions 
            this.emailRegularExperssion = @"([a-z0-9_\.-]+)@([\da-z\.-]+)\.([a-z\.]{2,6})";
            this.IpRegularExperssion = @"(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)";
            this.UrlRegularExperssion = @"(https?:\/\/)([\da-z\.-]+)\.([a-z\.]{2,6})([\/\w \.-]*)*\/?";
            this.homePhoneIsraelRegularExperssion = @"0(2|3|4|8|9|72|73|76|77)([-]{0,1})\d{7}";
            this.privatePhoneIsraelRegularExperssion = @"05[023456789]([-]{0,1})\d{7}";
            this.DatesRegularExperssion = @"(((0[1-9])|(1[0-2]))[\.\\\/-]((0[1-9])|(1[0-9])|(2[0-9])|(3[0-1]))[ \.\\\/-](19(\d{2})|20((0\d)|(1[0-7]))))|(((0[1-9])|(1[0-9])|(2[0-9])|(3[0-1]))[ \.\\\/-]( (0[1-9])|(1[0-2]))[ \.\\\/-](19(\d{2})|20((0\d)|(1[0-7]))))";
            this.creditCardRegularExperssion = @"(?<![\d])(?:4[0-9]{12}|4[0-9]{3}\s?[0-9]{4}\s?[0-9]{4}\s?[0-9]{4}|5[1-5][0-9]{14}|6(?:011|5[0-9][0-9])[0-9]{12}|3[47][0-9]{13}|3(?:0[0-5]|[68][0-9])[0-9]{11}|(?:2131|1800|35\d{3})\d{11})(?![\d])";

        }

        public void buttonGo_Click(object sender, EventArgs e)
        {
            if (this.isTheScanStopped == false)
                closeThreads();

            
         
          
            string pattern = textBox1.Text;
           
            
            if (pattern.CompareTo(this.creditCardRegularExperssion) == 0)
                resultLabel.Text = "Credit cards search results";
            else
            {
                if (pattern.CompareTo(this.emailRegularExperssion) == 0)
                    resultLabel.Text = "E-mails search results";
                else
                {
                    if (pattern.CompareTo(this.IpRegularExperssion) == 0)
                        resultLabel.Text = "IP Addresses search results";
                    else
                    {
                        if (pattern.CompareTo(this.UrlRegularExperssion) == 0)
                            resultLabel.Text = "URLs search results";
                        else
                        {
                            if (pattern.CompareTo(this.homePhoneIsraelRegularExperssion) == 0)
                                resultLabel.Text = "Telephone numbers search results";
                            else
                            {
                                if (pattern.CompareTo(this.privatePhoneIsraelRegularExperssion) == 0)
                                    resultLabel.Text = "Mobile phone numbers search results";
                                else
                                {
                                    if (pattern.CompareTo(this.DatesRegularExperssion) == 0)
                                        resultLabel.Text = "Dates search results";
                                    else
                                    {
                                        resultLabel.Text = "Showing search result for: " + pattern;
                                    }
                                }

                            }


                        }
                            
                    }
                       
                }
            }
            this.isThreadsWereCreated = true;
            this.isTheScanStopped = false;
            this.takingResultsFlag = false;
            this.scan = new Scanning(this.processID, pattern);
            this.scanThread = new Thread(this.scan.startScan); //scanning in loops
            this.takingInfoThread = new Thread(this.takingResults); //taking results in loops
            this.scanThread.Start();
            this.takingInfoThread.Start();
            scanStatusLbl.Text = "Scan status: Scanning";
          
            
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.closeThreads();

            string url = @"C:\dump file for Memory Scraper.txt";
            
            if (File.Exists(url))
                File.Delete(url);

            ProcessesList obj1 = new ProcessesList();
            obj1.Show();
            this.Hide();
        }

        private void closeThreads()
        {
            if (this.isThreadsWereCreated == false)
                return;

            takingResultsFlag = true;
            this.scan.stopScanning();

            this.takingInfoThread.Abort();
            this.scanThread.Abort();

            this.takingInfoThread.Join();
            this.scanThread.Join();
            Thread.Sleep(3000);
            this.isThreadsWereCreated = false;


        }
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.closeThreads();
            
            string url = @"C:\dump file for Memory Scraper.txt";
            if (File.Exists(url))
                File.Delete(url);
             
            this.Close();
        }

        private void creditCardBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = creditCardRegularExperssion;
        }

        private void emailBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = emailRegularExperssion;
        }

        private void IpAddressScan_Click(object sender, EventArgs e)
        {
            textBox1.Text = IpRegularExperssion;
        }

        private void urlScanBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = UrlRegularExperssion;
        }

        private void homePhoneIsrael_Click(object sender, EventArgs e)
        {
            textBox1.Text = homePhoneIsraelRegularExperssion;
        }

        private void privatePhoneIsrael_Click(object sender, EventArgs e)
        {
            textBox1.Text = privatePhoneIsraelRegularExperssion;
        }

        private void DateBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = DatesRegularExperssion; ;
        }
        private void takingResults()
        {
            int maxAllowedMatches = 300;         //Maximum allowed matches in the results 
            int errorNumber = 0;
            string txt = "";
            int countOfResults;
           // Thread.Sleep(4000);
            while (takingResultsFlag == false)
            {
                countOfResults = this.scan.info.Count;
                errorNumber = this.scan.getResultsStatus();
                if (errorNumber == 2)
                {
                    txt = "Error in your regular expression";
                    

                }
                    
                else
                {
                    if (errorNumber == 3)
                    {
                         txt = "Loading the results. Please wait.\r\n\r\nIt may take 3 - 90 seconds.\r\n\r\nIf after a while no results are shown -\r\nPlease go back and choose another procees.\r\n(The selected process has changed its PID)";
                         
                    }
                       
                    else
                    {
                        
                        if (countOfResults <= maxAllowedMatches)  //if it's okay
                        {
                            txt = countOfResults + " results:\r\n\r\n";
                            // Iterate matches    
                            for (int ctr = 0; ctr < countOfResults; ctr++)
                                txt += ctr + 1 + ".  " + this.scan.info[ctr] + "\r\n";

                        }
                        else                         //if it's not
                        {
                            txt = "There are more than " + maxAllowedMatches + " results.\r\n(Actually there are " + countOfResults + ").\r\nHere are the first " + maxAllowedMatches + " :\r\n\r\n";
                            for (int ctr = 0; ctr < maxAllowedMatches; ctr++)
                                txt += ctr + 1 + ".  " + this.scan.info[ctr] + "\r\n";
                        }

                      
                    }
                }



                if (textBoxResult.InvokeRequired)
                {
                    Invoke((MethodInvoker)(() => textBoxResult.Text = txt));
                }
                else
                {
                    textBoxResult.Text = txt;
                }               
            }
        }

        private void stropScanBtn_Click(object sender, EventArgs e)
        {
            this.closeThreads();
            this.isTheScanStopped = true;
            scanStatusLbl.Text = "Scan status: Stopped";
          
        }

        private void LabelEnterString_Click(object sender, EventArgs e)
        {

        }
       
    }
        
    }

