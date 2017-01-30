using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;
using System.Threading;

namespace AudioPlayerBar
{
	public class AudioPlayer : INotifyPropertyChanged
	{
		public static AudioPlayer Instance { get; private set; }
		static AudioPlayer() { Instance = new AudioPlayer(); }
		private AudioPlayer()
		{

			Device.StartTimer(TimeSpan.FromMilliseconds(100), () =>
			{
				if (_IsPlaying)
				{
					CurrentPosition = DateTime.Now.Subtract(_StartTime).TotalSeconds;
				}
				return true;
			}
			);

		}



		private string _title = "Player Title";
		public string Title
		{
			get { return _title; }
			set { SetValue(ref _title, value); }
		}

		private bool _IsPlaying = false;
		public bool IsPlaying
		{
			get
			{
				return _IsPlaying;
			}
			set
			{
				SetValue(ref _IsPlaying, value);
			}
		}

		private DateTime _StartTime = DateTime.Now;
		private double _CurrentPosition = 0;
		public double CurrentPosition
		{
			get
			{
				return _CurrentPosition;
			}
			set
			{
				SetValue(ref _CurrentPosition, value);
			}
		}

		protected void SetValue<T>(ref T field, T value,
			[CallerMemberName]string propertyName = null)
		{
			if (!EqualityComparer<T>.Default.Equals(field, value))
			{
				field = value;
				OnPropertyChanged(propertyName);
			}
		}
		protected virtual void OnPropertyChanged(
			[CallerMemberName]string propertyName = null)
		{
			var handler = PropertyChanged;
			if (handler != null)
				handler(this, new PropertyChangedEventArgs(propertyName));
		}
		public event PropertyChangedEventHandler PropertyChanged;
	}
}
