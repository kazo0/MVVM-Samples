using Microsoft.Extensions.DependencyInjection;
using Microsoft.Toolkit.Mvvm.DependencyInjection;
using MvvmSampleUwp.Services;
using MvvmSampleXF.Services;
using MvvmSampleXF.Views;
using Refit;
using System;
using System.IO;
using System.Linq;
using System.Reflection;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MvvmSampleXF
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			// Register services
			Ioc.Default.ConfigureServices(services =>
			{
				services.AddSingleton<IFilesService, FileService>();
				services.AddSingleton<ISettingsService, SettingsService>();
				services.AddSingleton(RestService.For<IRedditService>("https://www.reddit.com/"));
			});
			MainPage = new AppShell();
		}

		protected override void OnStart()
		{
		}

		protected override void OnSleep()
		{
		}

		protected override void OnResume()
		{
		}
	}
}
