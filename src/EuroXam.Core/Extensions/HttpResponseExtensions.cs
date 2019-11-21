using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using EuroXam.Core.Models.UI;
using EuroXam.Core.ViewModels;
using MvvmCross;
using MvvmCross.Navigation;

namespace EuroXam.Core.Extensions
{
    public static class HttpResponseExtensions
    {
        public static bool HandleErrorResponse(this HttpResponseMessage response, string title)
        {
            if (response.IsSuccessStatusCode)
            {
                return true;
            }

            string message;

            if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                message = "Unauthorized.";
            }
            else
            {
                message = $"Server responded with {response.StatusCode}";
            }

            var navigationService = Mvx.IoCProvider.Resolve<IMvxNavigationService>();

            navigationService.Navigate<ModalViewModel, UIMessage>(new UIMessage(title, message));

            return false;
        }
    }
}
