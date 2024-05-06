using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    public class FileWriter
    {
        public void Write(string message)
        {
            using (StreamWriter writer = new StreamWriter("log.txt", true))
            {
                writer.Write(message);
            }
        }
        public void WriteLine(string message)
        {
            using (StreamWriter writer = new StreamWriter("log.txt", true))
            {
                writer.WriteLine(message);
            }
        }
    }
    }

