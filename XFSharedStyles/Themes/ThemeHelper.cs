using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XFSharedStyles.Themes
{
	public static class ThemeHelper
	{
		public static Theme CurrentTheme = Theme.Light;

		public static void ChangeTheme(Theme theme, bool forceChange = false)
		{
			if ((theme == CurrentTheme) && (forceChange == false))
				return;

			ResourceDictionary newTheme;

			switch (theme)
			{
				case Theme.Dark:
					newTheme = new DarkTheme();
					break;

				case Theme.Light:
				default:
					newTheme = new LightTheme();
					break;
			}

			Application.Current.Resources = newTheme;
			//Application.Current.Resources.MergedDictionaries.Clear();
			//Application.Current.Resources.MergedDictionaries.Add(newTheme);
			//Application.Current.Resources.MergedDictionaries.Add(new SharedStyles());

			CurrentTheme = theme;
		}
	}
}
