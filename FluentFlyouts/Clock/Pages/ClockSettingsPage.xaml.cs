using FluentFlyouts.Calendar.Flyouts;
using FluentFlyouts.Flyouts;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace FluentFlyouts.Calendar.Pages
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class ClockSettingsPage : Page
	{
		public ClockSettingsPage()
		{
			this.InitializeComponent();
			ActiveSwitch.IsOn = App.Settings.IsClockFlyoutEnabled;
		}

		private void ToggleSwitch_Toggled(object sender, RoutedEventArgs e)
		{
			App.Settings.IsClockFlyoutEnabled = ActiveSwitch.IsOn;
			if (ActiveSwitch.IsOn && !App.flyoutService.HasFlyout(2))
			{
				App.flyoutService.AddFlyout(2, tray => new ClockFlyout(tray), true);
			}
			else if (!ActiveSwitch.IsOn && App.flyoutService.HasFlyout(2))
			{
				App.flyoutService.RemoveFlyout(2);
			}
		}
	}
}
