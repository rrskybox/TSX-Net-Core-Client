using System;

namespace TSXNetCoreClient
{
    public class ImageLink
    {
        const string TSXCLASS = "ImageLink.";
        const string CR = "\r\n";


        public void execute() => Link.TSXSend(TSXCLASS+"build");

        public string pathToFITS
        {
            get => Link.TSXSend(TSXCLASS+"pathToFITS");
            set => Link.TSXSend(TSXCLASS+"pathToFits=" + value);
        }

        public double scale
        {
            get => Convert.ToDouble(Link.TSXSend(TSXCLASS+"scale"));
            set => Link.TSXSend(TSXCLASS+"scale=" + value.ToString());
        }

        public bool unknownScale
        {
            get => Convert.ToBoolean(Link.TSXSend(TSXCLASS+"scale"));
            set => Link.TSXSend(TSXCLASS+"scale=" + value.ToString());
        }
    }
}
