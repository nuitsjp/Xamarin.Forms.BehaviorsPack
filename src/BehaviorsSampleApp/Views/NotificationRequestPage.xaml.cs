using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BehaviorsSampleApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NotificationRequestPage : ContentPage
	{
		public NotificationRequestPage()
		{
			InitializeComponent();
		}

		private void NotificationBehavior_OnReceived(object sender, EventArgs e)
		{
			Navigation.PopAsync();
		}
	}
}