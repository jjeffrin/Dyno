using Dyno.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyno.Shared.AppRepository
{
    public class ClientRepository : IClientRepository
    {
        public ClientRepository()
        {
            this.GetSiteData();
        }

        #region Methods

        public void GetSiteData()
        {

        }

        #endregion

        #region Properties

        public SiteModel Site { get; set; }

        #endregion
    }
}
