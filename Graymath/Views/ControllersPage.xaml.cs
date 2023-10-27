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
	public partial class ControllersPage : ContentPage
	{
		public ControllersPage ()
		{
			InitializeComponent ();

			// Add event handlers for button clicks
		}
		private void OnCheckInClicked(object sender, EventArgs e)
		{
			// Handle the CheckIn button click event
		}

		private void OnCheckOutClicked(object sender, EventArgs e)
		{
			// Handle the CheckOut button click event
		}

		private void OnWorkFromHomeClicked(object sender, EventArgs e)
		{
			// Handle the WorkFromHome button click event
		}

		private void OnLeaveClicked(object sender, EventArgs e)
		{
			// Handle the Leave button click event
		}

		private void OnHistoryClicked(object sender, EventArgs e)
		{
			// Handle the History button click event
		}

	}
}