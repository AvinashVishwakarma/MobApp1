using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobApp1.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CallPage : ContentPage
	{
		public CallPage ()
		{
			InitializeComponent ();
		}

        private async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            var answer = await DisplayAlert("Alert", "you are about to add new call", "Continue", "Cancel");
            await DisplayAlert("Ans", "You clicked " + answer.ToString(), "OK");
        }
    }
}