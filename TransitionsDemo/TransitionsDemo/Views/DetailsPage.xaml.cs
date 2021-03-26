using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TransitionsDemo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailsPage : ContentPage
    {
        public DetailsPage()
        {
            InitializeComponent();
            //CatPicture.Source = new UriImageSource
            //{
            //    Uri = new Uri("https://image.shutterstock.com/image-photo/cat-medical-mask-protective-antiviral-600w-1716771988.jpg"),
            //    CachingEnabled = true,
            //    CacheValidity = new TimeSpan(5, 0, 0, 0)
            //};
        }
    }
}