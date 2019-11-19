using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using EuroXam.Core.Models.Api;
using MvvmCross.Commands;
using MvvmCross.Logging;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using Newtonsoft.Json;

namespace EuroXam.Core.ViewModels
{
    public class RegisterAccountViewModel : MvxNavigationViewModel
    {
        private string _password;
        private string _username;
        public ICommand CreateAccountCommand { get; set; }

        public string Password
        {
            get => _password;
            set => SetProperty(ref _password, value);
        }

        public ICommand SignInCommand { get; set; }

        public string Username
        {
            get => _username;
            set => SetProperty(ref _username, value);
        }

        public RegisterAccountViewModel(IMvxLogProvider logProvider, IMvxNavigationService navigationService) : base(logProvider, navigationService)
        {
            SignInCommand = new MvxCommand(SignIn);
            CreateAccountCommand = new MvxCommand(CreateCommand);
        }

        private async void CreateCommand()
        {
            using (var client = new HttpClient())
            {
                var content = JsonConvert.SerializeObject(new RegisterCredentialsApiModel
                {
                    Username = Username,
                    Password = Password
                });
                var result = await client.PostAsync("http://localhost:5000/api/register", content)
            }
        }

        private void SignIn()
        {
            NavigationService.Navigate(typeof(SignInViewModel));
        }
    }
}
