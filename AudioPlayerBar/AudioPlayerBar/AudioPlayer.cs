using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace AudioPlayerBar
{
	public  class AudioPlayer :INotifyPropertyChanged
	{
		// Singleton for use throughout the app
		public static AudioPlayer Current = new AudioPlayer();

		//Don't allow creation of the class elsewhere in the app.
		private AudioPlayer()
		{
		}

		private bool _IsPlaying = false;

		//property for whether a file is being played or not
		public bool IsPlaying
		{
			get
			{
				return _IsPlaying;
			}
			set
			{
				_IsPlaying = value;
				OnPropertyChanged("IsPlaying");
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged == null)
				return;

			PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
