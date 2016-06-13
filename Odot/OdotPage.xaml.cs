using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Odot
{
	public partial class OdotPage : ContentPage
	{
		private IOdotModel model;

		public OdotPage(IOdotModel m)
		{
			model = m;

			InitializeComponent();
		}

		async protected override void OnAppearing()
		{
			base.OnAppearing();

			await refreshTasks();
		}

		void OnItemTapped(object sender, ItemTappedEventArgs e)
		{
			if (e == null) return;
	
			((ListView)sender).SelectedItem = null;
		}

		async void OnComplete(object sender, EventArgs e)
		{
			var mi = (MenuItem)sender;
			var t = (OdotTask)mi.CommandParameter;

			await model.DeleteTask(t);

			await refreshTasks();
		}

		void OnNewTapped(object sender, EventArgs e)
		{
			Navigation.PushModalAsync(new NewTaskPage(model));
		}

		async Task refreshTasks()
		{
			List<OdotTask> ts = await model.GetTasks();

			TasksView.ItemsSource = null;
			TasksView.ItemsSource = ts;
		}
	}
}

