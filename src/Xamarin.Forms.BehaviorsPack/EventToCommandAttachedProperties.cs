using System;
using System.Windows.Input;
using Xamarin.Forms.Internals;

namespace Xamarin.Forms.BehaviorsPack {
	public partial class Applications {

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

		#region NotifyModalWhenModalPopped
        public static readonly BindableProperty NotifyModalWhenModalPoppedProperty =
            BindableProperty.CreateAttached("NotifyModalWhenModalPopped", typeof(ICommand), typeof(Applications), null, propertyChanged:OnNotifyModalWhenModalPoppedChanged);

        public static ICommand GetNotifyModalWhenModalPopped(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NotifyModalWhenModalPoppedProperty);
        }

		private static void OnNotifyModalWhenModalPoppedChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetNotifyModalWhenModalPopped((BindableObject)o);
            if (command.CanExecute(eventArgs.Modal))
                command.Execute(eventArgs.Modal);
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

		#region NotifyCancelWhenModalPopping
        public static readonly BindableProperty NotifyCancelWhenModalPoppingProperty =
            BindableProperty.CreateAttached("NotifyCancelWhenModalPopping", typeof(ICommand), typeof(Applications), null, propertyChanged:OnNotifyCancelWhenModalPoppingChanged);

        public static ICommand GetNotifyCancelWhenModalPopping(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NotifyCancelWhenModalPoppingProperty);
        }

		private static void OnNotifyCancelWhenModalPoppingChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetNotifyCancelWhenModalPopping((BindableObject)o);
            if (command.CanExecute(eventArgs.Cancel))
                command.Execute(eventArgs.Cancel);
        }
		#endregion

		#region NotifyModalWhenModalPopping
        public static readonly BindableProperty NotifyModalWhenModalPoppingProperty =
            BindableProperty.CreateAttached("NotifyModalWhenModalPopping", typeof(ICommand), typeof(Applications), null, propertyChanged:OnNotifyModalWhenModalPoppingChanged);

        public static ICommand GetNotifyModalWhenModalPopping(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NotifyModalWhenModalPoppingProperty);
        }

		private static void OnNotifyModalWhenModalPoppingChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetNotifyModalWhenModalPopping((BindableObject)o);
            if (command.CanExecute(eventArgs.Modal))
                command.Execute(eventArgs.Modal);
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

		#region NotifyModalWhenModalPushed
        public static readonly BindableProperty NotifyModalWhenModalPushedProperty =
            BindableProperty.CreateAttached("NotifyModalWhenModalPushed", typeof(ICommand), typeof(Applications), null, propertyChanged:OnNotifyModalWhenModalPushedChanged);

        public static ICommand GetNotifyModalWhenModalPushed(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NotifyModalWhenModalPushedProperty);
        }

		private static void OnNotifyModalWhenModalPushedChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetNotifyModalWhenModalPushed((BindableObject)o);
            if (command.CanExecute(eventArgs.Modal))
                command.Execute(eventArgs.Modal);
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

		#region NotifyModalWhenModalPushing
        public static readonly BindableProperty NotifyModalWhenModalPushingProperty =
            BindableProperty.CreateAttached("NotifyModalWhenModalPushing", typeof(ICommand), typeof(Applications), null, propertyChanged:OnNotifyModalWhenModalPushingChanged);

        public static ICommand GetNotifyModalWhenModalPushing(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NotifyModalWhenModalPushingProperty);
        }

		private static void OnNotifyModalWhenModalPushingChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetNotifyModalWhenModalPushing((BindableObject)o);
            if (command.CanExecute(eventArgs.Modal))
                command.Execute(eventArgs.Modal);
        }
		#endregion

	}
	public partial class Buttons {

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
	public partial class Cells {

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
	public partial class ColumnDefinitions {

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
	public partial class DatePickers {

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

		#region NotifyNewDateWhenDateSelected
        public static readonly BindableProperty NotifyNewDateWhenDateSelectedProperty =
            BindableProperty.CreateAttached("NotifyNewDateWhenDateSelected", typeof(ICommand), typeof(DatePickers), null, propertyChanged:OnNotifyNewDateWhenDateSelectedChanged);

        public static ICommand GetNotifyNewDateWhenDateSelected(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NotifyNewDateWhenDateSelectedProperty);
        }

		private static void OnNotifyNewDateWhenDateSelectedChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetNotifyNewDateWhenDateSelected((BindableObject)o);
            if (command.CanExecute(eventArgs.NewDate))
                command.Execute(eventArgs.NewDate);
        }
		#endregion

		#region NotifyOldDateWhenDateSelected
        public static readonly BindableProperty NotifyOldDateWhenDateSelectedProperty =
            BindableProperty.CreateAttached("NotifyOldDateWhenDateSelected", typeof(ICommand), typeof(DatePickers), null, propertyChanged:OnNotifyOldDateWhenDateSelectedChanged);

        public static ICommand GetNotifyOldDateWhenDateSelected(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NotifyOldDateWhenDateSelectedProperty);
        }

		private static void OnNotifyOldDateWhenDateSelectedChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetNotifyOldDateWhenDateSelected((BindableObject)o);
            if (command.CanExecute(eventArgs.OldDate))
                command.Execute(eventArgs.OldDate);
        }
		#endregion

	}
	public partial class Editors {

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

		#region NotifyNewTextValueWhenTextChanged
        public static readonly BindableProperty NotifyNewTextValueWhenTextChangedProperty =
            BindableProperty.CreateAttached("NotifyNewTextValueWhenTextChanged", typeof(ICommand), typeof(Editors), null, propertyChanged:OnNotifyNewTextValueWhenTextChangedChanged);

        public static ICommand GetNotifyNewTextValueWhenTextChanged(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NotifyNewTextValueWhenTextChangedProperty);
        }

		private static void OnNotifyNewTextValueWhenTextChangedChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetNotifyNewTextValueWhenTextChanged((BindableObject)o);
            if (command.CanExecute(eventArgs.NewTextValue))
                command.Execute(eventArgs.NewTextValue);
        }
		#endregion

		#region NotifyOldTextValueWhenTextChanged
        public static readonly BindableProperty NotifyOldTextValueWhenTextChangedProperty =
            BindableProperty.CreateAttached("NotifyOldTextValueWhenTextChanged", typeof(ICommand), typeof(Editors), null, propertyChanged:OnNotifyOldTextValueWhenTextChangedChanged);

        public static ICommand GetNotifyOldTextValueWhenTextChanged(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NotifyOldTextValueWhenTextChangedProperty);
        }

		private static void OnNotifyOldTextValueWhenTextChangedChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetNotifyOldTextValueWhenTextChanged((BindableObject)o);
            if (command.CanExecute(eventArgs.OldTextValue))
                command.Execute(eventArgs.OldTextValue);
        }
		#endregion

	}
	public partial class Elements {

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

		#region NotifyElementWhenChildAdded
        public static readonly BindableProperty NotifyElementWhenChildAddedProperty =
            BindableProperty.CreateAttached("NotifyElementWhenChildAdded", typeof(ICommand), typeof(Elements), null, propertyChanged:OnNotifyElementWhenChildAddedChanged);

        public static ICommand GetNotifyElementWhenChildAdded(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NotifyElementWhenChildAddedProperty);
        }

		private static void OnNotifyElementWhenChildAddedChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetNotifyElementWhenChildAdded((BindableObject)o);
            if (command.CanExecute(eventArgs.Element))
                command.Execute(eventArgs.Element);
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

		#region NotifyElementWhenChildRemoved
        public static readonly BindableProperty NotifyElementWhenChildRemovedProperty =
            BindableProperty.CreateAttached("NotifyElementWhenChildRemoved", typeof(ICommand), typeof(Elements), null, propertyChanged:OnNotifyElementWhenChildRemovedChanged);

        public static ICommand GetNotifyElementWhenChildRemoved(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NotifyElementWhenChildRemovedProperty);
        }

		private static void OnNotifyElementWhenChildRemovedChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetNotifyElementWhenChildRemoved((BindableObject)o);
            if (command.CanExecute(eventArgs.Element))
                command.Execute(eventArgs.Element);
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

		#region NotifyElementWhenDescendantAdded
        public static readonly BindableProperty NotifyElementWhenDescendantAddedProperty =
            BindableProperty.CreateAttached("NotifyElementWhenDescendantAdded", typeof(ICommand), typeof(Elements), null, propertyChanged:OnNotifyElementWhenDescendantAddedChanged);

        public static ICommand GetNotifyElementWhenDescendantAdded(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NotifyElementWhenDescendantAddedProperty);
        }

		private static void OnNotifyElementWhenDescendantAddedChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetNotifyElementWhenDescendantAdded((BindableObject)o);
            if (command.CanExecute(eventArgs.Element))
                command.Execute(eventArgs.Element);
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

		#region NotifyElementWhenDescendantRemoved
        public static readonly BindableProperty NotifyElementWhenDescendantRemovedProperty =
            BindableProperty.CreateAttached("NotifyElementWhenDescendantRemoved", typeof(ICommand), typeof(Elements), null, propertyChanged:OnNotifyElementWhenDescendantRemovedChanged);

        public static ICommand GetNotifyElementWhenDescendantRemoved(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NotifyElementWhenDescendantRemovedProperty);
        }

		private static void OnNotifyElementWhenDescendantRemovedChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetNotifyElementWhenDescendantRemoved((BindableObject)o);
            if (command.CanExecute(eventArgs.Element))
                command.Execute(eventArgs.Element);
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
	public partial class Entries {

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

		#region NotifyNewTextValueWhenTextChanged
        public static readonly BindableProperty NotifyNewTextValueWhenTextChangedProperty =
            BindableProperty.CreateAttached("NotifyNewTextValueWhenTextChanged", typeof(ICommand), typeof(Entries), null, propertyChanged:OnNotifyNewTextValueWhenTextChangedChanged);

        public static ICommand GetNotifyNewTextValueWhenTextChanged(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NotifyNewTextValueWhenTextChangedProperty);
        }

		private static void OnNotifyNewTextValueWhenTextChangedChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetNotifyNewTextValueWhenTextChanged((BindableObject)o);
            if (command.CanExecute(eventArgs.NewTextValue))
                command.Execute(eventArgs.NewTextValue);
        }
		#endregion

		#region NotifyOldTextValueWhenTextChanged
        public static readonly BindableProperty NotifyOldTextValueWhenTextChangedProperty =
            BindableProperty.CreateAttached("NotifyOldTextValueWhenTextChanged", typeof(ICommand), typeof(Entries), null, propertyChanged:OnNotifyOldTextValueWhenTextChangedChanged);

        public static ICommand GetNotifyOldTextValueWhenTextChanged(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NotifyOldTextValueWhenTextChangedProperty);
        }

		private static void OnNotifyOldTextValueWhenTextChangedChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetNotifyOldTextValueWhenTextChanged((BindableObject)o);
            if (command.CanExecute(eventArgs.OldTextValue))
                command.Execute(eventArgs.OldTextValue);
        }
		#endregion

	}
	public partial class EntryCells {

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
	public partial class Layouts {

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
	public partial class ListViews {

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

		#region NotifyItemWhenItemAppearing
        public static readonly BindableProperty NotifyItemWhenItemAppearingProperty =
            BindableProperty.CreateAttached("NotifyItemWhenItemAppearing", typeof(ICommand), typeof(ListViews), null, propertyChanged:OnNotifyItemWhenItemAppearingChanged);

        public static ICommand GetNotifyItemWhenItemAppearing(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NotifyItemWhenItemAppearingProperty);
        }

		private static void OnNotifyItemWhenItemAppearingChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetNotifyItemWhenItemAppearing((BindableObject)o);
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
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion

		#region NotifyItemWhenItemDisappearing
        public static readonly BindableProperty NotifyItemWhenItemDisappearingProperty =
            BindableProperty.CreateAttached("NotifyItemWhenItemDisappearing", typeof(ICommand), typeof(ListViews), null, propertyChanged:OnNotifyItemWhenItemDisappearingChanged);

        public static ICommand GetNotifyItemWhenItemDisappearing(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NotifyItemWhenItemDisappearingProperty);
        }

		private static void OnNotifyItemWhenItemDisappearingChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetNotifyItemWhenItemDisappearing((BindableObject)o);
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
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion

		#region NotifySelectedItemWhenItemSelected
        public static readonly BindableProperty NotifySelectedItemWhenItemSelectedProperty =
            BindableProperty.CreateAttached("NotifySelectedItemWhenItemSelected", typeof(ICommand), typeof(ListViews), null, propertyChanged:OnNotifySelectedItemWhenItemSelectedChanged);

        public static ICommand GetNotifySelectedItemWhenItemSelected(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NotifySelectedItemWhenItemSelectedProperty);
        }

		private static void OnNotifySelectedItemWhenItemSelectedChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetNotifySelectedItemWhenItemSelected((BindableObject)o);
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
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion

		#region NotifyGroupWhenItemTapped
        public static readonly BindableProperty NotifyGroupWhenItemTappedProperty =
            BindableProperty.CreateAttached("NotifyGroupWhenItemTapped", typeof(ICommand), typeof(ListViews), null, propertyChanged:OnNotifyGroupWhenItemTappedChanged);

        public static ICommand GetNotifyGroupWhenItemTapped(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NotifyGroupWhenItemTappedProperty);
        }

		private static void OnNotifyGroupWhenItemTappedChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetNotifyGroupWhenItemTapped((BindableObject)o);
            if (command.CanExecute(eventArgs.Group))
                command.Execute(eventArgs.Group);
        }
		#endregion

		#region NotifyItemWhenItemTapped
        public static readonly BindableProperty NotifyItemWhenItemTappedProperty =
            BindableProperty.CreateAttached("NotifyItemWhenItemTapped", typeof(ICommand), typeof(ListViews), null, propertyChanged:OnNotifyItemWhenItemTappedChanged);

        public static ICommand GetNotifyItemWhenItemTapped(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NotifyItemWhenItemTappedProperty);
        }

		private static void OnNotifyItemWhenItemTappedChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetNotifyItemWhenItemTapped((BindableObject)o);
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

		#region NotifyElementWhenScrollToRequested
        public static readonly BindableProperty NotifyElementWhenScrollToRequestedProperty =
            BindableProperty.CreateAttached("NotifyElementWhenScrollToRequested", typeof(ICommand), typeof(ListViews), null, propertyChanged:OnNotifyElementWhenScrollToRequestedChanged);

        public static ICommand GetNotifyElementWhenScrollToRequested(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NotifyElementWhenScrollToRequestedProperty);
        }

		private static void OnNotifyElementWhenScrollToRequestedChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetNotifyElementWhenScrollToRequested((BindableObject)o);
            if (command.CanExecute(eventArgs.Element))
                command.Execute(eventArgs.Element);
        }
		#endregion

		#region NotifyModeWhenScrollToRequested
        public static readonly BindableProperty NotifyModeWhenScrollToRequestedProperty =
            BindableProperty.CreateAttached("NotifyModeWhenScrollToRequested", typeof(ICommand), typeof(ListViews), null, propertyChanged:OnNotifyModeWhenScrollToRequestedChanged);

        public static ICommand GetNotifyModeWhenScrollToRequested(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NotifyModeWhenScrollToRequestedProperty);
        }

		private static void OnNotifyModeWhenScrollToRequestedChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetNotifyModeWhenScrollToRequested((BindableObject)o);
            if (command.CanExecute(eventArgs.Mode))
                command.Execute(eventArgs.Mode);
        }
		#endregion

		#region NotifyPositionWhenScrollToRequested
        public static readonly BindableProperty NotifyPositionWhenScrollToRequestedProperty =
            BindableProperty.CreateAttached("NotifyPositionWhenScrollToRequested", typeof(ICommand), typeof(ListViews), null, propertyChanged:OnNotifyPositionWhenScrollToRequestedChanged);

        public static ICommand GetNotifyPositionWhenScrollToRequested(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NotifyPositionWhenScrollToRequestedProperty);
        }

		private static void OnNotifyPositionWhenScrollToRequestedChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetNotifyPositionWhenScrollToRequested((BindableObject)o);
            if (command.CanExecute(eventArgs.Position))
                command.Execute(eventArgs.Position);
        }
		#endregion

		#region NotifyScrollXWhenScrollToRequested
        public static readonly BindableProperty NotifyScrollXWhenScrollToRequestedProperty =
            BindableProperty.CreateAttached("NotifyScrollXWhenScrollToRequested", typeof(ICommand), typeof(ListViews), null, propertyChanged:OnNotifyScrollXWhenScrollToRequestedChanged);

        public static ICommand GetNotifyScrollXWhenScrollToRequested(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NotifyScrollXWhenScrollToRequestedProperty);
        }

		private static void OnNotifyScrollXWhenScrollToRequestedChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetNotifyScrollXWhenScrollToRequested((BindableObject)o);
            if (command.CanExecute(eventArgs.ScrollX))
                command.Execute(eventArgs.ScrollX);
        }
		#endregion

		#region NotifyScrollYWhenScrollToRequested
        public static readonly BindableProperty NotifyScrollYWhenScrollToRequestedProperty =
            BindableProperty.CreateAttached("NotifyScrollYWhenScrollToRequested", typeof(ICommand), typeof(ListViews), null, propertyChanged:OnNotifyScrollYWhenScrollToRequestedChanged);

        public static ICommand GetNotifyScrollYWhenScrollToRequested(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NotifyScrollYWhenScrollToRequestedProperty);
        }

		private static void OnNotifyScrollYWhenScrollToRequestedChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetNotifyScrollYWhenScrollToRequested((BindableObject)o);
            if (command.CanExecute(eventArgs.ScrollY))
                command.Execute(eventArgs.ScrollY);
        }
		#endregion

		#region NotifyShouldAnimateWhenScrollToRequested
        public static readonly BindableProperty NotifyShouldAnimateWhenScrollToRequestedProperty =
            BindableProperty.CreateAttached("NotifyShouldAnimateWhenScrollToRequested", typeof(ICommand), typeof(ListViews), null, propertyChanged:OnNotifyShouldAnimateWhenScrollToRequestedChanged);

        public static ICommand GetNotifyShouldAnimateWhenScrollToRequested(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NotifyShouldAnimateWhenScrollToRequestedProperty);
        }

		private static void OnNotifyShouldAnimateWhenScrollToRequestedChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetNotifyShouldAnimateWhenScrollToRequested((BindableObject)o);
            if (command.CanExecute(eventArgs.ShouldAnimate))
                command.Execute(eventArgs.ShouldAnimate);
        }
		#endregion

	}
	public partial class MasterDetailPages {

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

		#region NotifyHandledWhenBackButtonPressed
        public static readonly BindableProperty NotifyHandledWhenBackButtonPressedProperty =
            BindableProperty.CreateAttached("NotifyHandledWhenBackButtonPressed", typeof(ICommand), typeof(MasterDetailPages), null, propertyChanged:OnNotifyHandledWhenBackButtonPressedChanged);

        public static ICommand GetNotifyHandledWhenBackButtonPressed(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NotifyHandledWhenBackButtonPressedProperty);
        }

		private static void OnNotifyHandledWhenBackButtonPressedChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetNotifyHandledWhenBackButtonPressed((BindableObject)o);
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
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion

	}
	public partial class MenuItems {

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
	public partial class NavigationPages {

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

		#region NotifyAnimatedWhenInsertPageBeforeRequested
        public static readonly BindableProperty NotifyAnimatedWhenInsertPageBeforeRequestedProperty =
            BindableProperty.CreateAttached("NotifyAnimatedWhenInsertPageBeforeRequested", typeof(ICommand), typeof(NavigationPages), null, propertyChanged:OnNotifyAnimatedWhenInsertPageBeforeRequestedChanged);

        public static ICommand GetNotifyAnimatedWhenInsertPageBeforeRequested(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NotifyAnimatedWhenInsertPageBeforeRequestedProperty);
        }

		private static void OnNotifyAnimatedWhenInsertPageBeforeRequestedChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetNotifyAnimatedWhenInsertPageBeforeRequested((BindableObject)o);
            if (command.CanExecute(eventArgs.Animated))
                command.Execute(eventArgs.Animated);
        }
		#endregion

		#region NotifyBeforePageWhenInsertPageBeforeRequested
        public static readonly BindableProperty NotifyBeforePageWhenInsertPageBeforeRequestedProperty =
            BindableProperty.CreateAttached("NotifyBeforePageWhenInsertPageBeforeRequested", typeof(ICommand), typeof(NavigationPages), null, propertyChanged:OnNotifyBeforePageWhenInsertPageBeforeRequestedChanged);

        public static ICommand GetNotifyBeforePageWhenInsertPageBeforeRequested(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NotifyBeforePageWhenInsertPageBeforeRequestedProperty);
        }

		private static void OnNotifyBeforePageWhenInsertPageBeforeRequestedChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetNotifyBeforePageWhenInsertPageBeforeRequested((BindableObject)o);
            if (command.CanExecute(eventArgs.BeforePage))
                command.Execute(eventArgs.BeforePage);
        }
		#endregion

		#region NotifyRealizeWhenInsertPageBeforeRequested
        public static readonly BindableProperty NotifyRealizeWhenInsertPageBeforeRequestedProperty =
            BindableProperty.CreateAttached("NotifyRealizeWhenInsertPageBeforeRequested", typeof(ICommand), typeof(NavigationPages), null, propertyChanged:OnNotifyRealizeWhenInsertPageBeforeRequestedChanged);

        public static ICommand GetNotifyRealizeWhenInsertPageBeforeRequested(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NotifyRealizeWhenInsertPageBeforeRequestedProperty);
        }

		private static void OnNotifyRealizeWhenInsertPageBeforeRequestedChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetNotifyRealizeWhenInsertPageBeforeRequested((BindableObject)o);
            if (command.CanExecute(eventArgs.Realize))
                command.Execute(eventArgs.Realize);
        }
		#endregion

		#region NotifyTaskWhenInsertPageBeforeRequested
        public static readonly BindableProperty NotifyTaskWhenInsertPageBeforeRequestedProperty =
            BindableProperty.CreateAttached("NotifyTaskWhenInsertPageBeforeRequested", typeof(ICommand), typeof(NavigationPages), null, propertyChanged:OnNotifyTaskWhenInsertPageBeforeRequestedChanged);

        public static ICommand GetNotifyTaskWhenInsertPageBeforeRequested(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NotifyTaskWhenInsertPageBeforeRequestedProperty);
        }

		private static void OnNotifyTaskWhenInsertPageBeforeRequestedChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetNotifyTaskWhenInsertPageBeforeRequested((BindableObject)o);
            if (command.CanExecute(eventArgs.Task))
                command.Execute(eventArgs.Task);
        }
		#endregion

		#region NotifyPageWhenInsertPageBeforeRequested
        public static readonly BindableProperty NotifyPageWhenInsertPageBeforeRequestedProperty =
            BindableProperty.CreateAttached("NotifyPageWhenInsertPageBeforeRequested", typeof(ICommand), typeof(NavigationPages), null, propertyChanged:OnNotifyPageWhenInsertPageBeforeRequestedChanged);

        public static ICommand GetNotifyPageWhenInsertPageBeforeRequested(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NotifyPageWhenInsertPageBeforeRequestedProperty);
        }

		private static void OnNotifyPageWhenInsertPageBeforeRequestedChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetNotifyPageWhenInsertPageBeforeRequested((BindableObject)o);
            if (command.CanExecute(eventArgs.Page))
                command.Execute(eventArgs.Page);
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

		#region NotifyPageWhenPopped
        public static readonly BindableProperty NotifyPageWhenPoppedProperty =
            BindableProperty.CreateAttached("NotifyPageWhenPopped", typeof(ICommand), typeof(NavigationPages), null, propertyChanged:OnNotifyPageWhenPoppedChanged);

        public static ICommand GetNotifyPageWhenPopped(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NotifyPageWhenPoppedProperty);
        }

		private static void OnNotifyPageWhenPoppedChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetNotifyPageWhenPopped((BindableObject)o);
            if (command.CanExecute(eventArgs.Page))
                command.Execute(eventArgs.Page);
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

		#region NotifyPageWhenPoppedToRoot
        public static readonly BindableProperty NotifyPageWhenPoppedToRootProperty =
            BindableProperty.CreateAttached("NotifyPageWhenPoppedToRoot", typeof(ICommand), typeof(NavigationPages), null, propertyChanged:OnNotifyPageWhenPoppedToRootChanged);

        public static ICommand GetNotifyPageWhenPoppedToRoot(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NotifyPageWhenPoppedToRootProperty);
        }

		private static void OnNotifyPageWhenPoppedToRootChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetNotifyPageWhenPoppedToRoot((BindableObject)o);
            if (command.CanExecute(eventArgs.Page))
                command.Execute(eventArgs.Page);
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

		#region NotifyAnimatedWhenPopRequested
        public static readonly BindableProperty NotifyAnimatedWhenPopRequestedProperty =
            BindableProperty.CreateAttached("NotifyAnimatedWhenPopRequested", typeof(ICommand), typeof(NavigationPages), null, propertyChanged:OnNotifyAnimatedWhenPopRequestedChanged);

        public static ICommand GetNotifyAnimatedWhenPopRequested(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NotifyAnimatedWhenPopRequestedProperty);
        }

		private static void OnNotifyAnimatedWhenPopRequestedChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetNotifyAnimatedWhenPopRequested((BindableObject)o);
            if (command.CanExecute(eventArgs.Animated))
                command.Execute(eventArgs.Animated);
        }
		#endregion

		#region NotifyBeforePageWhenPopRequested
        public static readonly BindableProperty NotifyBeforePageWhenPopRequestedProperty =
            BindableProperty.CreateAttached("NotifyBeforePageWhenPopRequested", typeof(ICommand), typeof(NavigationPages), null, propertyChanged:OnNotifyBeforePageWhenPopRequestedChanged);

        public static ICommand GetNotifyBeforePageWhenPopRequested(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NotifyBeforePageWhenPopRequestedProperty);
        }

		private static void OnNotifyBeforePageWhenPopRequestedChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetNotifyBeforePageWhenPopRequested((BindableObject)o);
            if (command.CanExecute(eventArgs.BeforePage))
                command.Execute(eventArgs.BeforePage);
        }
		#endregion

		#region NotifyRealizeWhenPopRequested
        public static readonly BindableProperty NotifyRealizeWhenPopRequestedProperty =
            BindableProperty.CreateAttached("NotifyRealizeWhenPopRequested", typeof(ICommand), typeof(NavigationPages), null, propertyChanged:OnNotifyRealizeWhenPopRequestedChanged);

        public static ICommand GetNotifyRealizeWhenPopRequested(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NotifyRealizeWhenPopRequestedProperty);
        }

		private static void OnNotifyRealizeWhenPopRequestedChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetNotifyRealizeWhenPopRequested((BindableObject)o);
            if (command.CanExecute(eventArgs.Realize))
                command.Execute(eventArgs.Realize);
        }
		#endregion

		#region NotifyTaskWhenPopRequested
        public static readonly BindableProperty NotifyTaskWhenPopRequestedProperty =
            BindableProperty.CreateAttached("NotifyTaskWhenPopRequested", typeof(ICommand), typeof(NavigationPages), null, propertyChanged:OnNotifyTaskWhenPopRequestedChanged);

        public static ICommand GetNotifyTaskWhenPopRequested(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NotifyTaskWhenPopRequestedProperty);
        }

		private static void OnNotifyTaskWhenPopRequestedChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetNotifyTaskWhenPopRequested((BindableObject)o);
            if (command.CanExecute(eventArgs.Task))
                command.Execute(eventArgs.Task);
        }
		#endregion

		#region NotifyPageWhenPopRequested
        public static readonly BindableProperty NotifyPageWhenPopRequestedProperty =
            BindableProperty.CreateAttached("NotifyPageWhenPopRequested", typeof(ICommand), typeof(NavigationPages), null, propertyChanged:OnNotifyPageWhenPopRequestedChanged);

        public static ICommand GetNotifyPageWhenPopRequested(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NotifyPageWhenPopRequestedProperty);
        }

		private static void OnNotifyPageWhenPopRequestedChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetNotifyPageWhenPopRequested((BindableObject)o);
            if (command.CanExecute(eventArgs.Page))
                command.Execute(eventArgs.Page);
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

		#region NotifyAnimatedWhenPopToRootRequested
        public static readonly BindableProperty NotifyAnimatedWhenPopToRootRequestedProperty =
            BindableProperty.CreateAttached("NotifyAnimatedWhenPopToRootRequested", typeof(ICommand), typeof(NavigationPages), null, propertyChanged:OnNotifyAnimatedWhenPopToRootRequestedChanged);

        public static ICommand GetNotifyAnimatedWhenPopToRootRequested(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NotifyAnimatedWhenPopToRootRequestedProperty);
        }

		private static void OnNotifyAnimatedWhenPopToRootRequestedChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetNotifyAnimatedWhenPopToRootRequested((BindableObject)o);
            if (command.CanExecute(eventArgs.Animated))
                command.Execute(eventArgs.Animated);
        }
		#endregion

		#region NotifyBeforePageWhenPopToRootRequested
        public static readonly BindableProperty NotifyBeforePageWhenPopToRootRequestedProperty =
            BindableProperty.CreateAttached("NotifyBeforePageWhenPopToRootRequested", typeof(ICommand), typeof(NavigationPages), null, propertyChanged:OnNotifyBeforePageWhenPopToRootRequestedChanged);

        public static ICommand GetNotifyBeforePageWhenPopToRootRequested(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NotifyBeforePageWhenPopToRootRequestedProperty);
        }

		private static void OnNotifyBeforePageWhenPopToRootRequestedChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetNotifyBeforePageWhenPopToRootRequested((BindableObject)o);
            if (command.CanExecute(eventArgs.BeforePage))
                command.Execute(eventArgs.BeforePage);
        }
		#endregion

		#region NotifyRealizeWhenPopToRootRequested
        public static readonly BindableProperty NotifyRealizeWhenPopToRootRequestedProperty =
            BindableProperty.CreateAttached("NotifyRealizeWhenPopToRootRequested", typeof(ICommand), typeof(NavigationPages), null, propertyChanged:OnNotifyRealizeWhenPopToRootRequestedChanged);

        public static ICommand GetNotifyRealizeWhenPopToRootRequested(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NotifyRealizeWhenPopToRootRequestedProperty);
        }

		private static void OnNotifyRealizeWhenPopToRootRequestedChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetNotifyRealizeWhenPopToRootRequested((BindableObject)o);
            if (command.CanExecute(eventArgs.Realize))
                command.Execute(eventArgs.Realize);
        }
		#endregion

		#region NotifyTaskWhenPopToRootRequested
        public static readonly BindableProperty NotifyTaskWhenPopToRootRequestedProperty =
            BindableProperty.CreateAttached("NotifyTaskWhenPopToRootRequested", typeof(ICommand), typeof(NavigationPages), null, propertyChanged:OnNotifyTaskWhenPopToRootRequestedChanged);

        public static ICommand GetNotifyTaskWhenPopToRootRequested(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NotifyTaskWhenPopToRootRequestedProperty);
        }

		private static void OnNotifyTaskWhenPopToRootRequestedChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetNotifyTaskWhenPopToRootRequested((BindableObject)o);
            if (command.CanExecute(eventArgs.Task))
                command.Execute(eventArgs.Task);
        }
		#endregion

		#region NotifyPageWhenPopToRootRequested
        public static readonly BindableProperty NotifyPageWhenPopToRootRequestedProperty =
            BindableProperty.CreateAttached("NotifyPageWhenPopToRootRequested", typeof(ICommand), typeof(NavigationPages), null, propertyChanged:OnNotifyPageWhenPopToRootRequestedChanged);

        public static ICommand GetNotifyPageWhenPopToRootRequested(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NotifyPageWhenPopToRootRequestedProperty);
        }

		private static void OnNotifyPageWhenPopToRootRequestedChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetNotifyPageWhenPopToRootRequested((BindableObject)o);
            if (command.CanExecute(eventArgs.Page))
                command.Execute(eventArgs.Page);
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

		#region NotifyPageWhenPushed
        public static readonly BindableProperty NotifyPageWhenPushedProperty =
            BindableProperty.CreateAttached("NotifyPageWhenPushed", typeof(ICommand), typeof(NavigationPages), null, propertyChanged:OnNotifyPageWhenPushedChanged);

        public static ICommand GetNotifyPageWhenPushed(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NotifyPageWhenPushedProperty);
        }

		private static void OnNotifyPageWhenPushedChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetNotifyPageWhenPushed((BindableObject)o);
            if (command.CanExecute(eventArgs.Page))
                command.Execute(eventArgs.Page);
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

		#region NotifyAnimatedWhenPushRequested
        public static readonly BindableProperty NotifyAnimatedWhenPushRequestedProperty =
            BindableProperty.CreateAttached("NotifyAnimatedWhenPushRequested", typeof(ICommand), typeof(NavigationPages), null, propertyChanged:OnNotifyAnimatedWhenPushRequestedChanged);

        public static ICommand GetNotifyAnimatedWhenPushRequested(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NotifyAnimatedWhenPushRequestedProperty);
        }

		private static void OnNotifyAnimatedWhenPushRequestedChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetNotifyAnimatedWhenPushRequested((BindableObject)o);
            if (command.CanExecute(eventArgs.Animated))
                command.Execute(eventArgs.Animated);
        }
		#endregion

		#region NotifyBeforePageWhenPushRequested
        public static readonly BindableProperty NotifyBeforePageWhenPushRequestedProperty =
            BindableProperty.CreateAttached("NotifyBeforePageWhenPushRequested", typeof(ICommand), typeof(NavigationPages), null, propertyChanged:OnNotifyBeforePageWhenPushRequestedChanged);

        public static ICommand GetNotifyBeforePageWhenPushRequested(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NotifyBeforePageWhenPushRequestedProperty);
        }

		private static void OnNotifyBeforePageWhenPushRequestedChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetNotifyBeforePageWhenPushRequested((BindableObject)o);
            if (command.CanExecute(eventArgs.BeforePage))
                command.Execute(eventArgs.BeforePage);
        }
		#endregion

		#region NotifyRealizeWhenPushRequested
        public static readonly BindableProperty NotifyRealizeWhenPushRequestedProperty =
            BindableProperty.CreateAttached("NotifyRealizeWhenPushRequested", typeof(ICommand), typeof(NavigationPages), null, propertyChanged:OnNotifyRealizeWhenPushRequestedChanged);

        public static ICommand GetNotifyRealizeWhenPushRequested(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NotifyRealizeWhenPushRequestedProperty);
        }

		private static void OnNotifyRealizeWhenPushRequestedChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetNotifyRealizeWhenPushRequested((BindableObject)o);
            if (command.CanExecute(eventArgs.Realize))
                command.Execute(eventArgs.Realize);
        }
		#endregion

		#region NotifyTaskWhenPushRequested
        public static readonly BindableProperty NotifyTaskWhenPushRequestedProperty =
            BindableProperty.CreateAttached("NotifyTaskWhenPushRequested", typeof(ICommand), typeof(NavigationPages), null, propertyChanged:OnNotifyTaskWhenPushRequestedChanged);

        public static ICommand GetNotifyTaskWhenPushRequested(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NotifyTaskWhenPushRequestedProperty);
        }

		private static void OnNotifyTaskWhenPushRequestedChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetNotifyTaskWhenPushRequested((BindableObject)o);
            if (command.CanExecute(eventArgs.Task))
                command.Execute(eventArgs.Task);
        }
		#endregion

		#region NotifyPageWhenPushRequested
        public static readonly BindableProperty NotifyPageWhenPushRequestedProperty =
            BindableProperty.CreateAttached("NotifyPageWhenPushRequested", typeof(ICommand), typeof(NavigationPages), null, propertyChanged:OnNotifyPageWhenPushRequestedChanged);

        public static ICommand GetNotifyPageWhenPushRequested(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NotifyPageWhenPushRequestedProperty);
        }

		private static void OnNotifyPageWhenPushRequestedChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetNotifyPageWhenPushRequested((BindableObject)o);
            if (command.CanExecute(eventArgs.Page))
                command.Execute(eventArgs.Page);
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

		#region NotifyAnimatedWhenRemovePageRequested
        public static readonly BindableProperty NotifyAnimatedWhenRemovePageRequestedProperty =
            BindableProperty.CreateAttached("NotifyAnimatedWhenRemovePageRequested", typeof(ICommand), typeof(NavigationPages), null, propertyChanged:OnNotifyAnimatedWhenRemovePageRequestedChanged);

        public static ICommand GetNotifyAnimatedWhenRemovePageRequested(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NotifyAnimatedWhenRemovePageRequestedProperty);
        }

		private static void OnNotifyAnimatedWhenRemovePageRequestedChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetNotifyAnimatedWhenRemovePageRequested((BindableObject)o);
            if (command.CanExecute(eventArgs.Animated))
                command.Execute(eventArgs.Animated);
        }
		#endregion

		#region NotifyBeforePageWhenRemovePageRequested
        public static readonly BindableProperty NotifyBeforePageWhenRemovePageRequestedProperty =
            BindableProperty.CreateAttached("NotifyBeforePageWhenRemovePageRequested", typeof(ICommand), typeof(NavigationPages), null, propertyChanged:OnNotifyBeforePageWhenRemovePageRequestedChanged);

        public static ICommand GetNotifyBeforePageWhenRemovePageRequested(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NotifyBeforePageWhenRemovePageRequestedProperty);
        }

		private static void OnNotifyBeforePageWhenRemovePageRequestedChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetNotifyBeforePageWhenRemovePageRequested((BindableObject)o);
            if (command.CanExecute(eventArgs.BeforePage))
                command.Execute(eventArgs.BeforePage);
        }
		#endregion

		#region NotifyRealizeWhenRemovePageRequested
        public static readonly BindableProperty NotifyRealizeWhenRemovePageRequestedProperty =
            BindableProperty.CreateAttached("NotifyRealizeWhenRemovePageRequested", typeof(ICommand), typeof(NavigationPages), null, propertyChanged:OnNotifyRealizeWhenRemovePageRequestedChanged);

        public static ICommand GetNotifyRealizeWhenRemovePageRequested(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NotifyRealizeWhenRemovePageRequestedProperty);
        }

		private static void OnNotifyRealizeWhenRemovePageRequestedChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetNotifyRealizeWhenRemovePageRequested((BindableObject)o);
            if (command.CanExecute(eventArgs.Realize))
                command.Execute(eventArgs.Realize);
        }
		#endregion

		#region NotifyTaskWhenRemovePageRequested
        public static readonly BindableProperty NotifyTaskWhenRemovePageRequestedProperty =
            BindableProperty.CreateAttached("NotifyTaskWhenRemovePageRequested", typeof(ICommand), typeof(NavigationPages), null, propertyChanged:OnNotifyTaskWhenRemovePageRequestedChanged);

        public static ICommand GetNotifyTaskWhenRemovePageRequested(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NotifyTaskWhenRemovePageRequestedProperty);
        }

		private static void OnNotifyTaskWhenRemovePageRequestedChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetNotifyTaskWhenRemovePageRequested((BindableObject)o);
            if (command.CanExecute(eventArgs.Task))
                command.Execute(eventArgs.Task);
        }
		#endregion

		#region NotifyPageWhenRemovePageRequested
        public static readonly BindableProperty NotifyPageWhenRemovePageRequestedProperty =
            BindableProperty.CreateAttached("NotifyPageWhenRemovePageRequested", typeof(ICommand), typeof(NavigationPages), null, propertyChanged:OnNotifyPageWhenRemovePageRequestedChanged);

        public static ICommand GetNotifyPageWhenRemovePageRequested(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NotifyPageWhenRemovePageRequestedProperty);
        }

		private static void OnNotifyPageWhenRemovePageRequestedChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetNotifyPageWhenRemovePageRequested((BindableObject)o);
            if (command.CanExecute(eventArgs.Page))
                command.Execute(eventArgs.Page);
        }
		#endregion

	}
	public partial class OpenGLViews {

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
	public partial class Pages {

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
	public partial class PanGestureRecognizers {

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

		#region NotifyGestureIdWhenPanUpdated
        public static readonly BindableProperty NotifyGestureIdWhenPanUpdatedProperty =
            BindableProperty.CreateAttached("NotifyGestureIdWhenPanUpdated", typeof(ICommand), typeof(PanGestureRecognizers), null, propertyChanged:OnNotifyGestureIdWhenPanUpdatedChanged);

        public static ICommand GetNotifyGestureIdWhenPanUpdated(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NotifyGestureIdWhenPanUpdatedProperty);
        }

		private static void OnNotifyGestureIdWhenPanUpdatedChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetNotifyGestureIdWhenPanUpdated((BindableObject)o);
            if (command.CanExecute(eventArgs.GestureId))
                command.Execute(eventArgs.GestureId);
        }
		#endregion

		#region NotifyStatusTypeWhenPanUpdated
        public static readonly BindableProperty NotifyStatusTypeWhenPanUpdatedProperty =
            BindableProperty.CreateAttached("NotifyStatusTypeWhenPanUpdated", typeof(ICommand), typeof(PanGestureRecognizers), null, propertyChanged:OnNotifyStatusTypeWhenPanUpdatedChanged);

        public static ICommand GetNotifyStatusTypeWhenPanUpdated(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NotifyStatusTypeWhenPanUpdatedProperty);
        }

		private static void OnNotifyStatusTypeWhenPanUpdatedChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetNotifyStatusTypeWhenPanUpdated((BindableObject)o);
            if (command.CanExecute(eventArgs.StatusType))
                command.Execute(eventArgs.StatusType);
        }
		#endregion

		#region NotifyTotalXWhenPanUpdated
        public static readonly BindableProperty NotifyTotalXWhenPanUpdatedProperty =
            BindableProperty.CreateAttached("NotifyTotalXWhenPanUpdated", typeof(ICommand), typeof(PanGestureRecognizers), null, propertyChanged:OnNotifyTotalXWhenPanUpdatedChanged);

        public static ICommand GetNotifyTotalXWhenPanUpdated(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NotifyTotalXWhenPanUpdatedProperty);
        }

		private static void OnNotifyTotalXWhenPanUpdatedChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetNotifyTotalXWhenPanUpdated((BindableObject)o);
            if (command.CanExecute(eventArgs.TotalX))
                command.Execute(eventArgs.TotalX);
        }
		#endregion

		#region NotifyTotalYWhenPanUpdated
        public static readonly BindableProperty NotifyTotalYWhenPanUpdatedProperty =
            BindableProperty.CreateAttached("NotifyTotalYWhenPanUpdated", typeof(ICommand), typeof(PanGestureRecognizers), null, propertyChanged:OnNotifyTotalYWhenPanUpdatedChanged);

        public static ICommand GetNotifyTotalYWhenPanUpdated(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NotifyTotalYWhenPanUpdatedProperty);
        }

		private static void OnNotifyTotalYWhenPanUpdatedChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetNotifyTotalYWhenPanUpdated((BindableObject)o);
            if (command.CanExecute(eventArgs.TotalY))
                command.Execute(eventArgs.TotalY);
        }
		#endregion

	}
	public partial class Pickers {

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
	public partial class PinchGestureRecognizers {

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

		#region NotifyScaleWhenPinchUpdated
        public static readonly BindableProperty NotifyScaleWhenPinchUpdatedProperty =
            BindableProperty.CreateAttached("NotifyScaleWhenPinchUpdated", typeof(ICommand), typeof(PinchGestureRecognizers), null, propertyChanged:OnNotifyScaleWhenPinchUpdatedChanged);

        public static ICommand GetNotifyScaleWhenPinchUpdated(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NotifyScaleWhenPinchUpdatedProperty);
        }

		private static void OnNotifyScaleWhenPinchUpdatedChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetNotifyScaleWhenPinchUpdated((BindableObject)o);
            if (command.CanExecute(eventArgs.Scale))
                command.Execute(eventArgs.Scale);
        }
		#endregion

		#region NotifyScaleOriginWhenPinchUpdated
        public static readonly BindableProperty NotifyScaleOriginWhenPinchUpdatedProperty =
            BindableProperty.CreateAttached("NotifyScaleOriginWhenPinchUpdated", typeof(ICommand), typeof(PinchGestureRecognizers), null, propertyChanged:OnNotifyScaleOriginWhenPinchUpdatedChanged);

        public static ICommand GetNotifyScaleOriginWhenPinchUpdated(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NotifyScaleOriginWhenPinchUpdatedProperty);
        }

		private static void OnNotifyScaleOriginWhenPinchUpdatedChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetNotifyScaleOriginWhenPinchUpdated((BindableObject)o);
            if (command.CanExecute(eventArgs.ScaleOrigin))
                command.Execute(eventArgs.ScaleOrigin);
        }
		#endregion

		#region NotifyStatusWhenPinchUpdated
        public static readonly BindableProperty NotifyStatusWhenPinchUpdatedProperty =
            BindableProperty.CreateAttached("NotifyStatusWhenPinchUpdated", typeof(ICommand), typeof(PinchGestureRecognizers), null, propertyChanged:OnNotifyStatusWhenPinchUpdatedChanged);

        public static ICommand GetNotifyStatusWhenPinchUpdated(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NotifyStatusWhenPinchUpdatedProperty);
        }

		private static void OnNotifyStatusWhenPinchUpdatedChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetNotifyStatusWhenPinchUpdated((BindableObject)o);
            if (command.CanExecute(eventArgs.Status))
                command.Execute(eventArgs.Status);
        }
		#endregion

	}
	public partial class RowDefinitions {

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
	public partial class ScrollViews {

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

		#region NotifyScrollXWhenScrolled
        public static readonly BindableProperty NotifyScrollXWhenScrolledProperty =
            BindableProperty.CreateAttached("NotifyScrollXWhenScrolled", typeof(ICommand), typeof(ScrollViews), null, propertyChanged:OnNotifyScrollXWhenScrolledChanged);

        public static ICommand GetNotifyScrollXWhenScrolled(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NotifyScrollXWhenScrolledProperty);
        }

		private static void OnNotifyScrollXWhenScrolledChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetNotifyScrollXWhenScrolled((BindableObject)o);
            if (command.CanExecute(eventArgs.ScrollX))
                command.Execute(eventArgs.ScrollX);
        }
		#endregion

		#region NotifyScrollYWhenScrolled
        public static readonly BindableProperty NotifyScrollYWhenScrolledProperty =
            BindableProperty.CreateAttached("NotifyScrollYWhenScrolled", typeof(ICommand), typeof(ScrollViews), null, propertyChanged:OnNotifyScrollYWhenScrolledChanged);

        public static ICommand GetNotifyScrollYWhenScrolled(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NotifyScrollYWhenScrolledProperty);
        }

		private static void OnNotifyScrollYWhenScrolledChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetNotifyScrollYWhenScrolled((BindableObject)o);
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
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion

		#region NotifyElementWhenScrollToRequested
        public static readonly BindableProperty NotifyElementWhenScrollToRequestedProperty =
            BindableProperty.CreateAttached("NotifyElementWhenScrollToRequested", typeof(ICommand), typeof(ScrollViews), null, propertyChanged:OnNotifyElementWhenScrollToRequestedChanged);

        public static ICommand GetNotifyElementWhenScrollToRequested(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NotifyElementWhenScrollToRequestedProperty);
        }

		private static void OnNotifyElementWhenScrollToRequestedChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetNotifyElementWhenScrollToRequested((BindableObject)o);
            if (command.CanExecute(eventArgs.Element))
                command.Execute(eventArgs.Element);
        }
		#endregion

		#region NotifyModeWhenScrollToRequested
        public static readonly BindableProperty NotifyModeWhenScrollToRequestedProperty =
            BindableProperty.CreateAttached("NotifyModeWhenScrollToRequested", typeof(ICommand), typeof(ScrollViews), null, propertyChanged:OnNotifyModeWhenScrollToRequestedChanged);

        public static ICommand GetNotifyModeWhenScrollToRequested(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NotifyModeWhenScrollToRequestedProperty);
        }

		private static void OnNotifyModeWhenScrollToRequestedChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetNotifyModeWhenScrollToRequested((BindableObject)o);
            if (command.CanExecute(eventArgs.Mode))
                command.Execute(eventArgs.Mode);
        }
		#endregion

		#region NotifyPositionWhenScrollToRequested
        public static readonly BindableProperty NotifyPositionWhenScrollToRequestedProperty =
            BindableProperty.CreateAttached("NotifyPositionWhenScrollToRequested", typeof(ICommand), typeof(ScrollViews), null, propertyChanged:OnNotifyPositionWhenScrollToRequestedChanged);

        public static ICommand GetNotifyPositionWhenScrollToRequested(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NotifyPositionWhenScrollToRequestedProperty);
        }

		private static void OnNotifyPositionWhenScrollToRequestedChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetNotifyPositionWhenScrollToRequested((BindableObject)o);
            if (command.CanExecute(eventArgs.Position))
                command.Execute(eventArgs.Position);
        }
		#endregion

		#region NotifyScrollXWhenScrollToRequested
        public static readonly BindableProperty NotifyScrollXWhenScrollToRequestedProperty =
            BindableProperty.CreateAttached("NotifyScrollXWhenScrollToRequested", typeof(ICommand), typeof(ScrollViews), null, propertyChanged:OnNotifyScrollXWhenScrollToRequestedChanged);

        public static ICommand GetNotifyScrollXWhenScrollToRequested(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NotifyScrollXWhenScrollToRequestedProperty);
        }

		private static void OnNotifyScrollXWhenScrollToRequestedChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetNotifyScrollXWhenScrollToRequested((BindableObject)o);
            if (command.CanExecute(eventArgs.ScrollX))
                command.Execute(eventArgs.ScrollX);
        }
		#endregion

		#region NotifyScrollYWhenScrollToRequested
        public static readonly BindableProperty NotifyScrollYWhenScrollToRequestedProperty =
            BindableProperty.CreateAttached("NotifyScrollYWhenScrollToRequested", typeof(ICommand), typeof(ScrollViews), null, propertyChanged:OnNotifyScrollYWhenScrollToRequestedChanged);

        public static ICommand GetNotifyScrollYWhenScrollToRequested(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NotifyScrollYWhenScrollToRequestedProperty);
        }

		private static void OnNotifyScrollYWhenScrollToRequestedChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetNotifyScrollYWhenScrollToRequested((BindableObject)o);
            if (command.CanExecute(eventArgs.ScrollY))
                command.Execute(eventArgs.ScrollY);
        }
		#endregion

		#region NotifyShouldAnimateWhenScrollToRequested
        public static readonly BindableProperty NotifyShouldAnimateWhenScrollToRequestedProperty =
            BindableProperty.CreateAttached("NotifyShouldAnimateWhenScrollToRequested", typeof(ICommand), typeof(ScrollViews), null, propertyChanged:OnNotifyShouldAnimateWhenScrollToRequestedChanged);

        public static ICommand GetNotifyShouldAnimateWhenScrollToRequested(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NotifyShouldAnimateWhenScrollToRequestedProperty);
        }

		private static void OnNotifyShouldAnimateWhenScrollToRequestedChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetNotifyShouldAnimateWhenScrollToRequested((BindableObject)o);
            if (command.CanExecute(eventArgs.ShouldAnimate))
                command.Execute(eventArgs.ShouldAnimate);
        }
		#endregion

	}
	public partial class SearchBars {

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

		#region NotifyNewTextValueWhenTextChanged
        public static readonly BindableProperty NotifyNewTextValueWhenTextChangedProperty =
            BindableProperty.CreateAttached("NotifyNewTextValueWhenTextChanged", typeof(ICommand), typeof(SearchBars), null, propertyChanged:OnNotifyNewTextValueWhenTextChangedChanged);

        public static ICommand GetNotifyNewTextValueWhenTextChanged(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NotifyNewTextValueWhenTextChangedProperty);
        }

		private static void OnNotifyNewTextValueWhenTextChangedChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetNotifyNewTextValueWhenTextChanged((BindableObject)o);
            if (command.CanExecute(eventArgs.NewTextValue))
                command.Execute(eventArgs.NewTextValue);
        }
		#endregion

		#region NotifyOldTextValueWhenTextChanged
        public static readonly BindableProperty NotifyOldTextValueWhenTextChangedProperty =
            BindableProperty.CreateAttached("NotifyOldTextValueWhenTextChanged", typeof(ICommand), typeof(SearchBars), null, propertyChanged:OnNotifyOldTextValueWhenTextChangedChanged);

        public static ICommand GetNotifyOldTextValueWhenTextChanged(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NotifyOldTextValueWhenTextChangedProperty);
        }

		private static void OnNotifyOldTextValueWhenTextChangedChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetNotifyOldTextValueWhenTextChanged((BindableObject)o);
            if (command.CanExecute(eventArgs.OldTextValue))
                command.Execute(eventArgs.OldTextValue);
        }
		#endregion

	}
	public partial class Sliders {

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

		#region NotifyNewValueWhenValueChanged
        public static readonly BindableProperty NotifyNewValueWhenValueChangedProperty =
            BindableProperty.CreateAttached("NotifyNewValueWhenValueChanged", typeof(ICommand), typeof(Sliders), null, propertyChanged:OnNotifyNewValueWhenValueChangedChanged);

        public static ICommand GetNotifyNewValueWhenValueChanged(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NotifyNewValueWhenValueChangedProperty);
        }

		private static void OnNotifyNewValueWhenValueChangedChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetNotifyNewValueWhenValueChanged((BindableObject)o);
            if (command.CanExecute(eventArgs.NewValue))
                command.Execute(eventArgs.NewValue);
        }
		#endregion

		#region NotifyOldValueWhenValueChanged
        public static readonly BindableProperty NotifyOldValueWhenValueChangedProperty =
            BindableProperty.CreateAttached("NotifyOldValueWhenValueChanged", typeof(ICommand), typeof(Sliders), null, propertyChanged:OnNotifyOldValueWhenValueChangedChanged);

        public static ICommand GetNotifyOldValueWhenValueChanged(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NotifyOldValueWhenValueChangedProperty);
        }

		private static void OnNotifyOldValueWhenValueChangedChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetNotifyOldValueWhenValueChanged((BindableObject)o);
            if (command.CanExecute(eventArgs.OldValue))
                command.Execute(eventArgs.OldValue);
        }
		#endregion

	}
	public partial class Steppers {

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

		#region NotifyNewValueWhenValueChanged
        public static readonly BindableProperty NotifyNewValueWhenValueChangedProperty =
            BindableProperty.CreateAttached("NotifyNewValueWhenValueChanged", typeof(ICommand), typeof(Steppers), null, propertyChanged:OnNotifyNewValueWhenValueChangedChanged);

        public static ICommand GetNotifyNewValueWhenValueChanged(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NotifyNewValueWhenValueChangedProperty);
        }

		private static void OnNotifyNewValueWhenValueChangedChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetNotifyNewValueWhenValueChanged((BindableObject)o);
            if (command.CanExecute(eventArgs.NewValue))
                command.Execute(eventArgs.NewValue);
        }
		#endregion

		#region NotifyOldValueWhenValueChanged
        public static readonly BindableProperty NotifyOldValueWhenValueChangedProperty =
            BindableProperty.CreateAttached("NotifyOldValueWhenValueChanged", typeof(ICommand), typeof(Steppers), null, propertyChanged:OnNotifyOldValueWhenValueChangedChanged);

        public static ICommand GetNotifyOldValueWhenValueChanged(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NotifyOldValueWhenValueChangedProperty);
        }

		private static void OnNotifyOldValueWhenValueChangedChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetNotifyOldValueWhenValueChanged((BindableObject)o);
            if (command.CanExecute(eventArgs.OldValue))
                command.Execute(eventArgs.OldValue);
        }
		#endregion

	}
	public partial class Switchs {

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

		#region NotifyValueWhenToggled
        public static readonly BindableProperty NotifyValueWhenToggledProperty =
            BindableProperty.CreateAttached("NotifyValueWhenToggled", typeof(ICommand), typeof(Switchs), null, propertyChanged:OnNotifyValueWhenToggledChanged);

        public static ICommand GetNotifyValueWhenToggled(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NotifyValueWhenToggledProperty);
        }

		private static void OnNotifyValueWhenToggledChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetNotifyValueWhenToggled((BindableObject)o);
            if (command.CanExecute(eventArgs.Value))
                command.Execute(eventArgs.Value);
        }
		#endregion

	}
	public partial class SwitchCells {

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

		#region NotifyValueWhenOnChanged
        public static readonly BindableProperty NotifyValueWhenOnChangedProperty =
            BindableProperty.CreateAttached("NotifyValueWhenOnChanged", typeof(ICommand), typeof(SwitchCells), null, propertyChanged:OnNotifyValueWhenOnChangedChanged);

        public static ICommand GetNotifyValueWhenOnChanged(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NotifyValueWhenOnChangedProperty);
        }

		private static void OnNotifyValueWhenOnChangedChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetNotifyValueWhenOnChanged((BindableObject)o);
            if (command.CanExecute(eventArgs.Value))
                command.Execute(eventArgs.Value);
        }
		#endregion

	}
	public partial class TableViews {

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
	public partial class TapGestureRecognizers {

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
	public partial class ToolbarItems {
	}
	public partial class VisualElements {

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

		#region NotifyDataWhenBatchCommitted
        public static readonly BindableProperty NotifyDataWhenBatchCommittedProperty =
            BindableProperty.CreateAttached("NotifyDataWhenBatchCommitted", typeof(ICommand), typeof(VisualElements), null, propertyChanged:OnNotifyDataWhenBatchCommittedChanged);

        public static ICommand GetNotifyDataWhenBatchCommitted(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NotifyDataWhenBatchCommittedProperty);
        }

		private static void OnNotifyDataWhenBatchCommittedChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetNotifyDataWhenBatchCommitted((BindableObject)o);
            if (command.CanExecute(eventArgs.Data))
                command.Execute(eventArgs.Data);
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

		#region NotifyFocusWhenFocusChangeRequested
        public static readonly BindableProperty NotifyFocusWhenFocusChangeRequestedProperty =
            BindableProperty.CreateAttached("NotifyFocusWhenFocusChangeRequested", typeof(ICommand), typeof(VisualElements), null, propertyChanged:OnNotifyFocusWhenFocusChangeRequestedChanged);

        public static ICommand GetNotifyFocusWhenFocusChangeRequested(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NotifyFocusWhenFocusChangeRequestedProperty);
        }

		private static void OnNotifyFocusWhenFocusChangeRequestedChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetNotifyFocusWhenFocusChangeRequested((BindableObject)o);
            if (command.CanExecute(eventArgs.Focus))
                command.Execute(eventArgs.Focus);
        }
		#endregion

		#region NotifyResultWhenFocusChangeRequested
        public static readonly BindableProperty NotifyResultWhenFocusChangeRequestedProperty =
            BindableProperty.CreateAttached("NotifyResultWhenFocusChangeRequested", typeof(ICommand), typeof(VisualElements), null, propertyChanged:OnNotifyResultWhenFocusChangeRequestedChanged);

        public static ICommand GetNotifyResultWhenFocusChangeRequested(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NotifyResultWhenFocusChangeRequestedProperty);
        }

		private static void OnNotifyResultWhenFocusChangeRequestedChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetNotifyResultWhenFocusChangeRequested((BindableObject)o);
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
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion

		#region NotifyIsFocusedWhenFocused
        public static readonly BindableProperty NotifyIsFocusedWhenFocusedProperty =
            BindableProperty.CreateAttached("NotifyIsFocusedWhenFocused", typeof(ICommand), typeof(VisualElements), null, propertyChanged:OnNotifyIsFocusedWhenFocusedChanged);

        public static ICommand GetNotifyIsFocusedWhenFocused(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NotifyIsFocusedWhenFocusedProperty);
        }

		private static void OnNotifyIsFocusedWhenFocusedChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetNotifyIsFocusedWhenFocused((BindableObject)o);
            if (command.CanExecute(eventArgs.IsFocused))
                command.Execute(eventArgs.IsFocused);
        }
		#endregion

		#region NotifyVisualElementWhenFocused
        public static readonly BindableProperty NotifyVisualElementWhenFocusedProperty =
            BindableProperty.CreateAttached("NotifyVisualElementWhenFocused", typeof(ICommand), typeof(VisualElements), null, propertyChanged:OnNotifyVisualElementWhenFocusedChanged);

        public static ICommand GetNotifyVisualElementWhenFocused(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NotifyVisualElementWhenFocusedProperty);
        }

		private static void OnNotifyVisualElementWhenFocusedChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetNotifyVisualElementWhenFocused((BindableObject)o);
            if (command.CanExecute(eventArgs.VisualElement))
                command.Execute(eventArgs.VisualElement);
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

		#region NotifyIsFocusedWhenUnfocused
        public static readonly BindableProperty NotifyIsFocusedWhenUnfocusedProperty =
            BindableProperty.CreateAttached("NotifyIsFocusedWhenUnfocused", typeof(ICommand), typeof(VisualElements), null, propertyChanged:OnNotifyIsFocusedWhenUnfocusedChanged);

        public static ICommand GetNotifyIsFocusedWhenUnfocused(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NotifyIsFocusedWhenUnfocusedProperty);
        }

		private static void OnNotifyIsFocusedWhenUnfocusedChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetNotifyIsFocusedWhenUnfocused((BindableObject)o);
            if (command.CanExecute(eventArgs.IsFocused))
                command.Execute(eventArgs.IsFocused);
        }
		#endregion

		#region NotifyVisualElementWhenUnfocused
        public static readonly BindableProperty NotifyVisualElementWhenUnfocusedProperty =
            BindableProperty.CreateAttached("NotifyVisualElementWhenUnfocused", typeof(ICommand), typeof(VisualElements), null, propertyChanged:OnNotifyVisualElementWhenUnfocusedChanged);

        public static ICommand GetNotifyVisualElementWhenUnfocused(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NotifyVisualElementWhenUnfocusedProperty);
        }

		private static void OnNotifyVisualElementWhenUnfocusedChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetNotifyVisualElementWhenUnfocused((BindableObject)o);
            if (command.CanExecute(eventArgs.VisualElement))
                command.Execute(eventArgs.VisualElement);
        }
		#endregion

	}
	public partial class WebViews {

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

		#region NotifyScriptWhenEvalRequested
        public static readonly BindableProperty NotifyScriptWhenEvalRequestedProperty =
            BindableProperty.CreateAttached("NotifyScriptWhenEvalRequested", typeof(ICommand), typeof(WebViews), null, propertyChanged:OnNotifyScriptWhenEvalRequestedChanged);

        public static ICommand GetNotifyScriptWhenEvalRequested(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NotifyScriptWhenEvalRequestedProperty);
        }

		private static void OnNotifyScriptWhenEvalRequestedChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetNotifyScriptWhenEvalRequested((BindableObject)o);
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

		#region NotifyResultWhenNavigated
        public static readonly BindableProperty NotifyResultWhenNavigatedProperty =
            BindableProperty.CreateAttached("NotifyResultWhenNavigated", typeof(ICommand), typeof(WebViews), null, propertyChanged:OnNotifyResultWhenNavigatedChanged);

        public static ICommand GetNotifyResultWhenNavigated(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NotifyResultWhenNavigatedProperty);
        }

		private static void OnNotifyResultWhenNavigatedChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetNotifyResultWhenNavigated((BindableObject)o);
            if (command.CanExecute(eventArgs.Result))
                command.Execute(eventArgs.Result);
        }
		#endregion

		#region NotifyNavigationEventWhenNavigated
        public static readonly BindableProperty NotifyNavigationEventWhenNavigatedProperty =
            BindableProperty.CreateAttached("NotifyNavigationEventWhenNavigated", typeof(ICommand), typeof(WebViews), null, propertyChanged:OnNotifyNavigationEventWhenNavigatedChanged);

        public static ICommand GetNotifyNavigationEventWhenNavigated(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NotifyNavigationEventWhenNavigatedProperty);
        }

		private static void OnNotifyNavigationEventWhenNavigatedChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetNotifyNavigationEventWhenNavigated((BindableObject)o);
            if (command.CanExecute(eventArgs.NavigationEvent))
                command.Execute(eventArgs.NavigationEvent);
        }
		#endregion

		#region NotifySourceWhenNavigated
        public static readonly BindableProperty NotifySourceWhenNavigatedProperty =
            BindableProperty.CreateAttached("NotifySourceWhenNavigated", typeof(ICommand), typeof(WebViews), null, propertyChanged:OnNotifySourceWhenNavigatedChanged);

        public static ICommand GetNotifySourceWhenNavigated(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NotifySourceWhenNavigatedProperty);
        }

		private static void OnNotifySourceWhenNavigatedChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetNotifySourceWhenNavigated((BindableObject)o);
            if (command.CanExecute(eventArgs.Source))
                command.Execute(eventArgs.Source);
        }
		#endregion

		#region NotifyUrlWhenNavigated
        public static readonly BindableProperty NotifyUrlWhenNavigatedProperty =
            BindableProperty.CreateAttached("NotifyUrlWhenNavigated", typeof(ICommand), typeof(WebViews), null, propertyChanged:OnNotifyUrlWhenNavigatedChanged);

        public static ICommand GetNotifyUrlWhenNavigated(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NotifyUrlWhenNavigatedProperty);
        }

		private static void OnNotifyUrlWhenNavigatedChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetNotifyUrlWhenNavigated((BindableObject)o);
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
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion

		#region NotifyCancelWhenNavigating
        public static readonly BindableProperty NotifyCancelWhenNavigatingProperty =
            BindableProperty.CreateAttached("NotifyCancelWhenNavigating", typeof(ICommand), typeof(WebViews), null, propertyChanged:OnNotifyCancelWhenNavigatingChanged);

        public static ICommand GetNotifyCancelWhenNavigating(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NotifyCancelWhenNavigatingProperty);
        }

		private static void OnNotifyCancelWhenNavigatingChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetNotifyCancelWhenNavigating((BindableObject)o);
            if (command.CanExecute(eventArgs.Cancel))
                command.Execute(eventArgs.Cancel);
        }
		#endregion

		#region NotifyNavigationEventWhenNavigating
        public static readonly BindableProperty NotifyNavigationEventWhenNavigatingProperty =
            BindableProperty.CreateAttached("NotifyNavigationEventWhenNavigating", typeof(ICommand), typeof(WebViews), null, propertyChanged:OnNotifyNavigationEventWhenNavigatingChanged);

        public static ICommand GetNotifyNavigationEventWhenNavigating(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NotifyNavigationEventWhenNavigatingProperty);
        }

		private static void OnNotifyNavigationEventWhenNavigatingChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetNotifyNavigationEventWhenNavigating((BindableObject)o);
            if (command.CanExecute(eventArgs.NavigationEvent))
                command.Execute(eventArgs.NavigationEvent);
        }
		#endregion

		#region NotifySourceWhenNavigating
        public static readonly BindableProperty NotifySourceWhenNavigatingProperty =
            BindableProperty.CreateAttached("NotifySourceWhenNavigating", typeof(ICommand), typeof(WebViews), null, propertyChanged:OnNotifySourceWhenNavigatingChanged);

        public static ICommand GetNotifySourceWhenNavigating(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NotifySourceWhenNavigatingProperty);
        }

		private static void OnNotifySourceWhenNavigatingChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetNotifySourceWhenNavigating((BindableObject)o);
            if (command.CanExecute(eventArgs.Source))
                command.Execute(eventArgs.Source);
        }
		#endregion

		#region NotifyUrlWhenNavigating
        public static readonly BindableProperty NotifyUrlWhenNavigatingProperty =
            BindableProperty.CreateAttached("NotifyUrlWhenNavigating", typeof(ICommand), typeof(WebViews), null, propertyChanged:OnNotifyUrlWhenNavigatingChanged);

        public static ICommand GetNotifyUrlWhenNavigating(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NotifyUrlWhenNavigatingProperty);
        }

		private static void OnNotifyUrlWhenNavigatingChanged(BindableObject bindable, object oldValue, object newValue)
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
            var command = GetNotifyUrlWhenNavigating((BindableObject)o);
            if (command.CanExecute(eventArgs.Url))
                command.Execute(eventArgs.Url);
        }
		#endregion

	}
}
