using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XamarinForms.Behaviors
{
    public class InheritBindableObject : BindableObject
    {
        public void OnAttachedTo(BindableObject bindableObject)
        {
            if (BindingContext != null && bindableObject.BindingContext != null)
                BindingContext = bindableObject.BindingContext;
        }

        public void OnDetachingFrom(BindableObject bindableObject)
        {
            if (BindingContext != null)
                BindingContext = null;
        }
    }
}
