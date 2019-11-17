using MvvmCross.Forms.Presenters.Attributes;
using MvvmCross.Forms.Views;
using EuroXam.Core.ViewModels;
using Xamarin.Forms.Xaml;

namespace EuroXam.UI.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [MvxMasterDetailPagePresentation(Position = MasterDetailPosition.Detail, NoHistory = true, Title = "Sign In")]
    public partial class AddAccountPage : MvxContentPage<SignInViewModel>
    {
        public AddAccountPage()
        {
            InitializeComponent();
        }
    }
}
