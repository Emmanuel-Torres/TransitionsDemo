using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TransitionsDemo.Services
{
    public interface INavigationService
    {
        Task NavigateTo(Page page);
    }
}
