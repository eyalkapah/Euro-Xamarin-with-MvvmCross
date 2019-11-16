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
        private MvxObservableCollection<NavigationItem> _secondaryMenuItems;
        private NavigationItem _selectedNavigationItem;

        private NavigationItem _selectedSecondaryMenuItem;

        public ObservableCollection<NavigationItem> MenuItemList
        {
            get => _menuItemList;
            set => SetProperty(ref _menuItemList, value);
        }

        public MvxObservableCollection<NavigationItem> SecondaryMenuItems
        {
            get => _secondaryMenuItems;
            set => SetProperty(ref _secondaryMenuItems, value);
        }

        public IMvxAsyncCommand SecondaryMenuItemSelectedCommand { get; set; }

        public NavigationItem SelectedNavigationItem
        {
            get => _selectedNavigationItem;
            set => SetProperty(ref _selectedNavigationItem, value);
        }

        public NavigationItem SelectedSecondaryMenuItem
        {
            get => _selectedSecondaryMenuItem;
            set => SetProperty(ref _selectedSecondaryMenuItem, value);
        }

        public IMvxAsyncCommand ShowDetailPageAsyncCommand { get; }

        public MenuViewModel(IMvxLogProvider logProvider, IMvxNavigationService navigationService) : base(logProvider, navigationService)
        {
            ShowDetailPageAsyncCommand = new MvxAsyncCommand(ShowDetailPageAsync);
            SecondaryMenuItemSelectedCommand = new MvxAsyncCommand(OnSecondaryMenuItemSelected);
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

            SecondaryMenuItems = new MvxObservableCollection<NavigationItem>
            {
                new NavigationItem
                {
                    Title = "Add account",
                    Glyph = SolidIcons.Play,
                    TargetType = typeof(AddAccoutViewModel)
                },
                new NavigationItem
                {
                    Title = "Settins",
                    Glyph = SolidIcons.Cog,
                    TargetType = typeof(SettingsViewModel)
                }
            };

            return base.Initialize();
        }

        private Task OnSecondaryMenuItemSelected()
        {
            if (SelectedSecondaryMenuItem == null)
                return Task.CompletedTask;

            NavigationService.Navigate(SelectedSecondaryMenuItem.TargetType);

            SelectedSecondaryMenuItem = null;

            return Task.CompletedTask;
        }

        private Task ShowDetailPageAsync()
        {
            if (SelectedNavigationItem == null)
                return Task.CompletedTask;

            NavigationService.Navigate(SelectedNavigationItem.TargetType);

            SelectedNavigationItem = null;

            return Task.CompletedTask;
        }
    }
}
