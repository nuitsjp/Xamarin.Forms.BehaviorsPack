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
	public partial class MenuPage : ContentPage
	{
		public MenuPage()
		{
			InitializeComponent();
		}

		private void DisplayAlertButton_OnClicked(object sender, EventArgs e)
		{
			Navigation.PushAsync(new DisplayAlertPage());
		}

		private void DisplayActionSheetButton_OnClicked(object sender, EventArgs e)
		{
			Navigation.PushAsync(new DisplayActionSheetPage());
		}

		private void NotificationRequestButton_OnClicked(object sender, EventArgs e)
		{
			Navigation.PushAsync(new NotificationRequestPage());
		}

		private void EventToCommandButton_OnClicked(object sender, EventArgs e)
		{
			Navigation.PushAsync(new EventToCommandPage());
		}

	    private void SelectedItemBehavior_OnClicked(object sender, EventArgs e)
	    {
	        Navigation.PushAsync(new SelectedItemBehaviorPage());
	    }
	}
}