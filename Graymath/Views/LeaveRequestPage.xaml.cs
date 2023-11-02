using Navigation;
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
	public partial class LeaveRequestPage : ContentPage
	{
		public LeaveRequestPage()
		{
			InitializeComponent();
			// Attach an event handler to the "OtherReasonCheckBox" to toggle the visibility of the "OtherReasonEditor" field.
			OtherReasonCheckBox.CheckedChanged += (sender, e) =>
			{
				OtherReasonEditor.IsVisible = e.Value;
			};
		}
		private async void OnSubmitClicked(object sender, EventArgs e)
		{
			// Check how many checkboxes are selected
			int selectedCount = 0;

			if (MedicalEmergencyCheckBox.IsChecked)
				selectedCount++;

			if (FamilyEmergencyCheckBox.IsChecked)
				selectedCount++;

			if (OtherReasonCheckBox.IsChecked)
				selectedCount++;

			DateTime startDate = StartDatePicker.Date;
			DateTime endDate = EndDatePicker.Date;

			// Calculate the time span between start and end dates
			TimeSpan timeSpan = endDate - startDate;

			// Check if the time span is less than 1 day (24 hours)
			if (timeSpan.TotalHours < 24)
			{
				await DisplayAlert("Validation Error", "The gap between the start date and end date should be more than 1 day.", "OK");
				return;
			}

			if (selectedCount == 1)
			{
				// Only one checkbox is selected, proceed with submission
				bool result = await DisplayAlert("Confirmation", "Are you sure?", "Yes", "No");

				if (result)
				{
					await DisplayAlert("Success", "Your request has been submitted successfully.", "OK");
					await Navigation.PushAsync(new ControllersPage());
				}
			}
			else
			{
				// More than one checkbox is selected, display an alert
				await DisplayAlert("Error", "You have selected more than one checkbox. Please select only one reason.", "OK");
			}
		}

	}
}