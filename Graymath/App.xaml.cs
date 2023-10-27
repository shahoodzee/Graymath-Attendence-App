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
			MainPage = new ControllersPage();
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
	}
}
