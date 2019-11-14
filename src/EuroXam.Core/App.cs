using MvvmCross.IoC;
using MvvmCross.ViewModels;
using EuroXam.Core.ViewModels;

namespace EuroXam.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<RootViewModel>();
        }
    }
}
