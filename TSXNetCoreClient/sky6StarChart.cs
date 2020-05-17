//***************************************************************************************
//
// Library TSXNetCoreClient: Class csky6StarChart
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
    public class sky6StarChart
    {
        const string TSXCLASS = "sky6StarChart.";
        const string CR = "\r\n";

        #region methods

        public void ClickFind(int StarChartX, int StarChartY) =>
            Convert.ToInt32(Link.TSXSend(TSXCLASS + "ClickFind(" +
                StarChartX.ToString() + "," +
                StarChartY.ToString() + ")"));

        public void EquatorialToStarChartXY(double RA, double Dec) =>
            Link.TSXSend(TSXCLASS + "EquatorialToStarChartXY(" +
                RA.ToString() + "," +
                Dec.ToString() + ")");

        public void Find(string ObjectName) =>
            Link.TSXSend(TSXCLASS + "Find(" +
                "\"" + ObjectName + "\"" + ")");

        public void Refresh() => Link.TSXSend(TSXCLASS + "Refresh()");

        public void Save() => Link.TSXSend(TSXCLASS + "Save()");

        public void StarChartXYToEquatorial(int StarChartX, int StarChartY) =>
            Link.TSXSend(TSXCLASS + "StarChartXYToEquatorial(" +
                StarChartX.ToString() + "," +
                StarChartY.ToString() + ")");

        public void UpdateSolarSystem() => Link.TSXSend(TSXCLASS + "UpdateSolarSystem()");

        public void DocumentProperty(Sk6DocumentProperty Which) =>
            Link.TSXSend(TSXCLASS + "DocumentProperty(" +
                Convert.ToInt32(Which).ToString() + ")");

        public void SetDocumentProperty(Sk6DocumentProperty Which, double vNewVal) =>
            Link.TSXSend(TSXCLASS + "SetDocumentProperty(" +
                Convert.ToInt32(Which).ToString() + "," +
                vNewVal.ToString() + ")");

        public void SetDocumentProperty(Sk6DocumentProperty Which, int vNewVal) =>
            Link.TSXSend(TSXCLASS + "SetDocumentProperty(" +
                Convert.ToInt32(Which).ToString() + "," +
                vNewVal.ToString() + ")");

        public void SetDocumentProperty(Sk6DocumentProperty Which, string vNewVal) =>
            Link.TSXSend(TSXCLASS + "SetDocumentProperty(" +
                Convert.ToInt32(Which).ToString() + "," +
                vNewVal + ")");

        public void DisplayProperty(Sk6DisplayPropertyObjectType nIndex, Sk6DisplayPropertySkyMode Mode, Sk6DisplayProperty Prop, Sk6DisplayPropertyItem Item) =>
            Link.TSXSend(TSXCLASS + "DisplayProperty(" +
                ((Int32)(object)nIndex).ToString() + "," +
                ((Int32)(object)Mode).ToString() + "," +
                ((Int32)(object)Prop).ToString() + "," +
                ((Int32)(object)Item).ToString() + ")");

        public void SetDisplayProperty(Sk6DisplayPropertyObjectType nIndex, Sk6DisplayPropertySkyMode Mode, Sk6DisplayProperty Prop, Sk6DisplayPropertyItem Item, double vNewVal) =>
            Link.TSXSend(TSXCLASS + "SetDisplayProperty(" +
                 ((Int32)(object)nIndex).ToString() + "," +
                 ((Int32)(object)Mode).ToString() + "," +
                 ((Int32)(object)Prop).ToString() + "," +
                 ((Int32)(object)Item).ToString() + "," +
                 vNewVal.ToString() + ")");

        public void SetDisplayProperty(Sk6DisplayPropertyObjectType nIndex, Sk6DisplayPropertySkyMode Mode, Sk6DisplayProperty Prop, Sk6DisplayPropertyItem Item, int vNewVal) =>
            Link.TSXSend(TSXCLASS + "SetDisplayProperty(" +
                ((Int32)(object)nIndex).ToString() + "," +
                ((Int32)(object)Mode).ToString() + "," +
                ((Int32)(object)Prop).ToString() + "," +
                ((Int32)(object)Item).ToString() + "," +
                vNewVal.ToString() + ")");

        public void SetDisplayProperty(Sk6DisplayPropertyObjectType nIndex, Sk6DisplayPropertySkyMode Mode, Sk6DisplayProperty Prop, Sk6DisplayPropertyItem Item, string vNewVal) =>
            Link.TSXSend(TSXCLASS + "SetDisplayProperty(" +
                ((Int32)(object)nIndex).ToString() + "," +
                ((Int32)(object)Mode).ToString() + "," +
                ((Int32)(object)Prop).ToString() + "," +
                ((Int32)(object)Item).ToString() + "," +
                vNewVal + ")");

        #endregion

        #region properties

        public double Declination
        {
            get => Convert.ToDouble(Link.TSXSend(TSXCLASS + "Declination"));
            set => Link.TSXSend(TSXCLASS + "Declination=" + value.ToString() + ";");
        }


        public double FieldOfView
        {
            get => Convert.ToDouble(Link.TSXSend(TSXCLASS + "FieldOfView"));
            set => Link.TSXSend(TSXCLASS + "FieldOfView=" + value.ToString() + ";");
        }


        public double Rotation
        {
            get => Convert.ToDouble(Link.TSXSend(TSXCLASS + "Rotation"));
            set => Link.TSXSend(TSXCLASS + "Rotation=" + value.ToString() + ";");
        }


        public int HeightInPixels
        {
            get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "HeightInPixels"));
            set => Link.TSXSend(TSXCLASS + "HeightInPixels=" + value.ToString() + ";");
        }


        public string Path
        {
            get => Link.TSXSend(TSXCLASS + "Path");
            set => Link.TSXSend(TSXCLASS + "Path=" + value.ToString() + ";");
        }


        public int WidthInPixels
        {
            get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "WidthInPixels"));
            set => Link.TSXSend(TSXCLASS + "WidthInPixels=" + value.ToString() + ";");
        }


        public double RightAscension
        {
            get => Convert.ToDouble(Link.TSXSend(TSXCLASS + "RightAscension"));
            set => Link.TSXSend(TSXCLASS + "RightAscension=" + value.ToString() + ";");
        }


        public object DocPropOut
        {
            get
            {
                string sData = Link.TSXSend(TSXCLASS + "DocPropOut");
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
            set => Link.TSXSend(TSXCLASS + "DocPropOut=" + value.ToString() + ";");
        }

        public object DispPropOut
        {
            get
            {
                string sData = Link.TSXSend(TSXCLASS + "DispPropOut");
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
            set => Link.TSXSend(TSXCLASS + "DispPropOut=" + value.ToString() + ";");
        }


        public double dOut0
        {
            get => Convert.ToDouble(Link.TSXSend(TSXCLASS + "dOut0"));
            set => Link.TSXSend(TSXCLASS + "dOut0=" + value.ToString() + ";");
        }


        public double dOut1
        {
            get => Convert.ToDouble(Link.TSXSend(TSXCLASS + "dOut1"));
            set => Link.TSXSend(TSXCLASS + "dOut1=" + value.ToString() + ";");
        }


        #endregion


    }
}
