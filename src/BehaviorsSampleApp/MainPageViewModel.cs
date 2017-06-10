using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using BehaviorsSampleApp.Annotations;
using Xamarin.Forms;
using XamarinForms.Behaviors;

namespace BehaviorsSampleApp
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        private string _message = "Welcome to Xamarin Forms!";

        public string Message
        {
            get => _message;
            set => SetProperty(ref _message, value);
        }

        public ICommand UpdateMessageCommand => new Command(() =>
        {
            Message = "Updated message";
        });

        public ICommand DisplayAlertAcceptCommand => new Command(() =>
        {
            Message = "DisplayAlertAcceptCommand";
        });

        public ICommand DisplayAlertCancelCommand => new Command(() =>
        {
            Message = "DisplayAlertCancelCommand";
        });

        public ICommand ActionSheetCancelCommand => new Command(() =>
        {
            Message = "ActionSheetCancelCommand";
        });

        public ICommand ActionSheetDestructionCommand => new Command(() =>
        {
            Message = "ActionSheetDestructionCommand";
        });

        public ICommand ActionSheetButton1Command => new Command(() =>
        {
            Message = "ActionSheetButton1Command";
        });

        public ICommand ActionSheetButton2Command => new Command(() =>
        {
            Message = "ActionSheetButton2Command";
        });

        public InteractionRequest DisplayAlertRequest { get; } = new InteractionRequest();
        public ICommand DisplayAlertRequestCommand => new Command(() => DisplayAlertRequest.Request());

        public InteractionRequest DisplayActionSheetRequest { get; } = new InteractionRequest();
        public ICommand DisplayActionSheetRequestCommand => new Command(() => DisplayActionSheetRequest.Request());

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual bool SetProperty<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (Equals(field, value)) return false;

            field = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            return true;
        }
        #endregion
    }
}
