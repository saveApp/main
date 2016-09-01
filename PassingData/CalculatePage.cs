using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace PassingData
{
	public partial class CalculatePage : ContentPage
	{
		public CalculatePage ()
		{
			InitializeComponent ();



			var labelAvailableCash = new Label { Text = "Available Cash", TextColor = Color.FromHex("#85817E"), 
				FontSize = 20 };
			var entryAvailableCash = new Entry { TextColor=Color.FromHex("#999999"), Placeholder = "AUD", 
				PlaceholderColor=Color.FromHex("#DADADA"), Keyboard=Keyboard.Numeric, 
				BackgroundColor=Color.FromHex("#F8F8F8"), MinimumWidthRequest=250};
			var labelDate = new Label
			{
				Text = "Date of Next Payday",
				TextColor = Color.FromHex("#85817E"),
				FontSize = 20
			};
			var datePicker = new DatePicker
			{
				Format = "D",
				BackgroundColor = Color.FromHex("#F8F8F8"),
				Margin = new Thickness(0, 0, 0, 0),
				TextColor = Color.FromHex("#999999"),
				MinimumDate = DateTime.Now
			};
			var labelCashToSave = new Label
			{
				Text = "Cash to be Saved",
				TextColor = Color.FromHex("#85817E"),
				FontSize = 20
			};
			var entryCashToSave = new Entry
			{
				TextColor = Color.FromHex("#999999"),
				Placeholder = "AUD",
				PlaceholderColor = Color.FromHex("#DADADA"),
				Keyboard = Keyboard.Numeric,
				BackgroundColor = Color.FromHex("#F8F8F8"),
				MinimumWidthRequest = 250
			};
			var submitButton = new Button
			{
				Text = "Calculate",
				TextColor = Color.FromHex("#FFFFFF"),
				FontSize = 30,
				WidthRequest = 250,
				HeightRequest = 70,
				Margin = new Thickness(0,20,0,0),
				BackgroundColor = Color.FromHex("#3FA9F5")
			};

			content.Children.Add(labelAvailableCash);
			content.Children.Add(entryAvailableCash);
			content.Children.Add(labelDate);
			content.Children.Add(datePicker);
			content.Children.Add(labelCashToSave);
			content.Children.Add(entryCashToSave);
			content.Children.Add(submitButton);

		}
	}
}

