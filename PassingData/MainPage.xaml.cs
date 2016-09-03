using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace PassingData
{
	public partial class MainPage : ContentPage
	{
		// CHECK IF LOGGED IN OR NOT
		bool logged = true;
		public MainPage ()
		{
			InitializeComponent ();

			var buttonAccount = new ToolbarItem
			{
				Text = "Account",
				Order = ToolbarItemOrder.Secondary,
				Priority = 0,
			};
			buttonAccount.Clicked += (object sender, System.EventArgs e) =>
				{
					this.DisplayAlert("Selected!", "Account", "OK");
				};

			var buttonHistory = new ToolbarItem
			{
				Text = "History",
				Order = ToolbarItemOrder.Secondary,
				Priority = 1
			};
			buttonHistory.Clicked += (object sender, System.EventArgs e) =>
				{
					this.DisplayAlert("Selected!", "History", "OK");
				};

			var buttonLogOut = new ToolbarItem
			{
				Text = "Log Out",
				Order = ToolbarItemOrder.Secondary,
				Priority = 2
			};
			buttonLogOut.Clicked += (object sender, System.EventArgs e) =>
				{
					logged = false;
					this.DisplayAlert("Selected!", "LogOut", "OK");
				};

			var buttonLogIn = new ToolbarItem
			{
				Text = "Log In",
				Order = ToolbarItemOrder.Secondary,
				Priority = 0
			};
			buttonLogIn.Clicked += (object sender, System.EventArgs e) =>
				{
					logged = true;
					this.DisplayAlert("Selected!", "LogIn", "OK");
				};

			if (logged){
				ToolbarItems.Add(buttonAccount);
				ToolbarItems.Add(buttonHistory);
				ToolbarItems.Add(buttonLogOut);
			}
			else {
				ToolbarItems.Add(buttonLogIn);
			}

			listView.ItemsSource = new List<NewsModel> {
				new NewsModel{
					id = 0,
					newsName="How to join MLM",
					newsURL="asu.com",
					newsIMGURL="hono",
					newsContent="kapal Pesiar"
				}, new NewsModel{
					id = 6,
					newsName="How to not join MLM",
					newsURL="asu.com",
					newsIMGURL="hono",
					newsContent="kapal Pesiar"
				}
			};
			listView.ItemSelected += (sender, e) =>{
				DisplayAlert("Item selected!", (e.SelectedItem as NewsModel).id.ToString(), "hehe");
			};


		}
		async void toCalculate(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new CalculatePage());
		}
	}
}
