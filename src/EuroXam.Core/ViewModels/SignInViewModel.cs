using System;
using System.Windows.Input;
using MvvmCross.Commands;
using MvvmCross.Logging;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace EuroXam.Core.ViewModels
{
    public class SignInViewModel : MvxNavigationViewModel
    {
        public ICommand LoginWithFacebookCommand { get; set; }
        public ICommand LoginWithGoogleCommand { get; set; }
        public ICommand RegisterCommand { get; set; }

        public SignInViewModel(IMvxLogProvider logProvider, IMvxNavigationService navigationService) : base(logProvider, navigationService)
        {
            LoginWithFacebookCommand = new MvxCommand(LoginWithFacebook);
            LoginWithGoogleCommand = new MvxCommand(LoginWithGoogle);
            RegisterCommand = new MvxCommand(Register);
        }

        private void Register()
        {
            NavigationService.Navigate(typeof(RegisterAccountViewModel));
        }

        private void LoginWithGoogle()
        {
        }

        private void LoginWithFacebook()
        {
        }
    }
}
