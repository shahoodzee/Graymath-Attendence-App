
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
    public partial class ConfirmCheckIn : ContentPage
    {
        public ConfirmCheckIn()
        {
            InitializeComponent();
			// Attach an event handler to the "OtherReasonCheckBox" to toggle the visibility of the "OtherReasonEditor" field.
			OtherReasonCheckBox.CheckedChanged += (sender, e) =>
			{
				OtherReasonEditor.IsVisible = e.Value;

			};
			WFHCheckBox.CheckedChanged += WFHCheckBox_CheckedChanged;
		}
		private void WFHCheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
		{
			// Set the visibility of the "Select WFH Reason" section based on the checkbox state
			bool isWFHChecked = e.Value;
			WFHReasonLabel.IsVisible = isWFHChecked;
			WFHReasonLayout.IsVisible = isWFHChecked;
		}
		private async void CheckInButton_Clicked(object sender, EventArgs e)
        {
            int checkhInCount = 0,          // Check how many checkboxes are selected
			reasonCount = 0;

			if (MedicalEmergencyCheckBox.IsChecked)
				reasonCount++;

			if (FamilyEmergencyCheckBox.IsChecked)
				reasonCount++;

			if (OtherReasonCheckBox.IsChecked)
				reasonCount++;

			if (CasualCheckInCheckBox.IsChecked)
                checkhInCount++;

			if (WFHCheckBox.IsChecked)
				checkhInCount++;

            if (checkhInCount != 1)
            {
				await DisplayAlert("Validation Error", "Select One Check-In Type.", "OK");
                return;
			}
			if (WFHCheckBox.IsChecked && reasonCount != 1)
			{
				await DisplayAlert("Validation Error", "Select One WFH Reason", "OK");
				return;
			}

            bool answer = await DisplayAlert("Confirmation", $"Are you sure you want to CheckIn ", "Yes", "No");

            if (answer)
            {
                // User clicked "Yes," you can perform the check-in action here.
                // Add your check-in logic.
                await Navigation.PushAsync(new ControllersPage());
            }
            else
            {
				// User clicked "No," you can handle the cancellation here.
				return;
            }
        }
    }
}
