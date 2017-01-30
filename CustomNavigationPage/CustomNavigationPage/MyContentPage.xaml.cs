using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CustomNavigationPage
{
	public partial class MyContentPage : ContentPage
	{
		public MyContentPage()
		{
			InitializeComponent();
			lblTime.Text = DateTime.Now.ToString() + " (" + Navigation.NavigationStack.Count.ToString() + " views)";
		}

		void Handle_Clicked(object sender, System.EventArgs e)
		{
			Navigation.PushAsync(new MyContentPage());
		}
	}
}
