using Fabric.Subscribe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabric.Create
{
    public class WebSite
    {
        public Subscription CreateSubscription(decimal monthlyFee, int minimumSubscriptionPeriod, string type)
        {
            if (type == "Domestic")
            {
                return new DomesticSubscription(monthlyFee, minimumSubscriptionPeriod);
            }
            else if (type == "Educational")
            {
                return new EducationalSubscription(monthlyFee, minimumSubscriptionPeriod);
            }
            else if (type == "Premiu")
            {
                return new PremiumSubscription(monthlyFee, minimumSubscriptionPeriod);
            }
            else
            {
                throw new ArgumentException("Invalid subscription type");
            }
        }
    }
}
