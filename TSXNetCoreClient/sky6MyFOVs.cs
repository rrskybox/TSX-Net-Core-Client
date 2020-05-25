//***************************************************************************************
//
// Library TSXNetCoreClient: Class sky6MyFOVs
// Derived from SoftwareBisque, ScriptTheSkyX Specification V1.27
// Date: 15-May-2020
// Author: Rick McAlister, et. al.
// Version -- See Visual Studio Project
// Licence -- open
// 
//***************************************************************************************

using System;

namespace TSXNetCoreClient
{
    public class sky6MyFOVs
    {
        const string TSXCLASS = "sky6MyFOVs.";
        const string CR = "\r\n";

        #region methods

        public void Property(string FOVIName, sk6MyFOVElement Element, sk6MyFOVProperty Prop) =>
            Link.TSXSend(TSXCLASS + "Property(" +
                "\"" + FOVIName + "\"" + "," +
                Convert.ToInt32(Element).ToString() + "," +
                Convert.ToInt32(Prop).ToString() + ")");

        public void setProperty(string DectorName, sk6MyFOVElement Element, sk6MyFOVProperty property, double vVal) =>
            Link.TSXSend(TSXCLASS + "setProperty(" +
                "\"" + DectorName + "\"" + "," +
                Convert.ToInt32(Element).ToString() + "," +
                Convert.ToInt32(property).ToString() + "," +
                vVal.ToString() + ")");

        public void setProperty(string DectorName, sk6MyFOVElement Element, sk6MyFOVProperty Prop, int vVal) =>
            Link.TSXSend(TSXCLASS + "setProperty(" +
                "\"" + DectorName + "\"" + "," +
                Convert.ToInt32(Element).ToString() + "," +
                Convert.ToInt32(Prop).ToString() + "," +
                vVal.ToString() + ")");

        public void setProperty(string DectorName, sk6MyFOVElement Element, sk6MyFOVProperty Prop, string vVal) =>
             Link.TSXSend(TSXCLASS + "setProperty(" +
                 "\"" + DectorName + "\"" + "," +
                 Convert.ToInt32(Element).ToString() + "," +
                 Convert.ToInt32(Prop).ToString() + "," +
                 "\"" + vVal + "\"" + ")");

        public void Name(int Index) => Link.TSXSend(TSXCLASS + "Name(" + Index.ToString() + ")");

        public void Fill(sk6MyFOVReferenceFrame rf, sk6MyFOVShape shape, sk6MyFOVElement elem) =>
            Link.TSXSend(TSXCLASS + "Fill(" +
                Convert.ToInt32(rf).ToString() + "," +
                Convert.ToInt32(shape).ToString() + "," +
                Convert.ToInt32(elem).ToString() + ")");

        #endregion

        #region properties

        public int Count { get => ReliableConvert.ToInt32(Link.TSXSend(TSXCLASS + "Count")); }

        public string OutString { get => Link.TSXSend(TSXCLASS + "OutString"); }

        public object OutVar
        {
            get
            {
                string sData = Link.TSXSend(TSXCLASS + "OutVar");
                try
                {
                    double result = Double.Parse(sData);
                    return result;
                }
                catch
                {
                    try
                    {
                        int result = Int32.Parse(sData);
                        return result;
                    }
                    catch
                    {
                        string result = sData;
                        return result;

                    }
                }
            }
        }

        #endregion


    }
}
