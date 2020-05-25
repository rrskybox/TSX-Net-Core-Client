using System;

namespace TSXNetCoreClient
{
    public class ccdsoftImage
    {
        const string TSXCLASS = "ccdsoftCameraImage.";
        const string CR = "\r\n";

        #region enumerations
        public enum ccdsoftCoordinates { cdRA, cdDec }

        public enum ccdsoftSaveAs { cdGIF, cdBMP, cdJPG, cd48BitTIF }

        #endregion

        #region methods
        int Open() => ReliableConvert.ToInt32(Link.TSXSend(TSXCLASS + "Open()"));

        public int Save() => ReliableConvert.ToInt32(Link.TSXSend(TSXCLASS + "Save()"));

        public int Close() => ReliableConvert.ToInt32(Link.TSXSend(TSXCLASS + "Close()"));

        public int AttachToActive() => ReliableConvert.ToInt32(Link.TSXSend(TSXCLASS + "AttachToActive()"));

        public int ApplyBackgroundRange() => ReliableConvert.ToInt32(Link.TSXSend(TSXCLASS + "ApplyBackgroundRange()"));

        public int New(int Width, int Height, int BitsPerPixel) =>
            ReliableConvert.ToInt32(Link.TSXSend(TSXCLASS + "New(" +
                Width.ToString() + "," +
                Height.ToString() + "," +
                BitsPerPixel.ToString() + ")"));

        public int Zoom(int Numerator, int Denominator) =>
            ReliableConvert.ToInt32(Link.TSXSend(TSXCLASS + "Zoom(" +
                Numerator.ToString() + "," +
                Denominator.ToString() + ")"));

        public int SetActive() => ReliableConvert.ToInt32(Link.TSXSend(TSXCLASS + "SetActive()"));

        public int AttachToActiveImager() => ReliableConvert.ToInt32(Link.TSXSend(TSXCLASS + "AttachToActiveImager()"));

        public int AttachToActiveAutoguider() => ReliableConvert.ToInt32(Link.TSXSend(TSXCLASS + "AttachToActiveAutoguider()"));

        public object FITSKeyword(string qsKeyword)
        {
            //FITSKeywwod returns one of three casts -- string, int or double.  This cast
            //isn't carried in the return from the TSX tcpclient.  So, this algorithm assumes that
            //the return string can be parsed to either 1) double or 2) integer, in that order using exceptions. The default
            //return is a string object.
            //

            string sData = Link.TSXSend(TSXCLASS + "FITSKeyword(" + "\"" + qsKeyword + "\"" + ")");
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

        public void setFITSKeyword(string qsKeyword, string value) =>
                   ReliableConvert.ToInt32(Link.TSXSend(TSXCLASS + "setFITSKeyword(" +
                       "\"" + qsKeyword + "\"" + "," +
                       "\"" + value + "\"" + ")"));

        public void setFITSKeyword(string qsKeyword, int value) =>
                   ReliableConvert.ToInt32(Link.TSXSend(TSXCLASS + "setFITSKeyword(" +
                       "\"" + qsKeyword + "\"" + "," +
                        value.ToString() + ")"));

        public void setFITSKeyword(string qsKeyword, double value) =>
                    ReliableConvert.ToInt32(Link.TSXSend(TSXCLASS + "setFITSKeyword(" +
                        "\"" + qsKeyword + "\"" + "," +
                       value.ToString() + ")"));

        public int InsertWCS(int RedoExistingSolution) =>
            ReliableConvert.ToInt32(Link.TSXSend(TSXCLASS + "InsertWCS(" +
                RedoExistingSolution.ToString() + ")"));

        public int XYToRADec(double X, double Y) =>
            ReliableConvert.ToInt32(Link.TSXSend(TSXCLASS + "XYToRADec(" +
                X.ToString() + "," +
                Y.ToString() + ")"));

        public int RADecToXY(double RA, double Dec) =>
            ReliableConvert.ToInt32(Link.TSXSend(TSXCLASS + "RADecToXY(" +
                RA.ToString() + "," +
                Dec.ToString() + ")"));

        public double[] WCSArray(int WCSIndex) => Array.ConvertAll((Link.TSXSend(TSXCLASS + "WCSArray(" + WCSIndex.ToString() + ")")).Split(','), Double.Parse);

        public int ShowInventory() => ReliableConvert.ToInt32(Link.TSXSend(TSXCLASS + "ShowInventory()"));

        public double[] InventoryArray(int InventoryIndex)
        {
            string a = Link.TSXSend(TSXCLASS + "InventoryArray(" + InventoryIndex.ToString() + ")");
            string[] aArray = a.Split(',', StringSplitOptions.RemoveEmptyEntries);
            double[] dArray = Array.ConvertAll(aArray, double.Parse);
            return dArray;
        }

        public string FindInventoryAtRADec(double RA, double Dec) =>
            Link.TSXSend(TSXCLASS + "FindInventoryAtRADec(" +
                RA.ToString() + "," +
                Dec.ToString() + ")");

        // //public int MakeComparisonStarChart(QString &pVal)

        public int AutoContrast(int Method, int Background, int Highlight) =>
                    ReliableConvert.ToInt32(Link.TSXSend(TSXCLASS + "AutoContrast(" +
                        Method.ToString() + "," +
                        Background.ToString() + "," +
                        Highlight.ToString() + ")"));

        public int SaveAs(int Type, int Param = 0) =>
            ReliableConvert.ToInt32(Link.TSXSend(TSXCLASS + "SaveAs(" +
                Type.ToString() + "," +
                Param.ToString() + ")"));

