using MvvmCross.Forms.Presenters.Attributes;
using MvvmCross.Forms.Views;
using EuroXam.Core.ViewModels;
using Xamarin.Forms.Xaml;

namespace EuroXam.UI.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [MvxMasterDetailPagePresentation(Position = MasterDetailPosition.Master, WrapInNavigationPage = false, Title = "NavigationMenu")]
    public partial class MenuPage : MvxContentPage<MenuViewModel>
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        private void ListView_ItemTapped(object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
        }

        private void ListView_ItemTapped_1(object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
        }

        private void MenuList_ItemTapped(object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
        }

        private void OnImageButtonClicked(object sender, System.EventArgs e)
        {
        }
    }
}
