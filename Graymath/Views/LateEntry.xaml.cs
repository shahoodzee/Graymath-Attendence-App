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

        private async void ConfirmButton_Clicked(object sender, EventArgs e)
        {
			int selectedCount = 0;

			if (MedicalEmergencyCheckBox.IsChecked)
				selectedCount++;

			if (FamilyEmergencyCheckBox.IsChecked)
				selectedCount++;

			if (OtherReasonCheckBox.IsChecked)
				selectedCount++;

			if (selectedCount > 1)
			{
				await DisplayAlert("Error", "You have selected more than one checkbox. Please select only one reason.", "OK");
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
