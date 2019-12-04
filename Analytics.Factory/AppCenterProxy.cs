using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalyticIntegration
{
    public class AppCenterProxy : IAnalyticsIntegration
    {
        private string userId = $"{Environment.UserName}{Environment.MachineName}".GetHashCode().ToString();

        public AppCenterProxy()
        {
            AppCenter.Start("fb2c23b5-014c-4fdb-9026-d6ab0ab69368",
                   typeof(Analytics));
            AppCenter.SetUserId(userId);

        }

        public void TrackEvent(string Message, Dictionary<string, string> EventNames = null)
        {
            Analytics.TrackEvent(Message, EventNames);
            
        }

        public void SetUserId(string UserId)
        {
            this.userId = UserId;
        }

        public string GetUserId()
        {
            return this.userId;
        }
    }
}
