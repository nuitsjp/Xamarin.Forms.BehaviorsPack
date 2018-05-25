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
            if (command.CanExecute(null))
                command.Execute(null);
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
            if (command.CanExecute(null))
                command.Execute(null);
        }
        #endregion
        
        #region ModalPoppingNotifyCancel
        public static readonly BindableProperty ModalPoppingNotifyCancelProperty =
            BindableProperty.CreateAttached("ModalPoppingNotifyCancel", typeof(ICommand), typeof(Applications), null, propertyChanged:OnModalPoppingNotifyCancelChanged);
        
        public static ICommand GetModalPoppingNotifyCancel(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ModalPoppingNotifyCancelProperty);
        }
        
        private static void OnModalPoppingNotifyCancelChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetModalPoppingNotifyCancel((BindableObject)o);
            if (command.CanExecute(eventArgs.Cancel))
                command.Execute(eventArgs.Cancel);
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
            if (command.CanExecute(null))
                command.Execute(null);
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
            if (command.CanExecute(null))
                command.Execute(null);
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
            if (command.CanExecute(null))
                command.Execute(null);
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
            if (command.CanExecute(null))
                command.Execute(null);
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
            if (command.CanExecute(null))
                command.Execute(null);
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
            if (command.CanExecute(null))
                command.Execute(null);
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
            if (command.CanExecute(null))
                command.Execute(null);
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
            if (command.CanExecute(null))
                command.Execute(null);
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
            if (command.CanExecute(null))
                command.Execute(null);
        }
        #endregion
	}
	#endregion

	#region ClickGestureRecognizers
	public static partial class ClickGestureRecognizers {
        
        #region Clicked
        public static readonly BindableProperty ClickedProperty =
            BindableProperty.CreateAttached("Clicked", typeof(ICommand), typeof(ClickGestureRecognizers), null, propertyChanged:OnClickedChanged);
        
        public static ICommand GetClicked(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ClickedProperty);
        }
        
        private static void OnClickedChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is ClickGestureRecognizer target)
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
            if (command.CanExecute(null))
                command.Execute(null);
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
            if (command.CanExecute(null))
                command.Execute(null);
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
            if (command.CanExecute(null))
                command.Execute(null);
        }
        #endregion
        
        #region DateSelectedNotifyNewDate
        public static readonly BindableProperty DateSelectedNotifyNewDateProperty =
            BindableProperty.CreateAttached("DateSelectedNotifyNewDate", typeof(ICommand), typeof(DatePickers), null, propertyChanged:OnDateSelectedNotifyNewDateChanged);
        
        public static ICommand GetDateSelectedNotifyNewDate(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(DateSelectedNotifyNewDateProperty);
        }
        
        private static void OnDateSelectedNotifyNewDateChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetDateSelectedNotifyNewDate((BindableObject)o);
            if (command.CanExecute(eventArgs.NewDate))
                command.Execute(eventArgs.NewDate);
        }
        #endregion
        
        #region DateSelectedNotifyOldDate
        public static readonly BindableProperty DateSelectedNotifyOldDateProperty =
            BindableProperty.CreateAttached("DateSelectedNotifyOldDate", typeof(ICommand), typeof(DatePickers), null, propertyChanged:OnDateSelectedNotifyOldDateChanged);
        
        public static ICommand GetDateSelectedNotifyOldDate(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(DateSelectedNotifyOldDateProperty);
        }
        
        private static void OnDateSelectedNotifyOldDateChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetDateSelectedNotifyOldDate((BindableObject)o);
            if (command.CanExecute(eventArgs.OldDate))
                command.Execute(eventArgs.OldDate);
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
            if (command.CanExecute(null))
                command.Execute(null);
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
            if (command.CanExecute(null))
                command.Execute(null);
        }
        #endregion
        
        #region TextChangedNotifyNewTextValue
        public static readonly BindableProperty TextChangedNotifyNewTextValueProperty =
            BindableProperty.CreateAttached("TextChangedNotifyNewTextValue", typeof(ICommand), typeof(Editors), null, propertyChanged:OnTextChangedNotifyNewTextValueChanged);
        
        public static ICommand GetTextChangedNotifyNewTextValue(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(TextChangedNotifyNewTextValueProperty);
        }
        
        private static void OnTextChangedNotifyNewTextValueChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetTextChangedNotifyNewTextValue((BindableObject)o);
            if (command.CanExecute(eventArgs.NewTextValue))
                command.Execute(eventArgs.NewTextValue);
        }
        #endregion
        
        #region TextChangedNotifyOldTextValue
        public static readonly BindableProperty TextChangedNotifyOldTextValueProperty =
            BindableProperty.CreateAttached("TextChangedNotifyOldTextValue", typeof(ICommand), typeof(Editors), null, propertyChanged:OnTextChangedNotifyOldTextValueChanged);
        
        public static ICommand GetTextChangedNotifyOldTextValue(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(TextChangedNotifyOldTextValueProperty);
        }
        
        private static void OnTextChangedNotifyOldTextValueChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetTextChangedNotifyOldTextValue((BindableObject)o);
            if (command.CanExecute(eventArgs.OldTextValue))
                command.Execute(eventArgs.OldTextValue);
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
            if (command.CanExecute(null))
                command.Execute(null);
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
            if (command.CanExecute(null))
                command.Execute(null);
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
            if (command.CanExecute(null))
                command.Execute(null);
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
            if (command.CanExecute(null))
                command.Execute(null);
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
            if (command.CanExecute(null))
                command.Execute(null);
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
            if (command.CanExecute(null))
                command.Execute(null);
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
            if (command.CanExecute(null))
                command.Execute(null);
        }
        #endregion
        
        #region TextChangedNotifyNewTextValue
        public static readonly BindableProperty TextChangedNotifyNewTextValueProperty =
            BindableProperty.CreateAttached("TextChangedNotifyNewTextValue", typeof(ICommand), typeof(Entries), null, propertyChanged:OnTextChangedNotifyNewTextValueChanged);
        
        public static ICommand GetTextChangedNotifyNewTextValue(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(TextChangedNotifyNewTextValueProperty);
        }
        
        private static void OnTextChangedNotifyNewTextValueChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetTextChangedNotifyNewTextValue((BindableObject)o);
            if (command.CanExecute(eventArgs.NewTextValue))
                command.Execute(eventArgs.NewTextValue);
        }
        #endregion
        
        #region TextChangedNotifyOldTextValue
        public static readonly BindableProperty TextChangedNotifyOldTextValueProperty =
            BindableProperty.CreateAttached("TextChangedNotifyOldTextValue", typeof(ICommand), typeof(Entries), null, propertyChanged:OnTextChangedNotifyOldTextValueChanged);
        
        public static ICommand GetTextChangedNotifyOldTextValue(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(TextChangedNotifyOldTextValueProperty);
        }
        
        private static void OnTextChangedNotifyOldTextValueChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetTextChangedNotifyOldTextValue((BindableObject)o);
            if (command.CanExecute(eventArgs.OldTextValue))
                command.Execute(eventArgs.OldTextValue);
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
            if (command.CanExecute(null))
                command.Execute(null);
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
            if (command.CanExecute(null))
                command.Execute(null);
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
            if (command.CanExecute(null))
                command.Execute(null);
        }
        #endregion
        
        #region ItemAppearingNotifyItem
        public static readonly BindableProperty ItemAppearingNotifyItemProperty =
            BindableProperty.CreateAttached("ItemAppearingNotifyItem", typeof(ICommand), typeof(ListViews), null, propertyChanged:OnItemAppearingNotifyItemChanged);
        
        public static ICommand GetItemAppearingNotifyItem(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ItemAppearingNotifyItemProperty);
        }
        
        private static void OnItemAppearingNotifyItemChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetItemAppearingNotifyItem((BindableObject)o);
            if (command.CanExecute(eventArgs.Item))
                command.Execute(eventArgs.Item);
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
            if (command.CanExecute(null))
                command.Execute(null);
        }
        #endregion
        
        #region ItemDisappearingNotifyItem
        public static readonly BindableProperty ItemDisappearingNotifyItemProperty =
            BindableProperty.CreateAttached("ItemDisappearingNotifyItem", typeof(ICommand), typeof(ListViews), null, propertyChanged:OnItemDisappearingNotifyItemChanged);
        
        public static ICommand GetItemDisappearingNotifyItem(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ItemDisappearingNotifyItemProperty);
        }
        
        private static void OnItemDisappearingNotifyItemChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetItemDisappearingNotifyItem((BindableObject)o);
            if (command.CanExecute(eventArgs.Item))
                command.Execute(eventArgs.Item);
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
            if (command.CanExecute(null))
                command.Execute(null);
        }
        #endregion
        
        #region ItemSelectedNotifySelectedItem
        public static readonly BindableProperty ItemSelectedNotifySelectedItemProperty =
            BindableProperty.CreateAttached("ItemSelectedNotifySelectedItem", typeof(ICommand), typeof(ListViews), null, propertyChanged:OnItemSelectedNotifySelectedItemChanged);
        
        public static ICommand GetItemSelectedNotifySelectedItem(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ItemSelectedNotifySelectedItemProperty);
        }
        
        private static void OnItemSelectedNotifySelectedItemChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetItemSelectedNotifySelectedItem((BindableObject)o);
            if (command.CanExecute(eventArgs.SelectedItem))
                command.Execute(eventArgs.SelectedItem);
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
            if (command.CanExecute(null))
                command.Execute(null);
        }
        #endregion
        
        #region ItemTappedNotifyGroup
        public static readonly BindableProperty ItemTappedNotifyGroupProperty =
            BindableProperty.CreateAttached("ItemTappedNotifyGroup", typeof(ICommand), typeof(ListViews), null, propertyChanged:OnItemTappedNotifyGroupChanged);
        
        public static ICommand GetItemTappedNotifyGroup(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ItemTappedNotifyGroupProperty);
        }
        
        private static void OnItemTappedNotifyGroupChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetItemTappedNotifyGroup((BindableObject)o);
            if (command.CanExecute(eventArgs.Group))
                command.Execute(eventArgs.Group);
        }
        #endregion
        
        #region ItemTappedNotifyItem
        public static readonly BindableProperty ItemTappedNotifyItemProperty =
            BindableProperty.CreateAttached("ItemTappedNotifyItem", typeof(ICommand), typeof(ListViews), null, propertyChanged:OnItemTappedNotifyItemChanged);
        
        public static ICommand GetItemTappedNotifyItem(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ItemTappedNotifyItemProperty);
        }
        
        private static void OnItemTappedNotifyItemChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetItemTappedNotifyItem((BindableObject)o);
            if (command.CanExecute(eventArgs.Item))
                command.Execute(eventArgs.Item);
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
            if (command.CanExecute(null))
                command.Execute(null);
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
            if (command.CanExecute(null))
                command.Execute(null);
        }
        #endregion
        
        #region ScrollToRequestedNotifyScrollX
        public static readonly BindableProperty ScrollToRequestedNotifyScrollXProperty =
            BindableProperty.CreateAttached("ScrollToRequestedNotifyScrollX", typeof(ICommand), typeof(ListViews), null, propertyChanged:OnScrollToRequestedNotifyScrollXChanged);
        
        public static ICommand GetScrollToRequestedNotifyScrollX(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ScrollToRequestedNotifyScrollXProperty);
        }
        
        private static void OnScrollToRequestedNotifyScrollXChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetScrollToRequestedNotifyScrollX((BindableObject)o);
            if (command.CanExecute(eventArgs.ScrollX))
                command.Execute(eventArgs.ScrollX);
        }
        #endregion
        
        #region ScrollToRequestedNotifyScrollY
        public static readonly BindableProperty ScrollToRequestedNotifyScrollYProperty =
            BindableProperty.CreateAttached("ScrollToRequestedNotifyScrollY", typeof(ICommand), typeof(ListViews), null, propertyChanged:OnScrollToRequestedNotifyScrollYChanged);
        
        public static ICommand GetScrollToRequestedNotifyScrollY(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ScrollToRequestedNotifyScrollYProperty);
        }
        
        private static void OnScrollToRequestedNotifyScrollYChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetScrollToRequestedNotifyScrollY((BindableObject)o);
            if (command.CanExecute(eventArgs.ScrollY))
                command.Execute(eventArgs.ScrollY);
        }
        #endregion
        
        #region ScrollToRequestedNotifyShouldAnimate
        public static readonly BindableProperty ScrollToRequestedNotifyShouldAnimateProperty =
            BindableProperty.CreateAttached("ScrollToRequestedNotifyShouldAnimate", typeof(ICommand), typeof(ListViews), null, propertyChanged:OnScrollToRequestedNotifyShouldAnimateChanged);
        
        public static ICommand GetScrollToRequestedNotifyShouldAnimate(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ScrollToRequestedNotifyShouldAnimateProperty);
        }
        
        private static void OnScrollToRequestedNotifyShouldAnimateChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetScrollToRequestedNotifyShouldAnimate((BindableObject)o);
            if (command.CanExecute(eventArgs.ShouldAnimate))
                command.Execute(eventArgs.ShouldAnimate);
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
            if (command.CanExecute(null))
                command.Execute(null);
        }
        #endregion
        
        #region BackButtonPressedNotifyHandled
        public static readonly BindableProperty BackButtonPressedNotifyHandledProperty =
            BindableProperty.CreateAttached("BackButtonPressedNotifyHandled", typeof(ICommand), typeof(MasterDetailPages), null, propertyChanged:OnBackButtonPressedNotifyHandledChanged);
        
        public static ICommand GetBackButtonPressedNotifyHandled(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(BackButtonPressedNotifyHandledProperty);
        }
        
        private static void OnBackButtonPressedNotifyHandledChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetBackButtonPressedNotifyHandled((BindableObject)o);
            if (command.CanExecute(eventArgs.Handled))
                command.Execute(eventArgs.Handled);
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
            if (command.CanExecute(null))
                command.Execute(null);
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
            if (command.CanExecute(null))
                command.Execute(null);
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
            if (command.CanExecute(null))
                command.Execute(null);
        }
        #endregion
        
        #region InsertPageBeforeRequestedNotifyAnimated
        public static readonly BindableProperty InsertPageBeforeRequestedNotifyAnimatedProperty =
            BindableProperty.CreateAttached("InsertPageBeforeRequestedNotifyAnimated", typeof(ICommand), typeof(NavigationPages), null, propertyChanged:OnInsertPageBeforeRequestedNotifyAnimatedChanged);
        
        public static ICommand GetInsertPageBeforeRequestedNotifyAnimated(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(InsertPageBeforeRequestedNotifyAnimatedProperty);
        }
        
        private static void OnInsertPageBeforeRequestedNotifyAnimatedChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetInsertPageBeforeRequestedNotifyAnimated((BindableObject)o);
            if (command.CanExecute(eventArgs.Animated))
                command.Execute(eventArgs.Animated);
        }
        #endregion
        
        #region InsertPageBeforeRequestedNotifyRealize
        public static readonly BindableProperty InsertPageBeforeRequestedNotifyRealizeProperty =
            BindableProperty.CreateAttached("InsertPageBeforeRequestedNotifyRealize", typeof(ICommand), typeof(NavigationPages), null, propertyChanged:OnInsertPageBeforeRequestedNotifyRealizeChanged);
        
        public static ICommand GetInsertPageBeforeRequestedNotifyRealize(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(InsertPageBeforeRequestedNotifyRealizeProperty);
        }
        
        private static void OnInsertPageBeforeRequestedNotifyRealizeChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetInsertPageBeforeRequestedNotifyRealize((BindableObject)o);
            if (command.CanExecute(eventArgs.Realize))
                command.Execute(eventArgs.Realize);
        }
        #endregion
        
        #region InsertPageBeforeRequestedNotifyTask
        public static readonly BindableProperty InsertPageBeforeRequestedNotifyTaskProperty =
            BindableProperty.CreateAttached("InsertPageBeforeRequestedNotifyTask", typeof(ICommand), typeof(NavigationPages), null, propertyChanged:OnInsertPageBeforeRequestedNotifyTaskChanged);
        
        public static ICommand GetInsertPageBeforeRequestedNotifyTask(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(InsertPageBeforeRequestedNotifyTaskProperty);
        }
        
        private static void OnInsertPageBeforeRequestedNotifyTaskChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetInsertPageBeforeRequestedNotifyTask((BindableObject)o);
            if (command.CanExecute(eventArgs.Task))
                command.Execute(eventArgs.Task);
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
            if (command.CanExecute(null))
                command.Execute(null);
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
            if (command.CanExecute(null))
                command.Execute(null);
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
            if (command.CanExecute(null))
                command.Execute(null);
        }
        #endregion
        
        #region PopRequestedNotifyAnimated
        public static readonly BindableProperty PopRequestedNotifyAnimatedProperty =
            BindableProperty.CreateAttached("PopRequestedNotifyAnimated", typeof(ICommand), typeof(NavigationPages), null, propertyChanged:OnPopRequestedNotifyAnimatedChanged);
        
        public static ICommand GetPopRequestedNotifyAnimated(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(PopRequestedNotifyAnimatedProperty);
        }
        
        private static void OnPopRequestedNotifyAnimatedChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetPopRequestedNotifyAnimated((BindableObject)o);
            if (command.CanExecute(eventArgs.Animated))
                command.Execute(eventArgs.Animated);
        }
        #endregion
        
        #region PopRequestedNotifyRealize
        public static readonly BindableProperty PopRequestedNotifyRealizeProperty =
            BindableProperty.CreateAttached("PopRequestedNotifyRealize", typeof(ICommand), typeof(NavigationPages), null, propertyChanged:OnPopRequestedNotifyRealizeChanged);
        
        public static ICommand GetPopRequestedNotifyRealize(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(PopRequestedNotifyRealizeProperty);
        }
        
        private static void OnPopRequestedNotifyRealizeChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetPopRequestedNotifyRealize((BindableObject)o);
            if (command.CanExecute(eventArgs.Realize))
                command.Execute(eventArgs.Realize);
        }
        #endregion
        
        #region PopRequestedNotifyTask
        public static readonly BindableProperty PopRequestedNotifyTaskProperty =
            BindableProperty.CreateAttached("PopRequestedNotifyTask", typeof(ICommand), typeof(NavigationPages), null, propertyChanged:OnPopRequestedNotifyTaskChanged);
        
        public static ICommand GetPopRequestedNotifyTask(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(PopRequestedNotifyTaskProperty);
        }
        
        private static void OnPopRequestedNotifyTaskChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetPopRequestedNotifyTask((BindableObject)o);
            if (command.CanExecute(eventArgs.Task))
                command.Execute(eventArgs.Task);
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
            if (command.CanExecute(null))
                command.Execute(null);
        }
        #endregion
        
        #region PopToRootRequestedNotifyAnimated
        public static readonly BindableProperty PopToRootRequestedNotifyAnimatedProperty =
            BindableProperty.CreateAttached("PopToRootRequestedNotifyAnimated", typeof(ICommand), typeof(NavigationPages), null, propertyChanged:OnPopToRootRequestedNotifyAnimatedChanged);
        
        public static ICommand GetPopToRootRequestedNotifyAnimated(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(PopToRootRequestedNotifyAnimatedProperty);
        }
        
        private static void OnPopToRootRequestedNotifyAnimatedChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetPopToRootRequestedNotifyAnimated((BindableObject)o);
            if (command.CanExecute(eventArgs.Animated))
                command.Execute(eventArgs.Animated);
        }
        #endregion
        
        #region PopToRootRequestedNotifyRealize
        public static readonly BindableProperty PopToRootRequestedNotifyRealizeProperty =
            BindableProperty.CreateAttached("PopToRootRequestedNotifyRealize", typeof(ICommand), typeof(NavigationPages), null, propertyChanged:OnPopToRootRequestedNotifyRealizeChanged);
        
        public static ICommand GetPopToRootRequestedNotifyRealize(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(PopToRootRequestedNotifyRealizeProperty);
        }
        
        private static void OnPopToRootRequestedNotifyRealizeChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetPopToRootRequestedNotifyRealize((BindableObject)o);
            if (command.CanExecute(eventArgs.Realize))
                command.Execute(eventArgs.Realize);
        }
        #endregion
        
        #region PopToRootRequestedNotifyTask
        public static readonly BindableProperty PopToRootRequestedNotifyTaskProperty =
            BindableProperty.CreateAttached("PopToRootRequestedNotifyTask", typeof(ICommand), typeof(NavigationPages), null, propertyChanged:OnPopToRootRequestedNotifyTaskChanged);
        
        public static ICommand GetPopToRootRequestedNotifyTask(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(PopToRootRequestedNotifyTaskProperty);
        }
        
        private static void OnPopToRootRequestedNotifyTaskChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetPopToRootRequestedNotifyTask((BindableObject)o);
            if (command.CanExecute(eventArgs.Task))
                command.Execute(eventArgs.Task);
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
            if (command.CanExecute(null))
                command.Execute(null);
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
            if (command.CanExecute(null))
                command.Execute(null);
        }
        #endregion
        
        #region PushRequestedNotifyAnimated
        public static readonly BindableProperty PushRequestedNotifyAnimatedProperty =
            BindableProperty.CreateAttached("PushRequestedNotifyAnimated", typeof(ICommand), typeof(NavigationPages), null, propertyChanged:OnPushRequestedNotifyAnimatedChanged);
        
        public static ICommand GetPushRequestedNotifyAnimated(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(PushRequestedNotifyAnimatedProperty);
        }
        
        private static void OnPushRequestedNotifyAnimatedChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetPushRequestedNotifyAnimated((BindableObject)o);
            if (command.CanExecute(eventArgs.Animated))
                command.Execute(eventArgs.Animated);
        }
        #endregion
        
        #region PushRequestedNotifyRealize
        public static readonly BindableProperty PushRequestedNotifyRealizeProperty =
            BindableProperty.CreateAttached("PushRequestedNotifyRealize", typeof(ICommand), typeof(NavigationPages), null, propertyChanged:OnPushRequestedNotifyRealizeChanged);
        
        public static ICommand GetPushRequestedNotifyRealize(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(PushRequestedNotifyRealizeProperty);
        }
        
        private static void OnPushRequestedNotifyRealizeChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetPushRequestedNotifyRealize((BindableObject)o);
            if (command.CanExecute(eventArgs.Realize))
                command.Execute(eventArgs.Realize);
        }
        #endregion
        
        #region PushRequestedNotifyTask
        public static readonly BindableProperty PushRequestedNotifyTaskProperty =
            BindableProperty.CreateAttached("PushRequestedNotifyTask", typeof(ICommand), typeof(NavigationPages), null, propertyChanged:OnPushRequestedNotifyTaskChanged);
        
        public static ICommand GetPushRequestedNotifyTask(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(PushRequestedNotifyTaskProperty);
        }
        
        private static void OnPushRequestedNotifyTaskChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetPushRequestedNotifyTask((BindableObject)o);
            if (command.CanExecute(eventArgs.Task))
                command.Execute(eventArgs.Task);
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
            if (command.CanExecute(null))
                command.Execute(null);
        }
        #endregion
        
        #region RemovePageRequestedNotifyAnimated
        public static readonly BindableProperty RemovePageRequestedNotifyAnimatedProperty =
            BindableProperty.CreateAttached("RemovePageRequestedNotifyAnimated", typeof(ICommand), typeof(NavigationPages), null, propertyChanged:OnRemovePageRequestedNotifyAnimatedChanged);
        
        public static ICommand GetRemovePageRequestedNotifyAnimated(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(RemovePageRequestedNotifyAnimatedProperty);
        }
        
        private static void OnRemovePageRequestedNotifyAnimatedChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetRemovePageRequestedNotifyAnimated((BindableObject)o);
            if (command.CanExecute(eventArgs.Animated))
                command.Execute(eventArgs.Animated);
        }
        #endregion
        
        #region RemovePageRequestedNotifyRealize
        public static readonly BindableProperty RemovePageRequestedNotifyRealizeProperty =
            BindableProperty.CreateAttached("RemovePageRequestedNotifyRealize", typeof(ICommand), typeof(NavigationPages), null, propertyChanged:OnRemovePageRequestedNotifyRealizeChanged);
        
        public static ICommand GetRemovePageRequestedNotifyRealize(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(RemovePageRequestedNotifyRealizeProperty);
        }
        
        private static void OnRemovePageRequestedNotifyRealizeChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetRemovePageRequestedNotifyRealize((BindableObject)o);
            if (command.CanExecute(eventArgs.Realize))
                command.Execute(eventArgs.Realize);
        }
        #endregion
        
        #region RemovePageRequestedNotifyTask
        public static readonly BindableProperty RemovePageRequestedNotifyTaskProperty =
            BindableProperty.CreateAttached("RemovePageRequestedNotifyTask", typeof(ICommand), typeof(NavigationPages), null, propertyChanged:OnRemovePageRequestedNotifyTaskChanged);
        
        public static ICommand GetRemovePageRequestedNotifyTask(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(RemovePageRequestedNotifyTaskProperty);
        }
        
        private static void OnRemovePageRequestedNotifyTaskChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetRemovePageRequestedNotifyTask((BindableObject)o);
            if (command.CanExecute(eventArgs.Task))
                command.Execute(eventArgs.Task);
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
            if (command.CanExecute(null))
                command.Execute(null);
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
            if (command.CanExecute(null))
                command.Execute(null);
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
            if (command.CanExecute(null))
                command.Execute(null);
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
            if (command.CanExecute(null))
                command.Execute(null);
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
            if (command.CanExecute(null))
                command.Execute(null);
        }
        #endregion
        
        #region PanUpdatedNotifyGestureId
        public static readonly BindableProperty PanUpdatedNotifyGestureIdProperty =
            BindableProperty.CreateAttached("PanUpdatedNotifyGestureId", typeof(ICommand), typeof(PanGestureRecognizers), null, propertyChanged:OnPanUpdatedNotifyGestureIdChanged);
        
        public static ICommand GetPanUpdatedNotifyGestureId(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(PanUpdatedNotifyGestureIdProperty);
        }
        
        private static void OnPanUpdatedNotifyGestureIdChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetPanUpdatedNotifyGestureId((BindableObject)o);
            if (command.CanExecute(eventArgs.GestureId))
                command.Execute(eventArgs.GestureId);
        }
        #endregion
        
        #region PanUpdatedNotifyTotalX
        public static readonly BindableProperty PanUpdatedNotifyTotalXProperty =
            BindableProperty.CreateAttached("PanUpdatedNotifyTotalX", typeof(ICommand), typeof(PanGestureRecognizers), null, propertyChanged:OnPanUpdatedNotifyTotalXChanged);
        
        public static ICommand GetPanUpdatedNotifyTotalX(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(PanUpdatedNotifyTotalXProperty);
        }
        
        private static void OnPanUpdatedNotifyTotalXChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetPanUpdatedNotifyTotalX((BindableObject)o);
            if (command.CanExecute(eventArgs.TotalX))
                command.Execute(eventArgs.TotalX);
        }
        #endregion
        
        #region PanUpdatedNotifyTotalY
        public static readonly BindableProperty PanUpdatedNotifyTotalYProperty =
            BindableProperty.CreateAttached("PanUpdatedNotifyTotalY", typeof(ICommand), typeof(PanGestureRecognizers), null, propertyChanged:OnPanUpdatedNotifyTotalYChanged);
        
        public static ICommand GetPanUpdatedNotifyTotalY(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(PanUpdatedNotifyTotalYProperty);
        }
        
        private static void OnPanUpdatedNotifyTotalYChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetPanUpdatedNotifyTotalY((BindableObject)o);
            if (command.CanExecute(eventArgs.TotalY))
                command.Execute(eventArgs.TotalY);
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
            if (command.CanExecute(null))
                command.Execute(null);
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
            if (command.CanExecute(null))
                command.Execute(null);
        }
        #endregion
        
        #region PinchUpdatedNotifyScale
        public static readonly BindableProperty PinchUpdatedNotifyScaleProperty =
            BindableProperty.CreateAttached("PinchUpdatedNotifyScale", typeof(ICommand), typeof(PinchGestureRecognizers), null, propertyChanged:OnPinchUpdatedNotifyScaleChanged);
        
        public static ICommand GetPinchUpdatedNotifyScale(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(PinchUpdatedNotifyScaleProperty);
        }
        
        private static void OnPinchUpdatedNotifyScaleChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetPinchUpdatedNotifyScale((BindableObject)o);
            if (command.CanExecute(eventArgs.Scale))
                command.Execute(eventArgs.Scale);
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
            if (command.CanExecute(null))
                command.Execute(null);
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
            if (command.CanExecute(null))
                command.Execute(null);
        }
        #endregion
        
        #region ScrolledNotifyScrollX
        public static readonly BindableProperty ScrolledNotifyScrollXProperty =
            BindableProperty.CreateAttached("ScrolledNotifyScrollX", typeof(ICommand), typeof(ScrollViews), null, propertyChanged:OnScrolledNotifyScrollXChanged);
        
        public static ICommand GetScrolledNotifyScrollX(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ScrolledNotifyScrollXProperty);
        }
        
        private static void OnScrolledNotifyScrollXChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetScrolledNotifyScrollX((BindableObject)o);
            if (command.CanExecute(eventArgs.ScrollX))
                command.Execute(eventArgs.ScrollX);
        }
        #endregion
        
        #region ScrolledNotifyScrollY
        public static readonly BindableProperty ScrolledNotifyScrollYProperty =
            BindableProperty.CreateAttached("ScrolledNotifyScrollY", typeof(ICommand), typeof(ScrollViews), null, propertyChanged:OnScrolledNotifyScrollYChanged);
        
        public static ICommand GetScrolledNotifyScrollY(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ScrolledNotifyScrollYProperty);
        }
        
        private static void OnScrolledNotifyScrollYChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetScrolledNotifyScrollY((BindableObject)o);
            if (command.CanExecute(eventArgs.ScrollY))
                command.Execute(eventArgs.ScrollY);
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
            if (command.CanExecute(null))
                command.Execute(null);
        }
        #endregion
        
        #region ScrollToRequestedNotifyScrollX
        public static readonly BindableProperty ScrollToRequestedNotifyScrollXProperty =
            BindableProperty.CreateAttached("ScrollToRequestedNotifyScrollX", typeof(ICommand), typeof(ScrollViews), null, propertyChanged:OnScrollToRequestedNotifyScrollXChanged);
        
        public static ICommand GetScrollToRequestedNotifyScrollX(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ScrollToRequestedNotifyScrollXProperty);
        }
        
        private static void OnScrollToRequestedNotifyScrollXChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetScrollToRequestedNotifyScrollX((BindableObject)o);
            if (command.CanExecute(eventArgs.ScrollX))
                command.Execute(eventArgs.ScrollX);
        }
        #endregion
        
        #region ScrollToRequestedNotifyScrollY
        public static readonly BindableProperty ScrollToRequestedNotifyScrollYProperty =
            BindableProperty.CreateAttached("ScrollToRequestedNotifyScrollY", typeof(ICommand), typeof(ScrollViews), null, propertyChanged:OnScrollToRequestedNotifyScrollYChanged);
        
        public static ICommand GetScrollToRequestedNotifyScrollY(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ScrollToRequestedNotifyScrollYProperty);
        }
        
        private static void OnScrollToRequestedNotifyScrollYChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetScrollToRequestedNotifyScrollY((BindableObject)o);
            if (command.CanExecute(eventArgs.ScrollY))
                command.Execute(eventArgs.ScrollY);
        }
        #endregion
        
        #region ScrollToRequestedNotifyShouldAnimate
        public static readonly BindableProperty ScrollToRequestedNotifyShouldAnimateProperty =
            BindableProperty.CreateAttached("ScrollToRequestedNotifyShouldAnimate", typeof(ICommand), typeof(ScrollViews), null, propertyChanged:OnScrollToRequestedNotifyShouldAnimateChanged);
        
        public static ICommand GetScrollToRequestedNotifyShouldAnimate(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ScrollToRequestedNotifyShouldAnimateProperty);
        }
        
        private static void OnScrollToRequestedNotifyShouldAnimateChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetScrollToRequestedNotifyShouldAnimate((BindableObject)o);
            if (command.CanExecute(eventArgs.ShouldAnimate))
                command.Execute(eventArgs.ShouldAnimate);
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
            if (command.CanExecute(null))
                command.Execute(null);
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
            if (command.CanExecute(null))
                command.Execute(null);
        }
        #endregion
        
        #region TextChangedNotifyNewTextValue
        public static readonly BindableProperty TextChangedNotifyNewTextValueProperty =
            BindableProperty.CreateAttached("TextChangedNotifyNewTextValue", typeof(ICommand), typeof(SearchBars), null, propertyChanged:OnTextChangedNotifyNewTextValueChanged);
        
        public static ICommand GetTextChangedNotifyNewTextValue(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(TextChangedNotifyNewTextValueProperty);
        }
        
        private static void OnTextChangedNotifyNewTextValueChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetTextChangedNotifyNewTextValue((BindableObject)o);
            if (command.CanExecute(eventArgs.NewTextValue))
                command.Execute(eventArgs.NewTextValue);
        }
        #endregion
        
        #region TextChangedNotifyOldTextValue
        public static readonly BindableProperty TextChangedNotifyOldTextValueProperty =
            BindableProperty.CreateAttached("TextChangedNotifyOldTextValue", typeof(ICommand), typeof(SearchBars), null, propertyChanged:OnTextChangedNotifyOldTextValueChanged);
        
        public static ICommand GetTextChangedNotifyOldTextValue(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(TextChangedNotifyOldTextValueProperty);
        }
        
        private static void OnTextChangedNotifyOldTextValueChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetTextChangedNotifyOldTextValue((BindableObject)o);
            if (command.CanExecute(eventArgs.OldTextValue))
                command.Execute(eventArgs.OldTextValue);
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
            if (command.CanExecute(null))
                command.Execute(null);
        }
        #endregion
        
        #region ValueChangedNotifyNewValue
        public static readonly BindableProperty ValueChangedNotifyNewValueProperty =
            BindableProperty.CreateAttached("ValueChangedNotifyNewValue", typeof(ICommand), typeof(Sliders), null, propertyChanged:OnValueChangedNotifyNewValueChanged);
        
        public static ICommand GetValueChangedNotifyNewValue(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ValueChangedNotifyNewValueProperty);
        }
        
        private static void OnValueChangedNotifyNewValueChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetValueChangedNotifyNewValue((BindableObject)o);
            if (command.CanExecute(eventArgs.NewValue))
                command.Execute(eventArgs.NewValue);
        }
        #endregion
        
        #region ValueChangedNotifyOldValue
        public static readonly BindableProperty ValueChangedNotifyOldValueProperty =
            BindableProperty.CreateAttached("ValueChangedNotifyOldValue", typeof(ICommand), typeof(Sliders), null, propertyChanged:OnValueChangedNotifyOldValueChanged);
        
        public static ICommand GetValueChangedNotifyOldValue(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ValueChangedNotifyOldValueProperty);
        }
        
        private static void OnValueChangedNotifyOldValueChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetValueChangedNotifyOldValue((BindableObject)o);
            if (command.CanExecute(eventArgs.OldValue))
                command.Execute(eventArgs.OldValue);
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
            if (command.CanExecute(null))
                command.Execute(null);
        }
        #endregion
        
        #region ValueChangedNotifyNewValue
        public static readonly BindableProperty ValueChangedNotifyNewValueProperty =
            BindableProperty.CreateAttached("ValueChangedNotifyNewValue", typeof(ICommand), typeof(Steppers), null, propertyChanged:OnValueChangedNotifyNewValueChanged);
        
        public static ICommand GetValueChangedNotifyNewValue(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ValueChangedNotifyNewValueProperty);
        }
        
        private static void OnValueChangedNotifyNewValueChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetValueChangedNotifyNewValue((BindableObject)o);
            if (command.CanExecute(eventArgs.NewValue))
                command.Execute(eventArgs.NewValue);
        }
        #endregion
        
        #region ValueChangedNotifyOldValue
        public static readonly BindableProperty ValueChangedNotifyOldValueProperty =
            BindableProperty.CreateAttached("ValueChangedNotifyOldValue", typeof(ICommand), typeof(Steppers), null, propertyChanged:OnValueChangedNotifyOldValueChanged);
        
        public static ICommand GetValueChangedNotifyOldValue(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ValueChangedNotifyOldValueProperty);
        }
        
        private static void OnValueChangedNotifyOldValueChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetValueChangedNotifyOldValue((BindableObject)o);
            if (command.CanExecute(eventArgs.OldValue))
                command.Execute(eventArgs.OldValue);
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
            if (command.CanExecute(null))
                command.Execute(null);
        }
        #endregion
        
        #region ToggledNotifyValue
        public static readonly BindableProperty ToggledNotifyValueProperty =
            BindableProperty.CreateAttached("ToggledNotifyValue", typeof(ICommand), typeof(Switchs), null, propertyChanged:OnToggledNotifyValueChanged);
        
        public static ICommand GetToggledNotifyValue(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ToggledNotifyValueProperty);
        }
        
        private static void OnToggledNotifyValueChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetToggledNotifyValue((BindableObject)o);
            if (command.CanExecute(eventArgs.Value))
                command.Execute(eventArgs.Value);
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
            if (command.CanExecute(null))
                command.Execute(null);
        }
        #endregion
        
        #region OnChangedNotifyValue
        public static readonly BindableProperty OnChangedNotifyValueProperty =
            BindableProperty.CreateAttached("OnChangedNotifyValue", typeof(ICommand), typeof(SwitchCells), null, propertyChanged:OnOnChangedNotifyValueChanged);
        
        public static ICommand GetOnChangedNotifyValue(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(OnChangedNotifyValueProperty);
        }
        
        private static void OnOnChangedNotifyValueChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetOnChangedNotifyValue((BindableObject)o);
            if (command.CanExecute(eventArgs.Value))
                command.Execute(eventArgs.Value);
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
            if (command.CanExecute(null))
                command.Execute(null);
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
            if (command.CanExecute(null))
                command.Execute(null);
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
            if (command.CanExecute(null))
                command.Execute(null);
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
            if (command.CanExecute(null))
                command.Execute(null);
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
            if (command.CanExecute(null))
                command.Execute(null);
        }
        #endregion
        
        #region FocusChangeRequestedNotifyFocus
        public static readonly BindableProperty FocusChangeRequestedNotifyFocusProperty =
            BindableProperty.CreateAttached("FocusChangeRequestedNotifyFocus", typeof(ICommand), typeof(VisualElements), null, propertyChanged:OnFocusChangeRequestedNotifyFocusChanged);
        
        public static ICommand GetFocusChangeRequestedNotifyFocus(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(FocusChangeRequestedNotifyFocusProperty);
        }
        
        private static void OnFocusChangeRequestedNotifyFocusChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetFocusChangeRequestedNotifyFocus((BindableObject)o);
            if (command.CanExecute(eventArgs.Focus))
                command.Execute(eventArgs.Focus);
        }
        #endregion
        
        #region FocusChangeRequestedNotifyResult
        public static readonly BindableProperty FocusChangeRequestedNotifyResultProperty =
            BindableProperty.CreateAttached("FocusChangeRequestedNotifyResult", typeof(ICommand), typeof(VisualElements), null, propertyChanged:OnFocusChangeRequestedNotifyResultChanged);
        
        public static ICommand GetFocusChangeRequestedNotifyResult(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(FocusChangeRequestedNotifyResultProperty);
        }
        
        private static void OnFocusChangeRequestedNotifyResultChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetFocusChangeRequestedNotifyResult((BindableObject)o);
            if (command.CanExecute(eventArgs.Result))
                command.Execute(eventArgs.Result);
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
            if (command.CanExecute(null))
                command.Execute(null);
        }
        #endregion
        
        #region FocusedNotifyIsFocused
        public static readonly BindableProperty FocusedNotifyIsFocusedProperty =
            BindableProperty.CreateAttached("FocusedNotifyIsFocused", typeof(ICommand), typeof(VisualElements), null, propertyChanged:OnFocusedNotifyIsFocusedChanged);
        
        public static ICommand GetFocusedNotifyIsFocused(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(FocusedNotifyIsFocusedProperty);
        }
        
        private static void OnFocusedNotifyIsFocusedChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetFocusedNotifyIsFocused((BindableObject)o);
            if (command.CanExecute(eventArgs.IsFocused))
                command.Execute(eventArgs.IsFocused);
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
            if (command.CanExecute(null))
                command.Execute(null);
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
            if (command.CanExecute(null))
                command.Execute(null);
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
            if (command.CanExecute(null))
                command.Execute(null);
        }
        #endregion
        
        #region UnfocusedNotifyIsFocused
        public static readonly BindableProperty UnfocusedNotifyIsFocusedProperty =
            BindableProperty.CreateAttached("UnfocusedNotifyIsFocused", typeof(ICommand), typeof(VisualElements), null, propertyChanged:OnUnfocusedNotifyIsFocusedChanged);
        
        public static ICommand GetUnfocusedNotifyIsFocused(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(UnfocusedNotifyIsFocusedProperty);
        }
        
        private static void OnUnfocusedNotifyIsFocusedChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetUnfocusedNotifyIsFocused((BindableObject)o);
            if (command.CanExecute(eventArgs.IsFocused))
                command.Execute(eventArgs.IsFocused);
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
            if (command.CanExecute(null))
                command.Execute(null);
        }
        #endregion
        
        #region EvalRequestedNotifyScript
        public static readonly BindableProperty EvalRequestedNotifyScriptProperty =
            BindableProperty.CreateAttached("EvalRequestedNotifyScript", typeof(ICommand), typeof(WebViews), null, propertyChanged:OnEvalRequestedNotifyScriptChanged);
        
        public static ICommand GetEvalRequestedNotifyScript(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(EvalRequestedNotifyScriptProperty);
        }
        
        private static void OnEvalRequestedNotifyScriptChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetEvalRequestedNotifyScript((BindableObject)o);
            if (command.CanExecute(eventArgs.Script))
                command.Execute(eventArgs.Script);
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
            if (command.CanExecute(null))
                command.Execute(null);
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
            if (command.CanExecute(null))
                command.Execute(null);
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
            if (command.CanExecute(null))
                command.Execute(null);
        }
        #endregion
        
        #region NavigatedNotifyUrl
        public static readonly BindableProperty NavigatedNotifyUrlProperty =
            BindableProperty.CreateAttached("NavigatedNotifyUrl", typeof(ICommand), typeof(WebViews), null, propertyChanged:OnNavigatedNotifyUrlChanged);
        
        public static ICommand GetNavigatedNotifyUrl(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NavigatedNotifyUrlProperty);
        }
        
        private static void OnNavigatedNotifyUrlChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetNavigatedNotifyUrl((BindableObject)o);
            if (command.CanExecute(eventArgs.Url))
                command.Execute(eventArgs.Url);
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
            if (command.CanExecute(null))
                command.Execute(null);
        }
        #endregion
        
        #region NavigatingNotifyCancel
        public static readonly BindableProperty NavigatingNotifyCancelProperty =
            BindableProperty.CreateAttached("NavigatingNotifyCancel", typeof(ICommand), typeof(WebViews), null, propertyChanged:OnNavigatingNotifyCancelChanged);
        
        public static ICommand GetNavigatingNotifyCancel(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NavigatingNotifyCancelProperty);
        }
        
        private static void OnNavigatingNotifyCancelChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetNavigatingNotifyCancel((BindableObject)o);
            if (command.CanExecute(eventArgs.Cancel))
                command.Execute(eventArgs.Cancel);
        }
        #endregion
        
        #region NavigatingNotifyUrl
        public static readonly BindableProperty NavigatingNotifyUrlProperty =
            BindableProperty.CreateAttached("NavigatingNotifyUrl", typeof(ICommand), typeof(WebViews), null, propertyChanged:OnNavigatingNotifyUrlChanged);
        
        public static ICommand GetNavigatingNotifyUrl(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NavigatingNotifyUrlProperty);
        }
        
        private static void OnNavigatingNotifyUrlChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetNavigatingNotifyUrl((BindableObject)o);
            if (command.CanExecute(eventArgs.Url))
                command.Execute(eventArgs.Url);
        }
        #endregion
	}
	#endregion
}
