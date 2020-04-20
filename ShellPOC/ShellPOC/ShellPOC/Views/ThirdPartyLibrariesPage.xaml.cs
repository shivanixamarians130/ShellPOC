using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShellPOC.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ThirdPartyLibrariesPage : ContentPage
	{
		public ThirdPartyLibrariesPage ()
		{
			InitializeComponent ();
        }

        private void Button_Clicked(object sender, System.EventArgs e)
        {
            var btn = (Button)sender;
        }
    }
}

