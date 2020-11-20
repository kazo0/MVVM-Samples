using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.UI.Views;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MvvmSampleXF.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RedditBrowserPage : ContentPage
	{
		public RedditBrowserPage()
		{
			InitializeComponent();
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();
			SubredditWidget.PostSelected += SubredditWidget_PostSelected;
			PostWidget.OnAppearing();
			SubredditWidget.OnAppearing();
		}

		protected override void OnDisappearing()
		{
			base.OnDisappearing();
			SubredditWidget.PostSelected -= SubredditWidget_PostSelected;
			PostWidget.OnDisappearing();
		}

		private void SubredditWidget_PostSelected(object sender, EventArgs e)
		{
			
		}

	}
}