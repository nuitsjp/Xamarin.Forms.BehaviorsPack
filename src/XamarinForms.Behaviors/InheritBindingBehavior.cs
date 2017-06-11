using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XamarinForms.Behaviors
{
    public class InheritBindingBehavior<T> : Behavior<T> where T : BindableObject
    {
        private bool _inheritedBindingContedt = false;
        /// <summary>
        /// Property to which the Behavior is attached.
        /// </summary>
        protected T AssociatedObject { get; private set; }

        /// <summary>
        /// When attached, inherit BindingContext and monitor change events of BindingContext
        /// </summary>
        /// <param name="bindableObject">Object to be attached</param>
        protected override void OnAttachedTo(T bindableObject)
        {
            base.OnAttachedTo(bindableObject);

            AssociatedObject = bindableObject;
	        InheritBindingContext(bindableObject);

			bindableObject.BindingContextChanged += OnBindingContextChanged;
        }

        private void OnBindingContextChanged(object sender, EventArgs e)
        {
	        InheritBindingContext(AssociatedObject);
        }

		private void InheritBindingContext(T bindableObject)
	    {
		    if (BindingContext == null || _inheritedBindingContedt)
		    {
			    BindingContext = bindableObject.BindingContext;
			    _inheritedBindingContedt = true;
		    }
		}

		/// <summary>
		/// Remove event handler.
		/// </summary>
		/// <param name="bindableObject"></param>
		protected override void OnDetachingFrom(T bindableObject)
        {
            BindingContext = null;
            bindableObject.BindingContextChanged -= OnBindingContextChanged;
        }
    }
}
