using System;
using System.Threading;

namespace Photobox.Helpers
{
    public class CanellationHelper
    {
        private static CanellationHelper instance;
        private static object syncRoot = new object();
        public bool CancellationToken { get; set; } = true;
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
