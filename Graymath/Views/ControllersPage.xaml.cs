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
			// Hide the back button in the navigation bar
			NavigationPage.SetHasBackButton(this, false);
			NavigationPage.SetHasNavigationBar(this, true);

		}
		private async void OnBellImageTapped(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new NotificationsPage());
		}

		private async void OnLogoutImageTapped(object sender, EventArgs e)
		{
			// Handle the CheckOut button click event
			bool result = await DisplayAlert("Confirmation", "Are you sure you want to log-out?", "Yes", "No");
			if (result)
			{
				await Navigation.PushAsync(new LoginPage());
				// Call the logout method in App.xaml.cs
				(Application.Current as App)?.Logout();
			}
		}

		private async void OnCheckInClicked(object sender, EventArgs e)
		{
			// Handle the CheckIn button click event
			bool result = await DisplayAlert("Confirmation", "Are you sure you want to check-in?", "Yes", "No");
			if (result)
			{
				await Navigation.PushAsync(new ConfirmCheckIn());
			}
		}

		private async void OnCheckOutClicked(object sender, EventArgs e)
		{
			// Handle the CheckOut button click event
			bool result = await DisplayAlert("Confirmation", "Are you sure you want to check-out?", "Yes", "No");
			if (result)
			{
				await Navigation.PushAsync(new ConfirmCheckOut());
			}
		}

		private async void OnLateClicked(object sender, EventArgs e)
		{
			// Handle the CheckOut button click event
			bool result = await DisplayAlert("Confirmation", "Are you sure you want to check-in Late?", "Yes", "No");
			if (result)
			{
				await Navigation.PushAsync(new LateEntry());
			}
		}


		private async void OnWorkFromHomeClicked(object sender, EventArgs e)
		{
			// Handle the CheckOut button click event
			//bool result = await DisplayAlert("Confirmation", "Are you sure you want to check-in via WFH?", "Yes", "No");
			//if (result)
			{
				await Navigation.PushAsync(new WorkFromHome());
			}
		}

		private async void OnLeaveClicked(object sender, EventArgs e)
		{
			// Handle the CheckOut button click event
			await Navigation.PushAsync(new LeaveRequestPage());
		}

		private async void OnHistoryClicked(object sender, EventArgs e)
		{
			// Handle the CheckOut button click event
			//bool result = await DisplayAlert("Confirmation", "Are you sure you want to check-in?", "Yes", "No");
			//if (result)
			{
				await Navigation.PushAsync(new HistoryPage1());
			}
		}

	}
}