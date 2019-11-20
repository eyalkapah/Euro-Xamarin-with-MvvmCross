using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using EuroXam.Core.Models.Api;
using Newtonsoft.Json;

namespace EuroXam.Core.Services
{
    public class LoginService : ILoginService
    {
        private readonly ISettingsService _settings;

        public LoginService(ISettingsService settings)
        {
            _settings = settings;
        }

        public async Task<HttpResponseMessage> RegisterAsync(string username, string password)
        {
            using (var client = new HttpClient())
            {
                var jsonContent = JsonConvert.SerializeObject(new RegisterCredentialsApiModel
                {
                    Username = username,
                    Password = password
                });

                var response = await client.PostAsync(GlobalSetting.Instance.RegisterEndpoint,
                    new StringContent(jsonContent.ToString(), Encoding.UTF8, "application/json"));

                if (response.IsSuccessStatusCode)
                {
                }

                if (response.StatusCode == HttpStatusCode.Unauthorized)
                {
                }
                else
                {
                    var message = $"Server responded with {response.StatusCode}";
                }

                return null;
            }
        }
    }
}
