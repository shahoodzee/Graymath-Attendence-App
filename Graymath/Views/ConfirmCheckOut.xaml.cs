using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Graymath.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConfirmCheckOut : ContentPage
    {
        public ConfirmCheckOut()
        {
            InitializeComponent();
        }

        private async void CheckOutButton_Clicked(object sender, EventArgs e)
        {
            bool answer = await DisplayAlert("Confirmation", $"Are you sure you want to CheckOut ", "Yes", "No");

            if (answer)
            {
                // User clicked "Yes," you can perform the check-in action here.
                // Add your check-in logic.
                await Navigation.PushAsync(new ControllersPage());
            }
            else
            {
                // User clicked "No," you can handle the cancellation here.
            }
        }
    }
}
