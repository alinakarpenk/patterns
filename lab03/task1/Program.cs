using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    public class Program
    {
        static void Main(string[] args)
        {
            FileLogAdapter logger = new FileLogAdapter();
            logger.Log("This is a logger message.");
            FileLogAdapter warning = new FileLogAdapter();
            warning.Warning("This is a warning message.");
            FileLogAdapter error = new FileLogAdapter();
            error.Error("This is a error message.");
            Console.ReadKey();
        }
    }
}
