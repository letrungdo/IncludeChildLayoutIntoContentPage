using BlankApp1.Views;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using Xamarin.Forms;

namespace BlankApp1.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {

        
       
        public MainPageViewModel(INavigationService navigationService) 
            : base (navigationService)
        {
            Title = "Main Page";

          
            
        }

       

    }
}
