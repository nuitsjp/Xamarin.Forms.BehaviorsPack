using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Xamarin.Forms.BehaviorsPack
{
    public static partial class ListViews
    {
        public static partial class ItemSelected
        {
            #region ClearAfterExecuteCommand

            public static readonly BindableProperty ClearSelectedItemProperty =
                BindableProperty.CreateAttached("ClearSelectedItem", typeof(ICommand), typeof(ItemSelected), null, propertyChanged: OnClearSelectedItemChanged);

            public static ICommand GetClearSelectedItem(BindableObject bindableObject)
            {
                return (ICommand)bindableObject.GetValue(ClearSelectedItemProperty);
            }

            private static void OnClearSelectedItemChanged(BindableObject bindable, object oldValue, object newValue)
            {
                if (bindable is ListView target)
                {
                    if (oldValue == null && newValue != null)
                    {
                        target.ItemSelected += OnItemSelectedClearSelectedItem;
                    }
                    else if (oldValue != null && newValue == null)
                    {
                        target.ItemSelected -= OnItemSelectedClearSelectedItem;
                    }
                }
            }

            private static void OnItemSelectedClearSelectedItem(object o, SelectedItemChangedEventArgs eventArgs)
            {
                if (o is ListView listView && eventArgs.SelectedItem != null)
                {
                    var command = GetClearSelectedItem(listView);
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
}
