using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace PassingData
{
	public class Login : ContentPage
	{
		Entry usernameEntry, passwordEntry;
		Label messageLabel;

		public Login()
		{
			var toolbarItem = new ToolbarItem
			{
				Text = "Sign Up"
			};
			toolbarItem.Clicked += OnSignUpButtonClicked;
			ToolbarItems.Add(toolbarItem);

			messageLabel = new Label();
			usernameEntry = new Entry
			{
				Placeholder = "username"
			};
			passwordEntry = new Entry
			{
				IsPassword = true,
				Placeholder = "password"
			};
			var loginButton = new Button
			{
				Text = "Login"
			};
			loginButton.Clicked += OnLoginButtonClicked;

			Title = "Login";

			Content = new StackLayout
			{
				VerticalOptions = LayoutOptions.StartAndExpand,
				Children = {
					usernameEntry,
					passwordEntry,
					loginButton
				}
			};


		}
		async void OnSignUpButtonClicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new SignUpPage());
		}

		async void OnLoginButtonClicked(object sender, EventArgs e)
		{
			var user = new User
			{
				Username = usernameEntry.Text,
				Password = passwordEntry.Text
			};

			bool isValid = await new UserService().Get(user);
			if (isValid)
			{
				App.IsUserLoggedIn = true;
				App.Username = user.Username;
				Navigation.InsertPageBefore(new MainPage(), this);
				await this.DisplayAlert("LOGGED IN", "HI "+user.Username, "HEHE");
				await Navigation.PopAsync();
			}
			else
			{
				messageLabel.Text = "Login failed";
				passwordEntry.Text = string.Empty;
			}

		}
		/*bool AreCredentialsCorrect(User user)
        {
            return user.Username == Constants.Username && user.Password == Constants.Password;
        }*/
	}
}