using BlankApp1.Views;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlankApp1.ViewModels
{
    public class ViewModelBase : BindableBase, INavigationAware, IDestructible
    {
        protected INavigationService NavigationService { get; private set; }

        public DelegateCommand btn1Click { get; }//
        public DelegateCommand btn2Click { get; }//
        public DelegateCommand btn3Click { get; }//
                                                 //



        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public ViewModelBase(INavigationService navigationService)
        {
            NavigationService = navigationService;
            btn1Click = new DelegateCommand(showPage1);
            btn2Click = new DelegateCommand(showPage2);
        }

        private void showPage1()
        {

            //NavigationService.NavigateAsync("/NavigationPage/Page1");

            //NavigationService.NavigateAsync("/NavigationPage/MainPage/Page1", null, false, true);

           // View1 view1 = new View1();
            



        }

        private void showPage2()
        {
            //NavigationService.NavigateAsync("/NavigationPage/MainPage/Page2", null, false, false);
            //NavigationService.NavigateAsync("/NavigationPage/Page2");
        }

        public virtual void OnNavigatedFrom(NavigationParameters parameters)
        {
            
        }

        public virtual void OnNavigatedTo(NavigationParameters parameters)
        {
            
        }

        public virtual void OnNavigatingTo(NavigationParameters parameters)
        {
            
        }

        public virtual void Destroy()
        {
            
        }
    }
}
