using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EuroXam.Core.ViewModels;
using MvvmCross.Forms.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EuroXam.UI.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ModalPage : MvxContentPage<ModalViewModel>
    {
        public ModalPage()
        {
            InitializeComponent();
        }
    }
}
