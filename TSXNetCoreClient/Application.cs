using System;

namespace TSXNetCoreClient
{
    public class Application
    {
        public string build { get => Link.TSXSend("Application.build"); }
        public string version { get => Link.TSXSend("Application.version"); }
        public bool initialized { get => Convert.ToBoolean(Link.TSXSend("Application.initialized")); }

        public enum operatingSystem
        {
            osUnknown,
            osWindows,
            osMac,
            osLinux
        }

        public Application.operatingSystem AltOperatingSystem { get => (operatingSystem)Enum.Parse(typeof(operatingSystem), Link.TSXSend("Application.operatingSystem"), true); }

    }
}

