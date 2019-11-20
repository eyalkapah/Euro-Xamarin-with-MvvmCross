using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuroXam.Core
{
    public class GlobalSetting
    {
        public static GlobalSetting Instance { get; } = new GlobalSetting();

        private string _baseEndpoint;

        public string BaseEndpoint
        {
            get => _baseEndpoint;
            set
            {
                _baseEndpoint = value;
                UpdateEndpoint(_baseEndpoint);
            }
        }

        public string RegisterEndpoint { get; private set; }
        public string LogoutEndpoint { get; private set; }

        private void UpdateEndpoint(string baseEndpoint)
        {
            RegisterEndpoint = $"{baseEndpoint}/api/account/Register";
            LogoutEndpoint = $"{baseEndpoint}/api/account/endsession";
        }
    }
}
