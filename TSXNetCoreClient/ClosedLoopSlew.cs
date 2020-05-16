//***************************************************************************************
//
// Library TSXNetCoreClient: Class ClosedLoopSlew
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
    public class ClosedLoopSlew
    {
        const string TSXCLASS = "ClosedLoopSlew.";
        const string CR = "\r\n";

        #region methods

        public int exec()
        {
            try { return Convert.ToInt32(Link.TSXSend(TSXCLASS + "exec()")); }
            catch { return -1; }
        }

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
