using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace MemoryScraper
{
    class MakingDumpFile
    {
        // REQUIRED CONSTS

        const int PROCESS_QUERY_INFORMATION = 0x0400;
        const int MEM_COMMIT = 0x00001000;
        const int PAGE_READWRITE = 0x04;
        const int PROCESS_WM_READ = 0x0010;
        Encoding encUn = Encoding.Unicode;
        public int resultsStatus = 0; //1-okay, 2 -Error in your regular expression, 3- Loading the results. Please wait.\r\n\r\nIt may take 3 - 90 seconds.
        private MatchCollection matches;
        

        // REQUIRED METHODS

        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll")]
        public static extern bool ReadProcessMemory(int hProcess, int lpBaseAddress, byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesRead);

        [DllImport("kernel32.dll")]
        static extern void GetSystemInfo(out SYSTEM_INFO lpSystemInfo);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern int VirtualQueryEx(IntPtr hProcess, IntPtr lpAddress, out MEMORY_BASIC_INFORMATION lpBuffer, uint dwLength);


        // REQUIRED STRUCTS

        public struct MEMORY_BASIC_INFORMATION
        {
            public int BaseAddress;
            public int AllocationBase;
            public int AllocationProtect;
            public int RegionSize;
            public int State;
            public int Protect;
            public int lType;
        }

        public struct SYSTEM_INFO
        {
            public ushort processorArchitecture;
            ushort reserved;
            public uint pageSize;
            public IntPtr minimumApplicationAddress;
            public IntPtr maximumApplicationAddress;
            public IntPtr activeProcessorMask;
            public uint numberOfProcessors;
            public uint processorType;
            public uint allocationGranularity;
            public ushort processorLevel;
            public ushort processorRevision;
        }

        public bool MakingDumpFile1(int pid, string destination)  
        //recieving proccess ID and dump file destination and making it
        //returns true if the PID is correct, and false if it doesn't
        {
            
            // getting minimum & maximum address

            SYSTEM_INFO sys_info = new SYSTEM_INFO();
            GetSystemInfo(out sys_info);

            IntPtr proc_min_address = sys_info.minimumApplicationAddress;
            IntPtr proc_max_address = sys_info.maximumApplicationAddress;

            // saving the values as long ints so I won't have to do a lot of casts later
            long proc_min_address_l = (long)proc_min_address;
            long proc_max_address_l = (long)proc_max_address;


            
            
            try
            {
                Process process = Process.GetProcessById(pid);  //may crash here if PID isn't correct

                // opening the process with desired access level
                IntPtr processHandle = OpenProcess(PROCESS_QUERY_INFORMATION | PROCESS_WM_READ, false, process.Id);

           
                StreamWriter sw = new StreamWriter(destination);


                // this will store any information we get from VirtualQueryEx()
                MEMORY_BASIC_INFORMATION mem_basic_info = new MEMORY_BASIC_INFORMATION();

                int bytesRead = 0;  // number of bytes read with ReadProcessMemory

                while (proc_min_address_l < proc_max_address_l)
                {
                    // 28 = sizeof(MEMORY_BASIC_INFORMATION)
                    VirtualQueryEx(processHandle, proc_min_address, out mem_basic_info, 28);

                    // if this memory chunk is accessible
                    if (mem_basic_info.Protect == PAGE_READWRITE && mem_basic_info.State == MEM_COMMIT)
                    {
                        byte[] buffer = new byte[mem_basic_info.RegionSize];

                        // read everything in the buffer above
                        ReadProcessMemory((int)processHandle, mem_basic_info.BaseAddress, buffer, mem_basic_info.RegionSize, ref bytesRead);

                        sw.Write(encUn.GetString(buffer, 0, mem_basic_info.RegionSize));

                    }

                    // move to the next memory chunk
                    proc_min_address_l += mem_basic_info.RegionSize;
                    proc_min_address = new IntPtr(proc_min_address_l);
                }

                sw.Close();
                return true;


            }
            catch
            {
                return false;
            }
            

           
           


        }
        public string getStringFromDumpFile(string url) 
        //gets path of file and returns it's content as a string
        {


            string readText = "";

            if (File.Exists(url))
                readText = File.ReadAllText(url);

            return readText;


        }
        public void GetInstanes(string text, string pattern)
        //gets a text and a regualr expression and returns the instanes of it 
        {
            
            
          

            try
            {
                Regex regex = new Regex(pattern);
                this.matches = regex.Matches(text);
                

                /*
                if(count<=maxAllowedMatches)  //if it's okay
                {
                  result = count + " results:\r\n\r\n";
                  // Iterate matches    
                  for (int ctr = 0; ctr < count; ctr++)
                    result += ctr + 1 + ".  " + matches[ctr].Value + "\r\n";

                }
                else                         //if it's not
                {
                    result = "There are more than " + maxAllowedMatches + " results.\r\n(Actually there are "+ count+ ").\r\nHere are the first " + maxAllowedMatches + " :\r\n\r\n";
                    for (int ctr = 0; ctr < maxAllowedMatches; ctr++)
                        result += ctr + 1 + ".  " + matches[ctr].Value + "\r\n";
                }
                 */
                
            }
            catch
            {
                this.resultsStatus=2; // error in the regular expression
            }
            this.resultsStatus = 1; //okay

        }
        public MatchCollection PidToInstances(int pid, string pattern)
        {
            string pathForTextFile = @"C:\dump file for Memory Scraper.txt";

            bool PidCorrect = MakingDumpFile1(pid, pathForTextFile);
            if (PidCorrect)
            {
               string text = getStringFromDumpFile(pathForTextFile);
               GetInstanes(text, pattern);
            }
            else
            {
                this.resultsStatus=3;
                
            }
            return this.matches;
                
            
        }
            
    }
}
