using System;
using System.Collections.Generic;
using System.Text;
using TransitionsDemo.Services;
using TransitionsDemo.Views;
using Xamarin.Forms;

namespace TransitionsDemo.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        public Command GoToDetails =>
            new Command(() => {
                Navigation.NavigateTo(new DetailsPage());
            });

        public MainPageViewModel(INavigationService navigation) : base(navigation)
        {
        }
    }
}
