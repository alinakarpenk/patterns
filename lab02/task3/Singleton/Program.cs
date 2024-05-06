using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Authenticator auth1 = Authenticator.Instance();
            Authenticator auth2 = Authenticator.Instance();
            Console.WriteLine(auth1 == auth2); 
            Console.ReadLine();
        }
    }
}
