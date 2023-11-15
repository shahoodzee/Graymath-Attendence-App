using Graymath;
using Graymath.Views;
using Xamarin.Forms;

namespace Graymath
{
	public partial class App : Application
	{

		public App()
		{
			InitializeComponent();
			MainPage = new NavigationPage(new ControllersPage());
		}

		protected override void OnStart()
		{
		}

		protected override void OnSleep()
		{
		}

		protected override void OnResume()
		{

		}

		// Method to handle logout and reset the navigation stack
		public void Logout()
		{
			MainPage = new NavigationPage(new LoginPage());
		}
	}
}
