using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Graymath.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ForgotPasswordPage : ContentPage
	{
		public ForgotPasswordPage()
		{
			InitializeComponent();
		}
		private bool IsValidEmail(string email)
		{
			// Regular expression for email validation
			string emailPattern = @"^[\w\.-]+@[\w\.-]+\.\w+$";
			return System.Text.RegularExpressions.Regex.IsMatch(email, emailPattern);
		}
		private async void SendPasswordResetLink(object sender, EventArgs e)
		{
			// Handle the "Submit" button clicked event
			string email = EmailEntry.Text;

			// Email validation using a regular expression
			if (!IsValidEmail(email))
			{
				EmailErrorLabel.IsVisible = true;
				return;
			}
			await DisplayAlert("Success", "Password Reset Link has been sent at your registered email.", "OK");
			await Navigation.PushAsync(new LoginPage());
		}
	}
}