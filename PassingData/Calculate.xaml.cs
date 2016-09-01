using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PassingData
{
	public partial class Calculate : ContentPage
	{
		public Calculate()
		{
			InitializeComponent();

			var Money = new Label { Text = "Money" };
			var inputMoney = new Entry { Placeholder = "AUD", Keyboard = Keyboard.Numeric };
			content.Children.Add(Money);
			content.Children.Add(inputMoney);
		}
	}
}