        public int Resize(int NewWidth, int NewHeight) =>
            ReliableConvert.ToInt32(Link.TSXSend(TSXCLASS + "Resize(" +
                NewWidth.ToString() + "," +
                NewHeight.ToString() + ")"));

        public int RepairColumn(int ColumnToFix) =>
            ReliableConvert.ToInt32(Link.TSXSend(TSXCLASS + "RepairColumn(" +
                ColumnToFix.ToString() + ")"));

        public int RemoveColdPixels(int ColdCriteria, int Repaired) =>
            ReliableConvert.ToInt32(Link.TSXSend(TSXCLASS + "RemoveColdPixels(" +
                ColdCriteria.ToString() + "," +
                Repaired.ToString() + ")"));

        public int RemoveHotPixels(int HotCriteria, int pRepaired) =>
            ReliableConvert.ToInt32(Link.TSXSend(TSXCLASS + "RemoveHotPixels(" +
                HotCriteria.ToString() + "," +
                pRepaired.ToString() + ")"));

        public double averagePixelValue() => ReliableConvert.ToInt32(Link.TSXSend(TSXCLASS + "averagePixelValue()"));

        public double[] scanLine(int i) => Array.ConvertAll((Link.TSXSend(TSXCLASS + "scanLine(" + i.ToString() + ")")).Split(','), double.Parse);

        public double XYToRADecResultRA() => ReliableConvert.ToInt32(Link.TSXSend(TSXCLASS + "XYToRADecResultRA()"));

        public double XYToRADecResultDec() => ReliableConvert.ToDouble(Link.TSXSend(TSXCLASS + "XYToRADecResultDec()"));

        public double RADecToXYResultX() => ReliableConvert.ToDouble(Link.TSXSend(TSXCLASS + "RADecToXYResultX()"));

        public double RADecToXYResultY() => ReliableConvert.ToDouble(Link.TSXSend(TSXCLASS + "RADecToXYResultY()"));

        public double mousePressPixelX() => ReliableConvert.ToDouble(Link.TSXSend(TSXCLASS + "mousePressPixelX()"));

        public double mousePressPixelY() => ReliableConvert.ToDouble(Link.TSXSend(TSXCLASS + "mousePressPixelY()"));

        public double mouseDoubleClickPixelX() => ReliableConvert.ToDouble(Link.TSXSend(TSXCLASS + "mouseDoubleClickPixelX()"));

        public double mouseDoubleClickPixelY() => ReliableConvert.ToDouble(Link.TSXSend(TSXCLASS + "mouseDoubleClickPixelY()"));

        #endregion

        #region properties

        public double JulianDay { get => ReliableConvert.ToDouble(Link.TSXSend(TSXCLASS + "JulianDay")); }

        public string Path
        {
            get => Link.TSXSend(TSXCLASS + "Path");
            set => Link.TSXSend(TSXCLASS + "Path=" + value.ToString() + ";");
        }

        public int DetachOnClose
        {
            get => ReliableConvert.ToInt32(Link.TSXSend(TSXCLASS + "DetachOnClose"));
            set => Link.TSXSend(TSXCLASS + "DetachOnClose=" + value.ToString() + ";");
        }

        public int Visible
        {
            get => ReliableConvert.ToInt32(Link.TSXSend(TSXCLASS + "Visible"));
            set => Link.TSXSend(TSXCLASS + "Visible=" + value.ToString() + ";");
        }

        public int DataPtr { get => ReliableConvert.ToInt32(Link.TSXSend(TSXCLASS + "DataPtr")); }

        //public QVariant DataArray

        public int WidthInPixels { get => ReliableConvert.ToInt32(Link.TSXSend(TSXCLASS + "WidthInPixels")); }

        public int HeightInPixels { get => ReliableConvert.ToInt32(Link.TSXSend(TSXCLASS + "HeightInPixels")); }

        public int ModifiedFlag
        {
            get => ReliableConvert.ToInt32(Link.TSXSend(TSXCLASS + "ModifiedFlag"));
            set => Link.TSXSend(TSXCLASS + "ModifiedFlag=" + value.ToString() + ";");
        }

        public int Background
        {
            get => ReliableConvert.ToInt32(Link.TSXSend(TSXCLASS + "Background"));
            set => Link.TSXSend(TSXCLASS + "Background=" + value.ToString() + ";");
        }

        public int Range
        {
            get => ReliableConvert.ToInt32(Link.TSXSend(TSXCLASS + "Range"));
            set => Link.TSXSend(TSXCLASS + "Range=" + value.ToString() + ";");
        }

        public int WindowTop
        {
            get => ReliableConvert.ToInt32(Link.TSXSend(TSXCLASS + "WindowTop"));
            set => Link.TSXSend(TSXCLASS + "WindowTop=" + value.ToString() + ";");
        }

        public int WindowLeft
        {
            get => ReliableConvert.ToInt32(Link.TSXSend(TSXCLASS + "WindowLeft"));
            set => Link.TSXSend(TSXCLASS + "WindowLeft=" + value.ToString() + ";");
        }

        public int WindowRight { get => ReliableConvert.ToInt32(Link.TSXSend(TSXCLASS + "WindowRight")); }

        public int WindowBottom { get => ReliableConvert.ToInt32(Link.TSXSend(TSXCLASS + "WindowBottom")); }

        public double NorthAngle { get => ReliableConvert.ToDouble(Link.TSXSend(TSXCLASS + "NorthAngle")); }

        public double ScaleInArcsecondsPerPixel
        {
            get => ReliableConvert.ToDouble(Link.TSXSend(TSXCLASS + "ScaleInArcsecondsPerPixel"));
            set => Link.TSXSend(TSXCLASS + "ScaleInArcsecondsPerPixel=" + value.ToString() + ";");
        }

        #endregion
    }
}
