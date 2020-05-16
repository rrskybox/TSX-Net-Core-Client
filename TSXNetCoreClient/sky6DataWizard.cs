//***************************************************************************************
//
// Library TSXNetCoreClient: Class sky6DataWizard
// Derived from SoftwareBisque, ScriptTheSkyX Specification V1.27
// Date: 14-May-2020
// Author: Rick McAlister, et. al.
// Version -- See Visual Studio Project
// Licence -- open
// 
//***************************************************************************************

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
            set => Link.TSXSend(TSXCLASS + "Path=" + "\"" + value.Replace('\\','/') + "\"");
        }

        //Run Query in the COM library will return an class object for sky6ObjectInformation
        //However, that isn't retuned across the tcpclient interface to TSX.  So, RunQuery 
        //in this library will instanciate a class object in the TSX java script engine with the
        //name "tsxoi".  A genereric sky6ObjectInformation instanciation is returned to the caller.
        //
        //Every subsequent object information call will reference this "txsoi" object to the
        //TSX javascript engine transparently.
        //
        public sky6ObjectInformation RunQuery
        {
            get
            {
                string rqReturn = Link.TSXSend("var tsxoi = " + TSXCLASS + "RunQuery");
                return new sky6ObjectInformation();
            }
        }

        #endregion


    }
}
