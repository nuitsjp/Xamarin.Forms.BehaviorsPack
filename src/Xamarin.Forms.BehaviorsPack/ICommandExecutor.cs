using System;
using System.Windows.Input;

namespace Xamarin.Forms.BehaviorsPack
{
	public interface ICommandExecutor
	{
		void Execute(
			ICommand command,
			object commandParameter = null,
			EventArgs eventArgs = null,
			IValueConverter eventArgsCoverter = null,
			object eventArgsConverterParameter = null,
			string eventArgsPropertyPath = null);
	}
}