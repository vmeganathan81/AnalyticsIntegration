using AnalyticIntegration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Analytics
{
    class Program
    {
        static void Main(string[] args)
        {

            IAnalyticsIntegration analyticsInstance = new AppCenterFactory().CreateProduct();
            if (analyticsInstance != null)
            {
                analyticsInstance.TrackEvent("Testing 2...");
                Console.WriteLine(analyticsInstance.GetUserId());
            }
            else
            {
                Console.Write("Invalid Analytics Instance Type");
            }

            Console.ReadLine();
        }
    }
}
