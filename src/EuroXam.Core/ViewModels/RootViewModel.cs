using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using MvvmCross.Logging;

namespace EuroXam.Core.ViewModels
{
    public class RootViewModel : MvxNavigationViewModel
    {
        public RootViewModel(IMvxLogProvider logProvider, IMvxNavigationService navigationService) : base(logProvider, navigationService)
        {
        }

        public override async void ViewAppearing()
        {
            base.ViewAppearing();

            await NavigationService.Navigate<MenuViewModel>();
            await NavigationService.Navigate<HomeViewModel>();
        }
    }
}
