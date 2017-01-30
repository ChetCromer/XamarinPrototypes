using System;
using System.ComponentModel;

namespace AudioPlayerBar
{
	public class AudioPlayer : INotifyPropertyChanged
	{
		// Singleton for use throughout the app
		public static AudioPlayer Current = new AudioPlayer();

		private bool _IsPlaying = false;

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
