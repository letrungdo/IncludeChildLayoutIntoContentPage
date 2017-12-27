using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BlankApp1.Views
{
	public partial class MainPage : ContentPage
	{
		public MainPage ()
		{
			InitializeComponent ();

           
            this.FindByName<Button>("btn1").Clicked += Button1Click;
            btn2.Clicked += Button2Click;
        }

        private void Button2Click(object sender, EventArgs e)
        {
            
            View2 view2 = new View2();
            EntryFieldsStack.Children.Clear();
            EntryFieldsStack.Children.Add(view2);
            
        }

        private void Button1Click(object sender, EventArgs e)
        {

            View1 view1 = new View1();
            EntryFieldsStack.Children.Clear();
            EntryFieldsStack.Children.Add(view1);
        }
    }
}