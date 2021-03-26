using Ninject;
using Plugin.SharedTransitions;
using System;
using TransitionsDemo.Modules;
using TransitionsDemo.Services;
using TransitionsDemo.ViewModels;
using TransitionsDemo.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TransitionsDemo
{
    public partial class App : Application
    {
        public IKernel Kernel;

        public App()
        {
            InitializeComponent();
            Kernel = new StandardKernel(new NavigationModule());

            var mainPage = new SharedTransitionNavigationPage(new MainPage())
            {
                BindingContext = Kernel.Get<MainPageViewModel>()
            };

            var navService = Kernel.Get<INavigationService>() as NavigationService;
            navService.Navigation = mainPage.Navigation;
            MainPage = mainPage;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
