using MvvmCross.Forms.Views;
using MvvmCross.Forms.Presenters.Attributes;
using Xamarin.Forms.Xaml;
using EuroXam.Core.ViewModels;

namespace EuroXam.UI.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [MvxContentPagePresentation(WrapInNavigationPage = true, NoHistory = false)]
    public partial class SettingsPage : MvxContentPage<SettingsViewModel>
    {
        public SettingsPage()
        {
            InitializeComponent();
        }
    }
}
