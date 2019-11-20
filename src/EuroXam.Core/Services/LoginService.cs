using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuroXam.Core.Services
{
    public class LoginService : ILoginService
    {
        private readonly ISettingsService _settings;

        public LoginService(ISettingsService settings)
        {
            _settings = settings;
        }
    }
}
