//***************************************************************************************
//
// Library TSXNetCoreClient: Class sk6RASCOMTele
// Derived from SoftwareBisque, ScriptTheSkyX Specification V1.27
// Date: 14-May-2020
// Author: Rick McAlister, et. al.
// Version -- See Visual Studio Project
// Licence -- open
// 
//***************************************************************************************

namespace TSXNetCoreClient
{
    public class sky6RASCOMTele
    {
        const string TSXCLASS = "sky6RASCOMTele.";
        const string CR = "\r\n";

        #region methods

        public void Abort() => Link.TSXSend(TSXCLASS + "Abort()");

        public void CommutateMotors() => Link.TSXSend(TSXCLASS + "CommutateMotors()");

        public void Connect() => Link.TSXSend(TSXCLASS + "Connect()");

        public void DoCommand(int lParam, string qsParam) =>
            Link.TSXSend(TSXCLASS + "DoCommand(" + lParam.ToString() + "\"" + qsParam + "\"" + ");");

        public void Disconnect() => Link.TSXSend(TSXCLASS + "Disconnect()");

        public void FindHome() => Link.TSXSend(TSXCLASS + "FindHome()");

        public void FocusInFast() => Link.TSXSend(TSXCLASS + "FocusInFast()");

        public void FocusInSlow() => Link.TSXSend(TSXCLASS + "FocusInSlow()");

        public void FocusOutFast() => Link.TSXSend(TSXCLASS + "FocusOutFast()");

        public void FocusOutSlow() => Link.TSXSend(TSXCLASS + "FocusOutSlo(w)");

        public void GetAzAlt() => Link.TSXSend(TSXCLASS + "GetAzAlt()");

        public void GetRaDec() => Link.TSXSend(TSXCLASS + "GetRaDec()");

        public void Jog(double dJogAmtInMins, string lpszDirection) =>
            Link.TSXSend(TSXCLASS + "Jog(" + dJogAmtInMins.ToString() + "\"" + lpszDirection + "\"" + ");");

        public void SetParkPosition() => Link.TSXSend(TSXCLASS + "SetParkPosition()");

        public void SetTracking(int lOn, int lIgnoreRates, double dRaRate, double dDecRate) =>
                        Link.TSXSend(TSXCLASS + "SetTracking(" + lOn.ToString() + "," + lIgnoreRates.ToString() + dRaRate.ToString() + dDecRate.ToString() + ")");

        public void SlewToAzAlt(double az, double alt, string name) =>
            //    Link.TSXSend("var name=\"" + name + "\";" + CR + TSXCLASS + "SlewToAzAlt(" + az.ToString() + "," + alt.ToString() + "," + "name" + ")");
            Link.TSXSend(TSXCLASS + "SlewToAzAlt(" + az.ToString() + "," + alt.ToString() + "," + "\"" + name + "\"" + ")");

        public void SlewToRaDec(double ra, double dec, string name) =>
            //Link.TSXSend("var name=\"" + name + "\";" + CR + TSXCLASS + "SlewToRaDec(" + ra.ToString() + "," + dec.ToString() + "," + "name" + ")");
            Link.TSXSend(TSXCLASS + "SlewToRaDec(" + ra.ToString() + "," + dec.ToString() + "," + "\"" + name + "\"" + ")");

        public void Sync(double dRa, double dDec, string lpszObjectName) =>
            //.TSXSend("var name=\"" + lpszObjectName + "\";" + CR + TSXCLASS + "Sync(" + dRa.ToString() + dDec.ToString() + ",name);");
            Link.TSXSend(TSXCLASS + "Sync(" + dRa.ToString() + "," + dDec.ToString() + "," + "\"" + lpszObjectName + "\"" + ")");

        public void Park() => Link.TSXSend(TSXCLASS + "Park()");

        public void Unpark() => Link.TSXSend(TSXCLASS + "Unpark()");

        public void ParkAndDoNotDisconnect() => Link.TSXSend(TSXCLASS + "ParkAndDoNotDisconnect()");

        public bool IsParked() => ReliableConvert.ToBoolean(Link.TSXSend(TSXCLASS + "IsParked()"));

        public void ConnectAndDoNotUnpark() => Link.TSXSend(TSXCLASS + "ConnectAndDoNotUnpark()");

        #endregion

        #region properties

        public double dAz { get => ReliableConvert.ToDouble(Link.TSXSend(TSXCLASS + "dAz")); }

        public double dAlt { get => ReliableConvert.ToDouble(Link.TSXSend(TSXCLASS + "dAlt")); }

        public double dRa { get => ReliableConvert.ToDouble(Link.TSXSend(TSXCLASS + "dRa")); }

        public double dDec { get => ReliableConvert.ToDouble(Link.TSXSend(TSXCLASS + "dDec")); }

        public int Asynchronous
        {
            get => ReliableConvert.ToInt32(Link.TSXSend(TSXCLASS + "Asynchronous"));
            set => Link.TSXSend(TSXCLASS + "Asynchronous=" + value.ToString() + ";");
        }

        public double dDecTrackingRate { get => ReliableConvert.ToDouble(Link.TSXSend(TSXCLASS + "dDecTrackingRate")); }

        public double dRaTrackingRate { get => ReliableConvert.ToDouble(Link.TSXSend(TSXCLASS + "dRaTrackingRate")); }

        public double LastSlewError { get => ReliableConvert.ToDouble(Link.TSXSend(TSXCLASS + "LastSlewError")); }

        public int IsConnected { get => ReliableConvert.ToInt32(Link.TSXSend(TSXCLASS + "IsConnected")); }

        public int IsInLimit { get => ReliableConvert.ToInt32(Link.TSXSend(TSXCLASS + "IsInLimit")); }

        public int IsSlewComplete { get => ReliableConvert.ToInt32(Link.TSXSend(TSXCLASS + "IsSlewComplete")); }

        public int IsTracking { get => ReliableConvert.ToInt32(Link.TSXSend(TSXCLASS + "IsTracking")); }

        public string DoCommandOutput { get => Link.TSXSend(TSXCLASS + "DoCommandOutput"); }
        #endregion
    }
}
