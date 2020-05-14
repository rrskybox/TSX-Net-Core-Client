using System;
using System.Collections.Generic;
using System.Text;

namespace TSXNetCoreClient
{
    public class sky6RASCOMTele
    {
        const string CR = "\r\n";

        public void Connect() => Link.TSXSend("sky6RASCOMTele.Connect()");

        public void Disconnect() => Link.TSXSend("sky6RASCOMTele.Disconnect()");

        public void SlewToAzAlt(double az, double alt, string name) =>
            Link.TSXSend("var name=\"" + name + "\";" + CR + "sky6RASCOMTele.SlewToAzAlt(" + az + "," + alt + "," + "name" + ")");

        public void SlewToRaDec(double ra, double dec, string name) =>
           Link.TSXSend("var name=\"" + name + "\";" + CR + "sky6RASCOMTele.SlewToRaDec(" + ra + "," + dec + "," + "name" + ")");

        public void GetAzAlt() => Link.TSXSend("sky6RASCOMTele.GetAzAlt()");

        public void GetRaDec() => Link.TSXSend("sky6RASCOMTele.GetRaDec()");

        public double dAz { get => Convert.ToDouble(Link.TSXSend("sky6RASCOMTele.dAz")); }

        public double dAlt { get => Convert.ToDouble(Link.TSXSend("sky6RASCOMTele.dAlt")); }

        public double dRa { get => Convert.ToDouble(Link.TSXSend("sky6RASCOMTele.dRa")); }

        public double dDec { get => Convert.ToDouble(Link.TSXSend("sky6RASCOMTele.dDec")); }

        public bool IsParked() => Convert.ToBoolean(Link.TSXSend("sky6RASCOMTele.IsParked()")); 
   
        public void Park() => Link.TSXSend("sky6RASCOMTele.Park()");
      
        public void Unpark() => Link.TSXSend("sky6RASCOMTele.Unpark()");

        public void ParkAndDoNotDisconnect() => Link.TSXSend("sky6RASCOMTele.ParkAndDoNotDisconnect()");

        public void ConnectAndDoNotUnpark() => Link.TSXSend("sky6RASCOMTele.ConnectAndDoNotUnpark()");
    }
}
