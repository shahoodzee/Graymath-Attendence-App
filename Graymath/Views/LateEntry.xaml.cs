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
    public partial class LateEntry : ContentPage
    {
        public LateEntry()
        {
            InitializeComponent();
			// Attach an event handler to the "OtherReasonCheckBox" to toggle the visibility of the "OtherReasonEditor" field.
			OtherReasonCheckBox.CheckedChanged += (sender, e) =>
			{
				OtherReasonEditor.IsVisible = e.Value;
			};
		}
		private void OnCheckBoxCheckedChanged(object sender, CheckedChangedEventArgs e)
		{
			var currentCheckBox = sender as CheckBox;
			if (currentCheckBox.IsChecked)
			{
				// Uncheck other checkboxes
				if (currentCheckBox != MedicalEmergencyCheckBox)
					MedicalEmergencyCheckBox.IsChecked = false;

				if (currentCheckBox != FamilyEmergencyCheckBox)
					FamilyEmergencyCheckBox.IsChecked = false;

				if (currentCheckBox != OtherReasonCheckBox)
					OtherReasonCheckBox.IsChecked = false;
			}
		}

		private async void ConfirmButton_Clicked(object sender, EventArgs e)
        {
			int selectedCount = 0;

			if (MedicalEmergencyCheckBox.IsChecked)
				selectedCount++;

			if (FamilyEmergencyCheckBox.IsChecked)
				selectedCount++;

			if (OtherReasonCheckBox.IsChecked)
				selectedCount++;

			// Check if OtherReasonEditor is visible
			if (OtherReasonEditor.IsVisible)
			{
				// Check if OtherReasonEditor2 (Editor inside the frame) is empty
				if (string.IsNullOrWhiteSpace(OtherReasonEditor2.Text))
				{
					await DisplayAlert("Validation Error", "Please Explain your Other reason", "OK");
					return;
				}
			}
			if (selectedCount != 1)
			{
				await DisplayAlert("Error", "Please select one reason.", "OK");
				return;
			}
			else
			{
				bool result = await DisplayAlert("Confirmation", "Are you sure?", "Yes", "No");
				if (result)
				{
					await Navigation.PushAsync(new ControllersPage());
				}
			}
        }
    }
}
