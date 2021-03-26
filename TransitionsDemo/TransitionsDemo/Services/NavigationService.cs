using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TransitionsDemo.Services
{
    public class NavigationService : INavigationService
    {
        public INavigation Navigation;
        public async Task NavigateTo(Page page)
        {
            await Navigation.PushAsync(page, true);
        }
    }
}
