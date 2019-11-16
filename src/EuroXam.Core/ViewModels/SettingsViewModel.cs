using MvvmCross.Logging;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace EuroXam.Core.ViewModels
{
    public class SettingsViewModel : MvxNavigationViewModel
    {
        public SettingsViewModel(IMvxLogProvider logProvider, IMvxNavigationService navigationService) : base(logProvider, navigationService)
        {
        }
    }
}
