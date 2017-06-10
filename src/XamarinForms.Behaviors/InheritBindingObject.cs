using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XamarinForms.Behaviors
{
    public class InheritBindingObject<T> : BindableObject where T : BindableObject
    {
        protected T AssociatedObject { get; private set; }

        public void OnAttachedTo(T bindableObject)
        {
            AssociatedObject = bindableObject;

            if (BindingContext != null && bindableObject.BindingContext != null)
                BindingContext = bindableObject.BindingContext;

            AssociatedObject.BindingContextChanged += OnBindingContextChanged;
        }

        private void OnBindingContextChanged(object sender, EventArgs eventArgs)
        {
            BindingContext = AssociatedObject.BindingContext;
        }

        public void OnDetachingFrom(T bindableObject)
        {
            if (BindingContext != null)
                BindingContext = null;

            AssociatedObject.BindingContextChanged -= OnBindingContextChanged;
            AssociatedObject = null;
        }
    }
}
