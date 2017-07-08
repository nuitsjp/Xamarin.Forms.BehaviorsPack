using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.BehaviorsPack;

namespace BehaviorsSampleApp.ViewModels
{
    public class SelectedItemBehaviorPageViewModel
    {
        public IList<Fruit> Fruits { get; } = new List<Fruit>();

        public ICommand SelectedFruitCommand => new Command<Fruit>(fruit =>
        {
            NavigateNextPageRequest.Raise(new SelectedFruitEventArgs { SelectedFruit = fruit });
        });

        public NotificationRequest NavigateNextPageRequest { get; } = new NotificationRequest();

        public SelectedItemBehaviorPageViewModel()
        {
            Fruits.Add(new Fruit { Name = "Apple", Color = Color.Red });
            Fruits.Add(new Fruit { Name = "Orange", Color = Color.Orange });
            Fruits.Add(new Fruit { Name = "Pineapple", Color = Color.Yellow });
            Fruits.Add(new Fruit { Name = "Banana", Color = Color.Yellow });
            Fruits.Add(new Fruit { Name = "Peach", Color = Color.Pink });
            Fruits.Add(new Fruit { Name = "Mango", Color = Color.Yellow });
            Fruits.Add(new Fruit { Name = "Melon", Color = Color.Green });
            Fruits.Add(new Fruit { Name = "Grape", Color = Color.Purple });
            Fruits.Add(new Fruit { Name = "Strawberry", Color = Color.Red });
        }
    }
}
