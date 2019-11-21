using EuroXam.Core.Models.UI;
using MvvmCross.Logging;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace EuroXam.Core.ViewModels
{
    public class ModalViewModel : MvxViewModel<UIMessage>
    {
        private string _title;

        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        private string _message;

        public string Message
        {
            get => _message;
            set => SetProperty(ref _message, value);
        }

        //public ModalViewModel(IMvxLogProvider logProvider, IMvxNavigationService navigationService) : base(logProvider, navigationService)
        //{
        //}

        public override void Prepare(UIMessage parameter)
        {
            Title = parameter.Title;
            Message = parameter.Message;
        }
    }
}
