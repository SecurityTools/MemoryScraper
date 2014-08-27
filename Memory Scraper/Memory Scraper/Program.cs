using System;
using System.Windows.Forms;

namespace MemoryScraper
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var startingPage = new FirstPage();
            Application.Run(startingPage);
        }
    }
}
