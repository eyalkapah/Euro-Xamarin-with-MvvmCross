using System;
using System.Windows.Input;
using MvvmCross.Commands;
using MvvmCross.Logging;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace EuroXam.Core.ViewModels
{
    public class AddAccoutViewModel : MvxNavigationViewModel
    {
        public ICommand LoginWithFacebookCommand { get; set; }
        public ICommand LoginWithGoogleCommand { get; set; }

        public AddAccoutViewModel(IMvxLogProvider logProvider, IMvxNavigationService navigationService) : base(logProvider, navigationService)
        {
            LoginWithFacebookCommand = new MvxCommand(LoginWithFacebook);
            LoginWithGoogleCommand = new MvxCommand(LoginWithGoogle);
        }

        private void LoginWithGoogle()
        {
        }

        private void LoginWithFacebook()
        {
        }
    }
}
