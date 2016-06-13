using System;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Odot
{
	public class App : Application
	{
		public App()
		{
			var model = new SQLOdotModel();



			MainPage = new NavigationPage(new OdotPage(model)) { BarBackgroundColor = Color.FromHex("535478"), BarTextColor = Color.FromHex("9af6dd") };
			
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}

