using FluentFlyouts.Core.Battery.ViewModels;
using FluentFlyouts.Core.Interfaces;
using FluentFlyouts.Flyouts;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Hosting;
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

namespace FluentFlyouts.Battery.Flyouts
{
	public sealed partial class BatteryFlyout : UserControl, IFlyoutContent
	{
		public event EventHandler? ShowFlyoutRequested;
		private BatteryFlyoutViewModel ViewModel = new();
		private TrayIcon trayIcon;

		public BatteryFlyout(TrayIcon trayIcon)
		{
			this.InitializeComponent();
			this.trayIcon = trayIcon;
		}

		public void Dispose()
		{
		}
	}
}
