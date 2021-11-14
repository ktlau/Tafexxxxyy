using System;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace Calculator
{
	sealed partial class App : Application
	{
		public App()
		{
			InitializeComponent();
			Suspending += OnSuspending;
		}

		protected override void OnLaunched(LaunchActivatedEventArgs e)
		{
			if (!(Window.Current.Content is Frame rootFrame))
			{
				rootFrame = new Frame();

				rootFrame.NavigationFailed += OnNavigationFailed;

				Window.Current.Content = rootFrame;
			}

			if (e.PrelaunchActivated == false)
			{
				if (rootFrame.Content == null)
<<<<<<< HEAD
					rootFrame.Navigate(typeof(Currency_Calculator_Page), e.Arguments);
=======
					rootFrame.Navigate(typeof(Mortgage_Calculator_Page), e.Arguments);
>>>>>>> d1c2b4ee2313df6dcc34f7d7e374611ee0097846

				Window.Current.Activate();
			}
		}

		void OnNavigationFailed(object sender, NavigationFailedEventArgs e)
		{
			throw new Exception("Failed to load Page " + e.SourcePageType.FullName);
		}

		private void OnSuspending(object sender, SuspendingEventArgs e)
		{
			e.SuspendingOperation.GetDeferral().Complete();
		}
	}
}