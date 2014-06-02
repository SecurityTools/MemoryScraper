using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Text.RegularExpressions;


namespace MemoryScraper
{
    class Scanning
    {
        private volatile bool _shouldStop;
        private int pid;
        private string pattern;
        public volatile List<string> info;
        private MatchCollection matches;
        private MakingDumpFile m;
        
        public Scanning(int pid2, string pattern2)
        {
            m = new MakingDumpFile();
            this.info = new List<string>();
            this.info.Clear();
            this._shouldStop = false;
            this.pid = pid2;
            this.pattern = pattern2;
        }
        public int getResultsStatus()
        {
            return this.m.resultsStatus;
        }
        public void startScan()
        {
            
            
            while (!_shouldStop)
            {                    
                    this.matches = m.PidToInstances(this.pid, this.pattern);
                    if(m.resultsStatus==1)
                    {
                        foreach (Match match in this.matches)
                        {
                            if (this.info.Contains(match.Value) == false)
                                this.info.Add(match.Value);
                        }
                    }             
            }

        }
        public void stopScanning()
        {
            _shouldStop = true;
        }

    }
}
