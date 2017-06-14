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
			ConfirmRequest.Raise();
		});

		public NotificationRequest ConfirmRequest { get; } = new NotificationRequest();

		public ICommand RegistCommand => new Command(() =>
		{
			NotifyRegisteredRequest.Raise("Notice", "Registration has been completed.", cancel: new AlertButton
			{
			    Message = "OK",
                Action = () => GoBackRequest.Raise()
            });
		});

		public DisplayAlertRequest NotifyRegisteredRequest { get; } = new DisplayAlertRequest();

		public NotificationRequest GoBackRequest { get; } = new NotificationRequest();
	}
}
