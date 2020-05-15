using System;

namespace TSXNetCoreClient
{
    public class sky6Dome
    {

        const string TSXCLASS = "sky6DataWizard.";
        const string CR = "\r\n";

        #region enumerations

        #endregion

        #region methods

        public void Abort() => Link.TSXSend(TSXCLASS + "Abort()");

        public void CloseSlit() => Link.TSXSend(TSXCLASS + "CloseSlit()");
        public void Connect() => Link.TSXSend(TSXCLASS + "Connect()");

        public void FindHome() => Link.TSXSend(TSXCLASS + "FindHome()");


        public void GetAzEl() => Link.TSXSend(TSXCLASS + "GetAzEl()");

        public void GotoAzEl(double dAz, double dEl) =>
            Convert.ToInt32(Link.TSXSend(TSXCLASS + "GotoAzEl(" +
                dAz.ToString() + "," +
                dEl.ToString() + ")"));

        public void OpenSlit() => Link.TSXSend(TSXCLASS + "OpenSlit()");

        public void Park() => Link.TSXSend(TSXCLASS + "Park()");

        public void Sync(double dAz, double dEl) =>
            Convert.ToInt32(Link.TSXSend(TSXCLASS + "Sync(" +
                dAz.ToString() + "," +
                dEl.ToString() + ")"));

        public void Unpark() => Link.TSXSend(TSXCLASS + "Unpark()");

        public SlitState slitState() => (SlitState)Enum.Parse(typeof(SlitState), Link.TSXSend("slitState"), true);

        public int lastError() => Convert.ToInt32(Link.TSXSend(TSXCLASS + "lastError()"));

        #endregion

        #region properties
        public int IsConnected
        {
            get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "IsConnected"));
            set => Convert.ToInt32(Link.TSXSend(TSXCLASS + "IsConnected=" + value.ToString() + ";"));
        }

        public int IsCoupled
        {
            get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "IsCoupled"));
            set => Convert.ToInt32(Link.TSXSend(TSXCLASS + "IsCoupled=" + value.ToString() + ";"));
        }

        public double dAz { get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "dAz")); }

        public double dEl { get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "dEl")); }

        public int IsGotoComplete { get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "IsGotoComplete")); }

        public int IsOpenComplete { get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "IsOpenComplete")); }


        public int IsCloseComplete { get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "IsCloseComplete")); }

        public int IsParkComplete { get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "IsParkComplete")); }


        public int IsUnparkComplete { get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "IsUnparkComplete")); }

        public int IsFindHomeComplete { get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "IsFindHomeComplete")); }

        #endregion

    }
}
