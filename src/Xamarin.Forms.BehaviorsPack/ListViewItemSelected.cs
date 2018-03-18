using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Xamarin.Forms.BehaviorsPack
{
    public partial class ListViewItemSelected
    {
        #region ClearAfterExecuteCommand
        public static readonly BindableProperty ClearSelectedItemCommandProperty =
            BindableProperty.CreateAttached("ClearSelectedItemCommand", typeof(ICommand), typeof(ListViewItemSelected), null, propertyChanged: OnClearSelectedItemCommandChanged);

        public static ICommand GetClearSelectedItemCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ClearSelectedItemCommandProperty);
        }

        private static void OnClearSelectedItemCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is ListView target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.ItemSelected += OnClearSelectedItemCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.ItemSelected -= OnClearSelectedItemCommandChanged;
                }
            }
        }

        private static void OnClearSelectedItemCommandChanged(object o, SelectedItemChangedEventArgs eventArgs)
        {
            if (o is ListView listView)
            {
                var command = GetClearSelectedItemCommand(listView);
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
