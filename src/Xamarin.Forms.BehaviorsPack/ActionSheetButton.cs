using System;
using System.Windows.Input;
using Xamarin.Forms.Internals;

namespace Xamarin.Forms.BehaviorsPack
{
	[Preserve(AllMembers = true)]
    public class ActionSheetButton : BindableObject, IActionSheetButton
	{
        public static readonly BindableProperty MessageProperty =
            BindableProperty.Create(nameof(Message), typeof(string), typeof(ActionSheetButton));

        public static readonly BindableProperty CommandProperty =
            BindableProperty.Create(nameof(Command), typeof(ICommand), typeof(ActionSheetButton));

        public static readonly BindableProperty CommandParameterProperty =
            BindableProperty.Create(nameof(CommandParameter), typeof(object), typeof(ActionSheetButton));

        public static readonly BindableProperty EventArgsConverterProperty =
            BindableProperty.Create(nameof(EventArgsConverter), typeof(IValueConverter), typeof(ActionSheetButton));

        public static readonly BindableProperty EventArgsConverterParameterProperty =
            BindableProperty.Create(nameof(EventArgsConverterParameter), typeof(object), typeof(ActionSheetButton));

        public static readonly BindableProperty EventArgsPropertyPathProperty =
            BindableProperty.Create(nameof(EventArgsPropertyPath), typeof(string), typeof(ActionSheetButton));

		internal ICommandExecutor CommandExecutor { get; set; } = new CommandExecutor();

        public string Message
        {
            get => (string)GetValue(MessageProperty);
            set => SetValue(MessageProperty, value);
        }

        public ICommand Command
        {
            get => (ICommand)GetValue(CommandProperty);
            set => SetValue(CommandProperty, value);
        }

        public object CommandParameter
        {
            get => GetValue(CommandParameterProperty);
            set => SetValue(CommandParameterProperty, value);
        }

        public IValueConverter EventArgsConverter
        {
            get => (IValueConverter)GetValue(EventArgsConverterProperty);
            set => SetValue(EventArgsConverterProperty, value);
        }

        public object EventArgsConverterParameter
        {
            get => GetValue(EventArgsConverterParameterProperty);
            set => SetValue(EventArgsConverterParameterProperty, value);
        }

        public string EventArgsPropertyPath
        {
            get => (string)GetValue(EventArgsPropertyPathProperty);
            set => SetValue(EventArgsPropertyPathProperty, value);
        }

        public void OnClicked(object sender, EventArgs eventArgs)
        {
            CommandExecutor.Execute(Command, CommandParameter, eventArgs, EventArgsConverter, EventArgsConverterParameter, EventArgsPropertyPath);
        }
    }
}
