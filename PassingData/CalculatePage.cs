using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace PassingData
{
    public partial class CalculatePage : ContentPage
    {
        Entry entryCashToSave, entryAvailableCash,entryExpense;
        DatePicker datePicker;

        public CalculatePage()
        {
            InitializeComponent();



            var labelAvailableCash = new Label
            {
                Text = "Available Cash",
                TextColor = Color.FromHex("#85817E"),
                FontSize = 20
            };

            entryAvailableCash = new Entry
            {
                TextColor = Color.FromHex("#999999"),
                Placeholder = "AUD",
                PlaceholderColor = Color.FromHex("#DADADA"),
                Keyboard = Keyboard.Numeric,
                BackgroundColor = Color.FromHex("#eceff1"),
                MinimumWidthRequest = 300
            };

            var labelDate = new Label
            {
                Text = "Date of Next Payday",
                TextColor = Color.FromHex("#85817E"),
                FontSize = 20
            };
            datePicker = new DatePicker
            {
                Format = "D",
                BackgroundColor = Color.FromHex("#eceff1"),
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
            entryCashToSave = new Entry
            {
                TextColor = Color.FromHex("#999999"),
                Placeholder = "AUD",
                PlaceholderColor = Color.FromHex("#DADADA"),
                Keyboard = Keyboard.Numeric,
                BackgroundColor = Color.FromHex("#eceff1"),
                MinimumWidthRequest = 300
            };
            var labelExpense = new Label
            {
                Text = "Cash to be Saved",
                TextColor = Color.FromHex("#85817E"),
                FontSize = 20
            };
            entryExpense = new Entry
            {
                TextColor = Color.FromHex("#999999"),
                Placeholder = "AUD",
                PlaceholderColor = Color.FromHex("#DADADA"),
                Keyboard = Keyboard.Numeric,
                BackgroundColor = Color.FromHex("#eceff1"),
                MinimumWidthRequest = 300
            };
            var submitButton = new Button
            {
                Text = "Calculate",
                TextColor = Color.FromHex("#FFFFFF"),
                FontSize = 30,
                WidthRequest = 300,
                HeightRequest = 70,
                Margin = new Thickness(0, 20, 0, 0),
                BackgroundColor = Color.FromHex("#3FA9F5")

            };



            submitButton.Clicked += OnSubmitButtonClicked;

            content.Children.Add(labelAvailableCash);
            content.Children.Add(entryAvailableCash);
            content.Children.Add(labelDate);
            content.Children.Add(datePicker);
            content.Children.Add(labelCashToSave);
            content.Children.Add(entryCashToSave);
            content.Children.Add(labelExpense);
            content.Children.Add(entryExpense);
            content.Children.Add(submitButton);

        }

        private void OnSubmitButtonClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();

            var duit = new CalculationModel
            {
                saveMoney = int.Parse(entryCashToSave.Text),
                money = int.Parse(entryAvailableCash.Text),
                datesave = datePicker.Date,
                datenow = DateTime.Now,
                expense = int.Parse(entryExpense.Text)
            };
        }
    }
}
    


