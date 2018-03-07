using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Xamarin.Forms.BehaviorsPack
{
    public static class Pages
    {
        public static readonly BindableProperty AppearingToCommandProperty =
            BindableProperty.CreateAttached("AppearingToCommand", typeof(ICommand), typeof(Pages), null, propertyChanged:OnAppearingChanged);

        public static ICommand GetAppearingToCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(AppearingToCommandProperty);
        }

        private static void OnAppearingChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var page = (Page) bindable;
            if (oldValue != null) page.Appearing -= PageOnAppearing;
            if (newValue != null) page.Appearing += PageOnAppearing;
        }

        private static void PageOnAppearing(object o, EventArgs eventArgs)
        {
            var command = GetAppearingToCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
    }
}
