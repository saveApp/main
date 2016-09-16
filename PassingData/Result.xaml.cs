using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PassingData
{
	public partial class Result : ContentPage
	{
		public Result(CalculationModel data)
		{
			var day = (data.datesave - data.datenow.AddDays(-1)).Days;
			InitializeComponent();
			var labelDays = new Label
			{
				Text = "Days until Next Salary",
				TextColor = Color.FromHex("#85817E"),
				FontSize = 20
			};
			var days = new Label
			{
				Text = day.ToString(),
				TextColor = Color.FromHex("#85817E"),
				FontSize = 20
			};
			var labelSpent = new Label
			{
				Text = "Daily Spend",
				TextColor = Color.FromHex("#85817E"),
				FontSize = 20
			};
			var spent = new Label
			{
				Text = ((data.money - data.saveMoney - data.expense) / day).ToString(),
				TextColor = Color.FromHex("#85817E"),
				FontSize = 20

			};
			var labelSave = new Label
			{
				Text = "You Save",
				TextColor = Color.FromHex("#85817E"),
				FontSize = 20

			};
			var save = new Label
			{
				Text = data.saveMoney.ToString(),
				TextColor = Color.FromHex("#85817E"),
				FontSize = 20

			};
			var doneButton = new Button
			{
				Text = "DONE",
				TextColor = Color.FromHex("#FFFFFF"),
				FontSize = 30,
				WidthRequest = 300,
				HeightRequest = 70,
				Margin = new Thickness(0, 20, 0, 0),
				BackgroundColor = Color.FromHex("#3FA9F5")

			};
			doneButton.Clicked += toMenu;
			content.Children.Add(labelDays);
			content.Children.Add(days);
			content.Children.Add(labelSpent);
			content.Children.Add(spent);
			content.Children.Add(labelSave);
			content.Children.Add(save);
			content.Children.Add(doneButton);




		}
		async void toMenu(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new MainPage());

		}

	}
}

