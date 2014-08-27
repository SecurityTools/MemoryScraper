using System;
using System.Text;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace MemoryScraper
{
    class MakingDumpFile
    {
        

        const int ProcessQueryInformation = 0x0400;
        const int MemCommit = 0x00001000;
        const int PageReadwrite = 0x04;
        const int ProcessWmRead = 0x0010;
        readonly Encoding encUn = Encoding.Unicode;
        public int ResultsStatus = 0; 
        private MatchCollection _matches;
        

       

        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll")]
        public static extern bool ReadProcessMemory(int hProcess, int lpBaseAddress, byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesRead);

        [DllImport("kernel32.dll")]
        static extern void GetSystemInfo(out SystemInfo lpSystemInfo);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern int VirtualQueryEx(IntPtr hProcess, IntPtr lpAddress, out MemoryBasicInformation lpBuffer, uint dwLength);


      

        public struct MemoryBasicInformation
        {
            public int BaseAddress;
            public int AllocationBase;
            public int AllocationProtect;
            public int RegionSize;
            public int State;
            public int Protect;
            public int LType;
        }

        public struct SystemInfo
        {
            public ushort ProcessorArchitecture;
            public uint PageSize;
            public IntPtr MinimumApplicationAddress;
            public IntPtr MaximumApplicationAddress;
            public IntPtr ActiveProcessorMask;
            public uint NumberOfProcessors;
            public uint ProcessorType;
            public uint AllocationGranularity;
            public ushort ProcessorLevel;
            public ushort ProcessorRevision;
        }

        public bool MakingDumpFile1(int pid, string destination)  
       
        {
            
        

            SystemInfo sysInfo;
            GetSystemInfo(out sysInfo);

            var procMinAddress = sysInfo.MinimumApplicationAddress;
            var procMaxAddress = sysInfo.MaximumApplicationAddress;

           
            var procMinAddressL = (long)procMinAddress;
            var procMaxAddressL = (long)procMaxAddress;


            
            
            try
            {
                var process = Process.GetProcessById(pid);  

               
                var processHandle = OpenProcess(ProcessQueryInformation | ProcessWmRead, false, process.Id);

           
                var sw = new StreamWriter(destination);


                var bytesRead = 0; 

                while (procMinAddressL < procMaxAddressL)
                {
                    MemoryBasicInformation memBasicInfo;
                    VirtualQueryEx(processHandle, procMinAddress, out memBasicInfo, 28);

                   
                    if (memBasicInfo.Protect == PageReadwrite && memBasicInfo.State == MemCommit)
                    {
                        var buffer = new byte[memBasicInfo.RegionSize];

                        
                        ReadProcessMemory((int)processHandle, memBasicInfo.BaseAddress, buffer, memBasicInfo.RegionSize, ref bytesRead);

                        sw.Write(encUn.GetString(buffer, 0, memBasicInfo.RegionSize));

                    }

                    
                    procMinAddressL += memBasicInfo.RegionSize;
                    procMinAddress = new IntPtr(procMinAddressL);
                }

                sw.Close();
                return true;


            }
            catch
            {
                return false;
            }
            

           
           


        }
        public string GetStringFromDumpFile(string url) 
       
        {


            var readText = "";

            if (File.Exists(url))
                readText = File.ReadAllText(url);

            return readText;


        }
        public void GetInstanes(string text, string pattern)
     
        {
            
            
          

            try
            {
                var regex = new Regex(pattern);
                _matches = regex.Matches(text);
                
                
            }
            catch
            {
                ResultsStatus=2; 
            }
            ResultsStatus = 1;

        }
        public MatchCollection PidToInstances(int pid, string pattern)
        {
            
            const string pathForTextFile = @"..\dump file for Memory Scraper.txt";

            var pidCorrect = MakingDumpFile1(pid, pathForTextFile);
            if (pidCorrect)
            {
               var text = GetStringFromDumpFile(pathForTextFile);
               GetInstanes(text, pattern);
            }
            else
            {
                ResultsStatus=3;
                
            }
            return _matches;
                
            
        }
            
    }
}
