using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace PassingData
{
	public class SignUpPage : ContentPage
	{
		Entry usernameEntry, passwordEntry, emailEntry;
		Label messageLabel;
		public SignUpPage()
		{
			messageLabel = new Label();
			usernameEntry = new Entry
			{
				Placeholder = "username"
			};
			passwordEntry = new Entry
			{
				IsPassword = true
			};
			emailEntry = new Entry();
			var signUpButton = new Button
			{
				Text = "Sign Up"
			};
			signUpButton.Clicked += OnSignUpButtonClicked;

			Title = "Sign Up";
			Content = new StackLayout
			{
				VerticalOptions = LayoutOptions.StartAndExpand,
				Children = {
					new Label { Text = "Username" },
					usernameEntry,
					new Label { Text = "Password" },
					passwordEntry,
					new Label { Text = "Email address" },
					emailEntry,
					signUpButton,
					messageLabel
				}
			};
		}
		async void OnSignUpButtonClicked(object sender, EventArgs e)
		{
			var user = new User()
			{
				Username = usernameEntry.Text,
				Password = passwordEntry.Text,
				Email = emailEntry.Text
			};

			// Sign up logic goes here

			bool signUpSucceeded = await new UserService().Post(user);
			if (signUpSucceeded)
			{
				var rootPage = Navigation.NavigationStack.FirstOrDefault();
				await this.DisplayAlert("SIGN UP COMPLETE", "HI "+ user.Username, "HEHE");
				if (rootPage != null)
				{
					App.IsUserLoggedIn = true;

					Navigation.InsertPageBefore(new MainPage(), Navigation.NavigationStack.First());
					await Navigation.PopToRootAsync();
				}
			}
			else
			{
				messageLabel.Text = "Sign up failed";
			}
		}

		bool AreDetailsValid(User user)
		{
			return (!string.IsNullOrWhiteSpace(user.Username) && !string.IsNullOrWhiteSpace(user.Password) && !string.IsNullOrWhiteSpace(user.Email) && user.Email.Contains("@"));
		}
		protected override bool OnBackButtonPressed()
		{

			Navigation.InsertPageBefore(new Login(), this);
			return true;
		}
	}
}