using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalyticIntegration
{
    public interface IAnalyticsIntegration
    {
        void TrackEvent(string Message, Dictionary<string, string> EventNames = null);

        void SetUserId(string UserId);

        string GetUserId();
    }
}
