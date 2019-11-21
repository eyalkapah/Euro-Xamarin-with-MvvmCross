using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EuroXam.Core.ViewModels;
using MvvmCross;

namespace EuroXam.Core.Design
{
    public static class ViewModelLocator
    {
        public static ModalViewModel ModalViewModel => Mvx.IoCProvider.Resolve<ModalViewModel>();
    }
}
