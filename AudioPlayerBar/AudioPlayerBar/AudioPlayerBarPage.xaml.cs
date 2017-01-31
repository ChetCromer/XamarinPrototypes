using Xamarin.Forms;

namespace AudioPlayerBar
{
	public partial class AudioPlayerBarPage : ContentPage
	{
		public AudioPlayerBarPage()
		{
			InitializeComponent();
		}

		void Handle_Clicked(object sender, System.EventArgs e)
		{
			//Push up another view
			Navigation.PushAsync(new AudioPlayerBarPage());
		}

		void OnTogglePlayerLoaded(object sender, System.EventArgs e)
		{
			AudioPlayer.Instance.IsLoaded = !AudioPlayer.Instance.IsLoaded;
		}
	}
}
