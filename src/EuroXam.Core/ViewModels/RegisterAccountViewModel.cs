using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using EuroXam.Core.Extensions;
using EuroXam.Core.Models.Api;
using EuroXam.Core.Models.UI;
using EuroXam.Core.Services;
using MvvmCross.Commands;
using MvvmCross.Logging;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using Newtonsoft.Json;

namespace EuroXam.Core.ViewModels
{
    public class RegisterAccountViewModel : MvxNavigationViewModel
    {
        private readonly ILoginService _loginService;
        private string _password;
        private string _username;

        public string Password
        {
            get => _password;
            set => SetProperty(ref _password, value);
        }

        public ICommand RegisterCommandAsync { get; set; }
        public ICommand SignInCommand { get; set; }

        public string Username
        {
            get => _username;
            set => SetProperty(ref _username, value);
        }

        public RegisterAccountViewModel(IMvxLogProvider logProvider, IMvxNavigationService navigationService, ILoginService loginService) : base(logProvider, navigationService)
        {
            SignInCommand = new MvxCommand(SignIn);
            RegisterCommandAsync = new MvxCommand(RegisterAsync);
            _loginService = loginService;
        }

        private async void RegisterAsync()
        {
            try
            {
                var response = await _loginService.RegisterAsync(Username, Password);

                if (!response.HandleErrorResponse("Register"))
                    return;

                var content = await response.Content.ReadAsStringAsync();

                _loginService.HandleSuccessfullLogin(content);
            }
            catch (Exception ex)
            {
                await NavigationService.Navigate<ModalViewModel, UIMessage>(new UIMessage("Registration Error", ex.Message));
            }
        }

        private void SignIn()
        {
            NavigationService.Navigate(typeof(SignInViewModel));
        }
    }
}
