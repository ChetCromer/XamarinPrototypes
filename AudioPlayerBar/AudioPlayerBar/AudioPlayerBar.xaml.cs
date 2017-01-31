using System;
using System.Collections.Generic;
using System.Diagnostics;
using Xamarin.Forms;

namespace AudioPlayerBar
{
	public partial class AudioPlayerBar : ContentView
	{
		public AudioPlayerBar()
		{
			InitializeComponent();
		}

		void Click_PlayPause(object sender, System.EventArgs e)
		{
			AudioPlayer.Instance.IsPlaying = !AudioPlayer.Instance.IsPlaying;
			AudioPlayer.Instance.Title = DateTime.Now.ToString();
			Debug.WriteLine(AudioPlayer.Instance.Title);
		}
	}
}
