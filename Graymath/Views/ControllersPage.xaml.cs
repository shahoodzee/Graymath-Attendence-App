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
	public partial class ControllersPage : ContentPage
	{
		public ControllersPage ()
		{
			InitializeComponent ();

			// Add event handlers for button clicks
		}
		private void OnCheckInClicked(object sender, EventArgs e)
		{
			// Handle the CheckIn button click event
		}

		private void OnCheckOutClicked(object sender, EventArgs e)
		{
			// Handle the CheckOut button click event
		}

		private async void OnWorkFromHomeClicked(object sender, EventArgs e)
		{
			// Handle the WorkFromHome button click event
			bool result = await DisplayAlert("Confirmation", "Are you sure you want to check-in?", "Yes", "No");
			if (result)
			{
				await DisplayAlert("Success", "Your request has been submitted successfully.", "OK");
			}
		}

		private async void OnLeaveClicked(object sender, EventArgs e)
		{
			// Handle the Leave button click event
			bool result = await DisplayAlert("Confirmation", "Are you sure you want to check-in?", "Yes", "No");
			if (result)
			{
				await DisplayAlert("Success", "Your request has been submitted successfully.", "OK");
			}
		}
		private async void OnLatelicked(object sender, EventArgs e)
		{
			// Handle the Leave button click event
			bool result = await DisplayAlert("Confirmation", "Are you sure??", "Yes", "No");
			if (result)
			{
				await DisplayAlert("Success", "Your request has been submitted successfully.", "OK");
			}
		}

		private async void OnHistoryClicked(object sender, EventArgs e)
		{
			// Handle the History button click event
			bool result = await DisplayAlert("Confirmation", "Are you sure you want to check-in?", "Yes", "No");
			if (result)
			{
				await DisplayAlert("Success", "Your request has been submitted successfully.", "OK");
			}
		}

	}
}