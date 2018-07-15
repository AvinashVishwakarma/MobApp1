using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobApp1.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : TabbedPage
	{
		public MainPage ()
        {
            InitializeComponent ();
            //this.IsVisible = true;
            //this.BarBackgroundColor = Color.FromHex("#00BFA5");
            //this.BackgroundColor = Color.FromHex("#64FFDA");
        }
	}
}