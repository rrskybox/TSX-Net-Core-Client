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
        int Open() => Convert.ToInt32(Link.TSXSend(TSXCLASS + "TakeImage()"));

        public int Save() => Convert.ToInt32(Link.TSXSend(TSXCLASS + "Save()"));

        public int Close() => Convert.ToInt32(Link.TSXSend(TSXCLASS + "Close()"));

        public int AttachToActive() => Convert.ToInt32(Link.TSXSend(TSXCLASS + "AttachToActive()"));

        public int ApplyBackgroundRange() => Convert.ToInt32(Link.TSXSend(TSXCLASS + "ApplyBackgroundRange()"));

        public int New(int Width, int Height, int BitsPerPixel) =>
            Convert.ToInt32(Link.TSXSend(TSXCLASS + "New(" +
                Width.ToString() + "," +
                Height.ToString() + "," +
                BitsPerPixel.ToString() + ")"));

        public int Zoom(int Numerator, int Denominator) =>
            Convert.ToInt32(Link.TSXSend(TSXCLASS + "Zoom(" +
                Numerator.ToString() + "," +
                Denominator.ToString() + ")"));

        public int SetActive() => Convert.ToInt32(Link.TSXSend(TSXCLASS + "SetActive()"));

        public int AttachToActiveImager() => Convert.ToInt32(Link.TSXSend(TSXCLASS + "AttachToActiveImager()"));

        public int AttachToActiveAutoguider() => Convert.ToInt32(Link.TSXSend(TSXCLASS + "AttachToActiveAutoguider()"));

        public string FITSKeyword(string qsKeyword) => Link.TSXSend(TSXCLASS + "FITSKeyword(" + "\"" +qsKeyword + "\"" +")");

        public void setFITSKeyword(string qsKeyword, string value) =>
                   Convert.ToInt32(Link.TSXSend(TSXCLASS + "InsertWCS(" +
                       "\"" + qsKeyword + "\""+ "," +
                       "\"" + value + "\""  + ")"));

        public int InsertWCS(int RedoExistingSolution) =>
            Convert.ToInt32(Link.TSXSend(TSXCLASS + "InsertWCS(" +
                RedoExistingSolution.ToString() + ")"));

        public int XYToRADec(double X, double Y) =>
            Convert.ToInt32(Link.TSXSend(TSXCLASS + "XYToRADec(" +
                X.ToString() + "," +
                Y.ToString() + "," + ")"));

        public int RADecToXY(double RA, double Dec) =>
            Convert.ToInt32(Link.TSXSend(TSXCLASS + "RADecToXY(" +
                RA.ToString() + "," +
                Dec.ToString() + ")"));

        public double[] WCSArray(int WCSIndex) => Array.ConvertAll((Link.TSXSend(TSXCLASS + "WCSArray(" + WCSIndex.ToString() + ")")).Split(','), Double.Parse);

        public int ShowInventory() => Convert.ToInt32(Link.TSXSend(TSXCLASS + "ShowInventory()"));

        public double[] InventoryArray(int InventoryIndex)
        {
            string a = Link.TSXSend(TSXCLASS + "InventoryArray(" + InventoryIndex.ToString() + ")");
            string[] aArray = a.Split(',',StringSplitOptions.RemoveEmptyEntries );
            double [] dArray = Array.ConvertAll(aArray, double.Parse);
            return dArray;
        }

        public string FindInventoryAtRADec(double RA, double Dec) =>
            Link.TSXSend(TSXCLASS + "FindInventoryAtRADec(" +
                RA.ToString() + "," +
                Dec.ToString() + ")");

        // //public int MakeComparisonStarChart(QString &pVal)

        public int AutoContrast(int Method, int Background, int Highlight) =>
                    Convert.ToInt32(Link.TSXSend(TSXCLASS + "AutoContrast(" +
                        Method.ToString() + "," +
                        Background.ToString() + "," +
                        Highlight.ToString() + ")"));

        public int SaveAs(int Type, int Param = 0) =>
            Convert.ToInt32(Link.TSXSend(TSXCLASS + "SaveAs(" +
                Type.ToString() + "," +
                Param.ToString() + ")"));

        public int Resize(int NewWidth, int NewHeight) =>
            Convert.ToInt32(Link.TSXSend(TSXCLASS + "Resize(" +
                NewWidth.ToString() + "," +
                NewHeight.ToString() + ")"));

        public int RepairColumn(int ColumnToFix) =>
            Convert.ToInt32(Link.TSXSend(TSXCLASS + "RepairColumn(" +
                ColumnToFix.ToString() + ")"));

        public int RemoveColdPixels(int ColdCriteria, int Repaired) =>
            Convert.ToInt32(Link.TSXSend(TSXCLASS + "RemoveColdPixels(" +
                ColdCriteria.ToString() + "," +
                Repaired.ToString() + ")"));

        public int RemoveHotPixels(int HotCriteria, int pRepaired) =>
            Convert.ToInt32(Link.TSXSend(TSXCLASS + "RemoveHotPixels(" +
                HotCriteria.ToString() + "," +
                pRepaired.ToString() + ")"));

        public double averagePixelValue() => Convert.ToInt32(Link.TSXSend(TSXCLASS + "averagePixelValue()"));

        public Int32[] scanLine(int i) => Array.ConvertAll((Link.TSXSend(TSXCLASS + "scanLine(" + i.ToString() + ")")).Split(','), int.Parse);

        public double XYToRADecResultRA() => Convert.ToInt32(Link.TSXSend(TSXCLASS + "XYToRADecResultRA()"));

        public double XYToRADecResultDec() => Convert.ToDouble(Link.TSXSend(TSXCLASS + "XYToRADecResultDec()"));

        public double RADecToXYResultX() => Convert.ToDouble(Link.TSXSend(TSXCLASS + "RADecToXYResultX()"));

        public double RADecToXYResultY() => Convert.ToDouble(Link.TSXSend(TSXCLASS + "RADecToXYResultY()"));

        public double mousePressPixelX() => Convert.ToDouble(Link.TSXSend(TSXCLASS + "mousePressPixelX()"));

        public double mousePressPixelY() => Convert.ToDouble(Link.TSXSend(TSXCLASS + "mousePressPixelY()"));

        public double mouseDoubleClickPixelX() => Convert.ToDouble(Link.TSXSend(TSXCLASS + "mouseDoubleClickPixelX()"));

        public double mouseDoubleClickPixelY() => Convert.ToDouble(Link.TSXSend(TSXCLASS + "mouseDoubleClickPixelY()"));

        #endregion

        #region properties

        double JulianDay { get => Convert.ToDouble(Link.TSXSend(TSXCLASS + "JulianDay")); }

        public string Path
        {
            get => Link.TSXSend(TSXCLASS + "Path");
            set => Link.TSXSend(TSXCLASS + "Path=" + value.ToString() + ";");
        }

        public int DetachOnClose
        {
            get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "DetachOnClose"));
            set => Link.TSXSend(TSXCLASS + "DetachOnClose=" + value.ToString() + ";");
        }

        public int Visible
        {
            get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "Visible"));
            set => Link.TSXSend(TSXCLASS + "Visible=" + value.ToString() + ";");
        }

        public int DataPtr { get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "DataPtr")); }

        //public QVariant DataArray

        public int WidthInPixels { get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "WidthInPixels")); }

        public int HeightInPixels { get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "HeightInPixels")); }

        public int ModifiedFlag
        {
            get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "ModifiedFlag"));
            set => Link.TSXSend(TSXCLASS + "ModifiedFlag=" + value.ToString() + ";");
        }

        public int Background
        {
            get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "Background"));
            set => Link.TSXSend(TSXCLASS + "Background=" + value.ToString() + ";");
        }

        public int Range
        {
            get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "Range"));
            set => Link.TSXSend(TSXCLASS + "Range=" + value.ToString() + ";");
        }

        public int WindowTop
        {
            get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "WindowTop"));
            set => Link.TSXSend(TSXCLASS + "WindowTop=" + value.ToString() + ";");
        }

        public int WindowLeft
        {
            get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "WindowLeft"));
            set => Link.TSXSend(TSXCLASS + "WindowLeft=" + value.ToString() + ";");
        }

        public int WindowRight { get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "WindowRight")); }

        public int WindowBottom { get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "WindowBottom")); }

        public double NorthAngle { get => Convert.ToDouble(Link.TSXSend(TSXCLASS + "NorthAngle")); }

        public double ScaleInArcsecondsPerPixel
        {
            get => Convert.ToDouble(Link.TSXSend(TSXCLASS + "ScaleInArcsecondsPerPixel"));
            set => Link.TSXSend(TSXCLASS + "ScaleInArcsecondsPerPixel=" + value.ToString() + ";");
        }

        #endregion
    }
}
