using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Xamarin.Forms.BehaviorsPack
{
    public partial class ListViewItemSelected
    {
        #region SelectedItemCommand
        public static readonly BindableProperty ClearAfterExecuteCommandProperty =
            BindableProperty.CreateAttached("ClearAfterExecuteCommand", typeof(ICommand), typeof(ListViewItemSelected), null, propertyChanged: OnClearAfterExecuteCommandChanged);

        public static ICommand GetClearAfterExecuteCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ClearAfterExecuteCommandProperty);
        }

        private static void OnClearAfterExecuteCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is ListView target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.ItemSelected += OnClearAfterExecuteCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.ItemSelected -= OnClearAfterExecuteCommandChanged;
                }
            }
        }

        private static void OnClearAfterExecuteCommandChanged(object o, SelectedItemChangedEventArgs eventArgs)
        {
            if (o is ListView listView)
            {
                var command = GetClearAfterExecuteCommand(listView);
                if (command.CanExecute(eventArgs.SelectedItem))
                {
                    command.Execute(eventArgs.SelectedItem);
                    listView.SelectedItem = null;
                }
            }
        }
        #endregion
    }
}
