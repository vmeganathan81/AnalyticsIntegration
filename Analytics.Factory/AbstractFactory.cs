using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalyticIntegration
{
    public abstract class AbstractFactory
    {
        protected abstract IAnalyticsIntegration MakeProduct();
        public IAnalyticsIntegration CreateProduct()
        {
            return this.MakeProduct();
        }
    }
}
