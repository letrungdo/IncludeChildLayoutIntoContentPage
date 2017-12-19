using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BlankApp1.ViewModels
{
	public class Page1ViewModel : ViewModelBase
	{
      

        public Page1ViewModel(INavigationService navigationService) : base(navigationService)
        {
        }
    }
}
