using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Authenticator
    {
        private static readonly object lockObject = new object();
        private static Authenticator instance;
        private Authenticator() { }
        public static Authenticator Instance()
        {
            if (instance == null)
            {
                lock (lockObject)
                {
                    if (instance == null)
                    {
                        instance = new Authenticator();
                    }
                }
            }
            return instance;
        }
    }
}
        

