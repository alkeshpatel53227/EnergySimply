using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using System.Threading.Tasks;
using System.Timers;
using System.Web.Caching;
using System.Net;

namespace EnergySimply
{
    public class Global : HttpApplication
    {
        private static CacheItemRemovedCallback OnCacheRemove = null;
        public static string batchRunner = "run";
       public static int batchSeconds = 5;
        //public static int batchSeconds = 28800;
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AddTask(batchRunner, batchSeconds);
        }

        public void startBatch()
        {
            AddTask(batchRunner, batchSeconds);
        }
        private void AddTask(string name, int seconds)
        {
            OnCacheRemove = new CacheItemRemovedCallback(CacheItemRemoved);
            HttpRuntime.Cache.Insert(name, seconds, null,
                DateTime.Now.AddSeconds(seconds), Cache.NoSlidingExpiration,
                CacheItemPriority.NotRemovable, OnCacheRemove);
        }

        public void CacheItemRemoved(string k, object v, CacheItemRemovedReason r)
        {
            // do stuff here if it matches our taskname, like WebRequest
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(@"http://alkesh-patel.com/EnergySimply/Handlers/SaveExcel.ashx");
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            // re-add our task so it recurs
            if (batchRunner == "run"){
                AddTask(batchRunner, batchSeconds);
            }
            
        }
    }
}