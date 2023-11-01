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
        }

        private async void ConfirmButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LateConfirmation());
        }
    }
}
