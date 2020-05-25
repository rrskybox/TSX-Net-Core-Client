//***************************************************************************************
//
// Library TSXNetCoreClient: Class sky6Dome
// Derived from SoftwareBisque, ScriptTheSkyX Specification V1.27
// Date: 14-May-2020
// Author: Rick McAlister, et. al.
// Version -- See Visual Studio Project
// Licence -- open
// 
//***************************************************************************************

using System;

namespace TSXNetCoreClient
{
    public class sky6Dome
    {
        const string TSXCLASS = "sky6Dome.";
        const string CR = "\r\n";

        #region enumerations

        #endregion

        #region methods

        public void Abort() => Link.TSXSend(TSXCLASS + "Abort()");

        public void CloseSlit() => Link.TSXSend(TSXCLASS + "CloseSlit()");

        public void Connect() => Link.TSXSend(TSXCLASS + "Connect()");

        public void Disconnect() => Link.TSXSend(TSXCLASS + "Dusconnect()");

        public void FindHome() => Link.TSXSend(TSXCLASS + "FindHome()");

        public void GetAzEl() => Link.TSXSend(TSXCLASS + "GetAzEl()");

        public void GotoAzEl(double dAz, double dEl) =>
            Link.TSXSend(TSXCLASS + "GotoAzEl(" +
                dAz.ToString() + "," +
                dEl.ToString() + ")");

        public void OpenSlit() => Link.TSXSend(TSXCLASS + "OpenSlit()");

        public void Park() => Link.TSXSend(TSXCLASS + "Park()");

        public void Sync(double dAz, double dEl) =>
            Link.TSXSend(TSXCLASS + "Sync(" +
                dAz.ToString() + "," +
                dEl.ToString() + ")");

        public void Unpark() => Link.TSXSend(TSXCLASS + "Unpark()");

        public SlitState slitState() => (SlitState)Enum.Parse(typeof(SlitState), Link.TSXSend("slitState"), true);

        public int lastError() => ReliableConvert.ToInt32(Link.TSXSend(TSXCLASS + "lastError()"));

        #endregion

        #region properties
        public int IsConnected
        {
            get => ReliableConvert.ToInt32(Link.TSXSend(TSXCLASS + "IsConnected"));
            set => ReliableConvert.ToInt32(Link.TSXSend(TSXCLASS + "IsConnected=" + value.ToString() + ";"));
        }

        public int IsCoupled
        {
            get => ReliableConvert.ToInt32(Link.TSXSend(TSXCLASS + "IsCoupled"));
            set => ReliableConvert.ToInt32(Link.TSXSend(TSXCLASS + "IsCoupled=" + value.ToString() + ";"));
        }

        public double dAz { get => ReliableConvert.ToInt32(Link.TSXSend(TSXCLASS + "dAz")); }

        public double dEl { get => ReliableConvert.ToInt32(Link.TSXSend(TSXCLASS + "dEl")); }

        public int IsGotoComplete { get => ReliableConvert.ToInt32(Link.TSXSend(TSXCLASS + "IsGotoComplete")); }

        public int IsOpenComplete { get => ReliableConvert.ToInt32(Link.TSXSend(TSXCLASS + "IsOpenComplete")); }


        public int IsCloseComplete { get => ReliableConvert.ToInt32(Link.TSXSend(TSXCLASS + "IsCloseComplete")); }

        public int IsParkComplete { get => ReliableConvert.ToInt32(Link.TSXSend(TSXCLASS + "IsParkComplete")); }


        public int IsUnparkComplete { get => ReliableConvert.ToInt32(Link.TSXSend(TSXCLASS + "IsUnparkComplete")); }

        public int IsFindHomeComplete { get => ReliableConvert.ToInt32(Link.TSXSend(TSXCLASS + "IsFindHomeComplete")); }

        #endregion

    }
}
