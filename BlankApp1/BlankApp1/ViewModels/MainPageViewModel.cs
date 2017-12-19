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


        //INavigationService _navigationService;

        //public DelegateCommand btn1Click { get; }//
        //public DelegateCommand btn2Click { get; }//

        //private bool _isVisibleLbl1;
        //public bool IsVisibleLbl1
        //{
        //    get
        //    {
        //        return _isVisibleLbl1;
        //    }
        //    set
        //    {
        //        _isVisibleLbl1 = value;
        //        RaisePropertyChanged("IsVisibleLbl1");
        //    }
        //}

        //private bool _isVisibleLbl2;
        //public bool IsVisibleLbl2
        //{
        //    get
        //    {
        //        return _isVisibleLbl2;
        //    }
        //    set
        //    {
        //        _isVisibleLbl2 = value;
        //        RaisePropertyChanged("IsVisibleLbl2");
        //    }
        //}

        public MainPageViewModel(INavigationService navigationService) 
            : base (navigationService)
        {
            Title = "Main Page";

            //btn1Click = new DelegateCommand(showPage1);
            //btn2Click = new DelegateCommand(showPage2);
            //_navigationService = navigationService;
        }

        //private void showPage1()
        //{
        //    IsVisibleLbl1 = true;
        //    hidePage2();

        //    _navigationService.NavigateAsync("Page1");
         
        //}
        //private void hidePage1()
        //{
        //    IsVisibleLbl1 = false;
        //}

        //private void showPage2()
        //{
        //    IsVisibleLbl2 = true;
        //    hidePage1();
        //}
        //private void hidePage2()
        //{
        //    IsVisibleLbl2 = false;
        //}

    }
}
