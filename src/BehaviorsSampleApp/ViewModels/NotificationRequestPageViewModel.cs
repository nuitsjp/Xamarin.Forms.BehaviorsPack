using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.BehaviorsPack;

namespace BehaviorsSampleApp.ViewModels
{
	public class NotificationRequestPageViewModel : ViewModelBase
	{
		private string _message = "Message";

		public string Message
		{
			get => _message;
			set => SetProperty(ref _message, value);
		}

		public ICommand ConfirmCommand => new Command(() =>
		{
			// Execution of input validation etc.
			// ...
			ConfirmRequest.Request(this, new DisplayAlertRequestEventArgs());
		});

		public DisplayAlertRequest ConfirmRequest { get; } = new DisplayAlertRequest();

		public ICommand RegistCommand => new Command(() =>
		{
			NotifyRegisteredRequest.Request(this);
		});

		public NotificationRequest NotifyRegisteredRequest { get; } = new NotificationRequest();

		public ICommand GoBackCommand => new Command(() =>
		{
			GoBackRequest.Request(this);
		});

		public NotificationRequest GoBackRequest { get; } = new NotificationRequest();
	}
}
