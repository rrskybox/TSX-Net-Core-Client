//***************************************************************************************
//
// Library TSXNetCoreClient: Class ImageLinkResults
// Derived from SoftwareBisque, ScriptTheSkyX Specification V1.27
// Date: 14-May-2020
// Author: Rick McAlister, et. al.
// Version -- See Visual Studio Project
// Licence -- open
// 
//***************************************************************************************

namespace TSXNetCoreClient
{
    public class ImageLinkResults
    {
        const string TSXCLASS = "ImageLinkResults.";
        const string CR = "\r\n";

        #region properties

        public int errorCode { get => ReliableConvert.ToInt32(Link.TSXSend(TSXCLASS + "errorCode")); }

        public int succeeded { get => ReliableConvert.ToInt32(Link.TSXSend(TSXCLASS + "succeeded")); }

        public int searchAborted { get => ReliableConvert.ToInt32(Link.TSXSend(TSXCLASS + "searchAborted")); }

        public string errorText { get => (Link.TSXSend(TSXCLASS + "errorText")); }

        public double imageScale { get => ReliableConvert.ToDouble(Link.TSXSend(TSXCLASS + "imageScale")); }

        public double imagePositionAngle { get => ReliableConvert.ToDouble(Link.TSXSend(TSXCLASS + "imagePositionAngle")); }

        public double imageCenterRAJ2000 { get => ReliableConvert.ToDouble(Link.TSXSend(TSXCLASS + "imageCenterRAJ2000")); }

        public double imageCenterDecJ2000 { get => ReliableConvert.ToDouble(Link.TSXSend(TSXCLASS + "imageCenterDecJ2000")); }

        public int imageWidthInPixels { get => ReliableConvert.ToInt32(Link.TSXSend(TSXCLASS + "imageWidthInPixels")); }

        public int imageHeightInPixels { get => ReliableConvert.ToInt32(Link.TSXSend(TSXCLASS + "imageHeightInPixels")); }

        public int imageIsMirrored { get => ReliableConvert.ToInt32(Link.TSXSend(TSXCLASS + "imageIsMirrored")); }

        public string imageFilePath { get => Link.TSXSend(TSXCLASS + "imageFilePath"); }

        public int imageStarCount { get => ReliableConvert.ToInt32(Link.TSXSend(TSXCLASS + "imageStarCount")); }

        public double imageFWHMInArcSeconds { get => ReliableConvert.ToDouble(Link.TSXSend(TSXCLASS + "imageFWHMInArcSeconds")); }

        public double solutionRMS { get => ReliableConvert.ToDouble(Link.TSXSend(TSXCLASS + "solutionRMS")); }

        public double solutionRMSX { get => ReliableConvert.ToDouble(Link.TSXSend(TSXCLASS + "solutionRMSX")); }

        public double solutionRMSY { get => ReliableConvert.ToDouble(Link.TSXSend(TSXCLASS + "solutionRMSY")); }

        public int solutionStarCount { get => ReliableConvert.ToInt32(Link.TSXSend(TSXCLASS + "solutionStarCount")); }

        public int catalogStarCount { get => ReliableConvert.ToInt32(Link.TSXSend(TSXCLASS + "catalogStarCount")); }

        #endregion
    }
}
