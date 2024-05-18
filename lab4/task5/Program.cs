using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    public class Program
    {
        static void Main(string[] args)
        {
            TxtEdit editor = new TxtEdit();
            editor.Write("Hello, ");
            editor.PrintContent(); 
            editor.Write("world!");
            editor.PrintContent(); 
            editor.Undo();
            editor.PrintContent(); 
            editor.Undo();
            editor.PrintContent(); 
            editor.Undo();
            Console.ReadKey();
        }
    }
}
