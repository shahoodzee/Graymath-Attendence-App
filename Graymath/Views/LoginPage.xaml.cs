using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Graymath.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
		public LoginPage()
		{
			InitializeComponent();

		}
		private void OnForgotPasswordTapped(object sender, EventArgs e)
		{
			// Handle the "Forgot Password" link tapped event
			// You can navigate to the forgot password page or show a password reset dialog here
		}

		private async void OnSubmitClicked(object sender, EventArgs e)
		{
			// Handle the "Submit" button clicked event
			// You can perform login/authentication logic here

			// After a successful login, navigate to the AppShell
			await Navigation.PushAsync(new NavigationPage(new ControllersPage())); 
		}
	}
}