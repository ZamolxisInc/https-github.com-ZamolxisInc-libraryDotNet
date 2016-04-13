using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace libraryDotNet
{
    class Log
    {
        public Log(string data)
        {
            
            using (StreamWriter stream = new FileInfo("log-"+ DateTime.Now.ToString("yyyyMMdd")+".txt").AppendText())
            {
                
                DateTime current = DateTime.Now;
                stream.WriteLine(current.ToString() + ": " + data);
               
            }

        }
    }
}
