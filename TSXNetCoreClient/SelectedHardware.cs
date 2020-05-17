//***************************************************************************************
//
// Library TSXNetCoreClient: Class SelectedHardware
// Derived from SoftwareBisque, ScriptTheSkyX Specification V1.27
// Date: 15-May-2020
// Author: Rick McAlister, et. al.
// Version -- See Visual Studio Project
// Licence -- open
// 
//***************************************************************************************

namespace TSXNetCoreClient
{
    public class SelectedHardware
    {
        const string TSXCLASS = "SelectedHardware.";
        const string CR = "\r\n";

        public string adaptiveOpticsModel { get => Link.TSXSend(TSXCLASS + "adaptiveOpticsModel"); }

        public string adaptiveOpticsManufacturer { get => Link.TSXSend(TSXCLASS + "adaptiveOpticsManufacturer"); }

        public string cameraModel { get => Link.TSXSend(TSXCLASS + "cameraModel"); }

        public string cameraManufacturer { get => Link.TSXSend(TSXCLASS + "cameraManufacturer"); }

        public string domeModel { get => Link.TSXSend(TSXCLASS + "domeModel"); }

        public string domeManufacturer { get => Link.TSXSend(TSXCLASS + "domeManufacturer"); }

        public string filterWheelModel { get => Link.TSXSend(TSXCLASS + "filterWheelModel"); }

        public string filterWheelManufacturer { get => Link.TSXSend(TSXCLASS + "filterWheelManufacturer"); }

        public string focuserModel { get => Link.TSXSend(TSXCLASS + "focuserModel"); }

        public string focuserManufacturer { get => Link.TSXSend(TSXCLASS + "focuserManufacturer"); }

        public string mountModel { get => Link.TSXSend(TSXCLASS + "mountModel"); }

        public string mountManufacturer { get => Link.TSXSend(TSXCLASS + "mountManufacturer"); }

        public string opticalTubeAssemblyModel { get => Link.TSXSend(TSXCLASS + "opticalTubeAssemblyModel"); }

        public string opticalTubeAssemblyManufacturer { get => Link.TSXSend(TSXCLASS + "opticalTubeAssemblyManufacturer"); }

        public string rotatorModel { get => Link.TSXSend(TSXCLASS + "rotatorModel"); }

        public string rotatorManufacturer { get => Link.TSXSend(TSXCLASS + "rotatorManufacturer"); }

        public string videoDeviceModel { get => Link.TSXSend(TSXCLASS + "videoDeviceModel"); }

        public string videoDeviceManufacturer { get => Link.TSXSend(TSXCLASS + "videoDeviceManufacturer"); }

        public string weatherStationModel { get => Link.TSXSend(TSXCLASS + "weatherStationModel"); }

        public string weatherStationManufacturer { get => Link.TSXSend(TSXCLASS + "weatherStationManufacturer"); }

        public string autoguiderAdaptiveOpticsModel { get => Link.TSXSend(TSXCLASS + "autoguiderAdaptiveOpticsModel"); }

        public string autoguiderAdaptiveOpticsManufacturer { get => Link.TSXSend(TSXCLASS + "autoguiderAdaptiveOpticsManufacturer"); }

        public string autoguiderCameraModel { get => Link.TSXSend(TSXCLASS + "autoguiderCameraModel"); }

        public string autoguiderCameraManufacturer { get => Link.TSXSend(TSXCLASS + "autoguiderCameraManufacturer"); }

        public string autoguiderFilterWheelModel { get => Link.TSXSend(TSXCLASS + "autoguiderFilterWheelModel"); }

        public string autoguiderFilterWheelManufacturer { get => Link.TSXSend(TSXCLASS + "autoguiderFilterWheelManufacturer"); }

        public string autoguiderFocuserModel { get => Link.TSXSend(TSXCLASS + "autoguiderFocuserModel"); }

        public string autoguiderFocuserManufacturer { get => Link.TSXSend(TSXCLASS + "autoguiderFocuserManufacturer"); }

        public string autoguiderRotatorModel { get => Link.TSXSend(TSXCLASS + "autoguiderRotatorModel"); }

        public string autoguiderRotatorManufacturer { get => Link.TSXSend(TSXCLASS + "autoguiderRotatorManufacturer"); }

        public string autoguiderVideoDeviceModel { get => Link.TSXSend(TSXCLASS + "autoguiderVideoDeviceModel"); }

        public string autoguiderVideoDeviceManufacturer { get => Link.TSXSend(TSXCLASS + "autoguiderVideoDeviceManufacturer"); }

    }
}
