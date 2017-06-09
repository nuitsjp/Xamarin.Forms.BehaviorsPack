using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace XamarinForms.Behaviors
{
    public class DisplayAlertBehavior : EventToCommandBehavior
    {
        public static readonly BindableProperty TitleProperty =
            BindableProperty.Create(nameof(Title), typeof(string), typeof(DisplayAlertBehavior));
        public static readonly BindableProperty MessageProperty =
            BindableProperty.Create(nameof(Message), typeof(string), typeof(DisplayAlertBehavior));
        public static readonly BindableProperty AcceptProperty =
            BindableProperty.Create(nameof(Accept), typeof(string), typeof(DisplayAlertBehavior));
        public static readonly BindableProperty CancelProperty =
            BindableProperty.Create(nameof(Cancel), typeof(string), typeof(DisplayAlertBehavior));

        public string Title
        {
            get => (string)GetValue(TitleProperty);
            set => SetValue(TitleProperty, value);
        }
        public string Message
        {
            get => (string)GetValue(MessageProperty);
            set => SetValue(MessageProperty, value);
        }
        public string Accept
        {
            get => (string)GetValue(AcceptProperty);
            set => SetValue(AcceptProperty, value);
        }
        public string Cancel
        {
            get => (string)GetValue(CancelProperty);
            set => SetValue(CancelProperty, value);
        }

        protected override async void OnEventRaised(object sender, EventArgs eventArgs)
        {
            var currentPage = AssociatedObject.GetCurrentPage();
            if (currentPage != null)
            {
                if (string.IsNullOrEmpty(Accept))
                {
                    await currentPage.DisplayAlert(Title, Message, Cancel);
                    base.OnEventRaised(sender, eventArgs);
                }
                else
                {
                    var result = await currentPage.DisplayAlert(Title, Message, Accept, Cancel);
                    if (result)
                    {
                        base.OnEventRaised(sender, eventArgs);
                    }
                }
            }
        }
    }
}
