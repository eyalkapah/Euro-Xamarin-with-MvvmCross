﻿using Android.App;
using MvvmCross.Forms.Platforms.Android.Core;

#if DEBUG
[assembly: Application(Debuggable = true)]
#else
[assembly: Application(Debuggable = false)]
#endif

namespace EuroXam.Droid
{
    public class Setup : MvxFormsAndroidSetup<Core.App, UI.App>
    {
    }
}
