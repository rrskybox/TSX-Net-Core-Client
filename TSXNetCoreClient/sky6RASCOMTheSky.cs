//***************************************************************************************
//
// Library TSXNetCoreClient: Class sky6RASCOMTheSky
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
    public class sky6RASCOMTheSky
    {
        const string TSXCLASS = "sky6RASCOMTheSky.";
        const string CR = "\r\n";

        #region methods

        public void Abort() => Link.TSXSend(TSXCLASS + "Abort()");

        public void AutoMap() => Link.TSXSend(TSXCLASS + "AutoMap()");

        public void Connect() => Link.TSXSend(TSXCLASS + "Connect()");

        public void ConnectDome() => Link.TSXSend(TSXCLASS + "ConnectDome()");

        public void CoupleDome() => Link.TSXSend(TSXCLASS + "CoupleDome()");

        public void Disconnect() => Link.TSXSend(TSXCLASS + "Disconnect()");

        public void DisconnectDome() => Link.TSXSend(TSXCLASS + "DisconnectDome()");

        public void DisconnectTelescope() => Link.TSXSend(TSXCLASS + "DisconnectTelescope()");

        public void GetObjectAzAlt(string lpszObjectName) => Link.TSXSend(TSXCLASS + "GetObjectAzAlt(" + "\"" + lpszObjectName + "\"" + ")");

        public void GetObjectRaDec(string lpszObjectName) => Link.TSXSend(TSXCLASS + "GetObjectRaDec(" + "\"" + lpszObjectName + "\"" + ")");

        public void ImageLink(double dRa2000, double dDec2000, double dImageScale) =>
            Link.TSXSend(TSXCLASS + "ImageLink(" +
                dRa2000.ToString() + "," +
                dDec2000.ToString() + "," +
                dImageScale.ToString() + ")");

        public void SetTelescopeParkPosition() => Link.TSXSend(TSXCLASS + "SetTelescopeParkPosition()");

        public void Quit() => Link.TSXSend(TSXCLASS + "Quit()");

        public void SetWhenWhere(double dJulianDay, int lDSTOption, int lUseSystemClock, string lpszDescription, double dLongitude, double dLatitude, double dTimeZone, double dElevation) =>
            Link.TSXSend(TSXCLASS + "SetWhenWhere(" +
                dJulianDay.ToString() + "," +
                lDSTOption.ToString() + "," +
                lUseSystemClock.ToString() + "," +
                "\"" + lpszDescription + "\"" + "," +
                dLongitude.ToString() + "," +
                dLatitude.ToString() + "," +
                dTimeZone.ToString() + "," +
                dElevation.ToString() + ")");

        #endregion

        #region properties

        public double dObjectAlt
        {
            get => Convert.ToDouble(Link.TSXSend(TSXCLASS + "dObjectAlt"));
            set => Link.TSXSend(TSXCLASS + "dObjectAlt=" + value.ToString() + ";");
        }

        public double dObjectAz
        {
            get => Convert.ToDouble(Link.TSXSend(TSXCLASS + "dObjectAz"));
            set => Link.TSXSend(TSXCLASS + "dObjectAz=" + value.ToString() + ";");
        }
        public double dObjectDec
        {
            get => Convert.ToDouble(Link.TSXSend(TSXCLASS + "dObjectDec"));
            set => Link.TSXSend(TSXCLASS + "dObjectDec=" + value.ToString() + ";");
        }
        public double dObjectRa
        {
            get => Convert.ToDouble(Link.TSXSend(TSXCLASS + "dObjectRa"));
            set => Link.TSXSend(TSXCLASS + "dObjectRa=" + value.ToString() + ";");
        }
        public double dScreenDec
        {
            get => Convert.ToDouble(Link.TSXSend(TSXCLASS + "dScreenDec"));
            set => Link.TSXSend(TSXCLASS + "dScreenDec=" + value.ToString() + ";");
        }
        public double dScreenFOV
        {
            get => Convert.ToDouble(Link.TSXSend(TSXCLASS + "dScreenFOV"));
            set => Link.TSXSend(TSXCLASS + "dScreenFOV=" + value.ToString() + ";");
        }
        public double dScreenRa
        {
            get => Convert.ToDouble(Link.TSXSend(TSXCLASS + "dScreenRa"));
            set => Link.TSXSend(TSXCLASS + "dScreenRa=" + value.ToString() + ";");
        }
        public double dScreenRotation
        {
            get => Convert.ToDouble(Link.TSXSend(TSXCLASS + "dScreenRotation"));
            set => Link.TSXSend(TSXCLASS + "dScreenRotation=" + value.ToString() + ";");
        }
        public int IsConnected
        {
            get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "IsConnected"));
        }

        public int IsAsynchronous
        {
            get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "IsAsynchronous"));
            set => Link.TSXSend(TSXCLASS + "IsAsynchronous=" + value.ToString() + ";");
        }
        #endregion

    }
}
