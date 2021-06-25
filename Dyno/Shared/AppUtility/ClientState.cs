using Dyno.Shared.AppUtility.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyno.Shared.AppUtility
{
    public class ClientState : IClientState
    {
        public bool Loading { get; private set; } = false;

        public event Action OnChange;

        public void ToggleLoading(bool? state)
        {
            if (state == null)
            {
                this.Loading = !this.Loading;
            }
            else
            {
                this.Loading = (bool)state;
            }
            this.NotifyStateChange();
        }

        private void NotifyStateChange() => this.OnChange.Invoke();
    }
}
