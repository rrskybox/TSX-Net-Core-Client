using System;


namespace TSXNetCoreClient
{
    public class sky6ObjectInformation
    {

        const string TSXCLASS = "sky6ObjectInformation.";
        const string CR = "\r\n";

        #region enums


        #endregion

        #region methods

        public void Property(Sk6ObjectInformationProperty Which) =>
                 Link.TSXSend(TSXCLASS + "Property(" + ((Int32)(object)Which).ToString() + ")");

        public void PropertyApplies(Sk6ObjectInformationProperty Which) =>
            Convert.ToInt32(Link.TSXSend(TSXCLASS + "PropertyApplies(" +
                Convert.ToInt32(Which).ToString() + ")"));

        public void PropertyName(Sk6ObjectInformationProperty Which) =>
            Convert.ToInt32(Link.TSXSend(TSXCLASS + "PropertyName(" +
                Convert.ToInt32(Which).ToString() + ")"));

        //Public Member Functions
        //     Q_ENUMS (Sk6ObjectInformationProperty)


        #endregion

        public int Count { get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "Count")); }

        public int Index
        {
            get => Convert.ToInt32(Link.TSXSend(TSXCLASS + "Index"));
            set => Link.TSXSend(TSXCLASS + "Index=" + value.ToString() + ";");
        }

        public object ObjInfoPropOut
        {
            get
            {
                string sData = Link.TSXSend(TSXCLASS + "ObjInfoPropOut");
                try
                {
                    double result = Double.Parse(sData);
                    return result;
                }
                catch
                {
                    try
                    {
                        int result = Int32.Parse(sData);
                        return result;
                    }
                    catch
                    {
                        string result = sData;
                        return result;

                    }
                }
            }
        }

        #region properties

        #endregion

    }
}
