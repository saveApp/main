﻿using System;
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
                IsPassword = true
            };
            var loginButton = new Button
            {
                Text = "Login"
            };
            loginButton.Clicked += OnLoginButtonClicked;

            Title = "Login";
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

            var isValid = true;
            if (isValid)
            {
                App.IsUserLoggedIn = true;
                Navigation.InsertPageBefore(new MainPageCS("sa"), this);
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