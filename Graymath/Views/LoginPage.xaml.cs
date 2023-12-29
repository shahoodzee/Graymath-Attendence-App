using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Newtonsoft.Json;

namespace Graymath.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
		public LoginPage()
		{
			InitializeComponent();

		}
		private async void OnForgotPasswordTapped(object sender, EventArgs e)
		{
			// Handle the "Forgot Password" link tapped event
			await Navigation.PushAsync(new ForgotPasswordPage());

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
			await Navigation.PushAsync(new ControllersPage());


			//// Prepare the JSON payload
			//var Data = new
			//{
			//	data = new
			//	{
			//		Email = email,
			//		Password = password
			//	} 
			//};
			//string jsonData = JsonConvert.SerializeObject(Data);

			//// Send the POST request to the PHP backend
			//string apiUrl = "https://192.168.88.113/api/UserLogin.php";


			//using (HttpClient client = new HttpClient())
			//{
			//	StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");

			//	try
			//	{
			//		HttpResponseMessage response = await client.PostAsync(apiUrl, content);

			//		if (response.IsSuccessStatusCode)
			//		{
			//			string responseContent = await response.Content.ReadAsStringAsync();

			//			// Deserialize the JSON response
			//			var result = JsonConvert.DeserializeObject<LoginResponse>(responseContent);

			//			// Check if the login was successful
			//			if (result?.Good == true && result?.PayLoad != null && result.PayLoad.ContainsKey("User Logged In ") && result.PayLoad["User Logged In "] == true)
			//			{
			//				// Navigate to the next page upon successful login
			//				await Navigation.PushAsync(new ControllersPage());
			//			}
			//			else
			//			{
			//				// Display an error message if login fails
			//				await DisplayAlert("Login Failed", "Invalid username or password", "OK");
			//			}
			//		}
			//		else
			//		{
			//			// Handle the case where the server returns an error
			//			await DisplayAlert("Error", "Server returned an error: " + response.StatusCode, "OK");
			//		}
			//	}
			//	catch (Exception ex)
			//	{
			//		// Handle any exception that may occur during the request
			//		await DisplayAlert("Error", "An error occurred: " + ex.Message, "OK");
			//	}
			//}
		}

		private class LoginResponse
		{
			public bool Good { get; set; }
			public string Error { get; set; }
			public Dictionary<string, bool> PayLoad { get; set; }
		}

		private void OnShowPasswordToggled(object sender, ToggledEventArgs e)
		{
			bool isPasswordVisible = e.Value;
			PasswordEntry.IsPassword = !isPasswordVisible;
		}
	}
}