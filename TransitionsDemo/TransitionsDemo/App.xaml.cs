using Ninject;
using System;
using TransitionsDemo.Modules;
using TransitionsDemo.Services;
using TransitionsDemo.ViewModels;
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

            SetUpMainPage();
        }

        private void SetUpMainPage()
        {

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
