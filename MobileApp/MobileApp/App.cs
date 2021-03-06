using System;
using Xamarin.Forms;

namespace MobileApp
{
    public partial class App : Application
	{
		public App()
		{
			Button openHello = new Button { Text = "Go to Hello" };
			var openControls = new Button { Text = "Go To Controls Dayvin" };


			var page = new ContentPage
			{
				Content = new StackLayout
				{
					Orientation = StackOrientation.Vertical,
					Children =
					{
					openHello,
					openControls,
					}
				}

			};

			openHello.Command = new Command(() => page.Navigation.PushAsync(new HelloWorldPage()));
			openControls.Command = new Command(() => page.Navigation.PushAsync(new  Views.ControlsPage()));


			View titleView = new StackLayout
			{
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.Center,
				Children =
				{
					new Label {Text = "Welcome Dayvin" }
				}
			};
			NavigationPage.SetTitleView(page, titleView);

			MainPage = new NavigationPage(page);
		}
	}
}