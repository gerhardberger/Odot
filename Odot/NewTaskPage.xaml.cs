using System;

using Xamarin.Forms;

namespace Odot
{
	public partial class NewTaskPage : ContentPage
	{
		private IOdotModel model;

		public NewTaskPage(IOdotModel m)
		{
			model = m;

			InitializeComponent();
		}

		void OnCancel(object sender, EventArgs e)
		{
			Navigation.PopModalAsync(true);
		}

		async void OnSave(object sender, EventArgs e)
		{
			var text = TextArea.Text;

			if (String.IsNullOrEmpty(text)) return;

			var t = new OdotTask { Text = text };

			await model.AddTask(t);
			await Navigation.PopModalAsync(true);
		}
	}
}

