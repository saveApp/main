using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PassingData
{
	public partial class News : ContentPage
	{
		public News(NewsModel data)
		{
			InitializeComponent();

			Label header = new Label
			{
				Text = data.newsTitle,
				FontSize = 12,
				FontAttributes = FontAttributes.Bold,
				HorizontalOptions = LayoutOptions.Center
			};

			WebView webView = new WebView
			{
				Source = new HtmlWebViewSource
				{
					Html="<div>"+"<img src=\""+data.newsIMGURL+"\" />"+"</div>"+"<br/>"+data.newsContent+ "<br/><a href=\""+data.newsURL+"\">Go to Source</a>",
				},
				VerticalOptions = LayoutOptions.FillAndExpand
			};

			// Build the page.
			this.Content = new StackLayout
			{
				Children =
				{
					header,
					webView
				}
			};
		}
	}
}

