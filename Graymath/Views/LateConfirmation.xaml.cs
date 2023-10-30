using System;
using Xamarin.Forms;

namespace Graymath.Views
{
    public partial class LateConfirmation : ContentPage
    {
        public LateConfirmation()
        {
            InitializeComponent();
        }

        private async void YesButton_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Confirmation", "You have registered your late arrival.", "OK");

            // You can add further logic here to handle the "Yes" button click.
        }

        private async void NoButton_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Confirmation", "You have canceled your late arrival registration.", "OK");

            // You can add further logic here to handle the "No" button click.
        }
    }
}
