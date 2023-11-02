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
	public partial class WorkFromHome : ContentPage
	{
		public WorkFromHome ()
		{
			InitializeComponent ();
			OtherReasonCheckBox.CheckedChanged += (sender, e) =>
			{
				OtherReasonEditor.IsVisible = e.Value;
			};
		}

		private async void OnSubmitClicked(object sender, EventArgs e)
		{
			int selectedCount = 0;

			if (MedicalEmergencyCheckBox.IsChecked)
				selectedCount++;

			if (FamilyEmergencyCheckBox.IsChecked)
				selectedCount++;

			if (OtherReasonCheckBox.IsChecked)
				selectedCount++;

			TimeSpan checkInTime = CheckInTimePicker.Time;
			TimeSpan checkOutTime = CheckOutTimePicker.Time;

			// Calculate the time difference in hours
			double timeDifferenceHours = (checkOutTime - checkInTime).TotalHours;

			if (timeDifferenceHours < 8)
			{
				bool confirmation = await DisplayAlert("Confirmation", "The duration is less than 8 hours. Are you sure you want to submit it?", "Yes", "No");

				if (!confirmation)
				{
					return;
				}
			}
			if (selectedCount > 1)
			{
				await DisplayAlert("Error", "You have selected more than one checkbox. Please select only one reason.", "OK");
				return;
			}

			bool result = await DisplayAlert("Confirmation", "Are you sure?", "Yes", "No");

			if (result)
			{
				await DisplayAlert("Success", "Your request has been submitted successfully.", "OK");
				await Navigation.PushAsync(new ControllersPage());
			}
		}
	}
}