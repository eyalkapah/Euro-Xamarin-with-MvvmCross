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

        public AddAccoutViewModel(IMvxLogProvider logProvider, IMvxNavigationService navigationService) : base(logProvider, navigationService)
        {
            LoginWithFacebookCommand = new MvxCommand(LoginWithFacebook);
        }

        private void LoginWithFacebook()
        {
        }
    }
}
