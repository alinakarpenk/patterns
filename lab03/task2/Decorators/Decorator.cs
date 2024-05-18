using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task2.Items;

namespace task2.Decorators
{
    public abstract class Decorator : IItem
    {
        private readonly IItem _item;
        public Decorator(IItem item)
        {
            _item = item;
        }
        public virtual string Description => _item.Description;
    }
}
