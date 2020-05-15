namespace TSXNetCoreClient
{
    public class sky6DataWizard
    {
        const string TSXCLASS = "sky6DataWizard.";
        const string CR = "\r\n";

        #region enums

        #endregion

        #region methods

        public void Open() => Link.TSXSend(TSXCLASS + "Open()");

        #endregion

        #region properties
        public string Path
        {
            get => Link.TSXSend(TSXCLASS + "Path");
            set => Link.TSXSend(TSXCLASS + "Path=" + value.ToString() + ";");
        }

        //public sky6ObjectInformation RunQuery { get => Link.TSXSend(TSXCLASS + "RunQuery"); }
        public sky6ObjectInformation RunQuery
        {
            get { Link.TSXSend(TSXCLASS + "RunQuery"); return new sky6ObjectInformation(); }
        }

        #endregion


    }
}
