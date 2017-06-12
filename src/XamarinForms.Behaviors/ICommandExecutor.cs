using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace XamarinForms.Behaviors
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