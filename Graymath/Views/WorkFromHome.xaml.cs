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
	public partial class WorkFromHome : ContentPage
	{
		public WorkFromHome ()
		{
			InitializeComponent ();
		}
		private async void OnSubmitClicked(object sender, EventArgs e)
		{
			bool result = await DisplayAlert("Confirmation", "Are you sure?", "Yes", "No");
			if (result)
			{
				await DisplayAlert("Success", "Your request has been submitted successfully.", "OK");
			}
		}
	}
}