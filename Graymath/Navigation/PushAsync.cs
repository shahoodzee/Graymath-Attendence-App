using Graymath.Views;
using Xamarin.Forms;

namespace Navigation
{
	internal class PushAsync : Page
	{
		private LoginPage loginPage;

		public PushAsync(LoginPage loginPage)
		{
			this.loginPage = loginPage;
		}
	}
}