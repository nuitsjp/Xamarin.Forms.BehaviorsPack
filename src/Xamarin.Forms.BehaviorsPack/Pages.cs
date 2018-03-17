using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Xamarin.Forms.BehaviorsPack
{
    public static class PageEvents
    {
        public static readonly BindableProperty AppearingToProperty =
            BindableProperty.CreateAttached("AppearingTo", typeof(ICommand), typeof(PageEvents), null, propertyChanged:OnAppearingChanged);

        public static ICommand GetAppearingTo(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(AppearingToProperty);
        }

        private static void OnAppearingChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Page page)
            {
                if (oldValue == null && newValue != null)
                {
                    page.Appearing += PageOnAppearing;
                }
                else if (oldValue != null && newValue == null)
                {
                    page.Appearing -= PageOnAppearing;
                }
            }
        }

        private static void PageOnAppearing(object o, EventArgs eventArgs)
        {
            var command = GetAppearingTo((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
    }
}
