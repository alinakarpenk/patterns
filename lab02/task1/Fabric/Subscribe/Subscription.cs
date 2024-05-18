using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabric.Subscribe
{
    public abstract class Subscription
    {
        public decimal MonthlyFee { get; set; }
        public int MinimumSubscriptionPeriod { get; set; }
        public List<string> Channels { get; set; }

        public Subscription(decimal monthlyFee, int minimumSubscriptionPeriod)
        {
            MonthlyFee = monthlyFee;
            MinimumSubscriptionPeriod = minimumSubscriptionPeriod;
            Channels = new List<string>();
        }

        public abstract void AddExtraFeatures();
    }

}
