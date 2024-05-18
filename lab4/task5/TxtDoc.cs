using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    public class TxtDoc
    {
        public string Content { get; set; }
        public TxtDoc()
        {
            Content = string.Empty;
        }
        public override string ToString()
        {
            return Content;
        }
    }
}
