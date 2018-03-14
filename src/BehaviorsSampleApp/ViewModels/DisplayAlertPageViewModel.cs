using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace BehaviorsSampleApp.ViewModels
{
	public class DisplayAlertPageViewModel : ViewModelBase
	{
		private string _message = "Selection result is displayed here.";

		public string Message
		{
			get => _message;
			set => SetProperty(ref _message, value);
		}

		public ICommand AcceptCommand => new Command(() =>
		{
			Message = "Selected OK button.";
		});

		public Command<string> CancelCommand => new Command<string>(param =>
		{
			Message = param;
		});
    }
}
