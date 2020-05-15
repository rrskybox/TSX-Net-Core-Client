using System;

namespace TSXNetCoreClient
{
    public class ClosedLoopSlew
    {
        const string TSXCLASS = "ClosedLoopSlew.";
        const string CR = "\r\n";

        #region methods

        public int exec() => Convert.ToInt32(Link.TSXSend(TSXCLASS + "exec()"));

        #endregion

        #region properties

        public int asynchronous
        {
            get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "asynchronous"));
            set => Link.TSXSend(TSXCLASS + "asynchronous=" + value.ToString() + ";");
        }

        public double lastError { get => Convert.ToDouble(Link.TSXSend(TSXCLASS + "lastError")); }

        public int isClosedLoopSlewComplete { get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "isClosedLoopSlewComplete")); }

        #endregion
    }
}
