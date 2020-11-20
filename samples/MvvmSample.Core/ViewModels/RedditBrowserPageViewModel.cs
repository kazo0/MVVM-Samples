using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Messaging;
using Microsoft.Toolkit.Mvvm.Messaging.Messages;
using MvvmSampleUwp.Models;

namespace MvvmSampleUwp.ViewModels
{
	public class RedditBrowserPageViewModel : ObservableRecipient, IRecipient<PropertyChangedMessage<Post>>
	{
		private int _selectedTabIndex = 0;
		public int SelectedTabIndex { get => _selectedTabIndex; set => SetProperty(ref _selectedTabIndex, value); }

		public void Receive(PropertyChangedMessage<Post> message)
		{
			SelectedTabIndex = 1;
		}
	}
}
