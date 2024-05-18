using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabric.Subscribe
{
    public class EducationalSubscription : Subscription
    {
        public EducationalSubscription(decimal monthlyFee, int minimumSubscriptionPeriod)
            : base(monthlyFee, minimumSubscriptionPeriod)
        {
        }

        public override void AddExtraFeatures()
        {
        }
    }
}
