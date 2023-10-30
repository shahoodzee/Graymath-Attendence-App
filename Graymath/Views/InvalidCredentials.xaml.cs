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
    public partial class InvalidCredentials : ContentPage
    {
        public InvalidCredentials()
        {
            InitializeComponent();
        }
        private async void SubmitButton_Clicked(object sender, System.EventArgs e)
        {
            await DisplayAlert("Alert", "Invalid Credentials", "OK");
        }
    }
}