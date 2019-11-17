using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MvvmCross.Commands;
using MvvmCross.Logging;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace EuroXam.Core.ViewModels
{
    public class RegisterAccountViewModel : MvxNavigationViewModel
    {
        public ICommand SignInCommand { get; set; }
        public ICommand CreateAccountCommand { get; set; }

        private string _username;

        public string Username
        {
            get => _username;
            set => SetProperty(ref _username, value);
        }

        private string _password;

        public string Password
        {
            get => _password;
            set => SetProperty(ref _password, value);
        }


        public RegisterAccountViewModel(IMvxLogProvider logProvider, IMvxNavigationService navigationService) : base(logProvider, navigationService)
        {
            SignInCommand = new MvxCommand(SignIn);
            CreateAccountCommand = new MvxCommand(CreateCommand);
        }

        private void CreateCommand()
        {
            
        }

        private void SignIn()
        {
            NavigationService.Navigate(typeof(SignInViewModel));
        }
    }
}
