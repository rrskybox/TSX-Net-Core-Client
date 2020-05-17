//***************************************************************************************
//
// Library TSXNetCoreClient: Class ccdsoftCamera
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
    public class ccdsoftCamera
    {
        const string TSXCLASS = "ccdsoftCamera.";
        const string CR = "\r\n";


        #region methods
        public int TakeImage() => Convert.ToInt32(Link.TSXSend(TSXCLASS + "TakeImage()"));

        public int Autoguide() => Convert.ToInt32(Link.TSXSend(TSXCLASS + "Autoguide()"));

        public int Abort() => Convert.ToInt32(Link.TSXSend(TSXCLASS + "Abort()"));

        public int Connect() => Convert.ToInt32(Link.TSXSend(TSXCLASS + "Connect()"));

        public int Disconnect() => Convert.ToInt32(Link.TSXSend(TSXCLASS + "Disconnect()"));

        public int CenterBrightestObject() => Convert.ToInt32(Link.TSXSend(TSXCLASS + "CenterBrightestObject()"));

        public int Calibrate(int CalibrateAO) =>
            Convert.ToInt32(Link.TSXSend(TSXCLASS + "Calibrate(" + CalibrateAO.ToString() + ")"));

        public int AtFocus() => Convert.ToInt32(Link.TSXSend(TSXCLASS + "AtFocus()"));

        public int TakeColor() => Convert.ToInt32(Link.TSXSend(TSXCLASS + "TakeColor()"));

        public int MoveGuideStar() => Convert.ToInt32(Link.TSXSend(TSXCLASS + "MoveGuideStar()"));

        public int Move(double FromX, double FromY, double ToX, double ToY) =>
            Convert.ToInt32(Link.TSXSend(TSXCLASS + "Move(" +
                FromX.ToString() + "," +
                FromY.ToString() + "," +
                ToX.ToString() + "," +
                ToY.ToString() + ")"));

        public int focConnect() => Convert.ToInt32(Link.TSXSend(TSXCLASS + "focConnect()"));

        public int focDisconnect() => Convert.ToInt32(Link.TSXSend(TSXCLASS + "focDisconnect()"));

        public int focSettings() => Convert.ToInt32(Link.TSXSend(TSXCLASS + "focSettings()"));

        public int focMoveIn(int lSteps) =>
            Convert.ToInt32(Link.TSXSend(TSXCLASS + "focMoveIn(" + lSteps.ToString() + ")"));

        public int focMoveOut(int lSteps) =>
            Convert.ToInt32(Link.TSXSend(TSXCLASS + "focMoveOut(" + lSteps.ToString() + ")"));

        public int AtFocus2() => Convert.ToInt32(Link.TSXSend(TSXCLASS + "AtFocus2()"));

        public int filterWheelConnect() => Convert.ToInt32(Link.TSXSend(TSXCLASS + "filterWheelConnect()"));

        public int filterWheelDisconnect() => Convert.ToInt32(Link.TSXSend(TSXCLASS + "filterWheelDisconnect()"));

        public int filterWheelIsConnected() => Convert.ToInt32(Link.TSXSend(TSXCLASS + "filterWheelIsConnected()"));

        public int centerAO() => Convert.ToInt32(Link.TSXSend(TSXCLASS + "centerAO()"));

        public int rotatorConnect() => Convert.ToInt32(Link.TSXSend(TSXCLASS + "rotatorConnect()"));

        public int rotatorDisconnect() => Convert.ToInt32(Link.TSXSend(TSXCLASS + "rotatorDisconnect()"));

        public int rotatorIsConnected() => Convert.ToInt32(Link.TSXSend(TSXCLASS + "rotatorIsConnected()"));

        public double rotatorPositionAngle() => Convert.ToDouble(Link.TSXSend(TSXCLASS + "rotatorPositionAngle()"));

        public int rotatorGotoPositionAngle(double dPositionAngle) =>
            Convert.ToInt32(Link.TSXSend(TSXCLASS + "rotatorGotoPositionAngle(" + dPositionAngle.ToString() + ")"));

        public int rotatorIsRotating() => Convert.ToInt32(Link.TSXSend(TSXCLASS + "rotatorIsRotating()"));

        public int AtFocus3(int nAveraging, bool bFullAuto) =>
            Convert.ToInt32(Link.TSXSend(TSXCLASS + "AtFocus3(" + nAveraging.ToString() + "," +
                bFullAuto.ToString() + ")"));

        #endregion

        #region properties

        public int WidthInPixels
        {
            get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "WidthInPixels"));
            set => Link.TSXSend(TSXCLASS + "WidthInPixels=" + value.ToString() + ";");
        }

        public int HeightInPixels
        {
            get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "HeightInPixels"));
            set => Link.TSXSend(TSXCLASS + "HeightInPixels=" + value.ToString() + ";");
        }

        public double Temperature
        {
            get => Convert.ToDouble(Link.TSXSend(TSXCLASS + "Temperature"));
            set => Link.TSXSend(TSXCLASS + "Temperature=" + value.ToString() + ";");
        }

        public double ThermalElectricCoolerPower
        {
            get => Convert.ToDouble(Link.TSXSend(TSXCLASS + "ThermalElectricCoolerPower"));
            set => Link.TSXSend(TSXCLASS + "ThermalElectricCoolerPower=" + value.ToString() + ")");
        }

        public int IsExposureComplete
        {
            get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "IsExposureComplete"));
            set => Link.TSXSend(TSXCLASS + "IsExposureComplete=" + value.ToString() + ";");
        }

        public string ExposureStatus
        {
            get => Link.TSXSend(TSXCLASS + "ExposureStatus");
            set => Link.TSXSend(TSXCLASS + "ExposureStatus=" + "\"" + value + "\"" + ";");
        }

        public double ExposureTime
        {
            get => Convert.ToDouble(Link.TSXSend(TSXCLASS + "ExposureTime"));
            set => Link.TSXSend(TSXCLASS + "ExposureTime=" + value.ToString() + ";");
        }

        public string LastImageFileName
        {
            get => Link.TSXSend(TSXCLASS + "LastImageFileName");
            set => Link.TSXSend(TSXCLASS + "LastImageFileName=" + "\"" + value + "\"" + ";");
        }

        public string AutoSavePath
        {
            get => Link.TSXSend(TSXCLASS + "AutoSavePath");
            set => Link.TSXSend(TSXCLASS + "AutoSavePath=" + "\"" + value + "\"" + ";");
        }

        public string AutoSavePrefix

        {
            get => Link.TSXSend(TSXCLASS + "AutoSavePrefix");
            set => Link.TSXSend(TSXCLASS + "xAutoSavePrefix=" + "\"" + value + "\"" + ";");
        }

        public ccdsoftImageReduction ImageReduction
        {
            get => (ccdsoftImageReduction)Enum.Parse(typeof(ccdsoftImageReduction), Link.TSXSend("ImageReduction"), true);
            set => Link.TSXSend(TSXCLASS + "ImageReduction=" + Convert.ToInt32(value).ToString() + ";");
        }

        public double Delay
        {
            get => Convert.ToDouble(Link.TSXSend(TSXCLASS + "Delay"));
            set => Link.TSXSend(TSXCLASS + "Delay=" + value.ToString() + ";");
        }

        public int Series
        {
            get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "Series"));
            set => Link.TSXSend(TSXCLASS + "Series=" + value.ToString() + ";");
        }

        public int FilterIndexZeroBased
        {
            get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "FilterIndexZeroBased"));
            set => Link.TSXSend(TSXCLASS + "FilterIndexZeroBased=" + value.ToString() + ")");
        }

        public int Subframe
        {
            get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "Subframe"));
            set => Link.TSXSend(TSXCLASS + "Subframe=" + value.ToString() + ";");
        }

        public int SubframeLeft
        {
            get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "SubframeLeft"));
            set => Link.TSXSend(TSXCLASS + "SubframeLeft=" + value.ToString() + ")");
        }

        public int SubframeTop
        {
            get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "SubframeTop"));
            set => Link.TSXSend(TSXCLASS + "SubframeTop=" + value.ToString() + ")");
        }

        public int SubframeRight
        {
            get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "SubframeRight"));
            set => Link.TSXSend(TSXCLASS + "SubframeRight=" + value.ToString() + ")");
        }

        public int SubframeBottom
        {
            get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "SubframeBottom"));
            set => Link.TSXSend(TSXCLASS + "SubframeBottom=" + value.ToString() + ")");
        }

        public int BinX
        {
            get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "BinX"));
            set => Link.TSXSend(TSXCLASS + "BinX=" + value.ToString() + ")");
        }

        public int BinY
        {
            get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "BinY"));
            set => Link.TSXSend(TSXCLASS + "BinY=" + value.ToString() + ";");
        }

        public int ToNewWindow
        {
            get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "ToNewWindow"));
            set => Link.TSXSend(TSXCLASS + "ToNewWindow=" + value.ToString() + ";");
        }

        public int Autoguider
        {
            get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "Autoguider"));
            set => Link.TSXSend(TSXCLASS + "Autoguider=" + value.ToString() + ";");
        }

        public int Asynchronous
        {
            get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "Asynchronous"));
            set => Link.TSXSend(TSXCLASS + "Asynchronous=" + value.ToString() + ";");
        }

        public int lNumberFilters
        {
            get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "lNumberFilters"));
            set => Link.TSXSend(TSXCLASS + "lNumberFilters=" + value.ToString() + ";");
        }

        public int lNumberBins
        {
            get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "lNumberBins"));
            set => Link.TSXSend(TSXCLASS + "lNumberBins=" + value.ToString() + ";");
        }


        public int ReductionGroupCount
        {
            get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "ReductionGroupCount"));
            set => Link.TSXSend(TSXCLASS + "ReductionGroupCount=" + value.ToString() + ";");
        }

        public ccdsoftImageFrame Frame
        {
            get => (ccdsoftImageFrame)Enum.Parse(typeof(ccdsoftImageFrame), Link.TSXSend("Frame"), true);
            set => Link.TSXSend(TSXCLASS + "Frame=" + Convert.ToInt32(value).ToString() + ";");
        }


        public ccdsoftSBIGGuiderAntiBloom SBIGGuiderAntiBloom
        {
            get => (ccdsoftSBIGGuiderAntiBloom)Enum.Parse(typeof(ccdsoftSBIGGuiderAntiBloom), Link.TSXSend("SBIGGuiderAntiBloom"), true);
            set => Link.TSXSend(TSXCLASS + "SBIGGuiderAntiBloom=" + Convert.ToInt32(value).ToString() + ";");
        }


        public int SBIGOffChipBinning
        {
            get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "SBIGOffChipBinning"));
            set => Link.TSXSend(TSXCLASS + "SBIGOffChipBinning=" + value.ToString() + ";");
        }


        public int ImageUseDigitizedSkySurvey
        {
            get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "ImageUseDigitizedSkySurvey"));
            set => Link.TSXSend(TSXCLASS + "ImageUseDigitizedSkySurvey=" + value.ToString() + ";");
        }


        public int ReverseX
        {
            get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "ReverseX"));
            set => Link.TSXSend(TSXCLASS + "ReverseX=" + value.ToString() + ";");
        }

        public int ShowAutoguider
        {
            get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "ShowAutoguider"));
            set => Link.TSXSend(TSXCLASS + "ShowAutoguider=" + value.ToString() + ";");
        }


        public double GuideStarX
        {
            get => Convert.ToDouble(Link.TSXSend(TSXCLASS + "GuideStarX"));
            set => Link.TSXSend(TSXCLASS + "GuideStarX=" + value.ToString() + ";");
        }

        public double GuideStarY
        {
            get => Convert.ToDouble(Link.TSXSend(TSXCLASS + "GuideStarY"));
            set => Link.TSXSend(TSXCLASS + "GuideStarY=" + value.ToString() + ";");
        }

        public ccdsoftMoveVia MoveVia
        {
            get => (ccdsoftMoveVia)Enum.Parse(typeof(ccdsoftMoveVia), Link.TSXSend("MoveVia"), true);
            set => Link.TSXSend(TSXCLASS + "MoveVia=" + Convert.ToInt32(value).ToString() + ";");
        }

        public int TrackBoxX
        {
            get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "TrackBoxX"));
            set => Link.TSXSend(TSXCLASS + "TrackBoxX=" + value.ToString() + ";");
        }

        public int TrackBoxY
        {
            get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "TrackBoxY"));
            set => Link.TSXSend(TSXCLASS + "TrackBoxY=" + value.ToString() + ";");
        }

        public int SavedCalibrationTimeX
        {
            get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "SavedCalibrationTimeX"));
            set => Link.TSXSend(TSXCLASS + "SavedCalibrationTimeX=" + value.ToString() + ";");
        }

        public int SavedCalibrationTimeY
        {
            get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "SavedCalibrationTimeY"));
            set => Link.TSXSend(TSXCLASS + "SavedCalibrationTimeY=" + value.ToString() + ";");
        }

        public int EnabledXAxis
        {
            get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "EnabledXAxis"));
            set => Link.TSXSend(TSXCLASS + "EnabledXAxis=" + value.ToString() + ";");
        }

        public int EnabledYAxis
        {
            get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "EnabledYAxis"));
            set => Link.TSXSend(TSXCLASS + "EnabledYAxis=" + value.ToString() + ";");
        }

        public int AutoSaveOn
        {
            get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "AutoSaveOn"));
            set => Link.TSXSend(TSXCLASS + "AutoSaveOn=" + value.ToString() + ";");
        }

        public int AutoguiderAggressiveness
        {
            get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "AutoguiderAggressiveness"));
            set => Link.TSXSend(TSXCLASS + "AutoguiderAggressiveness=" + value.ToString() + ";");
        }

        public int AutoguiderMinimumMove
        {
            get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "AutoguiderMinimumMove"));
            set => Link.TSXSend(TSXCLASS + "AutoguiderMinimumMove=" + value.ToString() + ";");
        }

        public int AutoguiderMaximumMove
        {
            get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "AutoguiderMaximumMove"));
            set => Link.TSXSend(TSXCLASS + "AutoguiderMaximumMove=" + value.ToString() + ";");
        }

        public double AutoguiderBacklashXAxis
        {
            get => Convert.ToDouble(Link.TSXSend(TSXCLASS + "AutoguiderBacklashXAxis"));
            set => Link.TSXSend(TSXCLASS + "AutoguiderBacklashXAxis=" + value.ToString() + ";");
        }

        public double AutoguiderBacklashYAxis
        {
            get => Convert.ToDouble(Link.TSXSend(TSXCLASS + "AutoguiderBacklashYAxis"));
            set => Link.TSXSend(TSXCLASS + "AutoguiderBacklashYAxis=" + value.ToString() + ";");
        }

        public int AutoguiderDelayAfterCorrection
        {
            get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "AutoguiderDelayAfterCorrection"));
            set => Link.TSXSend(TSXCLASS + "AutoguiderDelayAfterCorrection=" + value.ToString() + ";");
        }

        public int AutoguiderLogData
        {
            get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "AutoguiderLogData"));
            set => Link.TSXSend(TSXCLASS + "AutoguiderLogData=" + value.ToString() + ";");
        }

        public int AutoguiderCalibrationTimeXAxis
        {
            get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "AutoguiderCalibrationTimeXAxis"));
            set => Link.TSXSend(TSXCLASS + "AutoguiderCalibrationTimeXAxis=" + value.ToString() + ";");
        }

        public int AutoguiderCalibrationTimeYAxis
        {
            get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "AutoguiderCalibrationTimeYAxis"));
            set => Link.TSXSend(TSXCLASS + "AutoguiderCalibrationTimeYAxis=" + value.ToString() + ";");
        }

        public int RegulateTemperature
        {
            get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "RegulateTemperature"));
            set => Link.TSXSend(TSXCLASS + "RegulateTemperature=" + value.ToString() + ";");
        }

        public int MoveToX
        {
            get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "MoveToX"));
            set => Link.TSXSend(TSXCLASS + "MoveToX=" + value.ToString() + ";");
        }

        public int MoveToY
        {
            get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "MoveToY"));
            set => Link.TSXSend(TSXCLASS + "MoveToY=" + value.ToString() + ";");
        }

        public int ColorSeries
        {
            get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "ColorSeries"));
            set => Link.TSXSend(TSXCLASS + "ColorSeries=" + value.ToString() + ";");
        }

        public int AutoSaveFocusImages
        {
            get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "AutoSaveFocusImages"));
            set => Link.TSXSend(TSXCLASS + "AutoSaveFocusImages=" + value.ToString() + ";");
        }

        public int ScreenShutter
        {
            get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "ScreenShutter"));
            set => Link.TSXSend(TSXCLASS + "ScreenShutter=" + value.ToString() + ";");
        }

        public int HighPriorityDownloads
        {
            get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "HighPriorityDownloads"));
            set => Link.TSXSend(TSXCLASS + "HighPriorityDownloads=" + value.ToString() + ";");
        }

        public int DownloadAbortedExposures
        {
            get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "DownloadAbortedExposures"));
            set => Link.TSXSend(TSXCLASS + "DownloadAbortedExposures=" + value.ToString() + ";");
        }

        public int DownloadAbortedExposuresAfterSeconds
        {
            get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "DownloadAbortedExposuresAfterSeconds"));
            set => Link.TSXSend(TSXCLASS + "DownloadAbortedExposuresAfterSeconds=" + value.ToString() + ";");
        }

        public int SaveImagesWithUTC
        {
            get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "SaveImagesWithUTC"));
            set => Link.TSXSend(TSXCLASS + "SaveImagesWithUTC=" + value.ToString() + ";");
        }

        public int ShutDownTemperatureRegulationOnDisconnect
        {
            get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "ShutDownTemperatureRegulationOnDisconnect"));
            set => Link.TSXSend(TSXCLASS + "ShutDownTemperatureRegulationOnDisconnect=" + value.ToString() + ";");
        }

        public ccdsoftAutoSaveAs AutoSaveFileFormat
        {
            get => (ccdsoftAutoSaveAs)Enum.Parse(typeof(ccdsoftAutoSaveAs), Link.TSXSend("AutoSaveFileFormat"), true);
            set => Link.TSXSend(TSXCLASS + "AutoSaveFileFormat=" + Convert.ToInt32(value).ToString() + ";");
        }

        public ccdsoftFocusGraph FocusGraphType
        {
            get => (ccdsoftFocusGraph)Enum.Parse(typeof(ccdsoftFocusGraph), Link.TSXSend("FocusGraphType"), true);
            set => Link.TSXSend(TSXCLASS + "FocusGraphType=" + Convert.ToInt32(value).ToString() + ";");
        }

        public int AtFocusSamples
        {
            get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "AtFocusSamples"));
            set => Link.TSXSend(TSXCLASS + "AtFocusSamples=" + value.ToString() + ";");
        }

        public int AtFocusAveraging
        {
            get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "AtFocusAveraging"));
            set => Link.TSXSend(TSXCLASS + "AtFocusAveraging=" + value.ToString() + ";");
        }

        public int AtFocusInitialMoveDirection
        {
            get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "AtFocusInitialMoveDirection"));
            set => Link.TSXSend(TSXCLASS + "AtFocusInitialMoveDirection=" + value.ToString() + ";");
        }

        public int AutoContrast
        {
            get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "AutoContrast"));
            set => Link.TSXSend(TSXCLASS + "AutoContrast=" + value.ToString() + ";");
        }

        public int SBIGFanOn
        {
            get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "SBIGFanOn"));
            set => Link.TSXSend(TSXCLASS + "SBIGFanOn=" + value.ToString() + ";");
        }

        public int ContinuousFocus
        {
            get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "ContinuousFocus"));
            set => Link.TSXSend(TSXCLASS + "ContinuousFocus=" + value.ToString() + ";");
        }

        public double AutoguiderExposureTime
        {
            get => Convert.ToDouble(Link.TSXSend(TSXCLASS + "AutoguiderExposureTime"));
            set => Link.TSXSend(TSXCLASS + "AutoguiderExposureTime=" + value.ToString() + ";");
        }

        public ccdsoftInterface CameraInterface
        {
            get => (ccdsoftInterface)Enum.Parse(typeof(ccdsoftInterface), Link.TSXSend("CameraInterface"), true);
            set => Link.TSXSend(TSXCLASS + "CameraInterface=" + Convert.ToInt32(value).ToString() + ";");
        }

        public double DeclinationAtCalibration
        {
            get => Convert.ToDouble(Link.TSXSend(TSXCLASS + "DeclinationAtCalibration"));
            set => Link.TSXSend(TSXCLASS + "DeclinationAtCalibration=" + value.ToString() + ";");
        }

        public double TelescopeDeclination
        {
            get => Convert.ToDouble(Link.TSXSend(TSXCLASS + "TelescopeDeclination"));
            set => Link.TSXSend(TSXCLASS + "TelescopeDeclination=" + value.ToString() + ";");
        }

        public double TemperatureSetPoint
        {
            get => Convert.ToDouble(Link.TSXSend(TSXCLASS + "TemperatureSetPoint"));
            set => Link.TSXSend(TSXCLASS + "TemperatureSetPoint=" + value.ToString() + ";");
        }

        public string ReductionGroupName
        {
            get => Link.TSXSend(TSXCLASS + "ReductionGroupName");
            set => Link.TSXSend(TSXCLASS + "ReductionGroupName=" + "\"" + value + "\"" + ";");
        }

        public int lAsynchronous
        {
            get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "lAsynchronous"));
            set => Link.TSXSend(TSXCLASS + "lAsynchronous=" + value.ToString() + ";");
        }

        public double FocusExposureTime
        {
            get => Convert.ToDouble(Link.TSXSend(TSXCLASS + "FocusExposureTime"));
            set => Link.TSXSend(TSXCLASS + "FocusExposureTime=" + value.ToString() + ";");
        }

        public ccdsoftfocTempCompMode focTemperatureCompensationMode
        {
            get => (ccdsoftfocTempCompMode)Enum.Parse(typeof(ccdsoftfocTempCompMode), Link.TSXSend("focTemperatureCompensationMode"), true);
            set => Link.TSXSend(TSXCLASS + "focTemperatureCompensationMode=" + Convert.ToInt32(value).ToString() + ";");
        }

        public int focBacklash
        {
            get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "focBacklash"));
            set => Link.TSXSend(TSXCLASS + "focBacklash=" + value.ToString() + ";");
        }

        public int focMaximumLimit

        {
            get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "focMaximumLimit"));
            set => Link.TSXSend(TSXCLASS + "focMaximumLimit=" + value.ToString() + ";");
        }

        public int focMinimumLimit
        {
            get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "focMinimumLimit"));
            set => Link.TSXSend(TSXCLASS + "focMinimumLimit=" + value.ToString() + ";");
        }

        public int focSmallStepSize
        {
            get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "focSmallStepSize"));
            set => Link.TSXSend(TSXCLASS + "focSmallStepSize=" + value.ToString() + ";");
        }

        public int focLargeStepSize
        {
            get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "focLargeStepSize"));
            set => Link.TSXSend(TSXCLASS + "focLargeStepSize=" + value.ToString() + ";");
        }

        public int focPort
        {
            get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "focPort"));
            set => Link.TSXSend(TSXCLASS + "focPort=" + value.ToString() + ";");
        }

        public double focTemperature
        {
            get => Convert.ToDouble(Link.TSXSend(TSXCLASS + "focTemperature"));
            set => Link.TSXSend(TSXCLASS + "focTemperature=" + value.ToString() + ";");
        }

        public string Status
        {
            get => Link.TSXSend(TSXCLASS + "Status");
            set => Link.TSXSend(TSXCLASS + "Status=" + "\"" + value + "\"" + ";");
        }

        public int Percent
        {
            get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "Percent"));
            set => Link.TSXSend(TSXCLASS + "Percent=" + value.ToString() + ";");
        }

        public ccdsoftCameraState State
        {
            get => (ccdsoftCameraState)Enum.Parse(typeof(ccdsoftCameraState), Link.TSXSend(TSXCLASS + "State"), true);
            set => Link.TSXSend(TSXCLASS + "State=" + Convert.ToInt32(value).ToString() + ";");
        }

        public double GuideErrorX
        {
            get => Convert.ToDouble(Link.TSXSend(TSXCLASS + "GuideErrorX"));
            set => Link.TSXSend(TSXCLASS + "GuideErrorX=" + value.ToString() + ";");
        }

        public double GuideErrorY
        {
            get => Convert.ToDouble(Link.TSXSend(TSXCLASS + "GuideErrorY"));
            set => Link.TSXSend(TSXCLASS + "GuideErrorY=" + value.ToString() + ";");
        }

        public double MaximumPixel
        {
            get => Convert.ToDouble(Link.TSXSend(TSXCLASS + "MaximumPixel"));
            set => Link.TSXSend(TSXCLASS + "MaximumPixel=" + value.ToString() + ";");
        }

        public int focIsConnected
        {
            get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "focIsConnected"));
            set => Link.TSXSend(TSXCLASS + "focIsConnected=" + value.ToString() + ";");
        }

        public int focPosition
        {
            get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "focPosition"));
            set => Link.TSXSend(TSXCLASS + "focPosition=" + value.ToString() + ";");
        }

        #endregion

        #region namebasedmethods

        public double PropDbl(string lpszPropName) =>
            Convert.ToDouble(Link.TSXSend(TSXCLASS + "PropDbl(" + "\"" + lpszPropName + "\"" + ");"));

        public void setPropDbl(string lpszPropName, double dVal) =>
            Link.TSXSend(TSXCLASS + "setProbDbl(" + "\"" + lpszPropName + "\"" + dVal.ToString() + ");");

        public int PropLng(string lpszPropName) =>
             Convert.ToInt32(Link.TSXSend(TSXCLASS + "PropLng(" + "\"" + lpszPropName + "\"" + ");"));

        public void setPropLng(string lpszPropName, int nVal) =>
            Link.TSXSend(TSXCLASS + "setPropLng(" + "\"" + lpszPropName + "\"" + nVal.ToString() + ");");

        public string PropStr(string lpszPropName) =>
            Link.TSXSend(TSXCLASS + "PropStr(" + "\"" + lpszPropName + "\"" + ");");

        public void setPropStr(string lpszPropName, string qsVal) =>
            Link.TSXSend(TSXCLASS + "setPropLng(" + "\"" + lpszPropName + "\"" + "," + "\"" + lpszPropName + "\"" + ");");

        #endregion

        #region paramprops

        public string szFilterName(int lZeroBasedIndex) => 
            Link.TSXSend(TSXCLASS + "szFilterName(" + lZeroBasedIndex.ToString() + ");");

        public void setszFilterName(int lZeroBasedIndex, string qsValue) =>
            Link.TSXSend(TSXCLASS + "setszFilterName(" + lZeroBasedIndex + "," + "\"" + qsValue + "\"" + ");");

        public string szBinModeFromIndex(int lZeroBasedIndex) => 
            Link.TSXSend(TSXCLASS + "szBinModeFromIndex(" + lZeroBasedIndex.ToString() + ");");

        public string ReductionGroupFromIndex(int lZeroBasedIndex) => 
            Link.TSXSend(TSXCLASS + "ReductionGroupFromIndex(" + lZeroBasedIndex.ToString() + ");");

        //public var LRGBArray (int seriesIndex)

        //public void setLRGBArray (int seriesIndex, QVariant colorData)

        #endregion

        #region calibration

        public double CalibrationVectorXPositiveXComponent
        {
            get => Convert.ToDouble(Link.TSXSend(TSXCLASS + "CalibrationVectorXPositiveXComponent"));
            set => Link.TSXSend(TSXCLASS + "CalibrationVectorXPositiveXComponent=" + value.ToString() + ";");
        }

        public double CalibrationVectorXPositiveYComponent
        {
            get => Convert.ToDouble(Link.TSXSend(TSXCLASS + "CalibrationVectorXPositiveYComponent"));
            set => Link.TSXSend(TSXCLASS + "CalibrationVectorXPositiveXComponent=" + value.ToString() + ";");
        }

        public double CalibrationVectorYPositiveXComponent
        {
            get => Convert.ToDouble(Link.TSXSend(TSXCLASS + "CalibrationVectorYPositiveXComponent"));
            set => Link.TSXSend(TSXCLASS + "CalibrationVectorYPositiveXComponent=" + value.ToString() + ";");
        }

        public double CalibrationVectorYPositiveYComponent
        {
            get => Convert.ToDouble(Link.TSXSend(TSXCLASS + "CalibrationVectorYPositiveYComponent"));
            set => Link.TSXSend(TSXCLASS + "CalibrationVectorYPositiveYComponent=" + value.ToString() + ";");
        }

        public double CalibrationVectorXNegativeXComponent
        {
            get => Convert.ToDouble(Link.TSXSend(TSXCLASS + "CalibrationVectorXNegativeXComponent"));
            set => Link.TSXSend(TSXCLASS + "CalibrationVectorXNegativeXComponent=" + value.ToString() + ";");
        }

        public double CalibrationVectorXNegativeYComponent
        {
            get => Convert.ToDouble(Link.TSXSend(TSXCLASS + "CalibrationVectorXNegativeYComponent"));
            set => Link.TSXSend(TSXCLASS + "CalibrationVectorXNegativeYComponent=" + value.ToString() + ";");
        }

        public double CalibrationVectorYNegativeXComponent
        {
            get => Convert.ToDouble(Link.TSXSend(TSXCLASS + "CalibrationVectorYNegativeXComponent"));
            set => Link.TSXSend(TSXCLASS + "CalibrationVectorYNegativeXComponent=" + value.ToString() + ";");
        }

        public double CalibrationVectorYNegativeYComponent
        {
            get => Convert.ToDouble(Link.TSXSend(TSXCLASS + "CalibrationVectorYNegativeYComponent"));
            set => Link.TSXSend(TSXCLASS + "CalibrationVectorYNegativeYComponent=" + value.ToString() + ";");
        }

        #endregion

    }
}
