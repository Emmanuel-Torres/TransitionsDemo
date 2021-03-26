using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using TransitionsDemo.Services;
using Xamarin.Forms;

namespace TransitionsDemo.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public INavigationService Navigation;

        public BaseViewModel(INavigationService navigation)
        {
            Navigation = navigation;
        }
    }
}
