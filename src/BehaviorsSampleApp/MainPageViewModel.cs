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

        public ICommand DisplayAlertCommand => new Command(() =>
        {
            Message = "DisplayAlertCommand";
        });

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
