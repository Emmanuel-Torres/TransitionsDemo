using System;
using System.Collections.Generic;
using System.Text;
using TransitionsDemo.Services;
using Xamarin.Forms;

namespace TransitionsDemo.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        public MainPageViewModel(INavigationService navigation) : base(navigation)
        {
        }
    }
}
