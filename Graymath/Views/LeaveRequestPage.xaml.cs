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
            StartDatePicker.DateSelected += StartDatePicker_DateSelected;

            void StartDatePicker_DateSelected(object sender, DateChangedEventArgs e)
            {
                // Set the EndDatePicker's date to match the selected start date
                EndDatePicker.Date = e.NewDate;
            }
        }
		private async void OnSubmitClicked(object sender, EventArgs e)
		{
			// Check how many checkboxes are selected
			int reasonCount  = 0 , leaveType = 0;

			if (MedicalEmergencyCheckBox.IsChecked)
				reasonCount++;

			if (FamilyEmergencyCheckBox.IsChecked)
				reasonCount++;

			if (OtherReasonCheckBox.IsChecked)
				reasonCount++;

			if (CasualTypeCheckBox.IsChecked)
				leaveType++;

			if (AnnualTypeCheckBox.IsChecked)
				leaveType++;
			
			if (SickTypeCheckBox.IsChecked)
				leaveType++;

			DateTime startDate = StartDatePicker.Date;
			DateTime endDate = EndDatePicker.Date;

			// Calculate the time span between start and end dates
			TimeSpan timeSpan = endDate - startDate;

			// Check if the time span is less than 1 day (24 hours)
			//if (timeSpan.TotalHours < 24)
			//{
			//	await DisplayAlert("Validation Error", "The gap between the start date and end date should be more than 1 day.", "OK");
			//	return;
			//}

			// Check if the start date is greater than the end date
			if (StartDatePicker.Date > EndDatePicker.Date)
			{
				await DisplayAlert("Validation Error", "Start date cannot be greater than end date", "OK");
				return;
			}
			if (leaveType != 1)
			{
				await DisplayAlert("Validation Error", "Select Only one Leave.", "OK");
				return;
			}
			if (reasonCount != 1)
			{
				await DisplayAlert("Validation Error", "Select Only one Leave Reason.", "OK");
				return;
			}

			// Only one checkbox is selected, proceed with submission
			bool result = await DisplayAlert("Confirmation", "Are you sure?", "Yes", "No");

			if (result)
			{
				await DisplayAlert("Success", "Your request has been submitted successfully.", "OK");
				await Navigation.PushAsync(new ControllersPage());
			}
		}

	}
}