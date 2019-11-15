using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using EuroXam.Core.ViewModels;
using MvvmCross.Logging;
using EuroXam.Core.Models.UI;
using EuroXam.Core.Utils;

namespace EuroXam.Core.ViewModels
{
    public class MenuViewModel : MvxNavigationViewModel
    {
        private ObservableCollection<NavigationItem> _menuItemList;
        private NavigationItem _selectedNavigationItem;

        public ObservableCollection<NavigationItem> MenuItemList
        {
            get => _menuItemList;
            set => SetProperty(ref _menuItemList, value);
        }

        public NavigationItem SelectedNavigationItem
        {
            get => _selectedNavigationItem;
            set => SetProperty(ref _selectedNavigationItem, value);
        }

        public IMvxAsyncCommand ShowDetailPageAsyncCommand { get; private set; }

        public MenuViewModel(IMvxLogProvider logProvider, IMvxNavigationService navigationService) : base(logProvider, navigationService)
        {
            ShowDetailPageAsyncCommand = new MvxAsyncCommand(ShowDetailPageAsync);
        }

        public override Task Initialize()
        {
            MenuItemList = new MvxObservableCollection<NavigationItem>()
            {
                new NavigationItem
                {
                    Title = "Home",
                    Glyph = SolidIcons.Home,
                    TargetType = typeof(HomeViewModel)
                },
                new NavigationItem
                {
                    Title = "Bets",
                    Glyph = SolidIcons.ThumbsUp,
                    TargetType = typeof(BetsViewModel)
                },
                new NavigationItem
                {
                    Title = "Standings",
                    Glyph = SolidIcons.Users,
                    TargetType = typeof(StandingsViewModel)
                },
                new NavigationItem
                {
                    Title = "Matches",
                    Glyph = SolidIcons.Play,
                    TargetType = typeof(MatchesViewModel)
                }
            };

            return base.Initialize();
        }

        private Task ShowDetailPageAsync()
        {
            NavigationService.Navigate(SelectedNavigationItem.TargetType);

            return Task.CompletedTask;
            // Implement your logic here.
            //switch (SelectedMenuItem)
            //{
            //    case "Home":
            //        await NavigationService.Navigate<HomeViewModel>();
            //        break;

            //    case "Contacts":
            //        await NavigationService.Navigate<ContactsViewModel>();
            //        break;

            //    default:
            //        break;
            //}

            //if (Application.Current.MainPage is MasterDetailPage masterDetailPage)
            //{
            //    masterDetailPage.IsPresented = false;
            //}
            //else if (Application.Current.MainPage is NavigationPage navigationPage
            //         && navigationPage.CurrentPage is MasterDetailPage nestedMasterDetail)
            //{
            //    nestedMasterDetail.IsPresented = false;
            //}
        }
    }
}
