
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShellPOC.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomePage : Shell
	{
		public HomePage ()
		{
			InitializeComponent ();
            if(Device.RuntimePlatform == Device.iOS)
            {

            }
            else if(Device.RuntimePlatform == Device.Android)
            {

            }
            else
            {

            }
		}
	}
}