using System;
using System.Windows.Input;
using Xamarin.Forms.Internals;

namespace Xamarin.Forms.BehaviorsPack {

	#region Applications
	public static partial class Applications {
        
        #region ModalPopped
        public static readonly BindableProperty ModalPoppedProperty =
            BindableProperty.CreateAttached("ModalPopped", typeof(ICommand), typeof(Applications), null, propertyChanged:OnModalPoppedChanged);
        
        public static ICommand GetModalPopped(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ModalPoppedProperty);
        }
        
        private static void OnModalPoppedChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Application target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.ModalPopped += OnModalPopped;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.ModalPopped -= OnModalPopped;
                }
            }
        }
        
        private static void OnModalPopped(object o, EventArgs eventArgs)
        {
            var command = GetModalPopped((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion

		#region ModalPopped Properties
		public static partial class ModalPopped {
            
            #region Modal
            public static readonly BindableProperty ModalProperty =
                BindableProperty.CreateAttached("Modal", typeof(ICommand), typeof(ModalPopped), null, propertyChanged:OnModalChanged);
            
            public static ICommand GetModal(BindableObject bindableObject)
            {
                return (ICommand)bindableObject.GetValue(ModalProperty);
            }
            
            private static void OnModalChanged(BindableObject bindable, object oldValue, object newValue)
            {
                if (bindable is Application target)
                {
                    if (oldValue == null && newValue != null)
                    {
                        target.ModalPopped += OnModalPoppedNotifyModal;
                    }
                    else if (oldValue != null && newValue == null)
                    {
                        target.ModalPopped -= OnModalPoppedNotifyModal;
                    }
                }
            }
            
            private static void OnModalPoppedNotifyModal(object o, Xamarin.Forms.ModalPoppedEventArgs eventArgs)
            {
                var command = GetModal((BindableObject)o);
                if (command.CanExecute(eventArgs.Modal))
                    command.Execute(eventArgs.Modal);
            }
            #endregion
		}
		#endregion
        
        #region ModalPopping
        public static readonly BindableProperty ModalPoppingProperty =
            BindableProperty.CreateAttached("ModalPopping", typeof(ICommand), typeof(Applications), null, propertyChanged:OnModalPoppingChanged);
        
        public static ICommand GetModalPopping(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ModalPoppingProperty);
        }
        
        private static void OnModalPoppingChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Application target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.ModalPopping += OnModalPopping;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.ModalPopping -= OnModalPopping;
                }
            }
        }
        
        private static void OnModalPopping(object o, EventArgs eventArgs)
        {
            var command = GetModalPopping((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion

		#region ModalPopping Properties
		public static partial class ModalPopping {
            
            #region Cancel
            public static readonly BindableProperty CancelProperty =
                BindableProperty.CreateAttached("Cancel", typeof(ICommand), typeof(ModalPopping), null, propertyChanged:OnCancelChanged);
            
            public static ICommand GetCancel(BindableObject bindableObject)
            {
                return (ICommand)bindableObject.GetValue(CancelProperty);
            }
            
            private static void OnCancelChanged(BindableObject bindable, object oldValue, object newValue)
            {
                if (bindable is Application target)
                {
                    if (oldValue == null && newValue != null)
                    {
                        target.ModalPopping += OnModalPoppingNotifyCancel;
                    }
                    else if (oldValue != null && newValue == null)
                    {
                        target.ModalPopping -= OnModalPoppingNotifyCancel;
                    }
                }
            }
            
            private static void OnModalPoppingNotifyCancel(object o, Xamarin.Forms.ModalPoppingEventArgs eventArgs)
            {
                var command = GetCancel((BindableObject)o);
                if (command.CanExecute(eventArgs.Cancel))
                    command.Execute(eventArgs.Cancel);
            }
            #endregion
            
            #region Modal
            public static readonly BindableProperty ModalProperty =
                BindableProperty.CreateAttached("Modal", typeof(ICommand), typeof(ModalPopping), null, propertyChanged:OnModalChanged);
            
            public static ICommand GetModal(BindableObject bindableObject)
            {
                return (ICommand)bindableObject.GetValue(ModalProperty);
            }
            
            private static void OnModalChanged(BindableObject bindable, object oldValue, object newValue)
            {
                if (bindable is Application target)
                {
                    if (oldValue == null && newValue != null)
                    {
                        target.ModalPopping += OnModalPoppingNotifyModal;
                    }
                    else if (oldValue != null && newValue == null)
                    {
                        target.ModalPopping -= OnModalPoppingNotifyModal;
                    }
                }
            }
            
            private static void OnModalPoppingNotifyModal(object o, Xamarin.Forms.ModalPoppingEventArgs eventArgs)
            {
                var command = GetModal((BindableObject)o);
                if (command.CanExecute(eventArgs.Modal))
                    command.Execute(eventArgs.Modal);
            }
            #endregion
		}
		#endregion
        
        #region ModalPushed
        public static readonly BindableProperty ModalPushedProperty =
            BindableProperty.CreateAttached("ModalPushed", typeof(ICommand), typeof(Applications), null, propertyChanged:OnModalPushedChanged);
        
        public static ICommand GetModalPushed(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ModalPushedProperty);
        }
        
        private static void OnModalPushedChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Application target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.ModalPushed += OnModalPushed;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.ModalPushed -= OnModalPushed;
                }
            }
        }
        
        private static void OnModalPushed(object o, EventArgs eventArgs)
        {
            var command = GetModalPushed((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion

		#region ModalPushed Properties
		public static partial class ModalPushed {
            
            #region Modal
            public static readonly BindableProperty ModalProperty =
                BindableProperty.CreateAttached("Modal", typeof(ICommand), typeof(ModalPushed), null, propertyChanged:OnModalChanged);
            
            public static ICommand GetModal(BindableObject bindableObject)
            {
                return (ICommand)bindableObject.GetValue(ModalProperty);
            }
            
            private static void OnModalChanged(BindableObject bindable, object oldValue, object newValue)
            {
                if (bindable is Application target)
                {
                    if (oldValue == null && newValue != null)
                    {
                        target.ModalPushed += OnModalPushedNotifyModal;
                    }
                    else if (oldValue != null && newValue == null)
                    {
                        target.ModalPushed -= OnModalPushedNotifyModal;
                    }
                }
            }
            
            private static void OnModalPushedNotifyModal(object o, Xamarin.Forms.ModalPushedEventArgs eventArgs)
            {
                var command = GetModal((BindableObject)o);
                if (command.CanExecute(eventArgs.Modal))
                    command.Execute(eventArgs.Modal);
            }
            #endregion
		}
		#endregion
        
        #region ModalPushing
        public static readonly BindableProperty ModalPushingProperty =
            BindableProperty.CreateAttached("ModalPushing", typeof(ICommand), typeof(Applications), null, propertyChanged:OnModalPushingChanged);
        
        public static ICommand GetModalPushing(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ModalPushingProperty);
        }
        
        private static void OnModalPushingChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Application target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.ModalPushing += OnModalPushing;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.ModalPushing -= OnModalPushing;
                }
            }
        }
        
        private static void OnModalPushing(object o, EventArgs eventArgs)
        {
            var command = GetModalPushing((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion

		#region ModalPushing Properties
		public static partial class ModalPushing {
            
            #region Modal
            public static readonly BindableProperty ModalProperty =
                BindableProperty.CreateAttached("Modal", typeof(ICommand), typeof(ModalPushing), null, propertyChanged:OnModalChanged);
            
            public static ICommand GetModal(BindableObject bindableObject)
            {
                return (ICommand)bindableObject.GetValue(ModalProperty);
            }
            
            private static void OnModalChanged(BindableObject bindable, object oldValue, object newValue)
            {
                if (bindable is Application target)
                {
                    if (oldValue == null && newValue != null)
                    {
                        target.ModalPushing += OnModalPushingNotifyModal;
                    }
                    else if (oldValue != null && newValue == null)
                    {
                        target.ModalPushing -= OnModalPushingNotifyModal;
                    }
                }
            }
            
            private static void OnModalPushingNotifyModal(object o, Xamarin.Forms.ModalPushingEventArgs eventArgs)
            {
                var command = GetModal((BindableObject)o);
                if (command.CanExecute(eventArgs.Modal))
                    command.Execute(eventArgs.Modal);
            }
            #endregion
		}
		#endregion
	}
	#endregion

	#region Buttons
	public static partial class Buttons {
        
        #region Clicked
        public static readonly BindableProperty ClickedProperty =
            BindableProperty.CreateAttached("Clicked", typeof(ICommand), typeof(Buttons), null, propertyChanged:OnClickedChanged);
        
        public static ICommand GetClicked(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ClickedProperty);
        }
        
        private static void OnClickedChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Button target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.Clicked += OnClicked;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.Clicked -= OnClicked;
                }
            }
        }
        
        private static void OnClicked(object o, EventArgs eventArgs)
        {
            var command = GetClicked((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region Pressed
        public static readonly BindableProperty PressedProperty =
            BindableProperty.CreateAttached("Pressed", typeof(ICommand), typeof(Buttons), null, propertyChanged:OnPressedChanged);
        
        public static ICommand GetPressed(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(PressedProperty);
        }
        
        private static void OnPressedChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Button target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.Pressed += OnPressed;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.Pressed -= OnPressed;
                }
            }
        }
        
        private static void OnPressed(object o, EventArgs eventArgs)
        {
            var command = GetPressed((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region Released
        public static readonly BindableProperty ReleasedProperty =
            BindableProperty.CreateAttached("Released", typeof(ICommand), typeof(Buttons), null, propertyChanged:OnReleasedChanged);
        
        public static ICommand GetReleased(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ReleasedProperty);
        }
        
        private static void OnReleasedChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Button target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.Released += OnReleased;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.Released -= OnReleased;
                }
            }
        }
        
        private static void OnReleased(object o, EventArgs eventArgs)
        {
            var command = GetReleased((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
	}
	#endregion

	#region Cells
	public static partial class Cells {
        
        #region Appearing
        public static readonly BindableProperty AppearingProperty =
            BindableProperty.CreateAttached("Appearing", typeof(ICommand), typeof(Cells), null, propertyChanged:OnAppearingChanged);
        
        public static ICommand GetAppearing(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(AppearingProperty);
        }
        
        private static void OnAppearingChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Cell target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.Appearing += OnAppearing;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.Appearing -= OnAppearing;
                }
            }
        }
        
        private static void OnAppearing(object o, EventArgs eventArgs)
        {
            var command = GetAppearing((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region Disappearing
        public static readonly BindableProperty DisappearingProperty =
            BindableProperty.CreateAttached("Disappearing", typeof(ICommand), typeof(Cells), null, propertyChanged:OnDisappearingChanged);
        
        public static ICommand GetDisappearing(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(DisappearingProperty);
        }
        
        private static void OnDisappearingChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Cell target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.Disappearing += OnDisappearing;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.Disappearing -= OnDisappearing;
                }
            }
        }
        
        private static void OnDisappearing(object o, EventArgs eventArgs)
        {
            var command = GetDisappearing((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region ForceUpdateSizeRequested
        public static readonly BindableProperty ForceUpdateSizeRequestedProperty =
            BindableProperty.CreateAttached("ForceUpdateSizeRequested", typeof(ICommand), typeof(Cells), null, propertyChanged:OnForceUpdateSizeRequestedChanged);
        
        public static ICommand GetForceUpdateSizeRequested(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ForceUpdateSizeRequestedProperty);
        }
        
        private static void OnForceUpdateSizeRequestedChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Cell target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.ForceUpdateSizeRequested += OnForceUpdateSizeRequested;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.ForceUpdateSizeRequested -= OnForceUpdateSizeRequested;
                }
            }
        }
        
        private static void OnForceUpdateSizeRequested(object o, EventArgs eventArgs)
        {
            var command = GetForceUpdateSizeRequested((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region Tapped
        public static readonly BindableProperty TappedProperty =
            BindableProperty.CreateAttached("Tapped", typeof(ICommand), typeof(Cells), null, propertyChanged:OnTappedChanged);
        
        public static ICommand GetTapped(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(TappedProperty);
        }
        
        private static void OnTappedChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Cell target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.Tapped += OnTapped;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.Tapped -= OnTapped;
                }
            }
        }
        
        private static void OnTapped(object o, EventArgs eventArgs)
        {
            var command = GetTapped((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
	}
	#endregion

	#region ColumnDefinitions
	public static partial class ColumnDefinitions {
        
        #region SizeChanged
        public static readonly BindableProperty SizeChangedProperty =
            BindableProperty.CreateAttached("SizeChanged", typeof(ICommand), typeof(ColumnDefinitions), null, propertyChanged:OnSizeChangedChanged);
        
        public static ICommand GetSizeChanged(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(SizeChangedProperty);
        }
        
        private static void OnSizeChangedChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is ColumnDefinition target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.SizeChanged += OnSizeChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.SizeChanged -= OnSizeChanged;
                }
            }
        }
        
        private static void OnSizeChanged(object o, EventArgs eventArgs)
        {
            var command = GetSizeChanged((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
	}
	#endregion

	#region DatePickers
	public static partial class DatePickers {
        
        #region DateSelected
        public static readonly BindableProperty DateSelectedProperty =
            BindableProperty.CreateAttached("DateSelected", typeof(ICommand), typeof(DatePickers), null, propertyChanged:OnDateSelectedChanged);
        
        public static ICommand GetDateSelected(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(DateSelectedProperty);
        }
        
        private static void OnDateSelectedChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is DatePicker target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.DateSelected += OnDateSelected;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.DateSelected -= OnDateSelected;
                }
            }
        }
        
        private static void OnDateSelected(object o, EventArgs eventArgs)
        {
            var command = GetDateSelected((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion

		#region DateSelected Properties
		public static partial class DateSelected {
            
            #region NewDate
            public static readonly BindableProperty NewDateProperty =
                BindableProperty.CreateAttached("NewDate", typeof(ICommand), typeof(DateSelected), null, propertyChanged:OnNewDateChanged);
            
            public static ICommand GetNewDate(BindableObject bindableObject)
            {
                return (ICommand)bindableObject.GetValue(NewDateProperty);
            }
            
            private static void OnNewDateChanged(BindableObject bindable, object oldValue, object newValue)
            {
                if (bindable is DatePicker target)
                {
                    if (oldValue == null && newValue != null)
                    {
                        target.DateSelected += OnDateSelectedNotifyNewDate;
                    }
                    else if (oldValue != null && newValue == null)
                    {
                        target.DateSelected -= OnDateSelectedNotifyNewDate;
                    }
                }
            }
            
            private static void OnDateSelectedNotifyNewDate(object o, Xamarin.Forms.DateChangedEventArgs eventArgs)
            {
                var command = GetNewDate((BindableObject)o);
                if (command.CanExecute(eventArgs.NewDate))
                    command.Execute(eventArgs.NewDate);
            }
            #endregion
            
            #region OldDate
            public static readonly BindableProperty OldDateProperty =
                BindableProperty.CreateAttached("OldDate", typeof(ICommand), typeof(DateSelected), null, propertyChanged:OnOldDateChanged);
            
            public static ICommand GetOldDate(BindableObject bindableObject)
            {
                return (ICommand)bindableObject.GetValue(OldDateProperty);
            }
            
            private static void OnOldDateChanged(BindableObject bindable, object oldValue, object newValue)
            {
                if (bindable is DatePicker target)
                {
                    if (oldValue == null && newValue != null)
                    {
                        target.DateSelected += OnDateSelectedNotifyOldDate;
                    }
                    else if (oldValue != null && newValue == null)
                    {
                        target.DateSelected -= OnDateSelectedNotifyOldDate;
                    }
                }
            }
            
            private static void OnDateSelectedNotifyOldDate(object o, Xamarin.Forms.DateChangedEventArgs eventArgs)
            {
                var command = GetOldDate((BindableObject)o);
                if (command.CanExecute(eventArgs.OldDate))
                    command.Execute(eventArgs.OldDate);
            }
            #endregion
		}
		#endregion
	}
	#endregion

	#region Editors
	public static partial class Editors {
        
        #region Completed
        public static readonly BindableProperty CompletedProperty =
            BindableProperty.CreateAttached("Completed", typeof(ICommand), typeof(Editors), null, propertyChanged:OnCompletedChanged);
        
        public static ICommand GetCompleted(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CompletedProperty);
        }
        
        private static void OnCompletedChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Editor target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.Completed += OnCompleted;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.Completed -= OnCompleted;
                }
            }
        }
        
        private static void OnCompleted(object o, EventArgs eventArgs)
        {
            var command = GetCompleted((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region TextChanged
        public static readonly BindableProperty TextChangedProperty =
            BindableProperty.CreateAttached("TextChanged", typeof(ICommand), typeof(Editors), null, propertyChanged:OnTextChangedChanged);
        
        public static ICommand GetTextChanged(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(TextChangedProperty);
        }
        
        private static void OnTextChangedChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Editor target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.TextChanged += OnTextChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.TextChanged -= OnTextChanged;
                }
            }
        }
        
        private static void OnTextChanged(object o, EventArgs eventArgs)
        {
            var command = GetTextChanged((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion

		#region TextChanged Properties
		public static partial class TextChanged {
            
            #region NewTextValue
            public static readonly BindableProperty NewTextValueProperty =
                BindableProperty.CreateAttached("NewTextValue", typeof(ICommand), typeof(TextChanged), null, propertyChanged:OnNewTextValueChanged);
            
            public static ICommand GetNewTextValue(BindableObject bindableObject)
            {
                return (ICommand)bindableObject.GetValue(NewTextValueProperty);
            }
            
            private static void OnNewTextValueChanged(BindableObject bindable, object oldValue, object newValue)
            {
                if (bindable is Editor target)
                {
                    if (oldValue == null && newValue != null)
                    {
                        target.TextChanged += OnTextChangedNotifyNewTextValue;
                    }
                    else if (oldValue != null && newValue == null)
                    {
                        target.TextChanged -= OnTextChangedNotifyNewTextValue;
                    }
                }
            }
            
            private static void OnTextChangedNotifyNewTextValue(object o, Xamarin.Forms.TextChangedEventArgs eventArgs)
            {
                var command = GetNewTextValue((BindableObject)o);
                if (command.CanExecute(eventArgs.NewTextValue))
                    command.Execute(eventArgs.NewTextValue);
            }
            #endregion
            
            #region OldTextValue
            public static readonly BindableProperty OldTextValueProperty =
                BindableProperty.CreateAttached("OldTextValue", typeof(ICommand), typeof(TextChanged), null, propertyChanged:OnOldTextValueChanged);
            
            public static ICommand GetOldTextValue(BindableObject bindableObject)
            {
                return (ICommand)bindableObject.GetValue(OldTextValueProperty);
            }
            
            private static void OnOldTextValueChanged(BindableObject bindable, object oldValue, object newValue)
            {
                if (bindable is Editor target)
                {
                    if (oldValue == null && newValue != null)
                    {
                        target.TextChanged += OnTextChangedNotifyOldTextValue;
                    }
                    else if (oldValue != null && newValue == null)
                    {
                        target.TextChanged -= OnTextChangedNotifyOldTextValue;
                    }
                }
            }
            
            private static void OnTextChangedNotifyOldTextValue(object o, Xamarin.Forms.TextChangedEventArgs eventArgs)
            {
                var command = GetOldTextValue((BindableObject)o);
                if (command.CanExecute(eventArgs.OldTextValue))
                    command.Execute(eventArgs.OldTextValue);
            }
            #endregion
		}
		#endregion
	}
	#endregion

	#region Elements
	public static partial class Elements {
        
        #region ChildAdded
        public static readonly BindableProperty ChildAddedProperty =
            BindableProperty.CreateAttached("ChildAdded", typeof(ICommand), typeof(Elements), null, propertyChanged:OnChildAddedChanged);
        
        public static ICommand GetChildAdded(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ChildAddedProperty);
        }
        
        private static void OnChildAddedChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Element target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.ChildAdded += OnChildAdded;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.ChildAdded -= OnChildAdded;
                }
            }
        }
        
        private static void OnChildAdded(object o, EventArgs eventArgs)
        {
            var command = GetChildAdded((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion

		#region ChildAdded Properties
		public static partial class ChildAdded {
            
            #region Element
            public static readonly BindableProperty ElementProperty =
                BindableProperty.CreateAttached("Element", typeof(ICommand), typeof(ChildAdded), null, propertyChanged:OnElementChanged);
            
            public static ICommand GetElement(BindableObject bindableObject)
            {
                return (ICommand)bindableObject.GetValue(ElementProperty);
            }
            
            private static void OnElementChanged(BindableObject bindable, object oldValue, object newValue)
            {
                if (bindable is Element target)
                {
                    if (oldValue == null && newValue != null)
                    {
                        target.ChildAdded += OnChildAddedNotifyElement;
                    }
                    else if (oldValue != null && newValue == null)
                    {
                        target.ChildAdded -= OnChildAddedNotifyElement;
                    }
                }
            }
            
            private static void OnChildAddedNotifyElement(object o, Xamarin.Forms.ElementEventArgs eventArgs)
            {
                var command = GetElement((BindableObject)o);
                if (command.CanExecute(eventArgs.Element))
                    command.Execute(eventArgs.Element);
            }
            #endregion
		}
		#endregion
        
        #region ChildRemoved
        public static readonly BindableProperty ChildRemovedProperty =
            BindableProperty.CreateAttached("ChildRemoved", typeof(ICommand), typeof(Elements), null, propertyChanged:OnChildRemovedChanged);
        
        public static ICommand GetChildRemoved(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ChildRemovedProperty);
        }
        
        private static void OnChildRemovedChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Element target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.ChildRemoved += OnChildRemoved;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.ChildRemoved -= OnChildRemoved;
                }
            }
        }
        
        private static void OnChildRemoved(object o, EventArgs eventArgs)
        {
            var command = GetChildRemoved((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion

		#region ChildRemoved Properties
		public static partial class ChildRemoved {
            
            #region Element
            public static readonly BindableProperty ElementProperty =
                BindableProperty.CreateAttached("Element", typeof(ICommand), typeof(ChildRemoved), null, propertyChanged:OnElementChanged);
            
            public static ICommand GetElement(BindableObject bindableObject)
            {
                return (ICommand)bindableObject.GetValue(ElementProperty);
            }
            
            private static void OnElementChanged(BindableObject bindable, object oldValue, object newValue)
            {
                if (bindable is Element target)
                {
                    if (oldValue == null && newValue != null)
                    {
                        target.ChildRemoved += OnChildRemovedNotifyElement;
                    }
                    else if (oldValue != null && newValue == null)
                    {
                        target.ChildRemoved -= OnChildRemovedNotifyElement;
                    }
                }
            }
            
            private static void OnChildRemovedNotifyElement(object o, Xamarin.Forms.ElementEventArgs eventArgs)
            {
                var command = GetElement((BindableObject)o);
                if (command.CanExecute(eventArgs.Element))
                    command.Execute(eventArgs.Element);
            }
            #endregion
		}
		#endregion
        
        #region DescendantAdded
        public static readonly BindableProperty DescendantAddedProperty =
            BindableProperty.CreateAttached("DescendantAdded", typeof(ICommand), typeof(Elements), null, propertyChanged:OnDescendantAddedChanged);
        
        public static ICommand GetDescendantAdded(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(DescendantAddedProperty);
        }
        
        private static void OnDescendantAddedChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Element target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.DescendantAdded += OnDescendantAdded;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.DescendantAdded -= OnDescendantAdded;
                }
            }
        }
        
        private static void OnDescendantAdded(object o, EventArgs eventArgs)
        {
            var command = GetDescendantAdded((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion

		#region DescendantAdded Properties
		public static partial class DescendantAdded {
            
            #region Element
            public static readonly BindableProperty ElementProperty =
                BindableProperty.CreateAttached("Element", typeof(ICommand), typeof(DescendantAdded), null, propertyChanged:OnElementChanged);
            
            public static ICommand GetElement(BindableObject bindableObject)
            {
                return (ICommand)bindableObject.GetValue(ElementProperty);
            }
            
            private static void OnElementChanged(BindableObject bindable, object oldValue, object newValue)
            {
                if (bindable is Element target)
                {
                    if (oldValue == null && newValue != null)
                    {
                        target.DescendantAdded += OnDescendantAddedNotifyElement;
                    }
                    else if (oldValue != null && newValue == null)
                    {
                        target.DescendantAdded -= OnDescendantAddedNotifyElement;
                    }
                }
            }
            
            private static void OnDescendantAddedNotifyElement(object o, Xamarin.Forms.ElementEventArgs eventArgs)
            {
                var command = GetElement((BindableObject)o);
                if (command.CanExecute(eventArgs.Element))
                    command.Execute(eventArgs.Element);
            }
            #endregion
		}
		#endregion
        
        #region DescendantRemoved
        public static readonly BindableProperty DescendantRemovedProperty =
            BindableProperty.CreateAttached("DescendantRemoved", typeof(ICommand), typeof(Elements), null, propertyChanged:OnDescendantRemovedChanged);
        
        public static ICommand GetDescendantRemoved(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(DescendantRemovedProperty);
        }
        
        private static void OnDescendantRemovedChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Element target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.DescendantRemoved += OnDescendantRemoved;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.DescendantRemoved -= OnDescendantRemoved;
                }
            }
        }
        
        private static void OnDescendantRemoved(object o, EventArgs eventArgs)
        {
            var command = GetDescendantRemoved((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion

		#region DescendantRemoved Properties
		public static partial class DescendantRemoved {
            
            #region Element
            public static readonly BindableProperty ElementProperty =
                BindableProperty.CreateAttached("Element", typeof(ICommand), typeof(DescendantRemoved), null, propertyChanged:OnElementChanged);
            
            public static ICommand GetElement(BindableObject bindableObject)
            {
                return (ICommand)bindableObject.GetValue(ElementProperty);
            }
            
            private static void OnElementChanged(BindableObject bindable, object oldValue, object newValue)
            {
                if (bindable is Element target)
                {
                    if (oldValue == null && newValue != null)
                    {
                        target.DescendantRemoved += OnDescendantRemovedNotifyElement;
                    }
                    else if (oldValue != null && newValue == null)
                    {
                        target.DescendantRemoved -= OnDescendantRemovedNotifyElement;
                    }
                }
            }
            
            private static void OnDescendantRemovedNotifyElement(object o, Xamarin.Forms.ElementEventArgs eventArgs)
            {
                var command = GetElement((BindableObject)o);
                if (command.CanExecute(eventArgs.Element))
                    command.Execute(eventArgs.Element);
            }
            #endregion
		}
		#endregion
        
        #region PlatformSet
        public static readonly BindableProperty PlatformSetProperty =
            BindableProperty.CreateAttached("PlatformSet", typeof(ICommand), typeof(Elements), null, propertyChanged:OnPlatformSetChanged);
        
        public static ICommand GetPlatformSet(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(PlatformSetProperty);
        }
        
        private static void OnPlatformSetChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Element target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.PlatformSet += OnPlatformSet;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.PlatformSet -= OnPlatformSet;
                }
            }
        }
        
        private static void OnPlatformSet(object o, EventArgs eventArgs)
        {
            var command = GetPlatformSet((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
	}
	#endregion

	#region Entries
	public static partial class Entries {
        
        #region Completed
        public static readonly BindableProperty CompletedProperty =
            BindableProperty.CreateAttached("Completed", typeof(ICommand), typeof(Entries), null, propertyChanged:OnCompletedChanged);
        
        public static ICommand GetCompleted(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CompletedProperty);
        }
        
        private static void OnCompletedChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Entry target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.Completed += OnCompleted;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.Completed -= OnCompleted;
                }
            }
        }
        
        private static void OnCompleted(object o, EventArgs eventArgs)
        {
            var command = GetCompleted((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region TextChanged
        public static readonly BindableProperty TextChangedProperty =
            BindableProperty.CreateAttached("TextChanged", typeof(ICommand), typeof(Entries), null, propertyChanged:OnTextChangedChanged);
        
        public static ICommand GetTextChanged(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(TextChangedProperty);
        }
        
        private static void OnTextChangedChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Entry target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.TextChanged += OnTextChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.TextChanged -= OnTextChanged;
                }
            }
        }
        
        private static void OnTextChanged(object o, EventArgs eventArgs)
        {
            var command = GetTextChanged((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion

		#region TextChanged Properties
		public static partial class TextChanged {
            
            #region NewTextValue
            public static readonly BindableProperty NewTextValueProperty =
                BindableProperty.CreateAttached("NewTextValue", typeof(ICommand), typeof(TextChanged), null, propertyChanged:OnNewTextValueChanged);
            
            public static ICommand GetNewTextValue(BindableObject bindableObject)
            {
                return (ICommand)bindableObject.GetValue(NewTextValueProperty);
            }
            
            private static void OnNewTextValueChanged(BindableObject bindable, object oldValue, object newValue)
            {
                if (bindable is Entry target)
                {
                    if (oldValue == null && newValue != null)
                    {
                        target.TextChanged += OnTextChangedNotifyNewTextValue;
                    }
                    else if (oldValue != null && newValue == null)
                    {
                        target.TextChanged -= OnTextChangedNotifyNewTextValue;
                    }
                }
            }
            
            private static void OnTextChangedNotifyNewTextValue(object o, Xamarin.Forms.TextChangedEventArgs eventArgs)
            {
                var command = GetNewTextValue((BindableObject)o);
                if (command.CanExecute(eventArgs.NewTextValue))
                    command.Execute(eventArgs.NewTextValue);
            }
            #endregion
            
            #region OldTextValue
            public static readonly BindableProperty OldTextValueProperty =
                BindableProperty.CreateAttached("OldTextValue", typeof(ICommand), typeof(TextChanged), null, propertyChanged:OnOldTextValueChanged);
            
            public static ICommand GetOldTextValue(BindableObject bindableObject)
            {
                return (ICommand)bindableObject.GetValue(OldTextValueProperty);
            }
            
            private static void OnOldTextValueChanged(BindableObject bindable, object oldValue, object newValue)
            {
                if (bindable is Entry target)
                {
                    if (oldValue == null && newValue != null)
                    {
                        target.TextChanged += OnTextChangedNotifyOldTextValue;
                    }
                    else if (oldValue != null && newValue == null)
                    {
                        target.TextChanged -= OnTextChangedNotifyOldTextValue;
                    }
                }
            }
            
            private static void OnTextChangedNotifyOldTextValue(object o, Xamarin.Forms.TextChangedEventArgs eventArgs)
            {
                var command = GetOldTextValue((BindableObject)o);
                if (command.CanExecute(eventArgs.OldTextValue))
                    command.Execute(eventArgs.OldTextValue);
            }
            #endregion
		}
		#endregion
	}
	#endregion

	#region EntryCells
	public static partial class EntryCells {
        
        #region Completed
        public static readonly BindableProperty CompletedProperty =
            BindableProperty.CreateAttached("Completed", typeof(ICommand), typeof(EntryCells), null, propertyChanged:OnCompletedChanged);
        
        public static ICommand GetCompleted(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CompletedProperty);
        }
        
        private static void OnCompletedChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is EntryCell target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.Completed += OnCompleted;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.Completed -= OnCompleted;
                }
            }
        }
        
        private static void OnCompleted(object o, EventArgs eventArgs)
        {
            var command = GetCompleted((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
	}
	#endregion

	#region Layouts
	public static partial class Layouts {
        
        #region LayoutChanged
        public static readonly BindableProperty LayoutChangedProperty =
            BindableProperty.CreateAttached("LayoutChanged", typeof(ICommand), typeof(Layouts), null, propertyChanged:OnLayoutChangedChanged);
        
        public static ICommand GetLayoutChanged(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(LayoutChangedProperty);
        }
        
        private static void OnLayoutChangedChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Layout target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.LayoutChanged += OnLayoutChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.LayoutChanged -= OnLayoutChanged;
                }
            }
        }
        
        private static void OnLayoutChanged(object o, EventArgs eventArgs)
        {
            var command = GetLayoutChanged((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
	}
	#endregion

	#region ListViews
	public static partial class ListViews {
        
        #region ItemAppearing
        public static readonly BindableProperty ItemAppearingProperty =
            BindableProperty.CreateAttached("ItemAppearing", typeof(ICommand), typeof(ListViews), null, propertyChanged:OnItemAppearingChanged);
        
        public static ICommand GetItemAppearing(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ItemAppearingProperty);
        }
        
        private static void OnItemAppearingChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is ListView target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.ItemAppearing += OnItemAppearing;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.ItemAppearing -= OnItemAppearing;
                }
            }
        }
        
        private static void OnItemAppearing(object o, EventArgs eventArgs)
        {
            var command = GetItemAppearing((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion

		#region ItemAppearing Properties
		public static partial class ItemAppearing {
            
            #region Item
            public static readonly BindableProperty ItemProperty =
                BindableProperty.CreateAttached("Item", typeof(ICommand), typeof(ItemAppearing), null, propertyChanged:OnItemChanged);
            
            public static ICommand GetItem(BindableObject bindableObject)
            {
                return (ICommand)bindableObject.GetValue(ItemProperty);
            }
            
            private static void OnItemChanged(BindableObject bindable, object oldValue, object newValue)
            {
                if (bindable is ListView target)
                {
                    if (oldValue == null && newValue != null)
                    {
                        target.ItemAppearing += OnItemAppearingNotifyItem;
                    }
                    else if (oldValue != null && newValue == null)
                    {
                        target.ItemAppearing -= OnItemAppearingNotifyItem;
                    }
                }
            }
            
            private static void OnItemAppearingNotifyItem(object o, Xamarin.Forms.ItemVisibilityEventArgs eventArgs)
            {
                var command = GetItem((BindableObject)o);
                if (command.CanExecute(eventArgs.Item))
                    command.Execute(eventArgs.Item);
            }
            #endregion
		}
		#endregion
        
        #region ItemDisappearing
        public static readonly BindableProperty ItemDisappearingProperty =
            BindableProperty.CreateAttached("ItemDisappearing", typeof(ICommand), typeof(ListViews), null, propertyChanged:OnItemDisappearingChanged);
        
        public static ICommand GetItemDisappearing(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ItemDisappearingProperty);
        }
        
        private static void OnItemDisappearingChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is ListView target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.ItemDisappearing += OnItemDisappearing;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.ItemDisappearing -= OnItemDisappearing;
                }
            }
        }
        
        private static void OnItemDisappearing(object o, EventArgs eventArgs)
        {
            var command = GetItemDisappearing((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion

		#region ItemDisappearing Properties
		public static partial class ItemDisappearing {
            
            #region Item
            public static readonly BindableProperty ItemProperty =
                BindableProperty.CreateAttached("Item", typeof(ICommand), typeof(ItemDisappearing), null, propertyChanged:OnItemChanged);
            
            public static ICommand GetItem(BindableObject bindableObject)
            {
                return (ICommand)bindableObject.GetValue(ItemProperty);
            }
            
            private static void OnItemChanged(BindableObject bindable, object oldValue, object newValue)
            {
                if (bindable is ListView target)
                {
                    if (oldValue == null && newValue != null)
                    {
                        target.ItemDisappearing += OnItemDisappearingNotifyItem;
                    }
                    else if (oldValue != null && newValue == null)
                    {
                        target.ItemDisappearing -= OnItemDisappearingNotifyItem;
                    }
                }
            }
            
            private static void OnItemDisappearingNotifyItem(object o, Xamarin.Forms.ItemVisibilityEventArgs eventArgs)
            {
                var command = GetItem((BindableObject)o);
                if (command.CanExecute(eventArgs.Item))
                    command.Execute(eventArgs.Item);
            }
            #endregion
		}
		#endregion
        
        #region ItemSelected
        public static readonly BindableProperty ItemSelectedProperty =
            BindableProperty.CreateAttached("ItemSelected", typeof(ICommand), typeof(ListViews), null, propertyChanged:OnItemSelectedChanged);
        
        public static ICommand GetItemSelected(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ItemSelectedProperty);
        }
        
        private static void OnItemSelectedChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is ListView target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.ItemSelected += OnItemSelected;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.ItemSelected -= OnItemSelected;
                }
            }
        }
        
        private static void OnItemSelected(object o, EventArgs eventArgs)
        {
            var command = GetItemSelected((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion

		#region ItemSelected Properties
		public static partial class ItemSelected {
            
            #region SelectedItem
            public static readonly BindableProperty SelectedItemProperty =
                BindableProperty.CreateAttached("SelectedItem", typeof(ICommand), typeof(ItemSelected), null, propertyChanged:OnSelectedItemChanged);
            
            public static ICommand GetSelectedItem(BindableObject bindableObject)
            {
                return (ICommand)bindableObject.GetValue(SelectedItemProperty);
            }
            
            private static void OnSelectedItemChanged(BindableObject bindable, object oldValue, object newValue)
            {
                if (bindable is ListView target)
                {
                    if (oldValue == null && newValue != null)
                    {
                        target.ItemSelected += OnItemSelectedNotifySelectedItem;
                    }
                    else if (oldValue != null && newValue == null)
                    {
                        target.ItemSelected -= OnItemSelectedNotifySelectedItem;
                    }
                }
            }
            
            private static void OnItemSelectedNotifySelectedItem(object o, Xamarin.Forms.SelectedItemChangedEventArgs eventArgs)
            {
                var command = GetSelectedItem((BindableObject)o);
                if (command.CanExecute(eventArgs.SelectedItem))
                    command.Execute(eventArgs.SelectedItem);
            }
            #endregion
		}
		#endregion
        
        #region ItemTapped
        public static readonly BindableProperty ItemTappedProperty =
            BindableProperty.CreateAttached("ItemTapped", typeof(ICommand), typeof(ListViews), null, propertyChanged:OnItemTappedChanged);
        
        public static ICommand GetItemTapped(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ItemTappedProperty);
        }
        
        private static void OnItemTappedChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is ListView target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.ItemTapped += OnItemTapped;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.ItemTapped -= OnItemTapped;
                }
            }
        }
        
        private static void OnItemTapped(object o, EventArgs eventArgs)
        {
            var command = GetItemTapped((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion

		#region ItemTapped Properties
		public static partial class ItemTapped {
            
            #region Group
            public static readonly BindableProperty GroupProperty =
                BindableProperty.CreateAttached("Group", typeof(ICommand), typeof(ItemTapped), null, propertyChanged:OnGroupChanged);
            
            public static ICommand GetGroup(BindableObject bindableObject)
            {
                return (ICommand)bindableObject.GetValue(GroupProperty);
            }
            
            private static void OnGroupChanged(BindableObject bindable, object oldValue, object newValue)
            {
                if (bindable is ListView target)
                {
                    if (oldValue == null && newValue != null)
                    {
                        target.ItemTapped += OnItemTappedNotifyGroup;
                    }
                    else if (oldValue != null && newValue == null)
                    {
                        target.ItemTapped -= OnItemTappedNotifyGroup;
                    }
                }
            }
            
            private static void OnItemTappedNotifyGroup(object o, Xamarin.Forms.ItemTappedEventArgs eventArgs)
            {
                var command = GetGroup((BindableObject)o);
                if (command.CanExecute(eventArgs.Group))
                    command.Execute(eventArgs.Group);
            }
            #endregion
            
            #region Item
            public static readonly BindableProperty ItemProperty =
                BindableProperty.CreateAttached("Item", typeof(ICommand), typeof(ItemTapped), null, propertyChanged:OnItemChanged);
            
            public static ICommand GetItem(BindableObject bindableObject)
            {
                return (ICommand)bindableObject.GetValue(ItemProperty);
            }
            
            private static void OnItemChanged(BindableObject bindable, object oldValue, object newValue)
            {
                if (bindable is ListView target)
                {
                    if (oldValue == null && newValue != null)
                    {
                        target.ItemTapped += OnItemTappedNotifyItem;
                    }
                    else if (oldValue != null && newValue == null)
                    {
                        target.ItemTapped -= OnItemTappedNotifyItem;
                    }
                }
            }
            
            private static void OnItemTappedNotifyItem(object o, Xamarin.Forms.ItemTappedEventArgs eventArgs)
            {
                var command = GetItem((BindableObject)o);
                if (command.CanExecute(eventArgs.Item))
                    command.Execute(eventArgs.Item);
            }
            #endregion
		}
		#endregion
        
        #region Refreshing
        public static readonly BindableProperty RefreshingProperty =
            BindableProperty.CreateAttached("Refreshing", typeof(ICommand), typeof(ListViews), null, propertyChanged:OnRefreshingChanged);
        
        public static ICommand GetRefreshing(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(RefreshingProperty);
        }
        
        private static void OnRefreshingChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is ListView target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.Refreshing += OnRefreshing;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.Refreshing -= OnRefreshing;
                }
            }
        }
        
        private static void OnRefreshing(object o, EventArgs eventArgs)
        {
            var command = GetRefreshing((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region ScrollToRequested
        public static readonly BindableProperty ScrollToRequestedProperty =
            BindableProperty.CreateAttached("ScrollToRequested", typeof(ICommand), typeof(ListViews), null, propertyChanged:OnScrollToRequestedChanged);
        
        public static ICommand GetScrollToRequested(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ScrollToRequestedProperty);
        }
        
        private static void OnScrollToRequestedChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is ListView target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.ScrollToRequested += OnScrollToRequested;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.ScrollToRequested -= OnScrollToRequested;
                }
            }
        }
        
        private static void OnScrollToRequested(object o, EventArgs eventArgs)
        {
            var command = GetScrollToRequested((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion

		#region ScrollToRequested Properties
		public static partial class ScrollToRequested {
            
            #region Element
            public static readonly BindableProperty ElementProperty =
                BindableProperty.CreateAttached("Element", typeof(ICommand), typeof(ScrollToRequested), null, propertyChanged:OnElementChanged);
            
            public static ICommand GetElement(BindableObject bindableObject)
            {
                return (ICommand)bindableObject.GetValue(ElementProperty);
            }
            
            private static void OnElementChanged(BindableObject bindable, object oldValue, object newValue)
            {
                if (bindable is ListView target)
                {
                    if (oldValue == null && newValue != null)
                    {
                        target.ScrollToRequested += OnScrollToRequestedNotifyElement;
                    }
                    else if (oldValue != null && newValue == null)
                    {
                        target.ScrollToRequested -= OnScrollToRequestedNotifyElement;
                    }
                }
            }
            
            private static void OnScrollToRequestedNotifyElement(object o, Xamarin.Forms.ScrollToRequestedEventArgs eventArgs)
            {
                var command = GetElement((BindableObject)o);
                if (command.CanExecute(eventArgs.Element))
                    command.Execute(eventArgs.Element);
            }
            #endregion
            
            #region Mode
            public static readonly BindableProperty ModeProperty =
                BindableProperty.CreateAttached("Mode", typeof(ICommand), typeof(ScrollToRequested), null, propertyChanged:OnModeChanged);
            
            public static ICommand GetMode(BindableObject bindableObject)
            {
                return (ICommand)bindableObject.GetValue(ModeProperty);
            }
            
            private static void OnModeChanged(BindableObject bindable, object oldValue, object newValue)
            {
                if (bindable is ListView target)
                {
                    if (oldValue == null && newValue != null)
                    {
                        target.ScrollToRequested += OnScrollToRequestedNotifyMode;
                    }
                    else if (oldValue != null && newValue == null)
                    {
                        target.ScrollToRequested -= OnScrollToRequestedNotifyMode;
                    }
                }
            }
            
            private static void OnScrollToRequestedNotifyMode(object o, Xamarin.Forms.ScrollToRequestedEventArgs eventArgs)
            {
                var command = GetMode((BindableObject)o);
                if (command.CanExecute(eventArgs.Mode))
                    command.Execute(eventArgs.Mode);
            }
            #endregion
            
            #region Position
            public static readonly BindableProperty PositionProperty =
                BindableProperty.CreateAttached("Position", typeof(ICommand), typeof(ScrollToRequested), null, propertyChanged:OnPositionChanged);
            
            public static ICommand GetPosition(BindableObject bindableObject)
            {
                return (ICommand)bindableObject.GetValue(PositionProperty);
            }
            
            private static void OnPositionChanged(BindableObject bindable, object oldValue, object newValue)
            {
                if (bindable is ListView target)
                {
                    if (oldValue == null && newValue != null)
                    {
                        target.ScrollToRequested += OnScrollToRequestedNotifyPosition;
                    }
                    else if (oldValue != null && newValue == null)
                    {
                        target.ScrollToRequested -= OnScrollToRequestedNotifyPosition;
                    }
                }
            }
            
            private static void OnScrollToRequestedNotifyPosition(object o, Xamarin.Forms.ScrollToRequestedEventArgs eventArgs)
            {
                var command = GetPosition((BindableObject)o);
                if (command.CanExecute(eventArgs.Position))
                    command.Execute(eventArgs.Position);
            }
            #endregion
            
            #region ScrollX
            public static readonly BindableProperty ScrollXProperty =
                BindableProperty.CreateAttached("ScrollX", typeof(ICommand), typeof(ScrollToRequested), null, propertyChanged:OnScrollXChanged);
            
            public static ICommand GetScrollX(BindableObject bindableObject)
            {
                return (ICommand)bindableObject.GetValue(ScrollXProperty);
            }
            
            private static void OnScrollXChanged(BindableObject bindable, object oldValue, object newValue)
            {
                if (bindable is ListView target)
                {
                    if (oldValue == null && newValue != null)
                    {
                        target.ScrollToRequested += OnScrollToRequestedNotifyScrollX;
                    }
                    else if (oldValue != null && newValue == null)
                    {
                        target.ScrollToRequested -= OnScrollToRequestedNotifyScrollX;
                    }
                }
            }
            
            private static void OnScrollToRequestedNotifyScrollX(object o, Xamarin.Forms.ScrollToRequestedEventArgs eventArgs)
            {
                var command = GetScrollX((BindableObject)o);
                if (command.CanExecute(eventArgs.ScrollX))
                    command.Execute(eventArgs.ScrollX);
            }
            #endregion
            
            #region ScrollY
            public static readonly BindableProperty ScrollYProperty =
                BindableProperty.CreateAttached("ScrollY", typeof(ICommand), typeof(ScrollToRequested), null, propertyChanged:OnScrollYChanged);
            
            public static ICommand GetScrollY(BindableObject bindableObject)
            {
                return (ICommand)bindableObject.GetValue(ScrollYProperty);
            }
            
            private static void OnScrollYChanged(BindableObject bindable, object oldValue, object newValue)
            {
                if (bindable is ListView target)
                {
                    if (oldValue == null && newValue != null)
                    {
                        target.ScrollToRequested += OnScrollToRequestedNotifyScrollY;
                    }
                    else if (oldValue != null && newValue == null)
                    {
                        target.ScrollToRequested -= OnScrollToRequestedNotifyScrollY;
                    }
                }
            }
            
            private static void OnScrollToRequestedNotifyScrollY(object o, Xamarin.Forms.ScrollToRequestedEventArgs eventArgs)
            {
                var command = GetScrollY((BindableObject)o);
                if (command.CanExecute(eventArgs.ScrollY))
                    command.Execute(eventArgs.ScrollY);
            }
            #endregion
            
            #region ShouldAnimate
            public static readonly BindableProperty ShouldAnimateProperty =
                BindableProperty.CreateAttached("ShouldAnimate", typeof(ICommand), typeof(ScrollToRequested), null, propertyChanged:OnShouldAnimateChanged);
            
            public static ICommand GetShouldAnimate(BindableObject bindableObject)
            {
                return (ICommand)bindableObject.GetValue(ShouldAnimateProperty);
            }
            
            private static void OnShouldAnimateChanged(BindableObject bindable, object oldValue, object newValue)
            {
                if (bindable is ListView target)
                {
                    if (oldValue == null && newValue != null)
                    {
                        target.ScrollToRequested += OnScrollToRequestedNotifyShouldAnimate;
                    }
                    else if (oldValue != null && newValue == null)
                    {
                        target.ScrollToRequested -= OnScrollToRequestedNotifyShouldAnimate;
                    }
                }
            }
            
            private static void OnScrollToRequestedNotifyShouldAnimate(object o, Xamarin.Forms.ScrollToRequestedEventArgs eventArgs)
            {
                var command = GetShouldAnimate((BindableObject)o);
                if (command.CanExecute(eventArgs.ShouldAnimate))
                    command.Execute(eventArgs.ShouldAnimate);
            }
            #endregion
		}
		#endregion
	}
	#endregion

	#region MasterDetailPages
	public static partial class MasterDetailPages {
        
        #region BackButtonPressed
        public static readonly BindableProperty BackButtonPressedProperty =
            BindableProperty.CreateAttached("BackButtonPressed", typeof(ICommand), typeof(MasterDetailPages), null, propertyChanged:OnBackButtonPressedChanged);
        
        public static ICommand GetBackButtonPressed(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(BackButtonPressedProperty);
        }
        
        private static void OnBackButtonPressedChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is MasterDetailPage target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.BackButtonPressed += OnBackButtonPressed;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.BackButtonPressed -= OnBackButtonPressed;
                }
            }
        }
        
        private static void OnBackButtonPressed(object o, EventArgs eventArgs)
        {
            var command = GetBackButtonPressed((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion

		#region BackButtonPressed Properties
		public static partial class BackButtonPressed {
            
            #region Handled
            public static readonly BindableProperty HandledProperty =
                BindableProperty.CreateAttached("Handled", typeof(ICommand), typeof(BackButtonPressed), null, propertyChanged:OnHandledChanged);
            
            public static ICommand GetHandled(BindableObject bindableObject)
            {
                return (ICommand)bindableObject.GetValue(HandledProperty);
            }
            
            private static void OnHandledChanged(BindableObject bindable, object oldValue, object newValue)
            {
                if (bindable is MasterDetailPage target)
                {
                    if (oldValue == null && newValue != null)
                    {
                        target.BackButtonPressed += OnBackButtonPressedNotifyHandled;
                    }
                    else if (oldValue != null && newValue == null)
                    {
                        target.BackButtonPressed -= OnBackButtonPressedNotifyHandled;
                    }
                }
            }
            
            private static void OnBackButtonPressedNotifyHandled(object o, Xamarin.Forms.BackButtonPressedEventArgs eventArgs)
            {
                var command = GetHandled((BindableObject)o);
                if (command.CanExecute(eventArgs.Handled))
                    command.Execute(eventArgs.Handled);
            }
            #endregion
		}
		#endregion
        
        #region IsPresentedChanged
        public static readonly BindableProperty IsPresentedChangedProperty =
            BindableProperty.CreateAttached("IsPresentedChanged", typeof(ICommand), typeof(MasterDetailPages), null, propertyChanged:OnIsPresentedChangedChanged);
        
        public static ICommand GetIsPresentedChanged(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(IsPresentedChangedProperty);
        }
        
        private static void OnIsPresentedChangedChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is MasterDetailPage target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.IsPresentedChanged += OnIsPresentedChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.IsPresentedChanged -= OnIsPresentedChanged;
                }
            }
        }
        
        private static void OnIsPresentedChanged(object o, EventArgs eventArgs)
        {
            var command = GetIsPresentedChanged((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
	}
	#endregion

	#region MenuItems
	public static partial class MenuItems {
        
        #region Clicked
        public static readonly BindableProperty ClickedProperty =
            BindableProperty.CreateAttached("Clicked", typeof(ICommand), typeof(MenuItems), null, propertyChanged:OnClickedChanged);
        
        public static ICommand GetClicked(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ClickedProperty);
        }
        
        private static void OnClickedChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is MenuItem target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.Clicked += OnClicked;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.Clicked -= OnClicked;
                }
            }
        }
        
        private static void OnClicked(object o, EventArgs eventArgs)
        {
            var command = GetClicked((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
	}
	#endregion

	#region NavigationPages
	public static partial class NavigationPages {
        
        #region InsertPageBeforeRequested
        public static readonly BindableProperty InsertPageBeforeRequestedProperty =
            BindableProperty.CreateAttached("InsertPageBeforeRequested", typeof(ICommand), typeof(NavigationPages), null, propertyChanged:OnInsertPageBeforeRequestedChanged);
        
        public static ICommand GetInsertPageBeforeRequested(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(InsertPageBeforeRequestedProperty);
        }
        
        private static void OnInsertPageBeforeRequestedChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is NavigationPage target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.InsertPageBeforeRequested += OnInsertPageBeforeRequested;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.InsertPageBeforeRequested -= OnInsertPageBeforeRequested;
                }
            }
        }
        
        private static void OnInsertPageBeforeRequested(object o, EventArgs eventArgs)
        {
            var command = GetInsertPageBeforeRequested((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion

		#region InsertPageBeforeRequested Properties
		public static partial class InsertPageBeforeRequested {
            
            #region Animated
            public static readonly BindableProperty AnimatedProperty =
                BindableProperty.CreateAttached("Animated", typeof(ICommand), typeof(InsertPageBeforeRequested), null, propertyChanged:OnAnimatedChanged);
            
            public static ICommand GetAnimated(BindableObject bindableObject)
            {
                return (ICommand)bindableObject.GetValue(AnimatedProperty);
            }
            
            private static void OnAnimatedChanged(BindableObject bindable, object oldValue, object newValue)
            {
                if (bindable is NavigationPage target)
                {
                    if (oldValue == null && newValue != null)
                    {
                        target.InsertPageBeforeRequested += OnInsertPageBeforeRequestedNotifyAnimated;
                    }
                    else if (oldValue != null && newValue == null)
                    {
                        target.InsertPageBeforeRequested -= OnInsertPageBeforeRequestedNotifyAnimated;
                    }
                }
            }
            
            private static void OnInsertPageBeforeRequestedNotifyAnimated(object o, Xamarin.Forms.Internals.NavigationRequestedEventArgs eventArgs)
            {
                var command = GetAnimated((BindableObject)o);
                if (command.CanExecute(eventArgs.Animated))
                    command.Execute(eventArgs.Animated);
            }
            #endregion
            
            #region BeforePage
            public static readonly BindableProperty BeforePageProperty =
                BindableProperty.CreateAttached("BeforePage", typeof(ICommand), typeof(InsertPageBeforeRequested), null, propertyChanged:OnBeforePageChanged);
            
            public static ICommand GetBeforePage(BindableObject bindableObject)
            {
                return (ICommand)bindableObject.GetValue(BeforePageProperty);
            }
            
            private static void OnBeforePageChanged(BindableObject bindable, object oldValue, object newValue)
            {
                if (bindable is NavigationPage target)
                {
                    if (oldValue == null && newValue != null)
                    {
                        target.InsertPageBeforeRequested += OnInsertPageBeforeRequestedNotifyBeforePage;
                    }
                    else if (oldValue != null && newValue == null)
                    {
                        target.InsertPageBeforeRequested -= OnInsertPageBeforeRequestedNotifyBeforePage;
                    }
                }
            }
            
            private static void OnInsertPageBeforeRequestedNotifyBeforePage(object o, Xamarin.Forms.Internals.NavigationRequestedEventArgs eventArgs)
            {
                var command = GetBeforePage((BindableObject)o);
                if (command.CanExecute(eventArgs.BeforePage))
                    command.Execute(eventArgs.BeforePage);
            }
            #endregion
            
            #region Realize
            public static readonly BindableProperty RealizeProperty =
                BindableProperty.CreateAttached("Realize", typeof(ICommand), typeof(InsertPageBeforeRequested), null, propertyChanged:OnRealizeChanged);
            
            public static ICommand GetRealize(BindableObject bindableObject)
            {
                return (ICommand)bindableObject.GetValue(RealizeProperty);
            }
            
            private static void OnRealizeChanged(BindableObject bindable, object oldValue, object newValue)
            {
                if (bindable is NavigationPage target)
                {
                    if (oldValue == null && newValue != null)
                    {
                        target.InsertPageBeforeRequested += OnInsertPageBeforeRequestedNotifyRealize;
                    }
                    else if (oldValue != null && newValue == null)
                    {
                        target.InsertPageBeforeRequested -= OnInsertPageBeforeRequestedNotifyRealize;
                    }
                }
            }
            
            private static void OnInsertPageBeforeRequestedNotifyRealize(object o, Xamarin.Forms.Internals.NavigationRequestedEventArgs eventArgs)
            {
                var command = GetRealize((BindableObject)o);
                if (command.CanExecute(eventArgs.Realize))
                    command.Execute(eventArgs.Realize);
            }
            #endregion
            
            #region Task
            public static readonly BindableProperty TaskProperty =
                BindableProperty.CreateAttached("Task", typeof(ICommand), typeof(InsertPageBeforeRequested), null, propertyChanged:OnTaskChanged);
            
            public static ICommand GetTask(BindableObject bindableObject)
            {
                return (ICommand)bindableObject.GetValue(TaskProperty);
            }
            
            private static void OnTaskChanged(BindableObject bindable, object oldValue, object newValue)
            {
                if (bindable is NavigationPage target)
                {
                    if (oldValue == null && newValue != null)
                    {
                        target.InsertPageBeforeRequested += OnInsertPageBeforeRequestedNotifyTask;
                    }
                    else if (oldValue != null && newValue == null)
                    {
                        target.InsertPageBeforeRequested -= OnInsertPageBeforeRequestedNotifyTask;
                    }
                }
            }
            
            private static void OnInsertPageBeforeRequestedNotifyTask(object o, Xamarin.Forms.Internals.NavigationRequestedEventArgs eventArgs)
            {
                var command = GetTask((BindableObject)o);
                if (command.CanExecute(eventArgs.Task))
                    command.Execute(eventArgs.Task);
            }
            #endregion
            
            #region Page
            public static readonly BindableProperty PageProperty =
                BindableProperty.CreateAttached("Page", typeof(ICommand), typeof(InsertPageBeforeRequested), null, propertyChanged:OnPageChanged);
            
            public static ICommand GetPage(BindableObject bindableObject)
            {
                return (ICommand)bindableObject.GetValue(PageProperty);
            }
            
            private static void OnPageChanged(BindableObject bindable, object oldValue, object newValue)
            {
                if (bindable is NavigationPage target)
                {
                    if (oldValue == null && newValue != null)
                    {
                        target.InsertPageBeforeRequested += OnInsertPageBeforeRequestedNotifyPage;
                    }
                    else if (oldValue != null && newValue == null)
                    {
                        target.InsertPageBeforeRequested -= OnInsertPageBeforeRequestedNotifyPage;
                    }
                }
            }
            
            private static void OnInsertPageBeforeRequestedNotifyPage(object o, Xamarin.Forms.Internals.NavigationRequestedEventArgs eventArgs)
            {
                var command = GetPage((BindableObject)o);
                if (command.CanExecute(eventArgs.Page))
                    command.Execute(eventArgs.Page);
            }
            #endregion
		}
		#endregion
        
        #region Popped
        public static readonly BindableProperty PoppedProperty =
            BindableProperty.CreateAttached("Popped", typeof(ICommand), typeof(NavigationPages), null, propertyChanged:OnPoppedChanged);
        
        public static ICommand GetPopped(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(PoppedProperty);
        }
        
        private static void OnPoppedChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is NavigationPage target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.Popped += OnPopped;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.Popped -= OnPopped;
                }
            }
        }
        
        private static void OnPopped(object o, EventArgs eventArgs)
        {
            var command = GetPopped((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion

		#region Popped Properties
		public static partial class Popped {
            
            #region Page
            public static readonly BindableProperty PageProperty =
                BindableProperty.CreateAttached("Page", typeof(ICommand), typeof(Popped), null, propertyChanged:OnPageChanged);
            
            public static ICommand GetPage(BindableObject bindableObject)
            {
                return (ICommand)bindableObject.GetValue(PageProperty);
            }
            
            private static void OnPageChanged(BindableObject bindable, object oldValue, object newValue)
            {
                if (bindable is NavigationPage target)
                {
                    if (oldValue == null && newValue != null)
                    {
                        target.Popped += OnPoppedNotifyPage;
                    }
                    else if (oldValue != null && newValue == null)
                    {
                        target.Popped -= OnPoppedNotifyPage;
                    }
                }
            }
            
            private static void OnPoppedNotifyPage(object o, Xamarin.Forms.NavigationEventArgs eventArgs)
            {
                var command = GetPage((BindableObject)o);
                if (command.CanExecute(eventArgs.Page))
                    command.Execute(eventArgs.Page);
            }
            #endregion
		}
		#endregion
        
        #region PoppedToRoot
        public static readonly BindableProperty PoppedToRootProperty =
            BindableProperty.CreateAttached("PoppedToRoot", typeof(ICommand), typeof(NavigationPages), null, propertyChanged:OnPoppedToRootChanged);
        
        public static ICommand GetPoppedToRoot(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(PoppedToRootProperty);
        }
        
        private static void OnPoppedToRootChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is NavigationPage target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.PoppedToRoot += OnPoppedToRoot;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.PoppedToRoot -= OnPoppedToRoot;
                }
            }
        }
        
        private static void OnPoppedToRoot(object o, EventArgs eventArgs)
        {
            var command = GetPoppedToRoot((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion

		#region PoppedToRoot Properties
		public static partial class PoppedToRoot {
            
            #region Page
            public static readonly BindableProperty PageProperty =
                BindableProperty.CreateAttached("Page", typeof(ICommand), typeof(PoppedToRoot), null, propertyChanged:OnPageChanged);
            
            public static ICommand GetPage(BindableObject bindableObject)
            {
                return (ICommand)bindableObject.GetValue(PageProperty);
            }
            
            private static void OnPageChanged(BindableObject bindable, object oldValue, object newValue)
            {
                if (bindable is NavigationPage target)
                {
                    if (oldValue == null && newValue != null)
                    {
                        target.PoppedToRoot += OnPoppedToRootNotifyPage;
                    }
                    else if (oldValue != null && newValue == null)
                    {
                        target.PoppedToRoot -= OnPoppedToRootNotifyPage;
                    }
                }
            }
            
            private static void OnPoppedToRootNotifyPage(object o, Xamarin.Forms.NavigationEventArgs eventArgs)
            {
                var command = GetPage((BindableObject)o);
                if (command.CanExecute(eventArgs.Page))
                    command.Execute(eventArgs.Page);
            }
            #endregion
		}
		#endregion
        
        #region PopRequested
        public static readonly BindableProperty PopRequestedProperty =
            BindableProperty.CreateAttached("PopRequested", typeof(ICommand), typeof(NavigationPages), null, propertyChanged:OnPopRequestedChanged);
        
        public static ICommand GetPopRequested(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(PopRequestedProperty);
        }
        
        private static void OnPopRequestedChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is NavigationPage target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.PopRequested += OnPopRequested;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.PopRequested -= OnPopRequested;
                }
            }
        }
        
        private static void OnPopRequested(object o, EventArgs eventArgs)
        {
            var command = GetPopRequested((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion

		#region PopRequested Properties
		public static partial class PopRequested {
            
            #region Animated
            public static readonly BindableProperty AnimatedProperty =
                BindableProperty.CreateAttached("Animated", typeof(ICommand), typeof(PopRequested), null, propertyChanged:OnAnimatedChanged);
            
            public static ICommand GetAnimated(BindableObject bindableObject)
            {
                return (ICommand)bindableObject.GetValue(AnimatedProperty);
            }
            
            private static void OnAnimatedChanged(BindableObject bindable, object oldValue, object newValue)
            {
                if (bindable is NavigationPage target)
                {
                    if (oldValue == null && newValue != null)
                    {
                        target.PopRequested += OnPopRequestedNotifyAnimated;
                    }
                    else if (oldValue != null && newValue == null)
                    {
                        target.PopRequested -= OnPopRequestedNotifyAnimated;
                    }
                }
            }
            
            private static void OnPopRequestedNotifyAnimated(object o, Xamarin.Forms.Internals.NavigationRequestedEventArgs eventArgs)
            {
                var command = GetAnimated((BindableObject)o);
                if (command.CanExecute(eventArgs.Animated))
                    command.Execute(eventArgs.Animated);
            }
            #endregion
            
            #region BeforePage
            public static readonly BindableProperty BeforePageProperty =
                BindableProperty.CreateAttached("BeforePage", typeof(ICommand), typeof(PopRequested), null, propertyChanged:OnBeforePageChanged);
            
            public static ICommand GetBeforePage(BindableObject bindableObject)
            {
                return (ICommand)bindableObject.GetValue(BeforePageProperty);
            }
            
            private static void OnBeforePageChanged(BindableObject bindable, object oldValue, object newValue)
            {
                if (bindable is NavigationPage target)
                {
                    if (oldValue == null && newValue != null)
                    {
                        target.PopRequested += OnPopRequestedNotifyBeforePage;
                    }
                    else if (oldValue != null && newValue == null)
                    {
                        target.PopRequested -= OnPopRequestedNotifyBeforePage;
                    }
                }
            }
            
            private static void OnPopRequestedNotifyBeforePage(object o, Xamarin.Forms.Internals.NavigationRequestedEventArgs eventArgs)
            {
                var command = GetBeforePage((BindableObject)o);
                if (command.CanExecute(eventArgs.BeforePage))
                    command.Execute(eventArgs.BeforePage);
            }
            #endregion
            
            #region Realize
            public static readonly BindableProperty RealizeProperty =
                BindableProperty.CreateAttached("Realize", typeof(ICommand), typeof(PopRequested), null, propertyChanged:OnRealizeChanged);
            
            public static ICommand GetRealize(BindableObject bindableObject)
            {
                return (ICommand)bindableObject.GetValue(RealizeProperty);
            }
            
            private static void OnRealizeChanged(BindableObject bindable, object oldValue, object newValue)
            {
                if (bindable is NavigationPage target)
                {
                    if (oldValue == null && newValue != null)
                    {
                        target.PopRequested += OnPopRequestedNotifyRealize;
                    }
                    else if (oldValue != null && newValue == null)
                    {
                        target.PopRequested -= OnPopRequestedNotifyRealize;
                    }
                }
            }
            
            private static void OnPopRequestedNotifyRealize(object o, Xamarin.Forms.Internals.NavigationRequestedEventArgs eventArgs)
            {
                var command = GetRealize((BindableObject)o);
                if (command.CanExecute(eventArgs.Realize))
                    command.Execute(eventArgs.Realize);
            }
            #endregion
            
            #region Task
            public static readonly BindableProperty TaskProperty =
                BindableProperty.CreateAttached("Task", typeof(ICommand), typeof(PopRequested), null, propertyChanged:OnTaskChanged);
            
            public static ICommand GetTask(BindableObject bindableObject)
            {
                return (ICommand)bindableObject.GetValue(TaskProperty);
            }
            
            private static void OnTaskChanged(BindableObject bindable, object oldValue, object newValue)
            {
                if (bindable is NavigationPage target)
                {
                    if (oldValue == null && newValue != null)
                    {
                        target.PopRequested += OnPopRequestedNotifyTask;
                    }
                    else if (oldValue != null && newValue == null)
                    {
                        target.PopRequested -= OnPopRequestedNotifyTask;
                    }
                }
            }
            
            private static void OnPopRequestedNotifyTask(object o, Xamarin.Forms.Internals.NavigationRequestedEventArgs eventArgs)
            {
                var command = GetTask((BindableObject)o);
                if (command.CanExecute(eventArgs.Task))
                    command.Execute(eventArgs.Task);
            }
            #endregion
            
            #region Page
            public static readonly BindableProperty PageProperty =
                BindableProperty.CreateAttached("Page", typeof(ICommand), typeof(PopRequested), null, propertyChanged:OnPageChanged);
            
            public static ICommand GetPage(BindableObject bindableObject)
            {
                return (ICommand)bindableObject.GetValue(PageProperty);
            }
            
            private static void OnPageChanged(BindableObject bindable, object oldValue, object newValue)
            {
                if (bindable is NavigationPage target)
                {
                    if (oldValue == null && newValue != null)
                    {
                        target.PopRequested += OnPopRequestedNotifyPage;
                    }
                    else if (oldValue != null && newValue == null)
                    {
                        target.PopRequested -= OnPopRequestedNotifyPage;
                    }
                }
            }
            
            private static void OnPopRequestedNotifyPage(object o, Xamarin.Forms.Internals.NavigationRequestedEventArgs eventArgs)
            {
                var command = GetPage((BindableObject)o);
                if (command.CanExecute(eventArgs.Page))
                    command.Execute(eventArgs.Page);
            }
            #endregion
		}
		#endregion
        
        #region PopToRootRequested
        public static readonly BindableProperty PopToRootRequestedProperty =
            BindableProperty.CreateAttached("PopToRootRequested", typeof(ICommand), typeof(NavigationPages), null, propertyChanged:OnPopToRootRequestedChanged);
        
        public static ICommand GetPopToRootRequested(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(PopToRootRequestedProperty);
        }
        
        private static void OnPopToRootRequestedChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is NavigationPage target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.PopToRootRequested += OnPopToRootRequested;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.PopToRootRequested -= OnPopToRootRequested;
                }
            }
        }
        
        private static void OnPopToRootRequested(object o, EventArgs eventArgs)
        {
            var command = GetPopToRootRequested((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion

		#region PopToRootRequested Properties
		public static partial class PopToRootRequested {
            
            #region Animated
            public static readonly BindableProperty AnimatedProperty =
                BindableProperty.CreateAttached("Animated", typeof(ICommand), typeof(PopToRootRequested), null, propertyChanged:OnAnimatedChanged);
            
            public static ICommand GetAnimated(BindableObject bindableObject)
            {
                return (ICommand)bindableObject.GetValue(AnimatedProperty);
            }
            
            private static void OnAnimatedChanged(BindableObject bindable, object oldValue, object newValue)
            {
                if (bindable is NavigationPage target)
                {
                    if (oldValue == null && newValue != null)
                    {
                        target.PopToRootRequested += OnPopToRootRequestedNotifyAnimated;
                    }
                    else if (oldValue != null && newValue == null)
                    {
                        target.PopToRootRequested -= OnPopToRootRequestedNotifyAnimated;
                    }
                }
            }
            
            private static void OnPopToRootRequestedNotifyAnimated(object o, Xamarin.Forms.Internals.NavigationRequestedEventArgs eventArgs)
            {
                var command = GetAnimated((BindableObject)o);
                if (command.CanExecute(eventArgs.Animated))
                    command.Execute(eventArgs.Animated);
            }
            #endregion
            
            #region BeforePage
            public static readonly BindableProperty BeforePageProperty =
                BindableProperty.CreateAttached("BeforePage", typeof(ICommand), typeof(PopToRootRequested), null, propertyChanged:OnBeforePageChanged);
            
            public static ICommand GetBeforePage(BindableObject bindableObject)
            {
                return (ICommand)bindableObject.GetValue(BeforePageProperty);
            }
            
            private static void OnBeforePageChanged(BindableObject bindable, object oldValue, object newValue)
            {
                if (bindable is NavigationPage target)
                {
                    if (oldValue == null && newValue != null)
                    {
                        target.PopToRootRequested += OnPopToRootRequestedNotifyBeforePage;
                    }
                    else if (oldValue != null && newValue == null)
                    {
                        target.PopToRootRequested -= OnPopToRootRequestedNotifyBeforePage;
                    }
                }
            }
            
            private static void OnPopToRootRequestedNotifyBeforePage(object o, Xamarin.Forms.Internals.NavigationRequestedEventArgs eventArgs)
            {
                var command = GetBeforePage((BindableObject)o);
                if (command.CanExecute(eventArgs.BeforePage))
                    command.Execute(eventArgs.BeforePage);
            }
            #endregion
            
            #region Realize
            public static readonly BindableProperty RealizeProperty =
                BindableProperty.CreateAttached("Realize", typeof(ICommand), typeof(PopToRootRequested), null, propertyChanged:OnRealizeChanged);
            
            public static ICommand GetRealize(BindableObject bindableObject)
            {
                return (ICommand)bindableObject.GetValue(RealizeProperty);
            }
            
            private static void OnRealizeChanged(BindableObject bindable, object oldValue, object newValue)
            {
                if (bindable is NavigationPage target)
                {
                    if (oldValue == null && newValue != null)
                    {
                        target.PopToRootRequested += OnPopToRootRequestedNotifyRealize;
                    }
                    else if (oldValue != null && newValue == null)
                    {
                        target.PopToRootRequested -= OnPopToRootRequestedNotifyRealize;
                    }
                }
            }
            
            private static void OnPopToRootRequestedNotifyRealize(object o, Xamarin.Forms.Internals.NavigationRequestedEventArgs eventArgs)
            {
                var command = GetRealize((BindableObject)o);
                if (command.CanExecute(eventArgs.Realize))
                    command.Execute(eventArgs.Realize);
            }
            #endregion
            
            #region Task
            public static readonly BindableProperty TaskProperty =
                BindableProperty.CreateAttached("Task", typeof(ICommand), typeof(PopToRootRequested), null, propertyChanged:OnTaskChanged);
            
            public static ICommand GetTask(BindableObject bindableObject)
            {
                return (ICommand)bindableObject.GetValue(TaskProperty);
            }
            
            private static void OnTaskChanged(BindableObject bindable, object oldValue, object newValue)
            {
                if (bindable is NavigationPage target)
                {
                    if (oldValue == null && newValue != null)
                    {
                        target.PopToRootRequested += OnPopToRootRequestedNotifyTask;
                    }
                    else if (oldValue != null && newValue == null)
                    {
                        target.PopToRootRequested -= OnPopToRootRequestedNotifyTask;
                    }
                }
            }
            
            private static void OnPopToRootRequestedNotifyTask(object o, Xamarin.Forms.Internals.NavigationRequestedEventArgs eventArgs)
            {
                var command = GetTask((BindableObject)o);
                if (command.CanExecute(eventArgs.Task))
                    command.Execute(eventArgs.Task);
            }
            #endregion
            
            #region Page
            public static readonly BindableProperty PageProperty =
                BindableProperty.CreateAttached("Page", typeof(ICommand), typeof(PopToRootRequested), null, propertyChanged:OnPageChanged);
            
            public static ICommand GetPage(BindableObject bindableObject)
            {
                return (ICommand)bindableObject.GetValue(PageProperty);
            }
            
            private static void OnPageChanged(BindableObject bindable, object oldValue, object newValue)
            {
                if (bindable is NavigationPage target)
                {
                    if (oldValue == null && newValue != null)
                    {
                        target.PopToRootRequested += OnPopToRootRequestedNotifyPage;
                    }
                    else if (oldValue != null && newValue == null)
                    {
                        target.PopToRootRequested -= OnPopToRootRequestedNotifyPage;
                    }
                }
            }
            
            private static void OnPopToRootRequestedNotifyPage(object o, Xamarin.Forms.Internals.NavigationRequestedEventArgs eventArgs)
            {
                var command = GetPage((BindableObject)o);
                if (command.CanExecute(eventArgs.Page))
                    command.Execute(eventArgs.Page);
            }
            #endregion
		}
		#endregion
        
        #region Pushed
        public static readonly BindableProperty PushedProperty =
            BindableProperty.CreateAttached("Pushed", typeof(ICommand), typeof(NavigationPages), null, propertyChanged:OnPushedChanged);
        
        public static ICommand GetPushed(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(PushedProperty);
        }
        
        private static void OnPushedChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is NavigationPage target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.Pushed += OnPushed;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.Pushed -= OnPushed;
                }
            }
        }
        
        private static void OnPushed(object o, EventArgs eventArgs)
        {
            var command = GetPushed((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion

		#region Pushed Properties
		public static partial class Pushed {
            
            #region Page
            public static readonly BindableProperty PageProperty =
                BindableProperty.CreateAttached("Page", typeof(ICommand), typeof(Pushed), null, propertyChanged:OnPageChanged);
            
            public static ICommand GetPage(BindableObject bindableObject)
            {
                return (ICommand)bindableObject.GetValue(PageProperty);
            }
            
            private static void OnPageChanged(BindableObject bindable, object oldValue, object newValue)
            {
                if (bindable is NavigationPage target)
                {
                    if (oldValue == null && newValue != null)
                    {
                        target.Pushed += OnPushedNotifyPage;
                    }
                    else if (oldValue != null && newValue == null)
                    {
                        target.Pushed -= OnPushedNotifyPage;
                    }
                }
            }
            
            private static void OnPushedNotifyPage(object o, Xamarin.Forms.NavigationEventArgs eventArgs)
            {
                var command = GetPage((BindableObject)o);
                if (command.CanExecute(eventArgs.Page))
                    command.Execute(eventArgs.Page);
            }
            #endregion
		}
		#endregion
        
        #region PushRequested
        public static readonly BindableProperty PushRequestedProperty =
            BindableProperty.CreateAttached("PushRequested", typeof(ICommand), typeof(NavigationPages), null, propertyChanged:OnPushRequestedChanged);
        
        public static ICommand GetPushRequested(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(PushRequestedProperty);
        }
        
        private static void OnPushRequestedChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is NavigationPage target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.PushRequested += OnPushRequested;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.PushRequested -= OnPushRequested;
                }
            }
        }
        
        private static void OnPushRequested(object o, EventArgs eventArgs)
        {
            var command = GetPushRequested((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion

		#region PushRequested Properties
		public static partial class PushRequested {
            
            #region Animated
            public static readonly BindableProperty AnimatedProperty =
                BindableProperty.CreateAttached("Animated", typeof(ICommand), typeof(PushRequested), null, propertyChanged:OnAnimatedChanged);
            
            public static ICommand GetAnimated(BindableObject bindableObject)
            {
                return (ICommand)bindableObject.GetValue(AnimatedProperty);
            }
            
            private static void OnAnimatedChanged(BindableObject bindable, object oldValue, object newValue)
            {
                if (bindable is NavigationPage target)
                {
                    if (oldValue == null && newValue != null)
                    {
                        target.PushRequested += OnPushRequestedNotifyAnimated;
                    }
                    else if (oldValue != null && newValue == null)
                    {
                        target.PushRequested -= OnPushRequestedNotifyAnimated;
                    }
                }
            }
            
            private static void OnPushRequestedNotifyAnimated(object o, Xamarin.Forms.Internals.NavigationRequestedEventArgs eventArgs)
            {
                var command = GetAnimated((BindableObject)o);
                if (command.CanExecute(eventArgs.Animated))
                    command.Execute(eventArgs.Animated);
            }
            #endregion
            
            #region BeforePage
            public static readonly BindableProperty BeforePageProperty =
                BindableProperty.CreateAttached("BeforePage", typeof(ICommand), typeof(PushRequested), null, propertyChanged:OnBeforePageChanged);
            
            public static ICommand GetBeforePage(BindableObject bindableObject)
            {
                return (ICommand)bindableObject.GetValue(BeforePageProperty);
            }
            
            private static void OnBeforePageChanged(BindableObject bindable, object oldValue, object newValue)
            {
                if (bindable is NavigationPage target)
                {
                    if (oldValue == null && newValue != null)
                    {
                        target.PushRequested += OnPushRequestedNotifyBeforePage;
                    }
                    else if (oldValue != null && newValue == null)
                    {
                        target.PushRequested -= OnPushRequestedNotifyBeforePage;
                    }
                }
            }
            
            private static void OnPushRequestedNotifyBeforePage(object o, Xamarin.Forms.Internals.NavigationRequestedEventArgs eventArgs)
            {
                var command = GetBeforePage((BindableObject)o);
                if (command.CanExecute(eventArgs.BeforePage))
                    command.Execute(eventArgs.BeforePage);
            }
            #endregion
            
            #region Realize
            public static readonly BindableProperty RealizeProperty =
                BindableProperty.CreateAttached("Realize", typeof(ICommand), typeof(PushRequested), null, propertyChanged:OnRealizeChanged);
            
            public static ICommand GetRealize(BindableObject bindableObject)
            {
                return (ICommand)bindableObject.GetValue(RealizeProperty);
            }
            
            private static void OnRealizeChanged(BindableObject bindable, object oldValue, object newValue)
            {
                if (bindable is NavigationPage target)
                {
                    if (oldValue == null && newValue != null)
                    {
                        target.PushRequested += OnPushRequestedNotifyRealize;
                    }
                    else if (oldValue != null && newValue == null)
                    {
                        target.PushRequested -= OnPushRequestedNotifyRealize;
                    }
                }
            }
            
            private static void OnPushRequestedNotifyRealize(object o, Xamarin.Forms.Internals.NavigationRequestedEventArgs eventArgs)
            {
                var command = GetRealize((BindableObject)o);
                if (command.CanExecute(eventArgs.Realize))
                    command.Execute(eventArgs.Realize);
            }
            #endregion
            
            #region Task
            public static readonly BindableProperty TaskProperty =
                BindableProperty.CreateAttached("Task", typeof(ICommand), typeof(PushRequested), null, propertyChanged:OnTaskChanged);
            
            public static ICommand GetTask(BindableObject bindableObject)
            {
                return (ICommand)bindableObject.GetValue(TaskProperty);
            }
            
            private static void OnTaskChanged(BindableObject bindable, object oldValue, object newValue)
            {
                if (bindable is NavigationPage target)
                {
                    if (oldValue == null && newValue != null)
                    {
                        target.PushRequested += OnPushRequestedNotifyTask;
                    }
                    else if (oldValue != null && newValue == null)
                    {
                        target.PushRequested -= OnPushRequestedNotifyTask;
                    }
                }
            }
            
            private static void OnPushRequestedNotifyTask(object o, Xamarin.Forms.Internals.NavigationRequestedEventArgs eventArgs)
            {
                var command = GetTask((BindableObject)o);
                if (command.CanExecute(eventArgs.Task))
                    command.Execute(eventArgs.Task);
            }
            #endregion
            
            #region Page
            public static readonly BindableProperty PageProperty =
                BindableProperty.CreateAttached("Page", typeof(ICommand), typeof(PushRequested), null, propertyChanged:OnPageChanged);
            
            public static ICommand GetPage(BindableObject bindableObject)
            {
                return (ICommand)bindableObject.GetValue(PageProperty);
            }
            
            private static void OnPageChanged(BindableObject bindable, object oldValue, object newValue)
            {
                if (bindable is NavigationPage target)
                {
                    if (oldValue == null && newValue != null)
                    {
                        target.PushRequested += OnPushRequestedNotifyPage;
                    }
                    else if (oldValue != null && newValue == null)
                    {
                        target.PushRequested -= OnPushRequestedNotifyPage;
                    }
                }
            }
            
            private static void OnPushRequestedNotifyPage(object o, Xamarin.Forms.Internals.NavigationRequestedEventArgs eventArgs)
            {
                var command = GetPage((BindableObject)o);
                if (command.CanExecute(eventArgs.Page))
                    command.Execute(eventArgs.Page);
            }
            #endregion
		}
		#endregion
        
        #region RemovePageRequested
        public static readonly BindableProperty RemovePageRequestedProperty =
            BindableProperty.CreateAttached("RemovePageRequested", typeof(ICommand), typeof(NavigationPages), null, propertyChanged:OnRemovePageRequestedChanged);
        
        public static ICommand GetRemovePageRequested(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(RemovePageRequestedProperty);
        }
        
        private static void OnRemovePageRequestedChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is NavigationPage target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.RemovePageRequested += OnRemovePageRequested;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.RemovePageRequested -= OnRemovePageRequested;
                }
            }
        }
        
        private static void OnRemovePageRequested(object o, EventArgs eventArgs)
        {
            var command = GetRemovePageRequested((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion

		#region RemovePageRequested Properties
		public static partial class RemovePageRequested {
            
            #region Animated
            public static readonly BindableProperty AnimatedProperty =
                BindableProperty.CreateAttached("Animated", typeof(ICommand), typeof(RemovePageRequested), null, propertyChanged:OnAnimatedChanged);
            
            public static ICommand GetAnimated(BindableObject bindableObject)
            {
                return (ICommand)bindableObject.GetValue(AnimatedProperty);
            }
            
            private static void OnAnimatedChanged(BindableObject bindable, object oldValue, object newValue)
            {
                if (bindable is NavigationPage target)
                {
                    if (oldValue == null && newValue != null)
                    {
                        target.RemovePageRequested += OnRemovePageRequestedNotifyAnimated;
                    }
                    else if (oldValue != null && newValue == null)
                    {
                        target.RemovePageRequested -= OnRemovePageRequestedNotifyAnimated;
                    }
                }
            }
            
            private static void OnRemovePageRequestedNotifyAnimated(object o, Xamarin.Forms.Internals.NavigationRequestedEventArgs eventArgs)
            {
                var command = GetAnimated((BindableObject)o);
                if (command.CanExecute(eventArgs.Animated))
                    command.Execute(eventArgs.Animated);
            }
            #endregion
            
            #region BeforePage
            public static readonly BindableProperty BeforePageProperty =
                BindableProperty.CreateAttached("BeforePage", typeof(ICommand), typeof(RemovePageRequested), null, propertyChanged:OnBeforePageChanged);
            
            public static ICommand GetBeforePage(BindableObject bindableObject)
            {
                return (ICommand)bindableObject.GetValue(BeforePageProperty);
            }
            
            private static void OnBeforePageChanged(BindableObject bindable, object oldValue, object newValue)
            {
                if (bindable is NavigationPage target)
                {
                    if (oldValue == null && newValue != null)
                    {
                        target.RemovePageRequested += OnRemovePageRequestedNotifyBeforePage;
                    }
                    else if (oldValue != null && newValue == null)
                    {
                        target.RemovePageRequested -= OnRemovePageRequestedNotifyBeforePage;
                    }
                }
            }
            
            private static void OnRemovePageRequestedNotifyBeforePage(object o, Xamarin.Forms.Internals.NavigationRequestedEventArgs eventArgs)
            {
                var command = GetBeforePage((BindableObject)o);
                if (command.CanExecute(eventArgs.BeforePage))
                    command.Execute(eventArgs.BeforePage);
            }
            #endregion
            
            #region Realize
            public static readonly BindableProperty RealizeProperty =
                BindableProperty.CreateAttached("Realize", typeof(ICommand), typeof(RemovePageRequested), null, propertyChanged:OnRealizeChanged);
            
            public static ICommand GetRealize(BindableObject bindableObject)
            {
                return (ICommand)bindableObject.GetValue(RealizeProperty);
            }
            
            private static void OnRealizeChanged(BindableObject bindable, object oldValue, object newValue)
            {
                if (bindable is NavigationPage target)
                {
                    if (oldValue == null && newValue != null)
                    {
                        target.RemovePageRequested += OnRemovePageRequestedNotifyRealize;
                    }
                    else if (oldValue != null && newValue == null)
                    {
                        target.RemovePageRequested -= OnRemovePageRequestedNotifyRealize;
                    }
                }
            }
            
            private static void OnRemovePageRequestedNotifyRealize(object o, Xamarin.Forms.Internals.NavigationRequestedEventArgs eventArgs)
            {
                var command = GetRealize((BindableObject)o);
                if (command.CanExecute(eventArgs.Realize))
                    command.Execute(eventArgs.Realize);
            }
            #endregion
            
            #region Task
            public static readonly BindableProperty TaskProperty =
                BindableProperty.CreateAttached("Task", typeof(ICommand), typeof(RemovePageRequested), null, propertyChanged:OnTaskChanged);
            
            public static ICommand GetTask(BindableObject bindableObject)
            {
                return (ICommand)bindableObject.GetValue(TaskProperty);
            }
            
            private static void OnTaskChanged(BindableObject bindable, object oldValue, object newValue)
            {
                if (bindable is NavigationPage target)
                {
                    if (oldValue == null && newValue != null)
                    {
                        target.RemovePageRequested += OnRemovePageRequestedNotifyTask;
                    }
                    else if (oldValue != null && newValue == null)
                    {
                        target.RemovePageRequested -= OnRemovePageRequestedNotifyTask;
                    }
                }
            }
            
            private static void OnRemovePageRequestedNotifyTask(object o, Xamarin.Forms.Internals.NavigationRequestedEventArgs eventArgs)
            {
                var command = GetTask((BindableObject)o);
                if (command.CanExecute(eventArgs.Task))
                    command.Execute(eventArgs.Task);
            }
            #endregion
            
            #region Page
            public static readonly BindableProperty PageProperty =
                BindableProperty.CreateAttached("Page", typeof(ICommand), typeof(RemovePageRequested), null, propertyChanged:OnPageChanged);
            
            public static ICommand GetPage(BindableObject bindableObject)
            {
                return (ICommand)bindableObject.GetValue(PageProperty);
            }
            
            private static void OnPageChanged(BindableObject bindable, object oldValue, object newValue)
            {
                if (bindable is NavigationPage target)
                {
                    if (oldValue == null && newValue != null)
                    {
                        target.RemovePageRequested += OnRemovePageRequestedNotifyPage;
                    }
                    else if (oldValue != null && newValue == null)
                    {
                        target.RemovePageRequested -= OnRemovePageRequestedNotifyPage;
                    }
                }
            }
            
            private static void OnRemovePageRequestedNotifyPage(object o, Xamarin.Forms.Internals.NavigationRequestedEventArgs eventArgs)
            {
                var command = GetPage((BindableObject)o);
                if (command.CanExecute(eventArgs.Page))
                    command.Execute(eventArgs.Page);
            }
            #endregion
		}
		#endregion
	}
	#endregion

	#region OpenGLViews
	public static partial class OpenGLViews {
        
        #region DisplayRequested
        public static readonly BindableProperty DisplayRequestedProperty =
            BindableProperty.CreateAttached("DisplayRequested", typeof(ICommand), typeof(OpenGLViews), null, propertyChanged:OnDisplayRequestedChanged);
        
        public static ICommand GetDisplayRequested(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(DisplayRequestedProperty);
        }
        
        private static void OnDisplayRequestedChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is OpenGLView target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.DisplayRequested += OnDisplayRequested;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.DisplayRequested -= OnDisplayRequested;
                }
            }
        }
        
        private static void OnDisplayRequested(object o, EventArgs eventArgs)
        {
            var command = GetDisplayRequested((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
	}
	#endregion

	#region Pages
	public static partial class Pages {
        
        #region Appearing
        public static readonly BindableProperty AppearingProperty =
            BindableProperty.CreateAttached("Appearing", typeof(ICommand), typeof(Pages), null, propertyChanged:OnAppearingChanged);
        
        public static ICommand GetAppearing(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(AppearingProperty);
        }
        
        private static void OnAppearingChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Page target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.Appearing += OnAppearing;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.Appearing -= OnAppearing;
                }
            }
        }
        
        private static void OnAppearing(object o, EventArgs eventArgs)
        {
            var command = GetAppearing((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region Disappearing
        public static readonly BindableProperty DisappearingProperty =
            BindableProperty.CreateAttached("Disappearing", typeof(ICommand), typeof(Pages), null, propertyChanged:OnDisappearingChanged);
        
        public static ICommand GetDisappearing(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(DisappearingProperty);
        }
        
        private static void OnDisappearingChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Page target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.Disappearing += OnDisappearing;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.Disappearing -= OnDisappearing;
                }
            }
        }
        
        private static void OnDisappearing(object o, EventArgs eventArgs)
        {
            var command = GetDisappearing((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region LayoutChanged
        public static readonly BindableProperty LayoutChangedProperty =
            BindableProperty.CreateAttached("LayoutChanged", typeof(ICommand), typeof(Pages), null, propertyChanged:OnLayoutChangedChanged);
        
        public static ICommand GetLayoutChanged(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(LayoutChangedProperty);
        }
        
        private static void OnLayoutChangedChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Page target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.LayoutChanged += OnLayoutChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.LayoutChanged -= OnLayoutChanged;
                }
            }
        }
        
        private static void OnLayoutChanged(object o, EventArgs eventArgs)
        {
            var command = GetLayoutChanged((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
	}
	#endregion

	#region PanGestureRecognizers
	public static partial class PanGestureRecognizers {
        
        #region PanUpdated
        public static readonly BindableProperty PanUpdatedProperty =
            BindableProperty.CreateAttached("PanUpdated", typeof(ICommand), typeof(PanGestureRecognizers), null, propertyChanged:OnPanUpdatedChanged);
        
        public static ICommand GetPanUpdated(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(PanUpdatedProperty);
        }
        
        private static void OnPanUpdatedChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is PanGestureRecognizer target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.PanUpdated += OnPanUpdated;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.PanUpdated -= OnPanUpdated;
                }
            }
        }
        
        private static void OnPanUpdated(object o, EventArgs eventArgs)
        {
            var command = GetPanUpdated((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion

		#region PanUpdated Properties
		public static partial class PanUpdated {
            
            #region GestureId
            public static readonly BindableProperty GestureIdProperty =
                BindableProperty.CreateAttached("GestureId", typeof(ICommand), typeof(PanUpdated), null, propertyChanged:OnGestureIdChanged);
            
            public static ICommand GetGestureId(BindableObject bindableObject)
            {
                return (ICommand)bindableObject.GetValue(GestureIdProperty);
            }
            
            private static void OnGestureIdChanged(BindableObject bindable, object oldValue, object newValue)
            {
                if (bindable is PanGestureRecognizer target)
                {
                    if (oldValue == null && newValue != null)
                    {
                        target.PanUpdated += OnPanUpdatedNotifyGestureId;
                    }
                    else if (oldValue != null && newValue == null)
                    {
                        target.PanUpdated -= OnPanUpdatedNotifyGestureId;
                    }
                }
            }
            
            private static void OnPanUpdatedNotifyGestureId(object o, Xamarin.Forms.PanUpdatedEventArgs eventArgs)
            {
                var command = GetGestureId((BindableObject)o);
                if (command.CanExecute(eventArgs.GestureId))
                    command.Execute(eventArgs.GestureId);
            }
            #endregion
            
            #region StatusType
            public static readonly BindableProperty StatusTypeProperty =
                BindableProperty.CreateAttached("StatusType", typeof(ICommand), typeof(PanUpdated), null, propertyChanged:OnStatusTypeChanged);
            
            public static ICommand GetStatusType(BindableObject bindableObject)
            {
                return (ICommand)bindableObject.GetValue(StatusTypeProperty);
            }
            
            private static void OnStatusTypeChanged(BindableObject bindable, object oldValue, object newValue)
            {
                if (bindable is PanGestureRecognizer target)
                {
                    if (oldValue == null && newValue != null)
                    {
                        target.PanUpdated += OnPanUpdatedNotifyStatusType;
                    }
                    else if (oldValue != null && newValue == null)
                    {
                        target.PanUpdated -= OnPanUpdatedNotifyStatusType;
                    }
                }
            }
            
            private static void OnPanUpdatedNotifyStatusType(object o, Xamarin.Forms.PanUpdatedEventArgs eventArgs)
            {
                var command = GetStatusType((BindableObject)o);
                if (command.CanExecute(eventArgs.StatusType))
                    command.Execute(eventArgs.StatusType);
            }
            #endregion
            
            #region TotalX
            public static readonly BindableProperty TotalXProperty =
                BindableProperty.CreateAttached("TotalX", typeof(ICommand), typeof(PanUpdated), null, propertyChanged:OnTotalXChanged);
            
            public static ICommand GetTotalX(BindableObject bindableObject)
            {
                return (ICommand)bindableObject.GetValue(TotalXProperty);
            }
            
            private static void OnTotalXChanged(BindableObject bindable, object oldValue, object newValue)
            {
                if (bindable is PanGestureRecognizer target)
                {
                    if (oldValue == null && newValue != null)
                    {
                        target.PanUpdated += OnPanUpdatedNotifyTotalX;
                    }
                    else if (oldValue != null && newValue == null)
                    {
                        target.PanUpdated -= OnPanUpdatedNotifyTotalX;
                    }
                }
            }
            
            private static void OnPanUpdatedNotifyTotalX(object o, Xamarin.Forms.PanUpdatedEventArgs eventArgs)
            {
                var command = GetTotalX((BindableObject)o);
                if (command.CanExecute(eventArgs.TotalX))
                    command.Execute(eventArgs.TotalX);
            }
            #endregion
            
            #region TotalY
            public static readonly BindableProperty TotalYProperty =
                BindableProperty.CreateAttached("TotalY", typeof(ICommand), typeof(PanUpdated), null, propertyChanged:OnTotalYChanged);
            
            public static ICommand GetTotalY(BindableObject bindableObject)
            {
                return (ICommand)bindableObject.GetValue(TotalYProperty);
            }
            
            private static void OnTotalYChanged(BindableObject bindable, object oldValue, object newValue)
            {
                if (bindable is PanGestureRecognizer target)
                {
                    if (oldValue == null && newValue != null)
                    {
                        target.PanUpdated += OnPanUpdatedNotifyTotalY;
                    }
                    else if (oldValue != null && newValue == null)
                    {
                        target.PanUpdated -= OnPanUpdatedNotifyTotalY;
                    }
                }
            }
            
            private static void OnPanUpdatedNotifyTotalY(object o, Xamarin.Forms.PanUpdatedEventArgs eventArgs)
            {
                var command = GetTotalY((BindableObject)o);
                if (command.CanExecute(eventArgs.TotalY))
                    command.Execute(eventArgs.TotalY);
            }
            #endregion
		}
		#endregion
	}
	#endregion

	#region Pickers
	public static partial class Pickers {
        
        #region SelectedIndexChanged
        public static readonly BindableProperty SelectedIndexChangedProperty =
            BindableProperty.CreateAttached("SelectedIndexChanged", typeof(ICommand), typeof(Pickers), null, propertyChanged:OnSelectedIndexChangedChanged);
        
        public static ICommand GetSelectedIndexChanged(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(SelectedIndexChangedProperty);
        }
        
        private static void OnSelectedIndexChangedChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Picker target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.SelectedIndexChanged += OnSelectedIndexChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.SelectedIndexChanged -= OnSelectedIndexChanged;
                }
            }
        }
        
        private static void OnSelectedIndexChanged(object o, EventArgs eventArgs)
        {
            var command = GetSelectedIndexChanged((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
	}
	#endregion

	#region PinchGestureRecognizers
	public static partial class PinchGestureRecognizers {
        
        #region PinchUpdated
        public static readonly BindableProperty PinchUpdatedProperty =
            BindableProperty.CreateAttached("PinchUpdated", typeof(ICommand), typeof(PinchGestureRecognizers), null, propertyChanged:OnPinchUpdatedChanged);
        
        public static ICommand GetPinchUpdated(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(PinchUpdatedProperty);
        }
        
        private static void OnPinchUpdatedChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is PinchGestureRecognizer target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.PinchUpdated += OnPinchUpdated;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.PinchUpdated -= OnPinchUpdated;
                }
            }
        }
        
        private static void OnPinchUpdated(object o, EventArgs eventArgs)
        {
            var command = GetPinchUpdated((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion

		#region PinchUpdated Properties
		public static partial class PinchUpdated {
            
            #region Scale
            public static readonly BindableProperty ScaleProperty =
                BindableProperty.CreateAttached("Scale", typeof(ICommand), typeof(PinchUpdated), null, propertyChanged:OnScaleChanged);
            
            public static ICommand GetScale(BindableObject bindableObject)
            {
                return (ICommand)bindableObject.GetValue(ScaleProperty);
            }
            
            private static void OnScaleChanged(BindableObject bindable, object oldValue, object newValue)
            {
                if (bindable is PinchGestureRecognizer target)
                {
                    if (oldValue == null && newValue != null)
                    {
                        target.PinchUpdated += OnPinchUpdatedNotifyScale;
                    }
                    else if (oldValue != null && newValue == null)
                    {
                        target.PinchUpdated -= OnPinchUpdatedNotifyScale;
                    }
                }
            }
            
            private static void OnPinchUpdatedNotifyScale(object o, Xamarin.Forms.PinchGestureUpdatedEventArgs eventArgs)
            {
                var command = GetScale((BindableObject)o);
                if (command.CanExecute(eventArgs.Scale))
                    command.Execute(eventArgs.Scale);
            }
            #endregion
            
            #region ScaleOrigin
            public static readonly BindableProperty ScaleOriginProperty =
                BindableProperty.CreateAttached("ScaleOrigin", typeof(ICommand), typeof(PinchUpdated), null, propertyChanged:OnScaleOriginChanged);
            
            public static ICommand GetScaleOrigin(BindableObject bindableObject)
            {
                return (ICommand)bindableObject.GetValue(ScaleOriginProperty);
            }
            
            private static void OnScaleOriginChanged(BindableObject bindable, object oldValue, object newValue)
            {
                if (bindable is PinchGestureRecognizer target)
                {
                    if (oldValue == null && newValue != null)
                    {
                        target.PinchUpdated += OnPinchUpdatedNotifyScaleOrigin;
                    }
                    else if (oldValue != null && newValue == null)
                    {
                        target.PinchUpdated -= OnPinchUpdatedNotifyScaleOrigin;
                    }
                }
            }
            
            private static void OnPinchUpdatedNotifyScaleOrigin(object o, Xamarin.Forms.PinchGestureUpdatedEventArgs eventArgs)
            {
                var command = GetScaleOrigin((BindableObject)o);
                if (command.CanExecute(eventArgs.ScaleOrigin))
                    command.Execute(eventArgs.ScaleOrigin);
            }
            #endregion
            
            #region Status
            public static readonly BindableProperty StatusProperty =
                BindableProperty.CreateAttached("Status", typeof(ICommand), typeof(PinchUpdated), null, propertyChanged:OnStatusChanged);
            
            public static ICommand GetStatus(BindableObject bindableObject)
            {
                return (ICommand)bindableObject.GetValue(StatusProperty);
            }
            
            private static void OnStatusChanged(BindableObject bindable, object oldValue, object newValue)
            {
                if (bindable is PinchGestureRecognizer target)
                {
                    if (oldValue == null && newValue != null)
                    {
                        target.PinchUpdated += OnPinchUpdatedNotifyStatus;
                    }
                    else if (oldValue != null && newValue == null)
                    {
                        target.PinchUpdated -= OnPinchUpdatedNotifyStatus;
                    }
                }
            }
            
            private static void OnPinchUpdatedNotifyStatus(object o, Xamarin.Forms.PinchGestureUpdatedEventArgs eventArgs)
            {
                var command = GetStatus((BindableObject)o);
                if (command.CanExecute(eventArgs.Status))
                    command.Execute(eventArgs.Status);
            }
            #endregion
		}
		#endregion
	}
	#endregion

	#region RowDefinitions
	public static partial class RowDefinitions {
        
        #region SizeChanged
        public static readonly BindableProperty SizeChangedProperty =
            BindableProperty.CreateAttached("SizeChanged", typeof(ICommand), typeof(RowDefinitions), null, propertyChanged:OnSizeChangedChanged);
        
        public static ICommand GetSizeChanged(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(SizeChangedProperty);
        }
        
        private static void OnSizeChangedChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is RowDefinition target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.SizeChanged += OnSizeChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.SizeChanged -= OnSizeChanged;
                }
            }
        }
        
        private static void OnSizeChanged(object o, EventArgs eventArgs)
        {
            var command = GetSizeChanged((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
	}
	#endregion

	#region ScrollViews
	public static partial class ScrollViews {
        
        #region Scrolled
        public static readonly BindableProperty ScrolledProperty =
            BindableProperty.CreateAttached("Scrolled", typeof(ICommand), typeof(ScrollViews), null, propertyChanged:OnScrolledChanged);
        
        public static ICommand GetScrolled(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ScrolledProperty);
        }
        
        private static void OnScrolledChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is ScrollView target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.Scrolled += OnScrolled;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.Scrolled -= OnScrolled;
                }
            }
        }
        
        private static void OnScrolled(object o, EventArgs eventArgs)
        {
            var command = GetScrolled((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion

		#region Scrolled Properties
		public static partial class Scrolled {
            
            #region ScrollX
            public static readonly BindableProperty ScrollXProperty =
                BindableProperty.CreateAttached("ScrollX", typeof(ICommand), typeof(Scrolled), null, propertyChanged:OnScrollXChanged);
            
            public static ICommand GetScrollX(BindableObject bindableObject)
            {
                return (ICommand)bindableObject.GetValue(ScrollXProperty);
            }
            
            private static void OnScrollXChanged(BindableObject bindable, object oldValue, object newValue)
            {
                if (bindable is ScrollView target)
                {
                    if (oldValue == null && newValue != null)
                    {
                        target.Scrolled += OnScrolledNotifyScrollX;
                    }
                    else if (oldValue != null && newValue == null)
                    {
                        target.Scrolled -= OnScrolledNotifyScrollX;
                    }
                }
            }
            
            private static void OnScrolledNotifyScrollX(object o, Xamarin.Forms.ScrolledEventArgs eventArgs)
            {
                var command = GetScrollX((BindableObject)o);
                if (command.CanExecute(eventArgs.ScrollX))
                    command.Execute(eventArgs.ScrollX);
            }
            #endregion
            
            #region ScrollY
            public static readonly BindableProperty ScrollYProperty =
                BindableProperty.CreateAttached("ScrollY", typeof(ICommand), typeof(Scrolled), null, propertyChanged:OnScrollYChanged);
            
            public static ICommand GetScrollY(BindableObject bindableObject)
            {
                return (ICommand)bindableObject.GetValue(ScrollYProperty);
            }
            
            private static void OnScrollYChanged(BindableObject bindable, object oldValue, object newValue)
            {
                if (bindable is ScrollView target)
                {
                    if (oldValue == null && newValue != null)
                    {
                        target.Scrolled += OnScrolledNotifyScrollY;
                    }
                    else if (oldValue != null && newValue == null)
                    {
                        target.Scrolled -= OnScrolledNotifyScrollY;
                    }
                }
            }
            
            private static void OnScrolledNotifyScrollY(object o, Xamarin.Forms.ScrolledEventArgs eventArgs)
            {
                var command = GetScrollY((BindableObject)o);
                if (command.CanExecute(eventArgs.ScrollY))
                    command.Execute(eventArgs.ScrollY);
            }
            #endregion
		}
		#endregion
        
        #region ScrollToRequested
        public static readonly BindableProperty ScrollToRequestedProperty =
            BindableProperty.CreateAttached("ScrollToRequested", typeof(ICommand), typeof(ScrollViews), null, propertyChanged:OnScrollToRequestedChanged);
        
        public static ICommand GetScrollToRequested(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ScrollToRequestedProperty);
        }
        
        private static void OnScrollToRequestedChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is ScrollView target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.ScrollToRequested += OnScrollToRequested;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.ScrollToRequested -= OnScrollToRequested;
                }
            }
        }
        
        private static void OnScrollToRequested(object o, EventArgs eventArgs)
        {
            var command = GetScrollToRequested((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion

		#region ScrollToRequested Properties
		public static partial class ScrollToRequested {
            
            #region Element
            public static readonly BindableProperty ElementProperty =
                BindableProperty.CreateAttached("Element", typeof(ICommand), typeof(ScrollToRequested), null, propertyChanged:OnElementChanged);
            
            public static ICommand GetElement(BindableObject bindableObject)
            {
                return (ICommand)bindableObject.GetValue(ElementProperty);
            }
            
            private static void OnElementChanged(BindableObject bindable, object oldValue, object newValue)
            {
                if (bindable is ScrollView target)
                {
                    if (oldValue == null && newValue != null)
                    {
                        target.ScrollToRequested += OnScrollToRequestedNotifyElement;
                    }
                    else if (oldValue != null && newValue == null)
                    {
                        target.ScrollToRequested -= OnScrollToRequestedNotifyElement;
                    }
                }
            }
            
            private static void OnScrollToRequestedNotifyElement(object o, Xamarin.Forms.ScrollToRequestedEventArgs eventArgs)
            {
                var command = GetElement((BindableObject)o);
                if (command.CanExecute(eventArgs.Element))
                    command.Execute(eventArgs.Element);
            }
            #endregion
            
            #region Mode
            public static readonly BindableProperty ModeProperty =
                BindableProperty.CreateAttached("Mode", typeof(ICommand), typeof(ScrollToRequested), null, propertyChanged:OnModeChanged);
            
            public static ICommand GetMode(BindableObject bindableObject)
            {
                return (ICommand)bindableObject.GetValue(ModeProperty);
            }
            
            private static void OnModeChanged(BindableObject bindable, object oldValue, object newValue)
            {
                if (bindable is ScrollView target)
                {
                    if (oldValue == null && newValue != null)
                    {
                        target.ScrollToRequested += OnScrollToRequestedNotifyMode;
                    }
                    else if (oldValue != null && newValue == null)
                    {
                        target.ScrollToRequested -= OnScrollToRequestedNotifyMode;
                    }
                }
            }
            
            private static void OnScrollToRequestedNotifyMode(object o, Xamarin.Forms.ScrollToRequestedEventArgs eventArgs)
            {
                var command = GetMode((BindableObject)o);
                if (command.CanExecute(eventArgs.Mode))
                    command.Execute(eventArgs.Mode);
            }
            #endregion
            
            #region Position
            public static readonly BindableProperty PositionProperty =
                BindableProperty.CreateAttached("Position", typeof(ICommand), typeof(ScrollToRequested), null, propertyChanged:OnPositionChanged);
            
            public static ICommand GetPosition(BindableObject bindableObject)
            {
                return (ICommand)bindableObject.GetValue(PositionProperty);
            }
            
            private static void OnPositionChanged(BindableObject bindable, object oldValue, object newValue)
            {
                if (bindable is ScrollView target)
                {
                    if (oldValue == null && newValue != null)
                    {
                        target.ScrollToRequested += OnScrollToRequestedNotifyPosition;
                    }
                    else if (oldValue != null && newValue == null)
                    {
                        target.ScrollToRequested -= OnScrollToRequestedNotifyPosition;
                    }
                }
            }
            
            private static void OnScrollToRequestedNotifyPosition(object o, Xamarin.Forms.ScrollToRequestedEventArgs eventArgs)
            {
                var command = GetPosition((BindableObject)o);
                if (command.CanExecute(eventArgs.Position))
                    command.Execute(eventArgs.Position);
            }
            #endregion
            
            #region ScrollX
            public static readonly BindableProperty ScrollXProperty =
                BindableProperty.CreateAttached("ScrollX", typeof(ICommand), typeof(ScrollToRequested), null, propertyChanged:OnScrollXChanged);
            
            public static ICommand GetScrollX(BindableObject bindableObject)
            {
                return (ICommand)bindableObject.GetValue(ScrollXProperty);
            }
            
            private static void OnScrollXChanged(BindableObject bindable, object oldValue, object newValue)
            {
                if (bindable is ScrollView target)
                {
                    if (oldValue == null && newValue != null)
                    {
                        target.ScrollToRequested += OnScrollToRequestedNotifyScrollX;
                    }
                    else if (oldValue != null && newValue == null)
                    {
                        target.ScrollToRequested -= OnScrollToRequestedNotifyScrollX;
                    }
                }
            }
            
            private static void OnScrollToRequestedNotifyScrollX(object o, Xamarin.Forms.ScrollToRequestedEventArgs eventArgs)
            {
                var command = GetScrollX((BindableObject)o);
                if (command.CanExecute(eventArgs.ScrollX))
                    command.Execute(eventArgs.ScrollX);
            }
            #endregion
            
            #region ScrollY
            public static readonly BindableProperty ScrollYProperty =
                BindableProperty.CreateAttached("ScrollY", typeof(ICommand), typeof(ScrollToRequested), null, propertyChanged:OnScrollYChanged);
            
            public static ICommand GetScrollY(BindableObject bindableObject)
            {
                return (ICommand)bindableObject.GetValue(ScrollYProperty);
            }
            
            private static void OnScrollYChanged(BindableObject bindable, object oldValue, object newValue)
            {
                if (bindable is ScrollView target)
                {
                    if (oldValue == null && newValue != null)
                    {
                        target.ScrollToRequested += OnScrollToRequestedNotifyScrollY;
                    }
                    else if (oldValue != null && newValue == null)
                    {
                        target.ScrollToRequested -= OnScrollToRequestedNotifyScrollY;
                    }
                }
            }
            
            private static void OnScrollToRequestedNotifyScrollY(object o, Xamarin.Forms.ScrollToRequestedEventArgs eventArgs)
            {
                var command = GetScrollY((BindableObject)o);
                if (command.CanExecute(eventArgs.ScrollY))
                    command.Execute(eventArgs.ScrollY);
            }
            #endregion
            
            #region ShouldAnimate
            public static readonly BindableProperty ShouldAnimateProperty =
                BindableProperty.CreateAttached("ShouldAnimate", typeof(ICommand), typeof(ScrollToRequested), null, propertyChanged:OnShouldAnimateChanged);
            
            public static ICommand GetShouldAnimate(BindableObject bindableObject)
            {
                return (ICommand)bindableObject.GetValue(ShouldAnimateProperty);
            }
            
            private static void OnShouldAnimateChanged(BindableObject bindable, object oldValue, object newValue)
            {
                if (bindable is ScrollView target)
                {
                    if (oldValue == null && newValue != null)
                    {
                        target.ScrollToRequested += OnScrollToRequestedNotifyShouldAnimate;
                    }
                    else if (oldValue != null && newValue == null)
                    {
                        target.ScrollToRequested -= OnScrollToRequestedNotifyShouldAnimate;
                    }
                }
            }
            
            private static void OnScrollToRequestedNotifyShouldAnimate(object o, Xamarin.Forms.ScrollToRequestedEventArgs eventArgs)
            {
                var command = GetShouldAnimate((BindableObject)o);
                if (command.CanExecute(eventArgs.ShouldAnimate))
                    command.Execute(eventArgs.ShouldAnimate);
            }
            #endregion
		}
		#endregion
	}
	#endregion

	#region SearchBars
	public static partial class SearchBars {
        
        #region SearchButtonPressed
        public static readonly BindableProperty SearchButtonPressedProperty =
            BindableProperty.CreateAttached("SearchButtonPressed", typeof(ICommand), typeof(SearchBars), null, propertyChanged:OnSearchButtonPressedChanged);
        
        public static ICommand GetSearchButtonPressed(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(SearchButtonPressedProperty);
        }
        
        private static void OnSearchButtonPressedChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is SearchBar target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.SearchButtonPressed += OnSearchButtonPressed;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.SearchButtonPressed -= OnSearchButtonPressed;
                }
            }
        }
        
        private static void OnSearchButtonPressed(object o, EventArgs eventArgs)
        {
            var command = GetSearchButtonPressed((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region TextChanged
        public static readonly BindableProperty TextChangedProperty =
            BindableProperty.CreateAttached("TextChanged", typeof(ICommand), typeof(SearchBars), null, propertyChanged:OnTextChangedChanged);
        
        public static ICommand GetTextChanged(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(TextChangedProperty);
        }
        
        private static void OnTextChangedChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is SearchBar target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.TextChanged += OnTextChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.TextChanged -= OnTextChanged;
                }
            }
        }
        
        private static void OnTextChanged(object o, EventArgs eventArgs)
        {
            var command = GetTextChanged((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion

		#region TextChanged Properties
		public static partial class TextChanged {
            
            #region NewTextValue
            public static readonly BindableProperty NewTextValueProperty =
                BindableProperty.CreateAttached("NewTextValue", typeof(ICommand), typeof(TextChanged), null, propertyChanged:OnNewTextValueChanged);
            
            public static ICommand GetNewTextValue(BindableObject bindableObject)
            {
                return (ICommand)bindableObject.GetValue(NewTextValueProperty);
            }
            
            private static void OnNewTextValueChanged(BindableObject bindable, object oldValue, object newValue)
            {
                if (bindable is SearchBar target)
                {
                    if (oldValue == null && newValue != null)
                    {
                        target.TextChanged += OnTextChangedNotifyNewTextValue;
                    }
                    else if (oldValue != null && newValue == null)
                    {
                        target.TextChanged -= OnTextChangedNotifyNewTextValue;
                    }
                }
            }
            
            private static void OnTextChangedNotifyNewTextValue(object o, Xamarin.Forms.TextChangedEventArgs eventArgs)
            {
                var command = GetNewTextValue((BindableObject)o);
                if (command.CanExecute(eventArgs.NewTextValue))
                    command.Execute(eventArgs.NewTextValue);
            }
            #endregion
            
            #region OldTextValue
            public static readonly BindableProperty OldTextValueProperty =
                BindableProperty.CreateAttached("OldTextValue", typeof(ICommand), typeof(TextChanged), null, propertyChanged:OnOldTextValueChanged);
            
            public static ICommand GetOldTextValue(BindableObject bindableObject)
            {
                return (ICommand)bindableObject.GetValue(OldTextValueProperty);
            }
            
            private static void OnOldTextValueChanged(BindableObject bindable, object oldValue, object newValue)
            {
                if (bindable is SearchBar target)
                {
                    if (oldValue == null && newValue != null)
                    {
                        target.TextChanged += OnTextChangedNotifyOldTextValue;
                    }
                    else if (oldValue != null && newValue == null)
                    {
                        target.TextChanged -= OnTextChangedNotifyOldTextValue;
                    }
                }
            }
            
            private static void OnTextChangedNotifyOldTextValue(object o, Xamarin.Forms.TextChangedEventArgs eventArgs)
            {
                var command = GetOldTextValue((BindableObject)o);
                if (command.CanExecute(eventArgs.OldTextValue))
                    command.Execute(eventArgs.OldTextValue);
            }
            #endregion
		}
		#endregion
	}
	#endregion

	#region Sliders
	public static partial class Sliders {
        
        #region ValueChanged
        public static readonly BindableProperty ValueChangedProperty =
            BindableProperty.CreateAttached("ValueChanged", typeof(ICommand), typeof(Sliders), null, propertyChanged:OnValueChangedChanged);
        
        public static ICommand GetValueChanged(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ValueChangedProperty);
        }
        
        private static void OnValueChangedChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Slider target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.ValueChanged += OnValueChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.ValueChanged -= OnValueChanged;
                }
            }
        }
        
        private static void OnValueChanged(object o, EventArgs eventArgs)
        {
            var command = GetValueChanged((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion

		#region ValueChanged Properties
		public static partial class ValueChanged {
            
            #region NewValue
            public static readonly BindableProperty NewValueProperty =
                BindableProperty.CreateAttached("NewValue", typeof(ICommand), typeof(ValueChanged), null, propertyChanged:OnNewValueChanged);
            
            public static ICommand GetNewValue(BindableObject bindableObject)
            {
                return (ICommand)bindableObject.GetValue(NewValueProperty);
            }
            
            private static void OnNewValueChanged(BindableObject bindable, object oldValue, object newValue)
            {
                if (bindable is Slider target)
                {
                    if (oldValue == null && newValue != null)
                    {
                        target.ValueChanged += OnValueChangedNotifyNewValue;
                    }
                    else if (oldValue != null && newValue == null)
                    {
                        target.ValueChanged -= OnValueChangedNotifyNewValue;
                    }
                }
            }
            
            private static void OnValueChangedNotifyNewValue(object o, Xamarin.Forms.ValueChangedEventArgs eventArgs)
            {
                var command = GetNewValue((BindableObject)o);
                if (command.CanExecute(eventArgs.NewValue))
                    command.Execute(eventArgs.NewValue);
            }
            #endregion
            
            #region OldValue
            public static readonly BindableProperty OldValueProperty =
                BindableProperty.CreateAttached("OldValue", typeof(ICommand), typeof(ValueChanged), null, propertyChanged:OnOldValueChanged);
            
            public static ICommand GetOldValue(BindableObject bindableObject)
            {
                return (ICommand)bindableObject.GetValue(OldValueProperty);
            }
            
            private static void OnOldValueChanged(BindableObject bindable, object oldValue, object newValue)
            {
                if (bindable is Slider target)
                {
                    if (oldValue == null && newValue != null)
                    {
                        target.ValueChanged += OnValueChangedNotifyOldValue;
                    }
                    else if (oldValue != null && newValue == null)
                    {
                        target.ValueChanged -= OnValueChangedNotifyOldValue;
                    }
                }
            }
            
            private static void OnValueChangedNotifyOldValue(object o, Xamarin.Forms.ValueChangedEventArgs eventArgs)
            {
                var command = GetOldValue((BindableObject)o);
                if (command.CanExecute(eventArgs.OldValue))
                    command.Execute(eventArgs.OldValue);
            }
            #endregion
		}
		#endregion
	}
	#endregion

	#region Steppers
	public static partial class Steppers {
        
        #region ValueChanged
        public static readonly BindableProperty ValueChangedProperty =
            BindableProperty.CreateAttached("ValueChanged", typeof(ICommand), typeof(Steppers), null, propertyChanged:OnValueChangedChanged);
        
        public static ICommand GetValueChanged(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ValueChangedProperty);
        }
        
        private static void OnValueChangedChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Stepper target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.ValueChanged += OnValueChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.ValueChanged -= OnValueChanged;
                }
            }
        }
        
        private static void OnValueChanged(object o, EventArgs eventArgs)
        {
            var command = GetValueChanged((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion

		#region ValueChanged Properties
		public static partial class ValueChanged {
            
            #region NewValue
            public static readonly BindableProperty NewValueProperty =
                BindableProperty.CreateAttached("NewValue", typeof(ICommand), typeof(ValueChanged), null, propertyChanged:OnNewValueChanged);
            
            public static ICommand GetNewValue(BindableObject bindableObject)
            {
                return (ICommand)bindableObject.GetValue(NewValueProperty);
            }
            
            private static void OnNewValueChanged(BindableObject bindable, object oldValue, object newValue)
            {
                if (bindable is Stepper target)
                {
                    if (oldValue == null && newValue != null)
                    {
                        target.ValueChanged += OnValueChangedNotifyNewValue;
                    }
                    else if (oldValue != null && newValue == null)
                    {
                        target.ValueChanged -= OnValueChangedNotifyNewValue;
                    }
                }
            }
            
            private static void OnValueChangedNotifyNewValue(object o, Xamarin.Forms.ValueChangedEventArgs eventArgs)
            {
                var command = GetNewValue((BindableObject)o);
                if (command.CanExecute(eventArgs.NewValue))
                    command.Execute(eventArgs.NewValue);
            }
            #endregion
            
            #region OldValue
            public static readonly BindableProperty OldValueProperty =
                BindableProperty.CreateAttached("OldValue", typeof(ICommand), typeof(ValueChanged), null, propertyChanged:OnOldValueChanged);
            
            public static ICommand GetOldValue(BindableObject bindableObject)
            {
                return (ICommand)bindableObject.GetValue(OldValueProperty);
            }
            
            private static void OnOldValueChanged(BindableObject bindable, object oldValue, object newValue)
            {
                if (bindable is Stepper target)
                {
                    if (oldValue == null && newValue != null)
                    {
                        target.ValueChanged += OnValueChangedNotifyOldValue;
                    }
                    else if (oldValue != null && newValue == null)
                    {
                        target.ValueChanged -= OnValueChangedNotifyOldValue;
                    }
                }
            }
            
            private static void OnValueChangedNotifyOldValue(object o, Xamarin.Forms.ValueChangedEventArgs eventArgs)
            {
                var command = GetOldValue((BindableObject)o);
                if (command.CanExecute(eventArgs.OldValue))
                    command.Execute(eventArgs.OldValue);
            }
            #endregion
		}
		#endregion
	}
	#endregion

	#region Switchs
	public static partial class Switchs {
        
        #region Toggled
        public static readonly BindableProperty ToggledProperty =
            BindableProperty.CreateAttached("Toggled", typeof(ICommand), typeof(Switchs), null, propertyChanged:OnToggledChanged);
        
        public static ICommand GetToggled(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ToggledProperty);
        }
        
        private static void OnToggledChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Switch target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.Toggled += OnToggled;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.Toggled -= OnToggled;
                }
            }
        }
        
        private static void OnToggled(object o, EventArgs eventArgs)
        {
            var command = GetToggled((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion

		#region Toggled Properties
		public static partial class Toggled {
            
            #region Value
            public static readonly BindableProperty ValueProperty =
                BindableProperty.CreateAttached("Value", typeof(ICommand), typeof(Toggled), null, propertyChanged:OnValueChanged);
            
            public static ICommand GetValue(BindableObject bindableObject)
            {
                return (ICommand)bindableObject.GetValue(ValueProperty);
            }
            
            private static void OnValueChanged(BindableObject bindable, object oldValue, object newValue)
            {
                if (bindable is Switch target)
                {
                    if (oldValue == null && newValue != null)
                    {
                        target.Toggled += OnToggledNotifyValue;
                    }
                    else if (oldValue != null && newValue == null)
                    {
                        target.Toggled -= OnToggledNotifyValue;
                    }
                }
            }
            
            private static void OnToggledNotifyValue(object o, Xamarin.Forms.ToggledEventArgs eventArgs)
            {
                var command = GetValue((BindableObject)o);
                if (command.CanExecute(eventArgs.Value))
                    command.Execute(eventArgs.Value);
            }
            #endregion
		}
		#endregion
	}
	#endregion

	#region SwitchCells
	public static partial class SwitchCells {
        
        #region OnChanged
        public static readonly BindableProperty OnChangedProperty =
            BindableProperty.CreateAttached("OnChanged", typeof(ICommand), typeof(SwitchCells), null, propertyChanged:OnOnChangedChanged);
        
        public static ICommand GetOnChanged(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(OnChangedProperty);
        }
        
        private static void OnOnChangedChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is SwitchCell target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.OnChanged += OnOnChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.OnChanged -= OnOnChanged;
                }
            }
        }
        
        private static void OnOnChanged(object o, EventArgs eventArgs)
        {
            var command = GetOnChanged((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion

		#region OnChanged Properties
		public static partial class OnChanged {
            
            #region Value
            public static readonly BindableProperty ValueProperty =
                BindableProperty.CreateAttached("Value", typeof(ICommand), typeof(OnChanged), null, propertyChanged:OnValueChanged);
            
            public static ICommand GetValue(BindableObject bindableObject)
            {
                return (ICommand)bindableObject.GetValue(ValueProperty);
            }
            
            private static void OnValueChanged(BindableObject bindable, object oldValue, object newValue)
            {
                if (bindable is SwitchCell target)
                {
                    if (oldValue == null && newValue != null)
                    {
                        target.OnChanged += OnOnChangedNotifyValue;
                    }
                    else if (oldValue != null && newValue == null)
                    {
                        target.OnChanged -= OnOnChangedNotifyValue;
                    }
                }
            }
            
            private static void OnOnChangedNotifyValue(object o, Xamarin.Forms.ToggledEventArgs eventArgs)
            {
                var command = GetValue((BindableObject)o);
                if (command.CanExecute(eventArgs.Value))
                    command.Execute(eventArgs.Value);
            }
            #endregion
		}
		#endregion
	}
	#endregion

	#region TableViews
	public static partial class TableViews {
        
        #region ModelChanged
        public static readonly BindableProperty ModelChangedProperty =
            BindableProperty.CreateAttached("ModelChanged", typeof(ICommand), typeof(TableViews), null, propertyChanged:OnModelChangedChanged);
        
        public static ICommand GetModelChanged(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ModelChangedProperty);
        }
        
        private static void OnModelChangedChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is TableView target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.ModelChanged += OnModelChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.ModelChanged -= OnModelChanged;
                }
            }
        }
        
        private static void OnModelChanged(object o, EventArgs eventArgs)
        {
            var command = GetModelChanged((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
	}
	#endregion

	#region TapGestureRecognizers
	public static partial class TapGestureRecognizers {
        
        #region Tapped
        public static readonly BindableProperty TappedProperty =
            BindableProperty.CreateAttached("Tapped", typeof(ICommand), typeof(TapGestureRecognizers), null, propertyChanged:OnTappedChanged);
        
        public static ICommand GetTapped(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(TappedProperty);
        }
        
        private static void OnTappedChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is TapGestureRecognizer target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.Tapped += OnTapped;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.Tapped -= OnTapped;
                }
            }
        }
        
        private static void OnTapped(object o, EventArgs eventArgs)
        {
            var command = GetTapped((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
	}
	#endregion

	#region VisualElements
	public static partial class VisualElements {
        
        #region BatchCommitted
        public static readonly BindableProperty BatchCommittedProperty =
            BindableProperty.CreateAttached("BatchCommitted", typeof(ICommand), typeof(VisualElements), null, propertyChanged:OnBatchCommittedChanged);
        
        public static ICommand GetBatchCommitted(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(BatchCommittedProperty);
        }
        
        private static void OnBatchCommittedChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is VisualElement target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.BatchCommitted += OnBatchCommitted;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.BatchCommitted -= OnBatchCommitted;
                }
            }
        }
        
        private static void OnBatchCommitted(object o, EventArgs eventArgs)
        {
            var command = GetBatchCommitted((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion

		#region BatchCommitted Properties
		public static partial class BatchCommitted {
            
            #region Data
            public static readonly BindableProperty DataProperty =
                BindableProperty.CreateAttached("Data", typeof(ICommand), typeof(BatchCommitted), null, propertyChanged:OnDataChanged);
            
            public static ICommand GetData(BindableObject bindableObject)
            {
                return (ICommand)bindableObject.GetValue(DataProperty);
            }
            
            private static void OnDataChanged(BindableObject bindable, object oldValue, object newValue)
            {
                if (bindable is VisualElement target)
                {
                    if (oldValue == null && newValue != null)
                    {
                        target.BatchCommitted += OnBatchCommittedNotifyData;
                    }
                    else if (oldValue != null && newValue == null)
                    {
                        target.BatchCommitted -= OnBatchCommittedNotifyData;
                    }
                }
            }
            
            private static void OnBatchCommittedNotifyData(object o, Xamarin.Forms.Internals.EventArg<Xamarin.Forms.VisualElement> eventArgs)
            {
                var command = GetData((BindableObject)o);
                if (command.CanExecute(eventArgs.Data))
                    command.Execute(eventArgs.Data);
            }
            #endregion
		}
		#endregion
        
        #region ChildrenReordered
        public static readonly BindableProperty ChildrenReorderedProperty =
            BindableProperty.CreateAttached("ChildrenReordered", typeof(ICommand), typeof(VisualElements), null, propertyChanged:OnChildrenReorderedChanged);
        
        public static ICommand GetChildrenReordered(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ChildrenReorderedProperty);
        }
        
        private static void OnChildrenReorderedChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is VisualElement target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.ChildrenReordered += OnChildrenReordered;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.ChildrenReordered -= OnChildrenReordered;
                }
            }
        }
        
        private static void OnChildrenReordered(object o, EventArgs eventArgs)
        {
            var command = GetChildrenReordered((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region FocusChangeRequested
        public static readonly BindableProperty FocusChangeRequestedProperty =
            BindableProperty.CreateAttached("FocusChangeRequested", typeof(ICommand), typeof(VisualElements), null, propertyChanged:OnFocusChangeRequestedChanged);
        
        public static ICommand GetFocusChangeRequested(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(FocusChangeRequestedProperty);
        }
        
        private static void OnFocusChangeRequestedChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is VisualElement target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.FocusChangeRequested += OnFocusChangeRequested;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.FocusChangeRequested -= OnFocusChangeRequested;
                }
            }
        }
        
        private static void OnFocusChangeRequested(object o, EventArgs eventArgs)
        {
            var command = GetFocusChangeRequested((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion

		#region FocusChangeRequested Properties
		public static partial class FocusChangeRequested {
            
            #region Focus
            public static readonly BindableProperty FocusProperty =
                BindableProperty.CreateAttached("Focus", typeof(ICommand), typeof(FocusChangeRequested), null, propertyChanged:OnFocusChanged);
            
            public static ICommand GetFocus(BindableObject bindableObject)
            {
                return (ICommand)bindableObject.GetValue(FocusProperty);
            }
            
            private static void OnFocusChanged(BindableObject bindable, object oldValue, object newValue)
            {
                if (bindable is VisualElement target)
                {
                    if (oldValue == null && newValue != null)
                    {
                        target.FocusChangeRequested += OnFocusChangeRequestedNotifyFocus;
                    }
                    else if (oldValue != null && newValue == null)
                    {
                        target.FocusChangeRequested -= OnFocusChangeRequestedNotifyFocus;
                    }
                }
            }
            
            private static void OnFocusChangeRequestedNotifyFocus(object o, Xamarin.Forms.VisualElement.FocusRequestArgs eventArgs)
            {
                var command = GetFocus((BindableObject)o);
                if (command.CanExecute(eventArgs.Focus))
                    command.Execute(eventArgs.Focus);
            }
            #endregion
            
            #region Result
            public static readonly BindableProperty ResultProperty =
                BindableProperty.CreateAttached("Result", typeof(ICommand), typeof(FocusChangeRequested), null, propertyChanged:OnResultChanged);
            
            public static ICommand GetResult(BindableObject bindableObject)
            {
                return (ICommand)bindableObject.GetValue(ResultProperty);
            }
            
            private static void OnResultChanged(BindableObject bindable, object oldValue, object newValue)
            {
                if (bindable is VisualElement target)
                {
                    if (oldValue == null && newValue != null)
                    {
                        target.FocusChangeRequested += OnFocusChangeRequestedNotifyResult;
                    }
                    else if (oldValue != null && newValue == null)
                    {
                        target.FocusChangeRequested -= OnFocusChangeRequestedNotifyResult;
                    }
                }
            }
            
            private static void OnFocusChangeRequestedNotifyResult(object o, Xamarin.Forms.VisualElement.FocusRequestArgs eventArgs)
            {
                var command = GetResult((BindableObject)o);
                if (command.CanExecute(eventArgs.Result))
                    command.Execute(eventArgs.Result);
            }
            #endregion
		}
		#endregion
        
        #region Focused
        public static readonly BindableProperty FocusedProperty =
            BindableProperty.CreateAttached("Focused", typeof(ICommand), typeof(VisualElements), null, propertyChanged:OnFocusedChanged);
        
        public static ICommand GetFocused(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(FocusedProperty);
        }
        
        private static void OnFocusedChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is VisualElement target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.Focused += OnFocused;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.Focused -= OnFocused;
                }
            }
        }
        
        private static void OnFocused(object o, EventArgs eventArgs)
        {
            var command = GetFocused((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion

		#region Focused Properties
		public static partial class Focused {
            
            #region IsFocused
            public static readonly BindableProperty IsFocusedProperty =
                BindableProperty.CreateAttached("IsFocused", typeof(ICommand), typeof(Focused), null, propertyChanged:OnIsFocusedChanged);
            
            public static ICommand GetIsFocused(BindableObject bindableObject)
            {
                return (ICommand)bindableObject.GetValue(IsFocusedProperty);
            }
            
            private static void OnIsFocusedChanged(BindableObject bindable, object oldValue, object newValue)
            {
                if (bindable is VisualElement target)
                {
                    if (oldValue == null && newValue != null)
                    {
                        target.Focused += OnFocusedNotifyIsFocused;
                    }
                    else if (oldValue != null && newValue == null)
                    {
                        target.Focused -= OnFocusedNotifyIsFocused;
                    }
                }
            }
            
            private static void OnFocusedNotifyIsFocused(object o, Xamarin.Forms.FocusEventArgs eventArgs)
            {
                var command = GetIsFocused((BindableObject)o);
                if (command.CanExecute(eventArgs.IsFocused))
                    command.Execute(eventArgs.IsFocused);
            }
            #endregion
            
            #region VisualElement
            public static readonly BindableProperty VisualElementProperty =
                BindableProperty.CreateAttached("VisualElement", typeof(ICommand), typeof(Focused), null, propertyChanged:OnVisualElementChanged);
            
            public static ICommand GetVisualElement(BindableObject bindableObject)
            {
                return (ICommand)bindableObject.GetValue(VisualElementProperty);
            }
            
            private static void OnVisualElementChanged(BindableObject bindable, object oldValue, object newValue)
            {
                if (bindable is VisualElement target)
                {
                    if (oldValue == null && newValue != null)
                    {
                        target.Focused += OnFocusedNotifyVisualElement;
                    }
                    else if (oldValue != null && newValue == null)
                    {
                        target.Focused -= OnFocusedNotifyVisualElement;
                    }
                }
            }
            
            private static void OnFocusedNotifyVisualElement(object o, Xamarin.Forms.FocusEventArgs eventArgs)
            {
                var command = GetVisualElement((BindableObject)o);
                if (command.CanExecute(eventArgs.VisualElement))
                    command.Execute(eventArgs.VisualElement);
            }
            #endregion
		}
		#endregion
        
        #region MeasureInvalidated
        public static readonly BindableProperty MeasureInvalidatedProperty =
            BindableProperty.CreateAttached("MeasureInvalidated", typeof(ICommand), typeof(VisualElements), null, propertyChanged:OnMeasureInvalidatedChanged);
        
        public static ICommand GetMeasureInvalidated(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(MeasureInvalidatedProperty);
        }
        
        private static void OnMeasureInvalidatedChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is VisualElement target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.MeasureInvalidated += OnMeasureInvalidated;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.MeasureInvalidated -= OnMeasureInvalidated;
                }
            }
        }
        
        private static void OnMeasureInvalidated(object o, EventArgs eventArgs)
        {
            var command = GetMeasureInvalidated((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region SizeChanged
        public static readonly BindableProperty SizeChangedProperty =
            BindableProperty.CreateAttached("SizeChanged", typeof(ICommand), typeof(VisualElements), null, propertyChanged:OnSizeChangedChanged);
        
        public static ICommand GetSizeChanged(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(SizeChangedProperty);
        }
        
        private static void OnSizeChangedChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is VisualElement target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.SizeChanged += OnSizeChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.SizeChanged -= OnSizeChanged;
                }
            }
        }
        
        private static void OnSizeChanged(object o, EventArgs eventArgs)
        {
            var command = GetSizeChanged((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region Unfocused
        public static readonly BindableProperty UnfocusedProperty =
            BindableProperty.CreateAttached("Unfocused", typeof(ICommand), typeof(VisualElements), null, propertyChanged:OnUnfocusedChanged);
        
        public static ICommand GetUnfocused(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(UnfocusedProperty);
        }
        
        private static void OnUnfocusedChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is VisualElement target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.Unfocused += OnUnfocused;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.Unfocused -= OnUnfocused;
                }
            }
        }
        
        private static void OnUnfocused(object o, EventArgs eventArgs)
        {
            var command = GetUnfocused((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion

		#region Unfocused Properties
		public static partial class Unfocused {
            
            #region IsFocused
            public static readonly BindableProperty IsFocusedProperty =
                BindableProperty.CreateAttached("IsFocused", typeof(ICommand), typeof(Unfocused), null, propertyChanged:OnIsFocusedChanged);
            
            public static ICommand GetIsFocused(BindableObject bindableObject)
            {
                return (ICommand)bindableObject.GetValue(IsFocusedProperty);
            }
            
            private static void OnIsFocusedChanged(BindableObject bindable, object oldValue, object newValue)
            {
                if (bindable is VisualElement target)
                {
                    if (oldValue == null && newValue != null)
                    {
                        target.Unfocused += OnUnfocusedNotifyIsFocused;
                    }
                    else if (oldValue != null && newValue == null)
                    {
                        target.Unfocused -= OnUnfocusedNotifyIsFocused;
                    }
                }
            }
            
            private static void OnUnfocusedNotifyIsFocused(object o, Xamarin.Forms.FocusEventArgs eventArgs)
            {
                var command = GetIsFocused((BindableObject)o);
                if (command.CanExecute(eventArgs.IsFocused))
                    command.Execute(eventArgs.IsFocused);
            }
            #endregion
            
            #region VisualElement
            public static readonly BindableProperty VisualElementProperty =
                BindableProperty.CreateAttached("VisualElement", typeof(ICommand), typeof(Unfocused), null, propertyChanged:OnVisualElementChanged);
            
            public static ICommand GetVisualElement(BindableObject bindableObject)
            {
                return (ICommand)bindableObject.GetValue(VisualElementProperty);
            }
            
            private static void OnVisualElementChanged(BindableObject bindable, object oldValue, object newValue)
            {
                if (bindable is VisualElement target)
                {
                    if (oldValue == null && newValue != null)
                    {
                        target.Unfocused += OnUnfocusedNotifyVisualElement;
                    }
                    else if (oldValue != null && newValue == null)
                    {
                        target.Unfocused -= OnUnfocusedNotifyVisualElement;
                    }
                }
            }
            
            private static void OnUnfocusedNotifyVisualElement(object o, Xamarin.Forms.FocusEventArgs eventArgs)
            {
                var command = GetVisualElement((BindableObject)o);
                if (command.CanExecute(eventArgs.VisualElement))
                    command.Execute(eventArgs.VisualElement);
            }
            #endregion
		}
		#endregion
	}
	#endregion

	#region WebViews
	public static partial class WebViews {
        
        #region EvalRequested
        public static readonly BindableProperty EvalRequestedProperty =
            BindableProperty.CreateAttached("EvalRequested", typeof(ICommand), typeof(WebViews), null, propertyChanged:OnEvalRequestedChanged);
        
        public static ICommand GetEvalRequested(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(EvalRequestedProperty);
        }
        
        private static void OnEvalRequestedChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is WebView target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.EvalRequested += OnEvalRequested;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.EvalRequested -= OnEvalRequested;
                }
            }
        }
        
        private static void OnEvalRequested(object o, EventArgs eventArgs)
        {
            var command = GetEvalRequested((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion

		#region EvalRequested Properties
		public static partial class EvalRequested {
            
            #region Script
            public static readonly BindableProperty ScriptProperty =
                BindableProperty.CreateAttached("Script", typeof(ICommand), typeof(EvalRequested), null, propertyChanged:OnScriptChanged);
            
            public static ICommand GetScript(BindableObject bindableObject)
            {
                return (ICommand)bindableObject.GetValue(ScriptProperty);
            }
            
            private static void OnScriptChanged(BindableObject bindable, object oldValue, object newValue)
            {
                if (bindable is WebView target)
                {
                    if (oldValue == null && newValue != null)
                    {
                        target.EvalRequested += OnEvalRequestedNotifyScript;
                    }
                    else if (oldValue != null && newValue == null)
                    {
                        target.EvalRequested -= OnEvalRequestedNotifyScript;
                    }
                }
            }
            
            private static void OnEvalRequestedNotifyScript(object o, Xamarin.Forms.Internals.EvalRequested eventArgs)
            {
                var command = GetScript((BindableObject)o);
                if (command.CanExecute(eventArgs.Script))
                    command.Execute(eventArgs.Script);
            }
            #endregion
		}
		#endregion
        
        #region GoBackRequested
        public static readonly BindableProperty GoBackRequestedProperty =
            BindableProperty.CreateAttached("GoBackRequested", typeof(ICommand), typeof(WebViews), null, propertyChanged:OnGoBackRequestedChanged);
        
        public static ICommand GetGoBackRequested(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(GoBackRequestedProperty);
        }
        
        private static void OnGoBackRequestedChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is WebView target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.GoBackRequested += OnGoBackRequested;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.GoBackRequested -= OnGoBackRequested;
                }
            }
        }
        
        private static void OnGoBackRequested(object o, EventArgs eventArgs)
        {
            var command = GetGoBackRequested((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region GoForwardRequested
        public static readonly BindableProperty GoForwardRequestedProperty =
            BindableProperty.CreateAttached("GoForwardRequested", typeof(ICommand), typeof(WebViews), null, propertyChanged:OnGoForwardRequestedChanged);
        
        public static ICommand GetGoForwardRequested(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(GoForwardRequestedProperty);
        }
        
        private static void OnGoForwardRequestedChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is WebView target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.GoForwardRequested += OnGoForwardRequested;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.GoForwardRequested -= OnGoForwardRequested;
                }
            }
        }
        
        private static void OnGoForwardRequested(object o, EventArgs eventArgs)
        {
            var command = GetGoForwardRequested((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion
        
        #region Navigated
        public static readonly BindableProperty NavigatedProperty =
            BindableProperty.CreateAttached("Navigated", typeof(ICommand), typeof(WebViews), null, propertyChanged:OnNavigatedChanged);
        
        public static ICommand GetNavigated(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NavigatedProperty);
        }
        
        private static void OnNavigatedChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is WebView target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.Navigated += OnNavigated;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.Navigated -= OnNavigated;
                }
            }
        }
        
        private static void OnNavigated(object o, EventArgs eventArgs)
        {
            var command = GetNavigated((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion

		#region Navigated Properties
		public static partial class Navigated {
            
            #region Result
            public static readonly BindableProperty ResultProperty =
                BindableProperty.CreateAttached("Result", typeof(ICommand), typeof(Navigated), null, propertyChanged:OnResultChanged);
            
            public static ICommand GetResult(BindableObject bindableObject)
            {
                return (ICommand)bindableObject.GetValue(ResultProperty);
            }
            
            private static void OnResultChanged(BindableObject bindable, object oldValue, object newValue)
            {
                if (bindable is WebView target)
                {
                    if (oldValue == null && newValue != null)
                    {
                        target.Navigated += OnNavigatedNotifyResult;
                    }
                    else if (oldValue != null && newValue == null)
                    {
                        target.Navigated -= OnNavigatedNotifyResult;
                    }
                }
            }
            
            private static void OnNavigatedNotifyResult(object o, Xamarin.Forms.WebNavigatedEventArgs eventArgs)
            {
                var command = GetResult((BindableObject)o);
                if (command.CanExecute(eventArgs.Result))
                    command.Execute(eventArgs.Result);
            }
            #endregion
            
            #region NavigationEvent
            public static readonly BindableProperty NavigationEventProperty =
                BindableProperty.CreateAttached("NavigationEvent", typeof(ICommand), typeof(Navigated), null, propertyChanged:OnNavigationEventChanged);
            
            public static ICommand GetNavigationEvent(BindableObject bindableObject)
            {
                return (ICommand)bindableObject.GetValue(NavigationEventProperty);
            }
            
            private static void OnNavigationEventChanged(BindableObject bindable, object oldValue, object newValue)
            {
                if (bindable is WebView target)
                {
                    if (oldValue == null && newValue != null)
                    {
                        target.Navigated += OnNavigatedNotifyNavigationEvent;
                    }
                    else if (oldValue != null && newValue == null)
                    {
                        target.Navigated -= OnNavigatedNotifyNavigationEvent;
                    }
                }
            }
            
            private static void OnNavigatedNotifyNavigationEvent(object o, Xamarin.Forms.WebNavigatedEventArgs eventArgs)
            {
                var command = GetNavigationEvent((BindableObject)o);
                if (command.CanExecute(eventArgs.NavigationEvent))
                    command.Execute(eventArgs.NavigationEvent);
            }
            #endregion
            
            #region Source
            public static readonly BindableProperty SourceProperty =
                BindableProperty.CreateAttached("Source", typeof(ICommand), typeof(Navigated), null, propertyChanged:OnSourceChanged);
            
            public static ICommand GetSource(BindableObject bindableObject)
            {
                return (ICommand)bindableObject.GetValue(SourceProperty);
            }
            
            private static void OnSourceChanged(BindableObject bindable, object oldValue, object newValue)
            {
                if (bindable is WebView target)
                {
                    if (oldValue == null && newValue != null)
                    {
                        target.Navigated += OnNavigatedNotifySource;
                    }
                    else if (oldValue != null && newValue == null)
                    {
                        target.Navigated -= OnNavigatedNotifySource;
                    }
                }
            }
            
            private static void OnNavigatedNotifySource(object o, Xamarin.Forms.WebNavigatedEventArgs eventArgs)
            {
                var command = GetSource((BindableObject)o);
                if (command.CanExecute(eventArgs.Source))
                    command.Execute(eventArgs.Source);
            }
            #endregion
            
            #region Url
            public static readonly BindableProperty UrlProperty =
                BindableProperty.CreateAttached("Url", typeof(ICommand), typeof(Navigated), null, propertyChanged:OnUrlChanged);
            
            public static ICommand GetUrl(BindableObject bindableObject)
            {
                return (ICommand)bindableObject.GetValue(UrlProperty);
            }
            
            private static void OnUrlChanged(BindableObject bindable, object oldValue, object newValue)
            {
                if (bindable is WebView target)
                {
                    if (oldValue == null && newValue != null)
                    {
                        target.Navigated += OnNavigatedNotifyUrl;
                    }
                    else if (oldValue != null && newValue == null)
                    {
                        target.Navigated -= OnNavigatedNotifyUrl;
                    }
                }
            }
            
            private static void OnNavigatedNotifyUrl(object o, Xamarin.Forms.WebNavigatedEventArgs eventArgs)
            {
                var command = GetUrl((BindableObject)o);
                if (command.CanExecute(eventArgs.Url))
                    command.Execute(eventArgs.Url);
            }
            #endregion
		}
		#endregion
        
        #region Navigating
        public static readonly BindableProperty NavigatingProperty =
            BindableProperty.CreateAttached("Navigating", typeof(ICommand), typeof(WebViews), null, propertyChanged:OnNavigatingChanged);
        
        public static ICommand GetNavigating(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NavigatingProperty);
        }
        
        private static void OnNavigatingChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is WebView target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.Navigating += OnNavigating;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.Navigating -= OnNavigating;
                }
            }
        }
        
        private static void OnNavigating(object o, EventArgs eventArgs)
        {
            var command = GetNavigating((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
        #endregion

		#region Navigating Properties
		public static partial class Navigating {
            
            #region Cancel
            public static readonly BindableProperty CancelProperty =
                BindableProperty.CreateAttached("Cancel", typeof(ICommand), typeof(Navigating), null, propertyChanged:OnCancelChanged);
            
            public static ICommand GetCancel(BindableObject bindableObject)
            {
                return (ICommand)bindableObject.GetValue(CancelProperty);
            }
            
            private static void OnCancelChanged(BindableObject bindable, object oldValue, object newValue)
            {
                if (bindable is WebView target)
                {
                    if (oldValue == null && newValue != null)
                    {
                        target.Navigating += OnNavigatingNotifyCancel;
                    }
                    else if (oldValue != null && newValue == null)
                    {
                        target.Navigating -= OnNavigatingNotifyCancel;
                    }
                }
            }
            
            private static void OnNavigatingNotifyCancel(object o, Xamarin.Forms.WebNavigatingEventArgs eventArgs)
            {
                var command = GetCancel((BindableObject)o);
                if (command.CanExecute(eventArgs.Cancel))
                    command.Execute(eventArgs.Cancel);
            }
            #endregion
            
            #region NavigationEvent
            public static readonly BindableProperty NavigationEventProperty =
                BindableProperty.CreateAttached("NavigationEvent", typeof(ICommand), typeof(Navigating), null, propertyChanged:OnNavigationEventChanged);
            
            public static ICommand GetNavigationEvent(BindableObject bindableObject)
            {
                return (ICommand)bindableObject.GetValue(NavigationEventProperty);
            }
            
            private static void OnNavigationEventChanged(BindableObject bindable, object oldValue, object newValue)
            {
                if (bindable is WebView target)
                {
                    if (oldValue == null && newValue != null)
                    {
                        target.Navigating += OnNavigatingNotifyNavigationEvent;
                    }
                    else if (oldValue != null && newValue == null)
                    {
                        target.Navigating -= OnNavigatingNotifyNavigationEvent;
                    }
                }
            }
            
            private static void OnNavigatingNotifyNavigationEvent(object o, Xamarin.Forms.WebNavigatingEventArgs eventArgs)
            {
                var command = GetNavigationEvent((BindableObject)o);
                if (command.CanExecute(eventArgs.NavigationEvent))
                    command.Execute(eventArgs.NavigationEvent);
            }
            #endregion
            
            #region Source
            public static readonly BindableProperty SourceProperty =
                BindableProperty.CreateAttached("Source", typeof(ICommand), typeof(Navigating), null, propertyChanged:OnSourceChanged);
            
            public static ICommand GetSource(BindableObject bindableObject)
            {
                return (ICommand)bindableObject.GetValue(SourceProperty);
            }
            
            private static void OnSourceChanged(BindableObject bindable, object oldValue, object newValue)
            {
                if (bindable is WebView target)
                {
                    if (oldValue == null && newValue != null)
                    {
                        target.Navigating += OnNavigatingNotifySource;
                    }
                    else if (oldValue != null && newValue == null)
                    {
                        target.Navigating -= OnNavigatingNotifySource;
                    }
                }
            }
            
            private static void OnNavigatingNotifySource(object o, Xamarin.Forms.WebNavigatingEventArgs eventArgs)
            {
                var command = GetSource((BindableObject)o);
                if (command.CanExecute(eventArgs.Source))
                    command.Execute(eventArgs.Source);
            }
            #endregion
            
            #region Url
            public static readonly BindableProperty UrlProperty =
                BindableProperty.CreateAttached("Url", typeof(ICommand), typeof(Navigating), null, propertyChanged:OnUrlChanged);
            
            public static ICommand GetUrl(BindableObject bindableObject)
            {
                return (ICommand)bindableObject.GetValue(UrlProperty);
            }
            
            private static void OnUrlChanged(BindableObject bindable, object oldValue, object newValue)
            {
                if (bindable is WebView target)
                {
                    if (oldValue == null && newValue != null)
                    {
                        target.Navigating += OnNavigatingNotifyUrl;
                    }
                    else if (oldValue != null && newValue == null)
                    {
                        target.Navigating -= OnNavigatingNotifyUrl;
                    }
                }
            }
            
            private static void OnNavigatingNotifyUrl(object o, Xamarin.Forms.WebNavigatingEventArgs eventArgs)
            {
                var command = GetUrl((BindableObject)o);
                if (command.CanExecute(eventArgs.Url))
                    command.Execute(eventArgs.Url);
            }
            #endregion
		}
		#endregion
	}
	#endregion
}
