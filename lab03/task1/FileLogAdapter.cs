using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    public class FileLogAdapter:Logger
    {
        public FileWriter write;
        public FileLogAdapter()
        {
            write = new FileWriter();
        }
        public new void Log(string message)
        {
            write.WriteLine("[logger] " + message);
        }
        public new void Error(string message)
        {
            write.WriteLine("[error] " + message);
        }
        public new void Warning(string message)
        {
            write.WriteLine("[warning] " + message);
        }
    }
}
