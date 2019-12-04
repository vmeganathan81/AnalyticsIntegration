using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalyticIntegration
{
    public class AppCenterFactory:AbstractFactory
    {
        protected override IAnalyticsIntegration MakeProduct()
        {
            IAnalyticsIntegration product = new AppCenterProxy();
            return product;
        }
    }
}
