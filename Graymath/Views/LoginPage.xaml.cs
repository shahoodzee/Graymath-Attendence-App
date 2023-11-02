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
		private bool IsValidEmail(string email)
		{
			// Regular expression for email validation
			string emailPattern = @"^[\w\.-]+@[\w\.-]+\.\w+$";
			return System.Text.RegularExpressions.Regex.IsMatch(email, emailPattern);
		}

		private bool IsValidPassword(string password)
		{
			// Password validation: 8 characters with capital letters and special characters
			return password.Length >= 8 && System.Text.RegularExpressions.Regex.IsMatch(password, "[A-Z]") && System.Text.RegularExpressions.Regex.IsMatch(password, "[!@#$%^&*()]");
		}
		private async void OnSubmitClicked(object sender, EventArgs e)
		{

			// Handle the "Submit" button clicked event
			// You can perform login/authentication logic here
			string email = EmailEntry.Text;
			string password = PasswordEntry.Text;

			// Email validation using a regular expression
			if (!IsValidEmail(email))
			{
				EmailErrorLabel.IsVisible = true;
				return;
			}

			// Password validation
			if (!IsValidPassword(password))
			{
				PasswordErrorLabel.IsVisible = true;
				return;
			}
			
			// After a successful login, navigate to the AppShell
			await Navigation.PushAsync(new ControllersPage()); 
		}
		private void OnShowPasswordToggled(object sender, ToggledEventArgs e)
		{
			bool isPasswordVisible = e.Value;
			PasswordEntry.IsPassword = !isPasswordVisible;
		}
	}
}