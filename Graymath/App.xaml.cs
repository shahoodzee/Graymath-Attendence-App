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
			//MainPage = new HistoryPage();
			//MainPage = new WorkFromHome();
			//MainPage = new LeaveRequestPage();
			//MainPage = new LoginPage();
			//MainPage = new ControllersPage();
			//MainPage = new ConfirmCheckIn();
			//MainPage = new LateConfirmation();
			//MainPage = new InvalidCredentials();
			//MainPage = new LateEntry();
			//MainPage = new HomePage();

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
