using System;
using System.Globalization;
using System.Reflection;
using System.Windows.Input;

namespace Xamarin.Forms.BehaviorsPack
{
	public class CommandExecutor : ICommandExecutor
    {
	    public void Execute(ICommand command, object commandParameter = null, EventArgs eventArgs = null,
		    IValueConverter eventArgsCoverter = null, object eventArgsConverterParameter = null,
		    string eventArgsPropertyPath = null)
	    {
			if (command == null)
		    {
			    return;
		    }

		    object parameter = null;
		    if (commandParameter != null)
		    {
			    parameter = commandParameter;
		    }
		    else if (eventArgs != null && eventArgs != EventArgs.Empty)
		    {
			    if (eventArgsCoverter != null)
			    {
				    parameter = eventArgsCoverter.Convert(eventArgs, typeof(object), eventArgsConverterParameter, CultureInfo.CurrentUICulture);
			    }
			    else if (!string.IsNullOrEmpty(eventArgsPropertyPath))
			    {
				    var propertyPathParts = eventArgsPropertyPath.Split('.');
				    object propertyValue = eventArgs;
				    foreach (var propertyPathPart in propertyPathParts)
				    {
					    var propInfo = propertyValue.GetType().GetTypeInfo().GetDeclaredProperty(propertyPathPart);
					    propertyValue = propInfo.GetValue(propertyValue);
					    if (propertyValue == null)
					    {
						    break;
					    }
				    }
				    parameter = propertyValue;
			    }
		    }

		    if (command.CanExecute(parameter))
		    {
			    command.Execute(parameter);
		    }
		}
	}
}
