using System;
using System.Collections.Generic;
using System.Text;

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

        //public operatingSystem operatingSystem { get => (operatingSystem)Enum.Parse(typeof(operatingSystem), Link.TSXSend("Application.build"), true); }

    }
}

