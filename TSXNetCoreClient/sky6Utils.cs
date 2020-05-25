//***************************************************************************************
//
// Library TSXNetCoreClient: Class sky6Utils
// Derived from SoftwareBisque, ScriptTheSkyX Specification V1.27
// Date: 14-May-2020
// Author: Rick McAlister, et. al.
// Version -- See Visual Studio Project
// Licence -- open
// 
//***************************************************************************************

namespace TSXNetCoreClient
{
    public class sky6Utils
    {

        const string TSXCLASS = "sky6Utils.";
        const string CR = "\r\n";

        #region methods

        public void ConvertStringToRA(string strRA) =>
                 Link.TSXSend(TSXCLASS + "ConvertStringToRA(" +
                      "\"" + strRA + "\"" + ")");

        public void ConvertStringToDec(string strDec) =>
           Link.TSXSend(TSXCLASS + "ConvertStringToDec(" +
                "\"" + strDec + "\"" + ")");

        public void ConvertEquatorialToString(double RA1, double Dec1, int SigFigs) =>
           Link.TSXSend(TSXCLASS + "ConvertEquatorialToString(" +
                RA1.ToString() + "," +
                Dec1.ToString() + "," +
                SigFigs.ToString() + ")");

        public void ConvertHorizonToString(double Az, double Alt, int SigFigs) =>
           Link.TSXSend(TSXCLASS + "ConvertHorizonToString(" +
                Az.ToString() + "," +
                Alt.ToString() + "," +
                SigFigs.ToString() + ")");

        public void ConvertRADecToAzAlt(double ra, double dec) =>
           Link.TSXSend(TSXCLASS + "ConvertRADecToAzAlt(" +
                ra.ToString() + "," +
                dec.ToString() + ")");

        public void ConvertAzAltToRADec(double az, double alt) =>
           Link.TSXSend(TSXCLASS + "ConvertAzAltToRADec(" +
                az.ToString() + "," +
                alt.ToString() + ")");

        public void ConvertJulianDateToCalender(double JulianDay) =>
           Link.TSXSend(TSXCLASS + "ConvertJulianDateToCalender(" +
                JulianDay.ToString() + ")");

        public void ConvertCalenderToJulianDate(int Year, int Month, int Day, int Hour, int Minute, double Second) =>
           Link.TSXSend(TSXCLASS + "ConvertCalenderToJulianDate(" +
                Year.ToString() + "," +
                Month.ToString() + "," +
                Day.ToString() + "," +
                Hour.ToString() + "," +
                Minute.ToString() + "," +
                Second.ToString() + ")");

        public void ConvertDMSToAngle(int Degrees, int Minutes, double Seconds) =>
           Link.TSXSend(TSXCLASS + "ConvertDMSToAngle(" +
                Degrees.ToString() + "," +
                Minutes.ToString() + "," +
                Seconds.ToString() + ")");

        public void ConvertAngleToDMS(double Angle) =>
           Link.TSXSend(TSXCLASS + "ConvertAngleToDMS(" +
                Angle.ToString() + ")");

        public void ConvertSexagesimalToString(double Value, int Format, int SigFigs) =>
           Link.TSXSend(TSXCLASS + "ConvertSexagesimalToString(" +
                Value.ToString() + "," +
                Format.ToString() + "," +
                SigFigs.ToString() + ")");

        public void ComputePositionAngle(double RA1, double Dec1, double RA2, double Dec2) =>
           Link.TSXSend(TSXCLASS + "ComputePositionAngle(" +
                RA1.ToString() + "," +
                Dec1.ToString() + "," +
                RA2.ToString() + "," +
                Dec2.ToString() + ")");

        public void ComputeAngularSeparation(double RA1, double Dec1, double RA2, double Dec2) =>
           Link.TSXSend(TSXCLASS + "ComputeAngularSeparation(" +
                RA1.ToString() + "," +
                Dec1.ToString() + "," +
                RA2.ToString() + "," +
                Dec2.ToString() + ")");

        public void ComputeHourAngle(double Ra) =>
           Link.TSXSend(TSXCLASS + "ComputeHourAngle(" +
                Ra.ToString() + ")");

        public void ComputeAirMass(double Alt) =>
           Link.TSXSend(TSXCLASS + "ComputeAirMass(" +
                Alt.ToString() + ")");

        public void ComputeLocalSiderealTime() =>
           Link.TSXSend(TSXCLASS + "ComputeLocalSiderealTime()");

        public void ComputeUniversalTime() =>
           Link.TSXSend(TSXCLASS + "ComputeUniversalTime()");

        public void ComputeJulianDate() =>
           Link.TSXSend(TSXCLASS + "ComputeJulianDate()");

        public void ComputeRefraction(double Alt) =>
           Link.TSXSend(TSXCLASS + "ComputeRefraction(" +
                Alt.ToString() + ")");

        public void ComputeRiseTransitSetTimes(double RA, double Dec) =>
           Link.TSXSend(TSXCLASS + "ComputeRiseTransitSetTimes(" +
                RA.ToString() + "," +
                Dec.ToString() + ")");

        public void PrecessNowTo2000(double RA, double Dec) =>
           Link.TSXSend(TSXCLASS + "PrecessNowTo2000(" +
                RA.ToString() + "," +
                Dec.ToString() + ")");

        public void Precess2000ToNow(double RA, double Dec) =>
           Link.TSXSend(TSXCLASS + "Precess2000ToNow(" +
                RA.ToString() + "," +
                Dec.ToString() + ")");

        #endregion

        #region properties

        public string strOut { get => Link.TSXSend(TSXCLASS + "strOut"); }

        public double dOut0 { get => ReliableConvert.ToDouble(Link.TSXSend(TSXCLASS + "dOut0")); }

        public double dOut1 { get => ReliableConvert.ToDouble(Link.TSXSend(TSXCLASS + "dOut1")); }

        public double dOut2 { get => ReliableConvert.ToDouble(Link.TSXSend(TSXCLASS + "dOut2")); }

        public double dOut3 { get => ReliableConvert.ToDouble(Link.TSXSend(TSXCLASS + "dOut3")); }

        public double dOut4 { get => ReliableConvert.ToDouble(Link.TSXSend(TSXCLASS + "dOut4")); }

        public double dOut5 { get => ReliableConvert.ToDouble(Link.TSXSend(TSXCLASS + "dOut5")); }

        #endregion
    }
}
