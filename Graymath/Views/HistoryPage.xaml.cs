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
	public partial class HistoryPage : ContentPage
	{
		public HistoryPage ()
		{
			InitializeComponent ();
		}
		private void OnDailyHistoryClicked(object sender, EventArgs e)
		{
			DailyHistoryTable.IsVisible = true;
			LeaveHistoryTable.IsVisible = false;
		}
		private void OnLeaveHistoryClicked(object sender, EventArgs e)
		{
			DailyHistoryTable.IsVisible = false;
			LeaveHistoryTable.IsVisible = true;
		}
	}
}