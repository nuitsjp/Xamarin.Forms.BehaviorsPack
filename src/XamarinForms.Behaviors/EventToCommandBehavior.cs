using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace XamarinForms.Behaviors
{
    public class EventToCommandBehavior : ReactToEventBehavior<VisualElement>
    {
        #region Command BindableProperty
        public static readonly BindableProperty CommandProperty = BindableProperty.Create<EventToCommandBehavior, ICommand>(p => p.Command, null);
        public ICommand Command
        {
            get { return (ICommand)GetValue(CommandProperty); }
            set { SetValue(CommandProperty, value); }
        }
        #endregion

        #region CommandParameter BindableProperty
        public static readonly BindableProperty CommandParameterProperty = BindableProperty.Create<EventToCommandBehavior, object>(p => p.CommandParameter, null);
        public object CommandParameter
        {
            get { return GetValue(CommandParameterProperty); }
            set { SetValue(CommandParameterProperty, value); }
        }
        #endregion

        #region Converter BindableProperty
        public static readonly BindableProperty ConverterProperty = BindableProperty.Create<EventToCommandBehavior, IValueConverter>(p => p.Converter, null);
        public IValueConverter Converter
        {
            get { return (IValueConverter)GetValue(ConverterProperty); }
            set { SetValue(ConverterProperty, value); }
        }
        #endregion

        /// <summary>
        /// イベントを購読する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="eventArgs"></param>
        protected override void OnEventRaised(object sender, EventArgs eventArgs)
        {
            // コマンドがバインドされていない場合、何もしない
            if (Command == null)
            {
                return;
            }

            // コマンド実行時のパラメータを決定する
            object resolvedParameter;
            if (CommandParameter != null)
            {
                // Commandプロパティに値が指定されていた場合、対象の値を利用する
                resolvedParameter = CommandParameter;
            }
            else if (Converter != null)
            {
                // Converterが指定されていた場合、イベントパラメータをコンバータで変換した結果を利用する
                resolvedParameter = Converter.Convert(eventArgs, typeof(object), null, null);
            }
            else
            {
                // それ以外の場合、イベント引数を利用する
                resolvedParameter = eventArgs;
            }

            // コマンドが実行可能であれば、コマンドを実行する
            if (Command.CanExecute(resolvedParameter))
            {
                Command.Execute(resolvedParameter);
            }
        }
    }
}
