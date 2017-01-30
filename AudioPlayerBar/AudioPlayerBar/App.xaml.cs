using System;
using System.Diagnostics;
using Xamarin.Forms;

namespace AudioPlayerBar
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new NavigationPage( new AudioPlayerBarPage());
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

		void Click_PlayPause(object sender, System.EventArgs e)
		{
			AudioPlayer.Instance.IsPlaying = !AudioPlayer.Instance.IsPlaying;
			AudioPlayer.Instance.Title = DateTime.Now.ToString();
			Debug.WriteLine(AudioPlayer.Instance.Title);
		}

	}
}
