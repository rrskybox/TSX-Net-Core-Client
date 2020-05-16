﻿//***************************************************************************************
//
// Library TSXNetCoreClient: Class sky6ObjectInformation
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
    public class sky6ObjectInformation
    {

        const string TSXCLASS = "sky6ObjectInformation.";

        //See notes in sky6DataWizard on the tsxoi object
        const string OICLASS = "tsxoi.";
        const string CR = "\r\n";

        #region enums


        #endregion

        #region methods

        public void Property(Sk6ObjectInformationProperty Which) =>
            Link.TSXSend(OICLASS + "Property(" +
                Convert.ToInt32(Which).ToString() + ")");

        public void PropertyApplies(Sk6ObjectInformationProperty Which) =>
            Link.TSXSend(OICLASS + "PropertyApplies(" +
                Convert.ToInt32(Which).ToString() + ")");

        public void PropertyName(Sk6ObjectInformationProperty Which) =>
            Link.TSXSend(OICLASS + "PropertyName(" +
                Convert.ToInt32(Which).ToString() + ")");

    
        #endregion

        public int Count { get => Convert.ToInt32(Link.TSXSend(OICLASS + "Count")); }

        public int Index
        {
            get => Convert.ToInt32(Link.TSXSend(OICLASS + "Index"));
            set => Link.TSXSend(OICLASS + "Index=" + value.ToString());
        }


        //ObjInfoPropOut returns one of three casts -- string, int or double.  This cast
        //isn't carried in the return from the TSX tcpclient.  So, this algorithm assumes that
        //the return string can be parsed to either 1) double or 2) integer, in that order using exceptions. The default
        //return is a string object.
        //
        public object ObjInfoPropOut
        {
            get
            {
                string sData = Link.TSXSend(OICLASS + "ObjInfoPropOut");
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

        #region properties

        #endregion

    }
}
