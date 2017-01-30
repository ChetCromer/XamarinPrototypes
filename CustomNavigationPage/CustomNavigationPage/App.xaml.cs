﻿using Xamarin.Forms;

namespace CustomNavigationPage
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new NavigationPage(new MyContentPage());
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}

		void Handle_Clicked(object sender, System.EventArgs e)
		{
			AudioPlayer.Current.IsPlaying = !AudioPlayer.Current.IsPlaying;
		}
	}
}
