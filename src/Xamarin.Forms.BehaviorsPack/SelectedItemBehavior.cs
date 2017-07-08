using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Xamarin.Forms.BehaviorsPack
{
    public class SelectedItemBehavior : InheritBindingBehavior<ListView>
    {
        public static readonly BindableProperty CommandProperty =
            BindableProperty.Create(nameof(Command), typeof(ICommand), typeof(SelectedItemBehavior));

        public static readonly BindableProperty ClearSelectedProperty =
            BindableProperty.Create(nameof(Command), typeof(bool), typeof(SelectedItemBehavior), true);

        public ICommand Command
        {
            get => (ICommand)GetValue(CommandProperty);
            set => SetValue(CommandProperty, value);
        }

        public bool ClearSelected
        {
            get => (bool)GetValue(ClearSelectedProperty);
            set => SetValue(ClearSelectedProperty, value);
        }

        protected override void OnAttachedTo(ListView bindableObject)
        {
            base.OnAttachedTo(bindableObject);
            bindableObject.ItemSelected += OnItemSelected;
        }

        protected override void OnDetachingFrom(ListView bindableObject)
        {
            bindableObject.ItemSelected -= OnItemSelected;
            base.OnDetachingFrom(bindableObject);
        }

        private void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (Command == null || e.SelectedItem == null)
                return;

            if (Command.CanExecute(e.SelectedItem))
            {
                Command.Execute(e.SelectedItem);
            }

            if (ClearSelected)
            {
                AssociatedObject.SelectedItem = null;
            }
        }
    }
}
