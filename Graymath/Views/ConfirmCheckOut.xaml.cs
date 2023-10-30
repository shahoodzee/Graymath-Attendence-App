using System;
using Xamarin.Forms;

namespace Graymath.Views
{
    public partial class ConfirmCheckOut : ContentPage
    {
        public ConfirmCheckOut()
        {
            InitializeComponent();
        }

        private async void CheckOutButton_Clicked(object sender, EventArgs e)
        {
            bool answer = await DisplayAlert("Confirmation", "Are you sure you want to check out?", "Yes", "No");

            if (answer)
            {
                // User clicked "Yes," you can perform the check-out action here.
                // Add your check-out logic.
            }
            else
            {
                // User clicked "No," you can handle the cancellation here.
            }
        }
    }
}
