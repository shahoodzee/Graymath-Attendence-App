using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static System.Collections.Specialized.BitVector32;

namespace Graymath.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomePage : ContentPage
	{
		public HomePage()
		{
			InitializeComponent();
		}
		private async void OnLoginButtonClicked(object sender, EventArgs e)
		{
			// Navigate to the login page
			//await Navigation.PushAsync(new LoginPage());
		}
	}
}



//In this XAML code:

//We use a Grid to divide the page into two sections: the header and the main content.
//The header section is defined in the first row (Grid.Row= "0") and contains a StackLayout with a centered image (your logo). You'll need to replace "your_logo.png" with the actual path or resource name of your logo.
//The main content section is defined in the second row (Grid.Row="1") and contains a StackLayout where you can add your main content.In this example, a simple welcome label is included.
//Adjust the HeightRequest and WidthRequest properties of the Image to control the size of your logo.
//Make sure to replace "YourNamespace" with the actual namespace of your Xamarin project and customize the content according to your application's needs.