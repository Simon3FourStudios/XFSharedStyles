using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFSharedStyles.Themes;

namespace XFSharedStyles
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			ThemeHelper.ChangeTheme(Theme.Light, true);

			MainPage = new MainPage();
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
