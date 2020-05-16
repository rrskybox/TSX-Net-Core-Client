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

using System;

namespace TSXNetCoreClient
{
    public class ImageLinkResults
    {
        const string TSXCLASS = "ImageLinkResults.";
        const string CR = "\r\n";

        #region properties

        public int errorCode { get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "errorCode")); }

        public int succeeded { get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "succeeded")); }

        public int searchAborted { get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "searchAborted")); }

        public string errorText { get => (Link.TSXSend(TSXCLASS + "errorText")); }

        public double imageScale { get => Convert.ToDouble(Link.TSXSend(TSXCLASS + "imageScale")); }

        public double imagePositionAngle { get => Convert.ToDouble(Link.TSXSend(TSXCLASS + "imagePositionAngle")); }

        public double imageCenterRAJ2000 { get => Convert.ToDouble(Link.TSXSend(TSXCLASS + "imageCenterRAJ2000")); }

        public double imageCenterDecJ2000 { get => Convert.ToDouble(Link.TSXSend(TSXCLASS + "imageCenterDecJ2000")); }

        public int imageWidthInPixels { get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "imageWidthInPixels")); }

        public int imageHeightInPixels { get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "imageHeightInPixels")); }

        public int imageIsMirrored { get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "imageIsMirrored")); }

        public string imageFilePath { get => Link.TSXSend(TSXCLASS + "imageFilePath"); }

        public int imageStarCount { get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "imageStarCount")); }

        public double imageFWHMInArcSeconds { get => Convert.ToDouble(Link.TSXSend(TSXCLASS + "imageFWHMInArcSeconds")); }

        public double solutionRMS { get => Convert.ToDouble(Link.TSXSend(TSXCLASS + "solutionRMS")); }

        public double solutionRMSX { get => Convert.ToDouble(Link.TSXSend(TSXCLASS + "solutionRMSX")); }

        public double solutionRMSY { get => Convert.ToDouble(Link.TSXSend(TSXCLASS + "solutionRMSY")); }

        public int solutionStarCount { get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "solutionStarCount")); }

        public int catalogStarCount { get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "catalogStarCount")); }

        #endregion
    }
}
