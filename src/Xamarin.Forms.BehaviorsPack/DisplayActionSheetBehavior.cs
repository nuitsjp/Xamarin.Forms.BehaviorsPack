using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Windows.Input;
using Xamarin.Forms.Internals;

namespace Xamarin.Forms.BehaviorsPack
{
	[Preserve]
    [ContentProperty("ActionSheetButtons")]
    public class DisplayActionSheetBehavior : NotificationBehavior<VisualElement, EventArgs>
    {
        public static readonly BindableProperty TitleProperty =
            BindableProperty.Create(nameof(Title), typeof(string), typeof(DisplayAlertBehavior));

		internal ICommandExecutor CommandExecutor { get; set; } = new CommandExecutor();

        public string Title
        {
            get => (string)GetValue(TitleProperty);
            set => SetValue(TitleProperty, value);
        }

        #region Cancel
        public static readonly BindableProperty CancelProperty =
            BindableProperty.Create(nameof(Cancel), typeof(string), typeof(DisplayAlertBehavior));

        public static readonly BindableProperty CancelCommandProperty =
            BindableProperty.Create(nameof(CancelCommand), typeof(ICommand), typeof(EventToCommandBehavior));

        public static readonly BindableProperty CancelCommandParameterProperty =
            BindableProperty.Create(nameof(CancelCommandParameter), typeof(object), typeof(EventToCommandBehavior));

        public static readonly BindableProperty CancelEventArgsConverterProperty =
            BindableProperty.Create(nameof(CancelEventArgsConverter), typeof(IValueConverter), typeof(EventToCommandBehavior));

        public static readonly BindableProperty CancelEventArgsConverterParameterProperty =
            BindableProperty.Create(nameof(CancelEventArgsConverterParameter), typeof(object), typeof(EventToCommandBehavior));

        public static readonly BindableProperty CancelEventArgsPropertyPathProperty =
            BindableProperty.Create(nameof(CancelEventArgsPropertyPath), typeof(string), typeof(EventToCommandBehavior));

        public string Cancel
        {
            get => (string)GetValue(CancelProperty);
            set => SetValue(CancelProperty, value);
        }
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
        public IValueConverter CancelEventArgsConverter
        {
            get => (IValueConverter)GetValue(CancelEventArgsConverterProperty);
            set => SetValue(CancelEventArgsConverterProperty, value);
        }

        public object CancelEventArgsConverterParameter
        {
            get => GetValue(CancelEventArgsConverterParameterProperty);
            set => SetValue(CancelEventArgsConverterParameterProperty, value);
        }

        public string CancelEventArgsPropertyPath
        {
            get => (string)GetValue(CancelEventArgsPropertyPathProperty);
            set => SetValue(CancelEventArgsPropertyPathProperty, value);
        }
        #endregion

        #region Destruction
        public static readonly BindableProperty DestructionProperty =
            BindableProperty.Create(nameof(Destruction), typeof(string), typeof(DisplayAlertBehavior));

        public string Destruction
        {
            get => (string)GetValue(DestructionProperty);
            set => SetValue(DestructionProperty, value);
        }
        public static readonly BindableProperty DestructionCommandProperty =
            BindableProperty.Create(nameof(DestructionCommand), typeof(ICommand), typeof(EventToCommandBehavior));

        public static readonly BindableProperty DestructionCommandParameterProperty =
            BindableProperty.Create(nameof(DestructionCommandParameter), typeof(object), typeof(EventToCommandBehavior));

        public static readonly BindableProperty DestructionEventArgsConverterProperty =
            BindableProperty.Create(nameof(DestructionEventArgsConverter), typeof(IValueConverter), typeof(EventToCommandBehavior));

        public static readonly BindableProperty DestructionEventArgsConverterParameterProperty =
            BindableProperty.Create(nameof(DestructionEventArgsConverterParameter), typeof(object), typeof(EventToCommandBehavior));

        public static readonly BindableProperty DestructionEventArgsPropertyPathProperty =
            BindableProperty.Create(nameof(DestructionEventArgsPropertyPath), typeof(string), typeof(EventToCommandBehavior));

        public ICommand DestructionCommand
        {
            get => (ICommand)GetValue(DestructionCommandProperty);
            set => SetValue(DestructionCommandProperty, value);
        }

        public object DestructionCommandParameter
        {
            get => GetValue(DestructionCommandParameterProperty);
            set => SetValue(DestructionCommandParameterProperty, value);
        }

        public IValueConverter DestructionEventArgsConverter
        {
            get => (IValueConverter)GetValue(DestructionEventArgsConverterProperty);
            set => SetValue(DestructionEventArgsConverterProperty, value);
        }

        public object DestructionEventArgsConverterParameter
        {
            get => GetValue(DestructionEventArgsConverterParameterProperty);
            set => SetValue(DestructionEventArgsConverterParameterProperty, value);
        }

        public string DestructionEventArgsPropertyPath
        {
            get => (string)GetValue(DestructionEventArgsPropertyPathProperty);
            set => SetValue(DestructionEventArgsPropertyPathProperty, value);
        }
        #endregion Destruction

        public ObservableCollection<IActionSheetButton> ActionSheetButtons { get;  } = new ObservableCollection<IActionSheetButton>();

        public DisplayActionSheetBehavior()
        {
            ActionSheetButtons.CollectionChanged += OnCollectionChanged;
        }

        private void OnCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems == null) return;

            foreach (var newItem in e.NewItems)
            {
	            if (newItem is BindableObject bindableObject)
		            SetInheritedBindingContext(bindableObject, BindingContext);
            }
        }

        protected override void OnBindingContextChanged()
        {
            foreach (var actionSheetButton in ActionSheetButtons)
            {
				if(actionSheetButton is BindableObject bindableObject)
	                SetInheritedBindingContext(bindableObject, BindingContext);
            }
            base.OnBindingContextChanged();
        }

        protected override async void OnReceived(object sender, EventArgs eventArgs)
        {
            var currentPage = AssociatedObject.GetCurrentPage();
            if (currentPage != null)
            {
                var buttons = ActionSheetButtons.Select(x => x.Message).ToArray();
                var result = await currentPage.DisplayActionSheet(Title, Cancel, Destruction, buttons);
                if (result == Cancel)
                {
                    CommandExecutor.Execute(CancelCommand, CancelCommandParameter, eventArgs, CancelEventArgsConverter, CancelEventArgsConverterParameter, CancelEventArgsPropertyPath);
                }
                else if (result == Destruction)
                {
                    CommandExecutor.Execute(DestructionCommand, DestructionCommandParameter, eventArgs, DestructionEventArgsConverter, DestructionEventArgsConverterParameter, DestructionEventArgsPropertyPath);
                }
                else
                {
                    var button = ActionSheetButtons.Single(x => x.Message == result);
                    button.OnClick(sender, eventArgs);
                }
            }
        }
    }
}
