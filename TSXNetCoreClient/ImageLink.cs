//***************************************************************************************
//
// Library TSXNetCoreClient: Class ImageLink
// Derived from SoftwareBisque, ScriptTheSkyX Specification V1.27
// Date: 14-May-2020
// Author: Rick McAlister, et. al.
// Version -- See Visual Studio Project
// Licence -- open
// 
//***************************************************************************************

namespace TSXNetCoreClient
{
    public class ImageLink
    {
        const string TSXCLASS = "ImageLink.";
        const string CR = "\r\n";

        #region methods

        public void execute() => Link.TSXSend(TSXCLASS + "execute()");

        #endregion

        #region properties

        public string pathToFITS
        {
            get => Link.TSXSend(TSXCLASS + "pathToFITS");
            set => Link.TSXSend(TSXCLASS + "pathToFits=" + "\"" + value + "\"");
        }

        public double scale
        {
            get => ReliableConvert.ToDouble(Link.TSXSend(TSXCLASS + "scale"));
            set => Link.TSXSend(TSXCLASS + "scale=" + value.ToString());
        }

        public bool unknownScale
        {
            get => ReliableConvert.ToBoolean(Link.TSXSend(TSXCLASS + "scale"));
            set => Link.TSXSend(TSXCLASS + "scale=" + value.ToString());
        }

        #endregion
    }
}
