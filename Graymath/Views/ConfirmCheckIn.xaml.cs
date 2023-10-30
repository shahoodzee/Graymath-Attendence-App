
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
        }

        private async void CheckInButton_Clicked(object sender, EventArgs e)
        {
            bool answer = await DisplayAlert("Confirmation", "Are you sure you want to check in?", "Yes", "No");

            if (answer)
            {
                // User clicked "Yes," you can perform the check-in action here.
                // Add your check-in logic.
            }
            else
            {
                // User clicked "No," you can handle the cancellation here.
            }
        }
    }
}