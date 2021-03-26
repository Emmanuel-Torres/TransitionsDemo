using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Text;
using TransitionsDemo.Services;
using TransitionsDemo.ViewModels;

namespace TransitionsDemo.Modules
{
    public class NavigationModule : NinjectModule
    {
        public override void Load()
        {
            Bind<INavigationService>().To<NavigationService>().InSingletonScope();
            Bind<MainPageViewModel>().ToSelf();
        }
    }
}
