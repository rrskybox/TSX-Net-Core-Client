using System;

namespace TSXNetCoreClient
{
    public class ImageLink
    {
        public void execute() => Link.TSXSend("ImageLink.build");

        public string pathToFITS
        {
            get => Link.TSXSend("ImageLink.pathToFITS");
            set => Link.TSXSend("pathToFits=" + value);
        }

        public double scale
        {
            get => Convert.ToDouble(Link.TSXSend("ImageLink.scale"));
            set => Link.TSXSend("ImageLink.scale=" + value.ToString());
        }

        public bool unknownScale
        {
            get => Convert.ToBoolean(Link.TSXSend("ImageLink.scale"));
            set => Link.TSXSend("ImageLink.scale=" + value.ToString());
        }
    }
}
