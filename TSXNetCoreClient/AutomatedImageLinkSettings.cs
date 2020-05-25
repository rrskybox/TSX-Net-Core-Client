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

namespace TSXNetCoreClient
{
    public class AutomatedImageLinkSettings
    {
        const string TSXCLASS = "AutomatedImageLinkSettings.";
        const string CR = "\r\n";

        #region properties

        public double imageScale
        {
            get => ReliableConvert.ToDouble(Link.TSXSend(TSXCLASS + "imageScale"));
            set => Link.TSXSend(TSXCLASS + "imageScale=" + value.ToString() + ";");
        }

        public double positionAngle  //Probaly read only, but the doc doesn't say
        {
            get => ReliableConvert.ToDouble(Link.TSXSend(TSXCLASS + "positionAngle"));
            set => Link.TSXSend(TSXCLASS + "positionAngle=" + value.ToString() + ";");
        }

        public double exposureTimeAILS
        {
            get => ReliableConvert.ToDouble(Link.TSXSend(TSXCLASS + "exposureTimeAILS"));
            set => Link.TSXSend(TSXCLASS + "exposureTimeAILS=" + value.ToString() + ";");
        }

        public int fovsToSearch
        {
            get => ReliableConvert.ToInt32(Link.TSXSend(TSXCLASS + "fovsToSearch"));
            set => Link.TSXSend(TSXCLASS + "fovsToSearch=" + value.ToString() + ";");
        }

        public int retries
        {
            get => ReliableConvert.ToInt32(Link.TSXSend(TSXCLASS + "retries"));
            set => Link.TSXSend(TSXCLASS + "retries=" + value.ToString() + ";");
        }

        public string filterNameAILS  //Probably read-only, but doc doesn't say
        {
            get => Link.TSXSend(TSXCLASS + "filterNameAILS");
            set => Link.TSXSend(TSXCLASS + "\"" + "filterNameAILS=" + "\"" + ";");
        }

        #endregion
    }
}
