using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public class ListViewPageViewModel : INotifyPropertyChanged
    {
        private string _selectedItem;

        public string SelectedItem
        {
            get => _selectedItem;
            set
            {
                _selectedItem = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<string> Items { get; }

        public ICommand TappedItemCommand => new Command<string>(item =>
        {
            SelectedItem = item;
        });

        public ICommand RegistCommand => new Command(() =>
        {
            NotifyCompletedRequest.Request();
        });

        public NotificationRequest NotifyCompletedRequest { get; } = new NotificationRequest();

        public ListViewPageViewModel()
        {
            Items = new ObservableCollection<string>
            {
                "Item 1",
                "Item 2",
                "Item 3",
                "Item 4",
                "Item 5"
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
