using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShellPOC.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AboutPage : ContentPage
	{
		public AboutPage ()
		{
			InitializeComponent ();
            var list = new List<string>
            {
                "data",
                "data",
                   "data",
                "data",
                   "data",
                "data",
                   "data",
                "data",
            };
            testList.ItemsSource = list;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var data = (ListView)sender;
        }
    }
}