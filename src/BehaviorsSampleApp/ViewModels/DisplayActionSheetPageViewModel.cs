using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace BehaviorsSampleApp.ViewModels
{
	public class DisplayActionSheetPageViewModel : ViewModelBase
	{
		private string _message = "Selection result is displayed here.";

		public string Message
		{
			get => _message;
			set => SetProperty(ref _message, value);
		}

		public Command<string> CancelCommand => new Command<string>(param =>
		{
			Message = param;
		});

		public ICommand DestructionCommand => new Command(() =>
		{
			Message = "Selected Delete button.";
		});

		public ICommand FirstActionSheetCommand => new Command(() =>
		{
			Message = "Selected First ActionSheet Item.";
		});

		public ICommand SecondActionSheetCommand => new Command(() =>
		{
			Message = "Selected Second ActionSheet Item.";
		});
	}
}
