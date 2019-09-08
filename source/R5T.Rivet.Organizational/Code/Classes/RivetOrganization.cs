using System;

using R5T.NetStandard.Organizational;


namespace R5T.Rivet.Organizational
{
    public class RivetOrganization : Organization
    {
        public static readonly string OrganizationName = Constants.RivetName;

        #region Static

        public static readonly RivetOrganization Instance = new RivetOrganization();

        #endregion


        public RivetOrganization()
            : base(RivetOrganization.OrganizationName)
        {
        }
    }
}
