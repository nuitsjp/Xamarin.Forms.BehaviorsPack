using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace XamarinForms.Behaviors
{
    public class DisplayAlertBehavior : ReceiveEventBehavior<VisualElement>
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

        #region Accept
        public static readonly BindableProperty AcceptCommandProperty =
            BindableProperty.Create(nameof(AcceptCommand), typeof(ICommand), typeof(EventToCommandBehavior));

        public static readonly BindableProperty AcceptCommandParameterProperty =
            BindableProperty.Create(nameof(AcceptCommandParameter), typeof(object), typeof(EventToCommandBehavior));

        public ICommand AcceptCommand
        {
            get => (ICommand)GetValue(AcceptCommandProperty);
            set => SetValue(AcceptCommandProperty, value);
        }

        public object AcceptCommandParameter
        {
            get => GetValue(AcceptCommandParameterProperty);
            set => SetValue(AcceptCommandParameterProperty, value);
        }
        #endregion

        #region Cancel
        public static readonly BindableProperty CancelCommandProperty =
            BindableProperty.Create(nameof(CancelCommand), typeof(ICommand), typeof(EventToCommandBehavior));

        public static readonly BindableProperty CancelCommandParameterProperty =
            BindableProperty.Create(nameof(CancelCommandParameter), typeof(object), typeof(EventToCommandBehavior));

        public ICommand CancelCommand
        {
            get => (ICommand)GetValue(CancelCommandProperty);
            set => SetValue(CancelCommandProperty, value);
        }

        public object CancelCommandParameter
        {
            get => GetValue(CancelCommandParameterProperty);
            set => SetValue(CancelCommandParameterProperty, value);
        }
        #endregion

        protected override async void OnEventRaised(object sender, EventArgs eventArgs)
        {
            var currentPage = AssociatedObject.GetCurrentPage();
            if (currentPage != null)
            {
                if (string.IsNullOrEmpty(Accept))
                {
                    await currentPage.DisplayAlert(Title, Message, Cancel);
                    CancelCommand?.Execute(CancelCommandParameter);
                }
                else
                {
                    var result = await currentPage.DisplayAlert(Title, Message, Accept, Cancel);
                    if (result)
                    {
                        AcceptCommand?.Execute(AcceptCommandParameter);
                    }
                    else
                    {
                        CancelCommand?.Execute(CancelCommandParameter);
                    }
                }
            }
        }
    }
}
