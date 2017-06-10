using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace XamarinForms.Behaviors
{
    public static class CommandExtensions
    {
        public static void Execute(this ICommand command, EventArgs eventArgs, object commandParameter,
            IValueConverter eventArgsCoverter, object eventArgsConverterParameter, string eventArgsPropertyPath)
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
            else if (eventArgs != EventArgs.Empty)
            {
                if (eventArgsCoverter != null)
                {
                    parameter = eventArgsCoverter.Convert(eventArgs, typeof(object), eventArgsConverterParameter, CultureInfo.CurrentUICulture);
                }
                else if(!string.IsNullOrEmpty(eventArgsPropertyPath))
                {
                    var propertyPathParts = eventArgsPropertyPath.Split('.');
                    object propertyValue = eventArgs;
                    foreach (var propertyPathPart in propertyPathParts)
                    {
                        var propInfo = propertyValue.GetType().GetTypeInfo().GetDeclaredProperty(propertyPathPart);
                        propertyValue = propInfo.GetValue(propertyValue);
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
