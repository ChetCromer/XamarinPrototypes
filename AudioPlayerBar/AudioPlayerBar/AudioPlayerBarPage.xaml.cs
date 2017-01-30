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
			Navigation.PushAsync(new AudioPlayerBarPage());
		}
	}
}
