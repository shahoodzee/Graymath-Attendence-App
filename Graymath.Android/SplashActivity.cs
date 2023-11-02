using System;
using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.OS;
using Graymath.Droid;
using Android.Util;
using System.Threading.Tasks;
using Android.Content;
using Graymath;
using AndroidX.AppCompat.App;

namespace Graymath.Droid
{
	[Activity(Label = "Graymath", Icon = "@mipmap/icon", Theme = "@style/MyTheme.Splash", NoHistory = true, MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize)]
	public class SplashActivity : AppCompatActivity
	{

		[Obsolete]
		public override void OnBackPressed() { }
		static readonly string TAG = "X:" + typeof(SplashActivity).Name;

		public override void OnCreate(Bundle savedInstanceState, PersistableBundle persistentState)
		{
			base.OnCreate(savedInstanceState, persistentState);
			Log.Debug(TAG, "SplashActivity.OnCreate");
		}

		// Launches the startup task
		protected override void OnResume()
		{
			base.OnResume();
			Task startupWork = new Task(() => { SimulateStartup(); });
			startupWork.Start();
		}

		// Simulates background work that happens behind the splash screen
		async void SimulateStartup()
		{
			Log.Debug(TAG, "Performing some startup work that takes a bit of time.");
			await Task.Delay(8000); // Simulate a bit of startup work.
			Log.Debug(TAG, "Startup work is finished - starting MainActivity.");
			StartActivity(new Intent(Application.Context, typeof(MainActivity)));
		}
	}
}
