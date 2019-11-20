using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace EuroXam.Core.Services
{
    public interface ILoginService
    {
        Task<HttpResponseMessage> RegisterAsync(string username, string password);
    }
}
