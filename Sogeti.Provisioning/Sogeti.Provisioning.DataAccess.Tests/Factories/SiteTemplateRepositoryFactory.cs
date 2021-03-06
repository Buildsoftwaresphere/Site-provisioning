using Sogeti.Provisioning.DataAccess.Repositories;
using System;
using Microsoft.Pex.Framework;

namespace Sogeti.Provisioning.DataAccess.Repositories
{
    /// <summary>A factory for Sogeti.Provisioning.DataAccess.Repositories.SiteTemplateRepository instances</summary>
    public static partial class SiteTemplateRepositoryFactory
    {
        /// <summary>A factory for Sogeti.Provisioning.DataAccess.Repositories.SiteTemplateRepository instances</summary>
        [PexFactoryMethod(typeof(SiteTemplateRepository))]
        public static SiteTemplateRepository Create()
        {
            SiteTemplateRepository siteTemplateRepository = new SiteTemplateRepository();
            return siteTemplateRepository;

            // TODO: Edit factory method of SiteTemplateRepository
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }
    }
}
