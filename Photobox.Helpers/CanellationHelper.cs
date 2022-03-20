using System;
using System.Threading;

namespace Photobox.WPFClient.helper
{
    public class CanellationHelper 
    {
        private static CanellationHelper instance;
        private static object syncRoot = new Object();
        public bool CancellationToken { get; set; } = false;
        public static CanellationHelper Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new CanellationHelper();
                    }
                }
                return instance;
            }
        }
    }
}
