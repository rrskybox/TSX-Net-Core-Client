using System;

namespace TSXNetCoreClient
{
    public class Application
    {
        const string TSXCLASS = "Application.";
        const string CR = "\r\n";

        public string build { get => Link.TSXSend(TSXCLASS+"build"); }
        public string version { get => Link.TSXSend(TSXCLASS + "version"); }
        public bool initialized { get => Convert.ToBoolean(Link.TSXSend(TSXCLASS + "initialized")); }

        public enum operatingSystem
        {
            osUnknown,
            osWindows,
            osMac,
            osLinux
        }

        public Application.operatingSystem AltOperatingSystem { get => (operatingSystem)Enum.Parse(typeof(operatingSystem), Link.TSXSend(TSXCLASS + "operatingSystem"), true); }

    }
}

