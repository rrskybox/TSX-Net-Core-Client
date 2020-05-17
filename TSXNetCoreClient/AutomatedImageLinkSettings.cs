//***************************************************************************************
//
// Library TSXNetCoreClient: Class AutomatedImageLinkSettings
// Derived from SoftwareBisque, ScriptTheSkyX Specification V1.27
// Date: 15-May-2020
// Author: Rick McAlister, et. al.
// Version -- See Visual Studio Project
// Licence -- open
// 
//***************************************************************************************

using System;
using System.Collections.Generic;
using System.Text;

namespace TSXNetCoreClient
{
    public class AutomatedImageLinkSettings
    {
        const string TSXCLASS = "AutomatedImageLinkSettings.";
        const string CR = "\r\n";

        #region methods

        public double imageScale
        {
            get => Convert.ToDouble(Link.TSXSend(TSXCLASS + "imageScale"));
            set => Link.TSXSend(TSXCLASS + "imageScale=" + value.ToString() + ";");
        }

        public double positionAngle  //Probaly read only, but the doc doesn't say
        {
            get => Convert.ToDouble(Link.TSXSend(TSXCLASS + "positionAngle"));
            set => Link.TSXSend(TSXCLASS + "positionAngle=" + value.ToString() + ";");
        }

        public double exposureTimeAILS
        {
            get => Convert.ToDouble(Link.TSXSend(TSXCLASS + "exposureTimeAILS"));
            set => Link.TSXSend(TSXCLASS + "exposureTimeAILS=" + value.ToString() + ";");
        }

        public int fovsToSearch
        {
            get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "fovsToSearch"));
            set => Link.TSXSend(TSXCLASS + "fovsToSearch=" + value.ToString() + ";");
        }

        public int retries
        {
            get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "retries"));
            set => Link.TSXSend(TSXCLASS + "retries=" + value.ToString() + ";");
        }

        public string filterNameAILS  //Probably read-only, but doc doesn't say
        {
            get => Link.TSXSend(TSXCLASS + "filterNameAILS");
            set => Link.TSXSend(TSXCLASS + "\""+"filterNameAILS=" + "\"" + ";");
        }

                #endregion
    }
}
