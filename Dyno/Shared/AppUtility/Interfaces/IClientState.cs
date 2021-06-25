using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyno.Shared.AppUtility.Interfaces
{
    public interface IClientState
    {
        #region Properties

        public bool Loading { get; }

        public event Action OnChange;

        #endregion


        #region Methods

        public void ToggleLoading(bool? state = null);
        #endregion
    }
}
