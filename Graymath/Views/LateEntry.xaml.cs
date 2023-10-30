using System;
using Xamarin.Forms;

namespace Graymath.Views
{
    public partial class LateEntry : ContentPage
    {
        public LateEntry()
        {
            InitializeComponent();
        }

        private async void ConfirmButton_Clicked(object sender, EventArgs e)
        {
            // Get the selected arrival and exit times
            TimeSpan arrivalTime = ArrivalTimePicker.Time;

            // You can use arrivalTime and exitTime for further processing (e.g., saving to a database)
            // Add your late confirmation logic here, such as saving the times.

            // Display a confirmation message with the selected times
            await DisplayAlert("Late Confirmation", $"You are late. Arrival Time: {arrivalTime},", "OK");

            // You can also navigate back to the previous page or perform other actions as needed.
        }
    }
}
