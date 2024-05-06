using Fabric.Create;
using Fabric.Subscribe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WebSite webSite = new WebSite();
            Subscription domesticSubscription = webSite.CreateSubscription(20, 6, "Domestic");
            Subscription educationalSubscription = webSite.CreateSubscription(30, 12, "Educational");
            domesticSubscription.AddExtraFeatures();
            educationalSubscription.AddExtraFeatures();
            Console.WriteLine("Domestic Subscription:");
            Console.WriteLine($"Monthly Fee: {domesticSubscription.MonthlyFee}, Minimum Subscription Period: {domesticSubscription.MinimumSubscriptionPeriod}");
            Console.WriteLine("Educational Subscription:");
            Console.WriteLine($"Monthly Fee: {educationalSubscription.MonthlyFee}, Minimum Subscription Period: {educationalSubscription.MinimumSubscriptionPeriod}");

            Console.ReadKey();  
        }
    }
}
