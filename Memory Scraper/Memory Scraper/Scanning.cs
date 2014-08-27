using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace MemoryScraper
{
    class Scanning
    {
        private volatile bool _shouldStop;
        private readonly int _pid;
        private readonly string _pattern;
        public volatile List<string> Info;
        private MatchCollection _matches;
        private readonly MakingDumpFile _m;
        
        public Scanning(int pid2, string pattern2)
        {
            _m = new MakingDumpFile();
            Info = new List<string>();
            Info.Clear();
            _shouldStop = false;
            _pid = pid2;
            _pattern = pattern2;
        }
        public int GetResultsStatus()
        {
            return _m.ResultsStatus;
        }
        public void StartScan()
        {

            var isCountOkay=false;
  
            while (!_shouldStop)
            {                    
                    _matches = _m.PidToInstances(_pid, _pattern);
                    try
                    {
                        if (_matches.Count > 0)
                            isCountOkay = true;
                        else
                            isCountOkay = false;
                    }
                    catch
                    {
                        _m.ResultsStatus = 2;
                    }
                    


                    if(_m.ResultsStatus==1 && isCountOkay)
                    {
                        foreach (Match match in _matches)
                        {
                            if (Info.Contains(match.Value) == false)
                                Info.Add(match.Value);
                        }
                    }             
            }

        }
        public void StopScanning()
        {
            _shouldStop = true;
        }

    }
}
