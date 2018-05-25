using System;
using System.Windows.Input;
using Xamarin.Forms.Internals;

namespace Xamarin.Forms.BehaviorsPack {

	[Obsolete]
	public class ApplicationModalPopped {

		#region Command
		[Obsolete]
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(ApplicationModalPopped), null, propertyChanged:OnCommandChanged);

		[Obsolete]
        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

		[Obsolete]
		private static void OnCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Application target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.ModalPopped += OnCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.ModalPopped -= OnCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion

		#region ModalCommand
		[Obsolete]
        public static readonly BindableProperty ModalCommandProperty =
            BindableProperty.CreateAttached("ModalCommand", typeof(ICommand), typeof(ApplicationModalPopped), null, propertyChanged:OnModalCommandChanged);

		[Obsolete]
        public static ICommand GetModalCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ModalCommandProperty);
        }

		[Obsolete]
		private static void OnModalCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Application target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.ModalPopped += OnModalCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.ModalPopped -= OnModalCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnModalCommandChanged(object o, Xamarin.Forms.ModalPoppedEventArgs eventArgs)
        {
            var command = GetModalCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Modal))
                command.Execute(eventArgs.Modal);
        }
		#endregion
	}

	[Obsolete]
	public class ApplicationModalPopping {

		#region Command
		[Obsolete]
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(ApplicationModalPopping), null, propertyChanged:OnCommandChanged);

		[Obsolete]
        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

		[Obsolete]
		private static void OnCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Application target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.ModalPopping += OnCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.ModalPopping -= OnCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion

		#region CancelCommand
		[Obsolete]
        public static readonly BindableProperty CancelCommandProperty =
            BindableProperty.CreateAttached("CancelCommand", typeof(ICommand), typeof(ApplicationModalPopping), null, propertyChanged:OnCancelCommandChanged);

		[Obsolete]
        public static ICommand GetCancelCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CancelCommandProperty);
        }

		[Obsolete]
		private static void OnCancelCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Application target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.ModalPopping += OnCancelCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.ModalPopping -= OnCancelCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnCancelCommandChanged(object o, Xamarin.Forms.ModalPoppingEventArgs eventArgs)
        {
            var command = GetCancelCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Cancel))
                command.Execute(eventArgs.Cancel);
        }
		#endregion

		#region ModalCommand
		[Obsolete]
        public static readonly BindableProperty ModalCommandProperty =
            BindableProperty.CreateAttached("ModalCommand", typeof(ICommand), typeof(ApplicationModalPopping), null, propertyChanged:OnModalCommandChanged);

		[Obsolete]
        public static ICommand GetModalCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ModalCommandProperty);
        }

		[Obsolete]
		private static void OnModalCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Application target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.ModalPopping += OnModalCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.ModalPopping -= OnModalCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnModalCommandChanged(object o, Xamarin.Forms.ModalPoppingEventArgs eventArgs)
        {
            var command = GetModalCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Modal))
                command.Execute(eventArgs.Modal);
        }
		#endregion
	}

	[Obsolete]
	public class ApplicationModalPushed {

		#region Command
		[Obsolete]
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(ApplicationModalPushed), null, propertyChanged:OnCommandChanged);

		[Obsolete]
        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

		[Obsolete]
		private static void OnCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Application target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.ModalPushed += OnCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.ModalPushed -= OnCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion

		#region ModalCommand
		[Obsolete]
        public static readonly BindableProperty ModalCommandProperty =
            BindableProperty.CreateAttached("ModalCommand", typeof(ICommand), typeof(ApplicationModalPushed), null, propertyChanged:OnModalCommandChanged);

		[Obsolete]
        public static ICommand GetModalCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ModalCommandProperty);
        }

		[Obsolete]
		private static void OnModalCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Application target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.ModalPushed += OnModalCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.ModalPushed -= OnModalCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnModalCommandChanged(object o, Xamarin.Forms.ModalPushedEventArgs eventArgs)
        {
            var command = GetModalCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Modal))
                command.Execute(eventArgs.Modal);
        }
		#endregion
	}

	[Obsolete]
	public class ApplicationModalPushing {

		#region Command
		[Obsolete]
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(ApplicationModalPushing), null, propertyChanged:OnCommandChanged);

		[Obsolete]
        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

		[Obsolete]
		private static void OnCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Application target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.ModalPushing += OnCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.ModalPushing -= OnCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion

		#region ModalCommand
		[Obsolete]
        public static readonly BindableProperty ModalCommandProperty =
            BindableProperty.CreateAttached("ModalCommand", typeof(ICommand), typeof(ApplicationModalPushing), null, propertyChanged:OnModalCommandChanged);

		[Obsolete]
        public static ICommand GetModalCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ModalCommandProperty);
        }

		[Obsolete]
		private static void OnModalCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Application target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.ModalPushing += OnModalCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.ModalPushing -= OnModalCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnModalCommandChanged(object o, Xamarin.Forms.ModalPushingEventArgs eventArgs)
        {
            var command = GetModalCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Modal))
                command.Execute(eventArgs.Modal);
        }
		#endregion
	}

	[Obsolete]
	public class ButtonClicked {

		#region Command
		[Obsolete]
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(ButtonClicked), null, propertyChanged:OnCommandChanged);

		[Obsolete]
        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

		[Obsolete]
		private static void OnCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Button target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.Clicked += OnCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.Clicked -= OnCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion
	}

	[Obsolete]
	public class ButtonPressed {

		#region Command
		[Obsolete]
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(ButtonPressed), null, propertyChanged:OnCommandChanged);

		[Obsolete]
        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

		[Obsolete]
		private static void OnCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Button target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.Pressed += OnCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.Pressed -= OnCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion
	}

	[Obsolete]
	public class ButtonReleased {

		#region Command
		[Obsolete]
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(ButtonReleased), null, propertyChanged:OnCommandChanged);

		[Obsolete]
        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

		[Obsolete]
		private static void OnCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Button target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.Released += OnCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.Released -= OnCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion
	}

	[Obsolete]
	public class CellAppearing {

		#region Command
		[Obsolete]
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(CellAppearing), null, propertyChanged:OnCommandChanged);

		[Obsolete]
        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

		[Obsolete]
		private static void OnCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Cell target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.Appearing += OnCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.Appearing -= OnCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion
	}

	[Obsolete]
	public class CellDisappearing {

		#region Command
		[Obsolete]
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(CellDisappearing), null, propertyChanged:OnCommandChanged);

		[Obsolete]
        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

		[Obsolete]
		private static void OnCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Cell target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.Disappearing += OnCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.Disappearing -= OnCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion
	}

	[Obsolete]
	public class CellForceUpdateSizeRequested {

		#region Command
		[Obsolete]
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(CellForceUpdateSizeRequested), null, propertyChanged:OnCommandChanged);

		[Obsolete]
        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

		[Obsolete]
		private static void OnCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Cell target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.ForceUpdateSizeRequested += OnCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.ForceUpdateSizeRequested -= OnCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion
	}

	[Obsolete]
	public class CellTapped {

		#region Command
		[Obsolete]
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(CellTapped), null, propertyChanged:OnCommandChanged);

		[Obsolete]
        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

		[Obsolete]
		private static void OnCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Cell target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.Tapped += OnCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.Tapped -= OnCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion
	}

	[Obsolete]
	public class ClickGestureRecognizerClicked {

		#region Command
		[Obsolete]
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(ClickGestureRecognizerClicked), null, propertyChanged:OnCommandChanged);

		[Obsolete]
        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

		[Obsolete]
		private static void OnCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is ClickGestureRecognizer target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.Clicked += OnCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.Clicked -= OnCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion
	}

	[Obsolete]
	public class ColumnDefinitionSizeChanged {

		#region Command
		[Obsolete]
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(ColumnDefinitionSizeChanged), null, propertyChanged:OnCommandChanged);

		[Obsolete]
        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

		[Obsolete]
		private static void OnCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is ColumnDefinition target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.SizeChanged += OnCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.SizeChanged -= OnCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion
	}

	[Obsolete]
	public class DatePickerDateSelected {

		#region Command
		[Obsolete]
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(DatePickerDateSelected), null, propertyChanged:OnCommandChanged);

		[Obsolete]
        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

		[Obsolete]
		private static void OnCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is DatePicker target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.DateSelected += OnCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.DateSelected -= OnCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion

		#region NewDateCommand
		[Obsolete]
        public static readonly BindableProperty NewDateCommandProperty =
            BindableProperty.CreateAttached("NewDateCommand", typeof(ICommand), typeof(DatePickerDateSelected), null, propertyChanged:OnNewDateCommandChanged);

		[Obsolete]
        public static ICommand GetNewDateCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NewDateCommandProperty);
        }

		[Obsolete]
		private static void OnNewDateCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is DatePicker target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.DateSelected += OnNewDateCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.DateSelected -= OnNewDateCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnNewDateCommandChanged(object o, Xamarin.Forms.DateChangedEventArgs eventArgs)
        {
            var command = GetNewDateCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.NewDate))
                command.Execute(eventArgs.NewDate);
        }
		#endregion

		#region OldDateCommand
		[Obsolete]
        public static readonly BindableProperty OldDateCommandProperty =
            BindableProperty.CreateAttached("OldDateCommand", typeof(ICommand), typeof(DatePickerDateSelected), null, propertyChanged:OnOldDateCommandChanged);

		[Obsolete]
        public static ICommand GetOldDateCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(OldDateCommandProperty);
        }

		[Obsolete]
		private static void OnOldDateCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is DatePicker target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.DateSelected += OnOldDateCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.DateSelected -= OnOldDateCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnOldDateCommandChanged(object o, Xamarin.Forms.DateChangedEventArgs eventArgs)
        {
            var command = GetOldDateCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.OldDate))
                command.Execute(eventArgs.OldDate);
        }
		#endregion
	}

	[Obsolete]
	public class EditorCompleted {

		#region Command
		[Obsolete]
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(EditorCompleted), null, propertyChanged:OnCommandChanged);

		[Obsolete]
        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

		[Obsolete]
		private static void OnCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Editor target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.Completed += OnCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.Completed -= OnCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion
	}

	[Obsolete]
	public class EditorTextChanged {

		#region Command
		[Obsolete]
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(EditorTextChanged), null, propertyChanged:OnCommandChanged);

		[Obsolete]
        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

		[Obsolete]
		private static void OnCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Editor target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.TextChanged += OnCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.TextChanged -= OnCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion

		#region NewTextValueCommand
		[Obsolete]
        public static readonly BindableProperty NewTextValueCommandProperty =
            BindableProperty.CreateAttached("NewTextValueCommand", typeof(ICommand), typeof(EditorTextChanged), null, propertyChanged:OnNewTextValueCommandChanged);

		[Obsolete]
        public static ICommand GetNewTextValueCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NewTextValueCommandProperty);
        }

		[Obsolete]
		private static void OnNewTextValueCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Editor target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.TextChanged += OnNewTextValueCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.TextChanged -= OnNewTextValueCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnNewTextValueCommandChanged(object o, Xamarin.Forms.TextChangedEventArgs eventArgs)
        {
            var command = GetNewTextValueCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.NewTextValue))
                command.Execute(eventArgs.NewTextValue);
        }
		#endregion

		#region OldTextValueCommand
		[Obsolete]
        public static readonly BindableProperty OldTextValueCommandProperty =
            BindableProperty.CreateAttached("OldTextValueCommand", typeof(ICommand), typeof(EditorTextChanged), null, propertyChanged:OnOldTextValueCommandChanged);

		[Obsolete]
        public static ICommand GetOldTextValueCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(OldTextValueCommandProperty);
        }

		[Obsolete]
		private static void OnOldTextValueCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Editor target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.TextChanged += OnOldTextValueCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.TextChanged -= OnOldTextValueCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnOldTextValueCommandChanged(object o, Xamarin.Forms.TextChangedEventArgs eventArgs)
        {
            var command = GetOldTextValueCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.OldTextValue))
                command.Execute(eventArgs.OldTextValue);
        }
		#endregion
	}

	[Obsolete]
	public class ElementChildAdded {

		#region Command
		[Obsolete]
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(ElementChildAdded), null, propertyChanged:OnCommandChanged);

		[Obsolete]
        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

		[Obsolete]
		private static void OnCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Element target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.ChildAdded += OnCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.ChildAdded -= OnCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion

		#region ElementCommand
		[Obsolete]
        public static readonly BindableProperty ElementCommandProperty =
            BindableProperty.CreateAttached("ElementCommand", typeof(ICommand), typeof(ElementChildAdded), null, propertyChanged:OnElementCommandChanged);

		[Obsolete]
        public static ICommand GetElementCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ElementCommandProperty);
        }

		[Obsolete]
		private static void OnElementCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Element target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.ChildAdded += OnElementCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.ChildAdded -= OnElementCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnElementCommandChanged(object o, Xamarin.Forms.ElementEventArgs eventArgs)
        {
            var command = GetElementCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Element))
                command.Execute(eventArgs.Element);
        }
		#endregion
	}

	[Obsolete]
	public class ElementChildRemoved {

		#region Command
		[Obsolete]
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(ElementChildRemoved), null, propertyChanged:OnCommandChanged);

		[Obsolete]
        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

		[Obsolete]
		private static void OnCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Element target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.ChildRemoved += OnCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.ChildRemoved -= OnCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion

		#region ElementCommand
		[Obsolete]
        public static readonly BindableProperty ElementCommandProperty =
            BindableProperty.CreateAttached("ElementCommand", typeof(ICommand), typeof(ElementChildRemoved), null, propertyChanged:OnElementCommandChanged);

		[Obsolete]
        public static ICommand GetElementCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ElementCommandProperty);
        }

		[Obsolete]
		private static void OnElementCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Element target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.ChildRemoved += OnElementCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.ChildRemoved -= OnElementCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnElementCommandChanged(object o, Xamarin.Forms.ElementEventArgs eventArgs)
        {
            var command = GetElementCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Element))
                command.Execute(eventArgs.Element);
        }
		#endregion
	}

	[Obsolete]
	public class ElementDescendantAdded {

		#region Command
		[Obsolete]
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(ElementDescendantAdded), null, propertyChanged:OnCommandChanged);

		[Obsolete]
        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

		[Obsolete]
		private static void OnCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Element target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.DescendantAdded += OnCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.DescendantAdded -= OnCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion

		#region ElementCommand
		[Obsolete]
        public static readonly BindableProperty ElementCommandProperty =
            BindableProperty.CreateAttached("ElementCommand", typeof(ICommand), typeof(ElementDescendantAdded), null, propertyChanged:OnElementCommandChanged);

		[Obsolete]
        public static ICommand GetElementCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ElementCommandProperty);
        }

		[Obsolete]
		private static void OnElementCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Element target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.DescendantAdded += OnElementCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.DescendantAdded -= OnElementCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnElementCommandChanged(object o, Xamarin.Forms.ElementEventArgs eventArgs)
        {
            var command = GetElementCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Element))
                command.Execute(eventArgs.Element);
        }
		#endregion
	}

	[Obsolete]
	public class ElementDescendantRemoved {

		#region Command
		[Obsolete]
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(ElementDescendantRemoved), null, propertyChanged:OnCommandChanged);

		[Obsolete]
        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

		[Obsolete]
		private static void OnCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Element target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.DescendantRemoved += OnCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.DescendantRemoved -= OnCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion

		#region ElementCommand
		[Obsolete]
        public static readonly BindableProperty ElementCommandProperty =
            BindableProperty.CreateAttached("ElementCommand", typeof(ICommand), typeof(ElementDescendantRemoved), null, propertyChanged:OnElementCommandChanged);

		[Obsolete]
        public static ICommand GetElementCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ElementCommandProperty);
        }

		[Obsolete]
		private static void OnElementCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Element target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.DescendantRemoved += OnElementCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.DescendantRemoved -= OnElementCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnElementCommandChanged(object o, Xamarin.Forms.ElementEventArgs eventArgs)
        {
            var command = GetElementCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Element))
                command.Execute(eventArgs.Element);
        }
		#endregion
	}

	[Obsolete]
	public class ElementPlatformSet {

		#region Command
		[Obsolete]
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(ElementPlatformSet), null, propertyChanged:OnCommandChanged);

		[Obsolete]
        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

		[Obsolete]
		private static void OnCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Element target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.PlatformSet += OnCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.PlatformSet -= OnCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion
	}

	[Obsolete]
	public class EntryCompleted {

		#region Command
		[Obsolete]
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(EntryCompleted), null, propertyChanged:OnCommandChanged);

		[Obsolete]
        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

		[Obsolete]
		private static void OnCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Entry target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.Completed += OnCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.Completed -= OnCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion
	}

	[Obsolete]
	public class EntryTextChanged {

		#region Command
		[Obsolete]
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(EntryTextChanged), null, propertyChanged:OnCommandChanged);

		[Obsolete]
        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

		[Obsolete]
		private static void OnCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Entry target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.TextChanged += OnCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.TextChanged -= OnCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion

		#region NewTextValueCommand
		[Obsolete]
        public static readonly BindableProperty NewTextValueCommandProperty =
            BindableProperty.CreateAttached("NewTextValueCommand", typeof(ICommand), typeof(EntryTextChanged), null, propertyChanged:OnNewTextValueCommandChanged);

		[Obsolete]
        public static ICommand GetNewTextValueCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NewTextValueCommandProperty);
        }

		[Obsolete]
		private static void OnNewTextValueCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Entry target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.TextChanged += OnNewTextValueCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.TextChanged -= OnNewTextValueCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnNewTextValueCommandChanged(object o, Xamarin.Forms.TextChangedEventArgs eventArgs)
        {
            var command = GetNewTextValueCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.NewTextValue))
                command.Execute(eventArgs.NewTextValue);
        }
		#endregion

		#region OldTextValueCommand
		[Obsolete]
        public static readonly BindableProperty OldTextValueCommandProperty =
            BindableProperty.CreateAttached("OldTextValueCommand", typeof(ICommand), typeof(EntryTextChanged), null, propertyChanged:OnOldTextValueCommandChanged);

		[Obsolete]
        public static ICommand GetOldTextValueCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(OldTextValueCommandProperty);
        }

		[Obsolete]
		private static void OnOldTextValueCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Entry target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.TextChanged += OnOldTextValueCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.TextChanged -= OnOldTextValueCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnOldTextValueCommandChanged(object o, Xamarin.Forms.TextChangedEventArgs eventArgs)
        {
            var command = GetOldTextValueCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.OldTextValue))
                command.Execute(eventArgs.OldTextValue);
        }
		#endregion
	}

	[Obsolete]
	public class EntryCellCompleted {

		#region Command
		[Obsolete]
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(EntryCellCompleted), null, propertyChanged:OnCommandChanged);

		[Obsolete]
        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

		[Obsolete]
		private static void OnCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is EntryCell target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.Completed += OnCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.Completed -= OnCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion
	}

	[Obsolete]
	public class LayoutLayoutChanged {

		#region Command
		[Obsolete]
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(LayoutLayoutChanged), null, propertyChanged:OnCommandChanged);

		[Obsolete]
        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

		[Obsolete]
		private static void OnCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Layout target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.LayoutChanged += OnCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.LayoutChanged -= OnCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion
	}

	[Obsolete]
	public class ListViewItemAppearing {

		#region Command
		[Obsolete]
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(ListViewItemAppearing), null, propertyChanged:OnCommandChanged);

		[Obsolete]
        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

		[Obsolete]
		private static void OnCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is ListView target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.ItemAppearing += OnCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.ItemAppearing -= OnCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion

		#region ItemCommand
		[Obsolete]
        public static readonly BindableProperty ItemCommandProperty =
            BindableProperty.CreateAttached("ItemCommand", typeof(ICommand), typeof(ListViewItemAppearing), null, propertyChanged:OnItemCommandChanged);

		[Obsolete]
        public static ICommand GetItemCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ItemCommandProperty);
        }

		[Obsolete]
		private static void OnItemCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is ListView target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.ItemAppearing += OnItemCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.ItemAppearing -= OnItemCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnItemCommandChanged(object o, Xamarin.Forms.ItemVisibilityEventArgs eventArgs)
        {
            var command = GetItemCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Item))
                command.Execute(eventArgs.Item);
        }
		#endregion
	}

	[Obsolete]
	public class ListViewItemDisappearing {

		#region Command
		[Obsolete]
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(ListViewItemDisappearing), null, propertyChanged:OnCommandChanged);

		[Obsolete]
        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

		[Obsolete]
		private static void OnCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is ListView target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.ItemDisappearing += OnCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.ItemDisappearing -= OnCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion

		#region ItemCommand
		[Obsolete]
        public static readonly BindableProperty ItemCommandProperty =
            BindableProperty.CreateAttached("ItemCommand", typeof(ICommand), typeof(ListViewItemDisappearing), null, propertyChanged:OnItemCommandChanged);

		[Obsolete]
        public static ICommand GetItemCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ItemCommandProperty);
        }

		[Obsolete]
		private static void OnItemCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is ListView target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.ItemDisappearing += OnItemCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.ItemDisappearing -= OnItemCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnItemCommandChanged(object o, Xamarin.Forms.ItemVisibilityEventArgs eventArgs)
        {
            var command = GetItemCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Item))
                command.Execute(eventArgs.Item);
        }
		#endregion
	}

	[Obsolete]
	public class ListViewItemSelected {

		#region Command
		[Obsolete]
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(ListViewItemSelected), null, propertyChanged:OnCommandChanged);

		[Obsolete]
        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

		[Obsolete]
		private static void OnCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is ListView target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.ItemSelected += OnCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.ItemSelected -= OnCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion

		#region SelectedItemCommand
		[Obsolete]
        public static readonly BindableProperty SelectedItemCommandProperty =
            BindableProperty.CreateAttached("SelectedItemCommand", typeof(ICommand), typeof(ListViewItemSelected), null, propertyChanged:OnSelectedItemCommandChanged);

		[Obsolete]
        public static ICommand GetSelectedItemCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(SelectedItemCommandProperty);
        }

		[Obsolete]
		private static void OnSelectedItemCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is ListView target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.ItemSelected += OnSelectedItemCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.ItemSelected -= OnSelectedItemCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnSelectedItemCommandChanged(object o, Xamarin.Forms.SelectedItemChangedEventArgs eventArgs)
        {
            var command = GetSelectedItemCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.SelectedItem))
                command.Execute(eventArgs.SelectedItem);
        }
		#endregion
	}

	[Obsolete]
	public class ListViewItemTapped {

		#region Command
		[Obsolete]
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(ListViewItemTapped), null, propertyChanged:OnCommandChanged);

		[Obsolete]
        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

		[Obsolete]
		private static void OnCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is ListView target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.ItemTapped += OnCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.ItemTapped -= OnCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion

		#region GroupCommand
		[Obsolete]
        public static readonly BindableProperty GroupCommandProperty =
            BindableProperty.CreateAttached("GroupCommand", typeof(ICommand), typeof(ListViewItemTapped), null, propertyChanged:OnGroupCommandChanged);

		[Obsolete]
        public static ICommand GetGroupCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(GroupCommandProperty);
        }

		[Obsolete]
		private static void OnGroupCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is ListView target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.ItemTapped += OnGroupCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.ItemTapped -= OnGroupCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnGroupCommandChanged(object o, Xamarin.Forms.ItemTappedEventArgs eventArgs)
        {
            var command = GetGroupCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Group))
                command.Execute(eventArgs.Group);
        }
		#endregion

		#region ItemCommand
		[Obsolete]
        public static readonly BindableProperty ItemCommandProperty =
            BindableProperty.CreateAttached("ItemCommand", typeof(ICommand), typeof(ListViewItemTapped), null, propertyChanged:OnItemCommandChanged);

		[Obsolete]
        public static ICommand GetItemCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ItemCommandProperty);
        }

		[Obsolete]
		private static void OnItemCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is ListView target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.ItemTapped += OnItemCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.ItemTapped -= OnItemCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnItemCommandChanged(object o, Xamarin.Forms.ItemTappedEventArgs eventArgs)
        {
            var command = GetItemCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Item))
                command.Execute(eventArgs.Item);
        }
		#endregion
	}

	[Obsolete]
	public class ListViewRefreshing {

		#region Command
		[Obsolete]
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(ListViewRefreshing), null, propertyChanged:OnCommandChanged);

		[Obsolete]
        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

		[Obsolete]
		private static void OnCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is ListView target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.Refreshing += OnCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.Refreshing -= OnCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion
	}

	[Obsolete]
	public class ListViewScrollToRequested {

		#region Command
		[Obsolete]
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(ListViewScrollToRequested), null, propertyChanged:OnCommandChanged);

		[Obsolete]
        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

		[Obsolete]
		private static void OnCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is ListView target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.ScrollToRequested += OnCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.ScrollToRequested -= OnCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion

		#region ElementCommand
		[Obsolete]
        public static readonly BindableProperty ElementCommandProperty =
            BindableProperty.CreateAttached("ElementCommand", typeof(ICommand), typeof(ListViewScrollToRequested), null, propertyChanged:OnElementCommandChanged);

		[Obsolete]
        public static ICommand GetElementCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ElementCommandProperty);
        }

		[Obsolete]
		private static void OnElementCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is ListView target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.ScrollToRequested += OnElementCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.ScrollToRequested -= OnElementCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnElementCommandChanged(object o, Xamarin.Forms.ScrollToRequestedEventArgs eventArgs)
        {
            var command = GetElementCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Element))
                command.Execute(eventArgs.Element);
        }
		#endregion

		#region ModeCommand
		[Obsolete]
        public static readonly BindableProperty ModeCommandProperty =
            BindableProperty.CreateAttached("ModeCommand", typeof(ICommand), typeof(ListViewScrollToRequested), null, propertyChanged:OnModeCommandChanged);

		[Obsolete]
        public static ICommand GetModeCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ModeCommandProperty);
        }

		[Obsolete]
		private static void OnModeCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is ListView target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.ScrollToRequested += OnModeCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.ScrollToRequested -= OnModeCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnModeCommandChanged(object o, Xamarin.Forms.ScrollToRequestedEventArgs eventArgs)
        {
            var command = GetModeCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Mode))
                command.Execute(eventArgs.Mode);
        }
		#endregion

		#region PositionCommand
		[Obsolete]
        public static readonly BindableProperty PositionCommandProperty =
            BindableProperty.CreateAttached("PositionCommand", typeof(ICommand), typeof(ListViewScrollToRequested), null, propertyChanged:OnPositionCommandChanged);

		[Obsolete]
        public static ICommand GetPositionCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(PositionCommandProperty);
        }

		[Obsolete]
		private static void OnPositionCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is ListView target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.ScrollToRequested += OnPositionCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.ScrollToRequested -= OnPositionCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnPositionCommandChanged(object o, Xamarin.Forms.ScrollToRequestedEventArgs eventArgs)
        {
            var command = GetPositionCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Position))
                command.Execute(eventArgs.Position);
        }
		#endregion

		#region ScrollXCommand
		[Obsolete]
        public static readonly BindableProperty ScrollXCommandProperty =
            BindableProperty.CreateAttached("ScrollXCommand", typeof(ICommand), typeof(ListViewScrollToRequested), null, propertyChanged:OnScrollXCommandChanged);

		[Obsolete]
        public static ICommand GetScrollXCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ScrollXCommandProperty);
        }

		[Obsolete]
		private static void OnScrollXCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is ListView target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.ScrollToRequested += OnScrollXCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.ScrollToRequested -= OnScrollXCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnScrollXCommandChanged(object o, Xamarin.Forms.ScrollToRequestedEventArgs eventArgs)
        {
            var command = GetScrollXCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.ScrollX))
                command.Execute(eventArgs.ScrollX);
        }
		#endregion

		#region ScrollYCommand
		[Obsolete]
        public static readonly BindableProperty ScrollYCommandProperty =
            BindableProperty.CreateAttached("ScrollYCommand", typeof(ICommand), typeof(ListViewScrollToRequested), null, propertyChanged:OnScrollYCommandChanged);

		[Obsolete]
        public static ICommand GetScrollYCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ScrollYCommandProperty);
        }

		[Obsolete]
		private static void OnScrollYCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is ListView target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.ScrollToRequested += OnScrollYCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.ScrollToRequested -= OnScrollYCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnScrollYCommandChanged(object o, Xamarin.Forms.ScrollToRequestedEventArgs eventArgs)
        {
            var command = GetScrollYCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.ScrollY))
                command.Execute(eventArgs.ScrollY);
        }
		#endregion

		#region ShouldAnimateCommand
		[Obsolete]
        public static readonly BindableProperty ShouldAnimateCommandProperty =
            BindableProperty.CreateAttached("ShouldAnimateCommand", typeof(ICommand), typeof(ListViewScrollToRequested), null, propertyChanged:OnShouldAnimateCommandChanged);

		[Obsolete]
        public static ICommand GetShouldAnimateCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ShouldAnimateCommandProperty);
        }

		[Obsolete]
		private static void OnShouldAnimateCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is ListView target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.ScrollToRequested += OnShouldAnimateCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.ScrollToRequested -= OnShouldAnimateCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnShouldAnimateCommandChanged(object o, Xamarin.Forms.ScrollToRequestedEventArgs eventArgs)
        {
            var command = GetShouldAnimateCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.ShouldAnimate))
                command.Execute(eventArgs.ShouldAnimate);
        }
		#endregion
	}

	[Obsolete]
	public class MasterDetailPageBackButtonPressed {

		#region Command
		[Obsolete]
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(MasterDetailPageBackButtonPressed), null, propertyChanged:OnCommandChanged);

		[Obsolete]
        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

		[Obsolete]
		private static void OnCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is MasterDetailPage target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.BackButtonPressed += OnCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.BackButtonPressed -= OnCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion

		#region HandledCommand
		[Obsolete]
        public static readonly BindableProperty HandledCommandProperty =
            BindableProperty.CreateAttached("HandledCommand", typeof(ICommand), typeof(MasterDetailPageBackButtonPressed), null, propertyChanged:OnHandledCommandChanged);

		[Obsolete]
        public static ICommand GetHandledCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(HandledCommandProperty);
        }

		[Obsolete]
		private static void OnHandledCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is MasterDetailPage target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.BackButtonPressed += OnHandledCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.BackButtonPressed -= OnHandledCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnHandledCommandChanged(object o, Xamarin.Forms.BackButtonPressedEventArgs eventArgs)
        {
            var command = GetHandledCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Handled))
                command.Execute(eventArgs.Handled);
        }
		#endregion
	}

	[Obsolete]
	public class MasterDetailPageIsPresentedChanged {

		#region Command
		[Obsolete]
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(MasterDetailPageIsPresentedChanged), null, propertyChanged:OnCommandChanged);

		[Obsolete]
        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

		[Obsolete]
		private static void OnCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is MasterDetailPage target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.IsPresentedChanged += OnCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.IsPresentedChanged -= OnCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion
	}

	[Obsolete]
	public class MenuItemClicked {

		#region Command
		[Obsolete]
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(MenuItemClicked), null, propertyChanged:OnCommandChanged);

		[Obsolete]
        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

		[Obsolete]
		private static void OnCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is MenuItem target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.Clicked += OnCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.Clicked -= OnCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion
	}

	[Obsolete]
	public class NavigationPageInsertPageBeforeRequested {

		#region Command
		[Obsolete]
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(NavigationPageInsertPageBeforeRequested), null, propertyChanged:OnCommandChanged);

		[Obsolete]
        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

		[Obsolete]
		private static void OnCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is NavigationPage target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.InsertPageBeforeRequested += OnCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.InsertPageBeforeRequested -= OnCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion

		#region AnimatedCommand
		[Obsolete]
        public static readonly BindableProperty AnimatedCommandProperty =
            BindableProperty.CreateAttached("AnimatedCommand", typeof(ICommand), typeof(NavigationPageInsertPageBeforeRequested), null, propertyChanged:OnAnimatedCommandChanged);

		[Obsolete]
        public static ICommand GetAnimatedCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(AnimatedCommandProperty);
        }

		[Obsolete]
		private static void OnAnimatedCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is NavigationPage target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.InsertPageBeforeRequested += OnAnimatedCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.InsertPageBeforeRequested -= OnAnimatedCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnAnimatedCommandChanged(object o, Xamarin.Forms.Internals.NavigationRequestedEventArgs eventArgs)
        {
            var command = GetAnimatedCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Animated))
                command.Execute(eventArgs.Animated);
        }
		#endregion

		#region BeforePageCommand
		[Obsolete]
        public static readonly BindableProperty BeforePageCommandProperty =
            BindableProperty.CreateAttached("BeforePageCommand", typeof(ICommand), typeof(NavigationPageInsertPageBeforeRequested), null, propertyChanged:OnBeforePageCommandChanged);

		[Obsolete]
        public static ICommand GetBeforePageCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(BeforePageCommandProperty);
        }

		[Obsolete]
		private static void OnBeforePageCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is NavigationPage target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.InsertPageBeforeRequested += OnBeforePageCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.InsertPageBeforeRequested -= OnBeforePageCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnBeforePageCommandChanged(object o, Xamarin.Forms.Internals.NavigationRequestedEventArgs eventArgs)
        {
            var command = GetBeforePageCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.BeforePage))
                command.Execute(eventArgs.BeforePage);
        }
		#endregion

		#region RealizeCommand
		[Obsolete]
        public static readonly BindableProperty RealizeCommandProperty =
            BindableProperty.CreateAttached("RealizeCommand", typeof(ICommand), typeof(NavigationPageInsertPageBeforeRequested), null, propertyChanged:OnRealizeCommandChanged);

		[Obsolete]
        public static ICommand GetRealizeCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(RealizeCommandProperty);
        }

		[Obsolete]
		private static void OnRealizeCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is NavigationPage target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.InsertPageBeforeRequested += OnRealizeCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.InsertPageBeforeRequested -= OnRealizeCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnRealizeCommandChanged(object o, Xamarin.Forms.Internals.NavigationRequestedEventArgs eventArgs)
        {
            var command = GetRealizeCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Realize))
                command.Execute(eventArgs.Realize);
        }
		#endregion

		#region TaskCommand
		[Obsolete]
        public static readonly BindableProperty TaskCommandProperty =
            BindableProperty.CreateAttached("TaskCommand", typeof(ICommand), typeof(NavigationPageInsertPageBeforeRequested), null, propertyChanged:OnTaskCommandChanged);

		[Obsolete]
        public static ICommand GetTaskCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(TaskCommandProperty);
        }

		[Obsolete]
		private static void OnTaskCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is NavigationPage target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.InsertPageBeforeRequested += OnTaskCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.InsertPageBeforeRequested -= OnTaskCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnTaskCommandChanged(object o, Xamarin.Forms.Internals.NavigationRequestedEventArgs eventArgs)
        {
            var command = GetTaskCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Task))
                command.Execute(eventArgs.Task);
        }
		#endregion

		#region PageCommand
		[Obsolete]
        public static readonly BindableProperty PageCommandProperty =
            BindableProperty.CreateAttached("PageCommand", typeof(ICommand), typeof(NavigationPageInsertPageBeforeRequested), null, propertyChanged:OnPageCommandChanged);

		[Obsolete]
        public static ICommand GetPageCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(PageCommandProperty);
        }

		[Obsolete]
		private static void OnPageCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is NavigationPage target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.InsertPageBeforeRequested += OnPageCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.InsertPageBeforeRequested -= OnPageCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnPageCommandChanged(object o, Xamarin.Forms.Internals.NavigationRequestedEventArgs eventArgs)
        {
            var command = GetPageCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Page))
                command.Execute(eventArgs.Page);
        }
		#endregion
	}

	[Obsolete]
	public class NavigationPagePopped {

		#region Command
		[Obsolete]
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(NavigationPagePopped), null, propertyChanged:OnCommandChanged);

		[Obsolete]
        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

		[Obsolete]
		private static void OnCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is NavigationPage target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.Popped += OnCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.Popped -= OnCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion

		#region PageCommand
		[Obsolete]
        public static readonly BindableProperty PageCommandProperty =
            BindableProperty.CreateAttached("PageCommand", typeof(ICommand), typeof(NavigationPagePopped), null, propertyChanged:OnPageCommandChanged);

		[Obsolete]
        public static ICommand GetPageCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(PageCommandProperty);
        }

		[Obsolete]
		private static void OnPageCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is NavigationPage target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.Popped += OnPageCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.Popped -= OnPageCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnPageCommandChanged(object o, Xamarin.Forms.NavigationEventArgs eventArgs)
        {
            var command = GetPageCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Page))
                command.Execute(eventArgs.Page);
        }
		#endregion
	}

	[Obsolete]
	public class NavigationPagePoppedToRoot {

		#region Command
		[Obsolete]
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(NavigationPagePoppedToRoot), null, propertyChanged:OnCommandChanged);

		[Obsolete]
        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

		[Obsolete]
		private static void OnCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is NavigationPage target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.PoppedToRoot += OnCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.PoppedToRoot -= OnCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion

		#region PageCommand
		[Obsolete]
        public static readonly BindableProperty PageCommandProperty =
            BindableProperty.CreateAttached("PageCommand", typeof(ICommand), typeof(NavigationPagePoppedToRoot), null, propertyChanged:OnPageCommandChanged);

		[Obsolete]
        public static ICommand GetPageCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(PageCommandProperty);
        }

		[Obsolete]
		private static void OnPageCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is NavigationPage target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.PoppedToRoot += OnPageCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.PoppedToRoot -= OnPageCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnPageCommandChanged(object o, Xamarin.Forms.NavigationEventArgs eventArgs)
        {
            var command = GetPageCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Page))
                command.Execute(eventArgs.Page);
        }
		#endregion
	}

	[Obsolete]
	public class NavigationPagePopRequested {

		#region Command
		[Obsolete]
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(NavigationPagePopRequested), null, propertyChanged:OnCommandChanged);

		[Obsolete]
        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

		[Obsolete]
		private static void OnCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is NavigationPage target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.PopRequested += OnCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.PopRequested -= OnCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion

		#region AnimatedCommand
		[Obsolete]
        public static readonly BindableProperty AnimatedCommandProperty =
            BindableProperty.CreateAttached("AnimatedCommand", typeof(ICommand), typeof(NavigationPagePopRequested), null, propertyChanged:OnAnimatedCommandChanged);

		[Obsolete]
        public static ICommand GetAnimatedCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(AnimatedCommandProperty);
        }

		[Obsolete]
		private static void OnAnimatedCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is NavigationPage target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.PopRequested += OnAnimatedCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.PopRequested -= OnAnimatedCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnAnimatedCommandChanged(object o, Xamarin.Forms.Internals.NavigationRequestedEventArgs eventArgs)
        {
            var command = GetAnimatedCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Animated))
                command.Execute(eventArgs.Animated);
        }
		#endregion

		#region BeforePageCommand
		[Obsolete]
        public static readonly BindableProperty BeforePageCommandProperty =
            BindableProperty.CreateAttached("BeforePageCommand", typeof(ICommand), typeof(NavigationPagePopRequested), null, propertyChanged:OnBeforePageCommandChanged);

		[Obsolete]
        public static ICommand GetBeforePageCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(BeforePageCommandProperty);
        }

		[Obsolete]
		private static void OnBeforePageCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is NavigationPage target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.PopRequested += OnBeforePageCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.PopRequested -= OnBeforePageCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnBeforePageCommandChanged(object o, Xamarin.Forms.Internals.NavigationRequestedEventArgs eventArgs)
        {
            var command = GetBeforePageCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.BeforePage))
                command.Execute(eventArgs.BeforePage);
        }
		#endregion

		#region RealizeCommand
		[Obsolete]
        public static readonly BindableProperty RealizeCommandProperty =
            BindableProperty.CreateAttached("RealizeCommand", typeof(ICommand), typeof(NavigationPagePopRequested), null, propertyChanged:OnRealizeCommandChanged);

		[Obsolete]
        public static ICommand GetRealizeCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(RealizeCommandProperty);
        }

		[Obsolete]
		private static void OnRealizeCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is NavigationPage target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.PopRequested += OnRealizeCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.PopRequested -= OnRealizeCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnRealizeCommandChanged(object o, Xamarin.Forms.Internals.NavigationRequestedEventArgs eventArgs)
        {
            var command = GetRealizeCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Realize))
                command.Execute(eventArgs.Realize);
        }
		#endregion

		#region TaskCommand
		[Obsolete]
        public static readonly BindableProperty TaskCommandProperty =
            BindableProperty.CreateAttached("TaskCommand", typeof(ICommand), typeof(NavigationPagePopRequested), null, propertyChanged:OnTaskCommandChanged);

		[Obsolete]
        public static ICommand GetTaskCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(TaskCommandProperty);
        }

		[Obsolete]
		private static void OnTaskCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is NavigationPage target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.PopRequested += OnTaskCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.PopRequested -= OnTaskCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnTaskCommandChanged(object o, Xamarin.Forms.Internals.NavigationRequestedEventArgs eventArgs)
        {
            var command = GetTaskCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Task))
                command.Execute(eventArgs.Task);
        }
		#endregion

		#region PageCommand
		[Obsolete]
        public static readonly BindableProperty PageCommandProperty =
            BindableProperty.CreateAttached("PageCommand", typeof(ICommand), typeof(NavigationPagePopRequested), null, propertyChanged:OnPageCommandChanged);

		[Obsolete]
        public static ICommand GetPageCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(PageCommandProperty);
        }

		[Obsolete]
		private static void OnPageCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is NavigationPage target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.PopRequested += OnPageCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.PopRequested -= OnPageCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnPageCommandChanged(object o, Xamarin.Forms.Internals.NavigationRequestedEventArgs eventArgs)
        {
            var command = GetPageCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Page))
                command.Execute(eventArgs.Page);
        }
		#endregion
	}

	[Obsolete]
	public class NavigationPagePopToRootRequested {

		#region Command
		[Obsolete]
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(NavigationPagePopToRootRequested), null, propertyChanged:OnCommandChanged);

		[Obsolete]
        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

		[Obsolete]
		private static void OnCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is NavigationPage target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.PopToRootRequested += OnCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.PopToRootRequested -= OnCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion

		#region AnimatedCommand
		[Obsolete]
        public static readonly BindableProperty AnimatedCommandProperty =
            BindableProperty.CreateAttached("AnimatedCommand", typeof(ICommand), typeof(NavigationPagePopToRootRequested), null, propertyChanged:OnAnimatedCommandChanged);

		[Obsolete]
        public static ICommand GetAnimatedCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(AnimatedCommandProperty);
        }

		[Obsolete]
		private static void OnAnimatedCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is NavigationPage target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.PopToRootRequested += OnAnimatedCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.PopToRootRequested -= OnAnimatedCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnAnimatedCommandChanged(object o, Xamarin.Forms.Internals.NavigationRequestedEventArgs eventArgs)
        {
            var command = GetAnimatedCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Animated))
                command.Execute(eventArgs.Animated);
        }
		#endregion

		#region BeforePageCommand
		[Obsolete]
        public static readonly BindableProperty BeforePageCommandProperty =
            BindableProperty.CreateAttached("BeforePageCommand", typeof(ICommand), typeof(NavigationPagePopToRootRequested), null, propertyChanged:OnBeforePageCommandChanged);

		[Obsolete]
        public static ICommand GetBeforePageCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(BeforePageCommandProperty);
        }

		[Obsolete]
		private static void OnBeforePageCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is NavigationPage target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.PopToRootRequested += OnBeforePageCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.PopToRootRequested -= OnBeforePageCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnBeforePageCommandChanged(object o, Xamarin.Forms.Internals.NavigationRequestedEventArgs eventArgs)
        {
            var command = GetBeforePageCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.BeforePage))
                command.Execute(eventArgs.BeforePage);
        }
		#endregion

		#region RealizeCommand
		[Obsolete]
        public static readonly BindableProperty RealizeCommandProperty =
            BindableProperty.CreateAttached("RealizeCommand", typeof(ICommand), typeof(NavigationPagePopToRootRequested), null, propertyChanged:OnRealizeCommandChanged);

		[Obsolete]
        public static ICommand GetRealizeCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(RealizeCommandProperty);
        }

		[Obsolete]
		private static void OnRealizeCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is NavigationPage target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.PopToRootRequested += OnRealizeCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.PopToRootRequested -= OnRealizeCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnRealizeCommandChanged(object o, Xamarin.Forms.Internals.NavigationRequestedEventArgs eventArgs)
        {
            var command = GetRealizeCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Realize))
                command.Execute(eventArgs.Realize);
        }
		#endregion

		#region TaskCommand
		[Obsolete]
        public static readonly BindableProperty TaskCommandProperty =
            BindableProperty.CreateAttached("TaskCommand", typeof(ICommand), typeof(NavigationPagePopToRootRequested), null, propertyChanged:OnTaskCommandChanged);

		[Obsolete]
        public static ICommand GetTaskCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(TaskCommandProperty);
        }

		[Obsolete]
		private static void OnTaskCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is NavigationPage target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.PopToRootRequested += OnTaskCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.PopToRootRequested -= OnTaskCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnTaskCommandChanged(object o, Xamarin.Forms.Internals.NavigationRequestedEventArgs eventArgs)
        {
            var command = GetTaskCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Task))
                command.Execute(eventArgs.Task);
        }
		#endregion

		#region PageCommand
		[Obsolete]
        public static readonly BindableProperty PageCommandProperty =
            BindableProperty.CreateAttached("PageCommand", typeof(ICommand), typeof(NavigationPagePopToRootRequested), null, propertyChanged:OnPageCommandChanged);

		[Obsolete]
        public static ICommand GetPageCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(PageCommandProperty);
        }

		[Obsolete]
		private static void OnPageCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is NavigationPage target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.PopToRootRequested += OnPageCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.PopToRootRequested -= OnPageCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnPageCommandChanged(object o, Xamarin.Forms.Internals.NavigationRequestedEventArgs eventArgs)
        {
            var command = GetPageCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Page))
                command.Execute(eventArgs.Page);
        }
		#endregion
	}

	[Obsolete]
	public class NavigationPagePushed {

		#region Command
		[Obsolete]
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(NavigationPagePushed), null, propertyChanged:OnCommandChanged);

		[Obsolete]
        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

		[Obsolete]
		private static void OnCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is NavigationPage target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.Pushed += OnCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.Pushed -= OnCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion

		#region PageCommand
		[Obsolete]
        public static readonly BindableProperty PageCommandProperty =
            BindableProperty.CreateAttached("PageCommand", typeof(ICommand), typeof(NavigationPagePushed), null, propertyChanged:OnPageCommandChanged);

		[Obsolete]
        public static ICommand GetPageCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(PageCommandProperty);
        }

		[Obsolete]
		private static void OnPageCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is NavigationPage target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.Pushed += OnPageCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.Pushed -= OnPageCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnPageCommandChanged(object o, Xamarin.Forms.NavigationEventArgs eventArgs)
        {
            var command = GetPageCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Page))
                command.Execute(eventArgs.Page);
        }
		#endregion
	}

	[Obsolete]
	public class NavigationPagePushRequested {

		#region Command
		[Obsolete]
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(NavigationPagePushRequested), null, propertyChanged:OnCommandChanged);

		[Obsolete]
        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

		[Obsolete]
		private static void OnCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is NavigationPage target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.PushRequested += OnCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.PushRequested -= OnCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion

		#region AnimatedCommand
		[Obsolete]
        public static readonly BindableProperty AnimatedCommandProperty =
            BindableProperty.CreateAttached("AnimatedCommand", typeof(ICommand), typeof(NavigationPagePushRequested), null, propertyChanged:OnAnimatedCommandChanged);

		[Obsolete]
        public static ICommand GetAnimatedCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(AnimatedCommandProperty);
        }

		[Obsolete]
		private static void OnAnimatedCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is NavigationPage target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.PushRequested += OnAnimatedCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.PushRequested -= OnAnimatedCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnAnimatedCommandChanged(object o, Xamarin.Forms.Internals.NavigationRequestedEventArgs eventArgs)
        {
            var command = GetAnimatedCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Animated))
                command.Execute(eventArgs.Animated);
        }
		#endregion

		#region BeforePageCommand
		[Obsolete]
        public static readonly BindableProperty BeforePageCommandProperty =
            BindableProperty.CreateAttached("BeforePageCommand", typeof(ICommand), typeof(NavigationPagePushRequested), null, propertyChanged:OnBeforePageCommandChanged);

		[Obsolete]
        public static ICommand GetBeforePageCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(BeforePageCommandProperty);
        }

		[Obsolete]
		private static void OnBeforePageCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is NavigationPage target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.PushRequested += OnBeforePageCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.PushRequested -= OnBeforePageCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnBeforePageCommandChanged(object o, Xamarin.Forms.Internals.NavigationRequestedEventArgs eventArgs)
        {
            var command = GetBeforePageCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.BeforePage))
                command.Execute(eventArgs.BeforePage);
        }
		#endregion

		#region RealizeCommand
		[Obsolete]
        public static readonly BindableProperty RealizeCommandProperty =
            BindableProperty.CreateAttached("RealizeCommand", typeof(ICommand), typeof(NavigationPagePushRequested), null, propertyChanged:OnRealizeCommandChanged);

		[Obsolete]
        public static ICommand GetRealizeCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(RealizeCommandProperty);
        }

		[Obsolete]
		private static void OnRealizeCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is NavigationPage target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.PushRequested += OnRealizeCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.PushRequested -= OnRealizeCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnRealizeCommandChanged(object o, Xamarin.Forms.Internals.NavigationRequestedEventArgs eventArgs)
        {
            var command = GetRealizeCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Realize))
                command.Execute(eventArgs.Realize);
        }
		#endregion

		#region TaskCommand
		[Obsolete]
        public static readonly BindableProperty TaskCommandProperty =
            BindableProperty.CreateAttached("TaskCommand", typeof(ICommand), typeof(NavigationPagePushRequested), null, propertyChanged:OnTaskCommandChanged);

		[Obsolete]
        public static ICommand GetTaskCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(TaskCommandProperty);
        }

		[Obsolete]
		private static void OnTaskCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is NavigationPage target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.PushRequested += OnTaskCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.PushRequested -= OnTaskCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnTaskCommandChanged(object o, Xamarin.Forms.Internals.NavigationRequestedEventArgs eventArgs)
        {
            var command = GetTaskCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Task))
                command.Execute(eventArgs.Task);
        }
		#endregion

		#region PageCommand
		[Obsolete]
        public static readonly BindableProperty PageCommandProperty =
            BindableProperty.CreateAttached("PageCommand", typeof(ICommand), typeof(NavigationPagePushRequested), null, propertyChanged:OnPageCommandChanged);

		[Obsolete]
        public static ICommand GetPageCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(PageCommandProperty);
        }

		[Obsolete]
		private static void OnPageCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is NavigationPage target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.PushRequested += OnPageCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.PushRequested -= OnPageCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnPageCommandChanged(object o, Xamarin.Forms.Internals.NavigationRequestedEventArgs eventArgs)
        {
            var command = GetPageCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Page))
                command.Execute(eventArgs.Page);
        }
		#endregion
	}

	[Obsolete]
	public class NavigationPageRemovePageRequested {

		#region Command
		[Obsolete]
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(NavigationPageRemovePageRequested), null, propertyChanged:OnCommandChanged);

		[Obsolete]
        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

		[Obsolete]
		private static void OnCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is NavigationPage target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.RemovePageRequested += OnCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.RemovePageRequested -= OnCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion

		#region AnimatedCommand
		[Obsolete]
        public static readonly BindableProperty AnimatedCommandProperty =
            BindableProperty.CreateAttached("AnimatedCommand", typeof(ICommand), typeof(NavigationPageRemovePageRequested), null, propertyChanged:OnAnimatedCommandChanged);

		[Obsolete]
        public static ICommand GetAnimatedCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(AnimatedCommandProperty);
        }

		[Obsolete]
		private static void OnAnimatedCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is NavigationPage target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.RemovePageRequested += OnAnimatedCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.RemovePageRequested -= OnAnimatedCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnAnimatedCommandChanged(object o, Xamarin.Forms.Internals.NavigationRequestedEventArgs eventArgs)
        {
            var command = GetAnimatedCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Animated))
                command.Execute(eventArgs.Animated);
        }
		#endregion

		#region BeforePageCommand
		[Obsolete]
        public static readonly BindableProperty BeforePageCommandProperty =
            BindableProperty.CreateAttached("BeforePageCommand", typeof(ICommand), typeof(NavigationPageRemovePageRequested), null, propertyChanged:OnBeforePageCommandChanged);

		[Obsolete]
        public static ICommand GetBeforePageCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(BeforePageCommandProperty);
        }

		[Obsolete]
		private static void OnBeforePageCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is NavigationPage target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.RemovePageRequested += OnBeforePageCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.RemovePageRequested -= OnBeforePageCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnBeforePageCommandChanged(object o, Xamarin.Forms.Internals.NavigationRequestedEventArgs eventArgs)
        {
            var command = GetBeforePageCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.BeforePage))
                command.Execute(eventArgs.BeforePage);
        }
		#endregion

		#region RealizeCommand
		[Obsolete]
        public static readonly BindableProperty RealizeCommandProperty =
            BindableProperty.CreateAttached("RealizeCommand", typeof(ICommand), typeof(NavigationPageRemovePageRequested), null, propertyChanged:OnRealizeCommandChanged);

		[Obsolete]
        public static ICommand GetRealizeCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(RealizeCommandProperty);
        }

		[Obsolete]
		private static void OnRealizeCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is NavigationPage target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.RemovePageRequested += OnRealizeCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.RemovePageRequested -= OnRealizeCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnRealizeCommandChanged(object o, Xamarin.Forms.Internals.NavigationRequestedEventArgs eventArgs)
        {
            var command = GetRealizeCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Realize))
                command.Execute(eventArgs.Realize);
        }
		#endregion

		#region TaskCommand
		[Obsolete]
        public static readonly BindableProperty TaskCommandProperty =
            BindableProperty.CreateAttached("TaskCommand", typeof(ICommand), typeof(NavigationPageRemovePageRequested), null, propertyChanged:OnTaskCommandChanged);

		[Obsolete]
        public static ICommand GetTaskCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(TaskCommandProperty);
        }

		[Obsolete]
		private static void OnTaskCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is NavigationPage target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.RemovePageRequested += OnTaskCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.RemovePageRequested -= OnTaskCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnTaskCommandChanged(object o, Xamarin.Forms.Internals.NavigationRequestedEventArgs eventArgs)
        {
            var command = GetTaskCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Task))
                command.Execute(eventArgs.Task);
        }
		#endregion

		#region PageCommand
		[Obsolete]
        public static readonly BindableProperty PageCommandProperty =
            BindableProperty.CreateAttached("PageCommand", typeof(ICommand), typeof(NavigationPageRemovePageRequested), null, propertyChanged:OnPageCommandChanged);

		[Obsolete]
        public static ICommand GetPageCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(PageCommandProperty);
        }

		[Obsolete]
		private static void OnPageCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is NavigationPage target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.RemovePageRequested += OnPageCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.RemovePageRequested -= OnPageCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnPageCommandChanged(object o, Xamarin.Forms.Internals.NavigationRequestedEventArgs eventArgs)
        {
            var command = GetPageCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Page))
                command.Execute(eventArgs.Page);
        }
		#endregion
	}

	[Obsolete]
	public class OpenGLViewDisplayRequested {

		#region Command
		[Obsolete]
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(OpenGLViewDisplayRequested), null, propertyChanged:OnCommandChanged);

		[Obsolete]
        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

		[Obsolete]
		private static void OnCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is OpenGLView target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.DisplayRequested += OnCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.DisplayRequested -= OnCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion
	}

	[Obsolete]
	public class PageAppearing {

		#region Command
		[Obsolete]
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(PageAppearing), null, propertyChanged:OnCommandChanged);

		[Obsolete]
        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

		[Obsolete]
		private static void OnCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Page target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.Appearing += OnCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.Appearing -= OnCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion
	}

	[Obsolete]
	public class PageDisappearing {

		#region Command
		[Obsolete]
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(PageDisappearing), null, propertyChanged:OnCommandChanged);

		[Obsolete]
        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

		[Obsolete]
		private static void OnCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Page target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.Disappearing += OnCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.Disappearing -= OnCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion
	}

	[Obsolete]
	public class PageLayoutChanged {

		#region Command
		[Obsolete]
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(PageLayoutChanged), null, propertyChanged:OnCommandChanged);

		[Obsolete]
        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

		[Obsolete]
		private static void OnCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Page target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.LayoutChanged += OnCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.LayoutChanged -= OnCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion
	}

	[Obsolete]
	public class PanGestureRecognizerPanUpdated {

		#region Command
		[Obsolete]
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(PanGestureRecognizerPanUpdated), null, propertyChanged:OnCommandChanged);

		[Obsolete]
        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

		[Obsolete]
		private static void OnCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is PanGestureRecognizer target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.PanUpdated += OnCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.PanUpdated -= OnCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion

		#region GestureIdCommand
		[Obsolete]
        public static readonly BindableProperty GestureIdCommandProperty =
            BindableProperty.CreateAttached("GestureIdCommand", typeof(ICommand), typeof(PanGestureRecognizerPanUpdated), null, propertyChanged:OnGestureIdCommandChanged);

		[Obsolete]
        public static ICommand GetGestureIdCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(GestureIdCommandProperty);
        }

		[Obsolete]
		private static void OnGestureIdCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is PanGestureRecognizer target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.PanUpdated += OnGestureIdCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.PanUpdated -= OnGestureIdCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnGestureIdCommandChanged(object o, Xamarin.Forms.PanUpdatedEventArgs eventArgs)
        {
            var command = GetGestureIdCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.GestureId))
                command.Execute(eventArgs.GestureId);
        }
		#endregion

		#region StatusTypeCommand
		[Obsolete]
        public static readonly BindableProperty StatusTypeCommandProperty =
            BindableProperty.CreateAttached("StatusTypeCommand", typeof(ICommand), typeof(PanGestureRecognizerPanUpdated), null, propertyChanged:OnStatusTypeCommandChanged);

		[Obsolete]
        public static ICommand GetStatusTypeCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(StatusTypeCommandProperty);
        }

		[Obsolete]
		private static void OnStatusTypeCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is PanGestureRecognizer target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.PanUpdated += OnStatusTypeCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.PanUpdated -= OnStatusTypeCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnStatusTypeCommandChanged(object o, Xamarin.Forms.PanUpdatedEventArgs eventArgs)
        {
            var command = GetStatusTypeCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.StatusType))
                command.Execute(eventArgs.StatusType);
        }
		#endregion

		#region TotalXCommand
		[Obsolete]
        public static readonly BindableProperty TotalXCommandProperty =
            BindableProperty.CreateAttached("TotalXCommand", typeof(ICommand), typeof(PanGestureRecognizerPanUpdated), null, propertyChanged:OnTotalXCommandChanged);

		[Obsolete]
        public static ICommand GetTotalXCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(TotalXCommandProperty);
        }

		[Obsolete]
		private static void OnTotalXCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is PanGestureRecognizer target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.PanUpdated += OnTotalXCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.PanUpdated -= OnTotalXCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnTotalXCommandChanged(object o, Xamarin.Forms.PanUpdatedEventArgs eventArgs)
        {
            var command = GetTotalXCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.TotalX))
                command.Execute(eventArgs.TotalX);
        }
		#endregion

		#region TotalYCommand
		[Obsolete]
        public static readonly BindableProperty TotalYCommandProperty =
            BindableProperty.CreateAttached("TotalYCommand", typeof(ICommand), typeof(PanGestureRecognizerPanUpdated), null, propertyChanged:OnTotalYCommandChanged);

		[Obsolete]
        public static ICommand GetTotalYCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(TotalYCommandProperty);
        }

		[Obsolete]
		private static void OnTotalYCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is PanGestureRecognizer target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.PanUpdated += OnTotalYCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.PanUpdated -= OnTotalYCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnTotalYCommandChanged(object o, Xamarin.Forms.PanUpdatedEventArgs eventArgs)
        {
            var command = GetTotalYCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.TotalY))
                command.Execute(eventArgs.TotalY);
        }
		#endregion
	}

	[Obsolete]
	public class PickerSelectedIndexChanged {

		#region Command
		[Obsolete]
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(PickerSelectedIndexChanged), null, propertyChanged:OnCommandChanged);

		[Obsolete]
        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

		[Obsolete]
		private static void OnCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Picker target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.SelectedIndexChanged += OnCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.SelectedIndexChanged -= OnCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion
	}

	[Obsolete]
	public class PinchGestureRecognizerPinchUpdated {

		#region Command
		[Obsolete]
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(PinchGestureRecognizerPinchUpdated), null, propertyChanged:OnCommandChanged);

		[Obsolete]
        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

		[Obsolete]
		private static void OnCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is PinchGestureRecognizer target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.PinchUpdated += OnCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.PinchUpdated -= OnCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion

		#region ScaleCommand
		[Obsolete]
        public static readonly BindableProperty ScaleCommandProperty =
            BindableProperty.CreateAttached("ScaleCommand", typeof(ICommand), typeof(PinchGestureRecognizerPinchUpdated), null, propertyChanged:OnScaleCommandChanged);

		[Obsolete]
        public static ICommand GetScaleCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ScaleCommandProperty);
        }

		[Obsolete]
		private static void OnScaleCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is PinchGestureRecognizer target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.PinchUpdated += OnScaleCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.PinchUpdated -= OnScaleCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnScaleCommandChanged(object o, Xamarin.Forms.PinchGestureUpdatedEventArgs eventArgs)
        {
            var command = GetScaleCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Scale))
                command.Execute(eventArgs.Scale);
        }
		#endregion

		#region ScaleOriginCommand
		[Obsolete]
        public static readonly BindableProperty ScaleOriginCommandProperty =
            BindableProperty.CreateAttached("ScaleOriginCommand", typeof(ICommand), typeof(PinchGestureRecognizerPinchUpdated), null, propertyChanged:OnScaleOriginCommandChanged);

		[Obsolete]
        public static ICommand GetScaleOriginCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ScaleOriginCommandProperty);
        }

		[Obsolete]
		private static void OnScaleOriginCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is PinchGestureRecognizer target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.PinchUpdated += OnScaleOriginCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.PinchUpdated -= OnScaleOriginCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnScaleOriginCommandChanged(object o, Xamarin.Forms.PinchGestureUpdatedEventArgs eventArgs)
        {
            var command = GetScaleOriginCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.ScaleOrigin))
                command.Execute(eventArgs.ScaleOrigin);
        }
		#endregion

		#region StatusCommand
		[Obsolete]
        public static readonly BindableProperty StatusCommandProperty =
            BindableProperty.CreateAttached("StatusCommand", typeof(ICommand), typeof(PinchGestureRecognizerPinchUpdated), null, propertyChanged:OnStatusCommandChanged);

		[Obsolete]
        public static ICommand GetStatusCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(StatusCommandProperty);
        }

		[Obsolete]
		private static void OnStatusCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is PinchGestureRecognizer target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.PinchUpdated += OnStatusCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.PinchUpdated -= OnStatusCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnStatusCommandChanged(object o, Xamarin.Forms.PinchGestureUpdatedEventArgs eventArgs)
        {
            var command = GetStatusCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Status))
                command.Execute(eventArgs.Status);
        }
		#endregion
	}

	[Obsolete]
	public class RowDefinitionSizeChanged {

		#region Command
		[Obsolete]
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(RowDefinitionSizeChanged), null, propertyChanged:OnCommandChanged);

		[Obsolete]
        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

		[Obsolete]
		private static void OnCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is RowDefinition target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.SizeChanged += OnCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.SizeChanged -= OnCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion
	}

	[Obsolete]
	public class ScrollViewScrolled {

		#region Command
		[Obsolete]
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(ScrollViewScrolled), null, propertyChanged:OnCommandChanged);

		[Obsolete]
        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

		[Obsolete]
		private static void OnCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is ScrollView target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.Scrolled += OnCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.Scrolled -= OnCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion

		#region ScrollXCommand
		[Obsolete]
        public static readonly BindableProperty ScrollXCommandProperty =
            BindableProperty.CreateAttached("ScrollXCommand", typeof(ICommand), typeof(ScrollViewScrolled), null, propertyChanged:OnScrollXCommandChanged);

		[Obsolete]
        public static ICommand GetScrollXCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ScrollXCommandProperty);
        }

		[Obsolete]
		private static void OnScrollXCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is ScrollView target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.Scrolled += OnScrollXCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.Scrolled -= OnScrollXCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnScrollXCommandChanged(object o, Xamarin.Forms.ScrolledEventArgs eventArgs)
        {
            var command = GetScrollXCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.ScrollX))
                command.Execute(eventArgs.ScrollX);
        }
		#endregion

		#region ScrollYCommand
		[Obsolete]
        public static readonly BindableProperty ScrollYCommandProperty =
            BindableProperty.CreateAttached("ScrollYCommand", typeof(ICommand), typeof(ScrollViewScrolled), null, propertyChanged:OnScrollYCommandChanged);

		[Obsolete]
        public static ICommand GetScrollYCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ScrollYCommandProperty);
        }

		[Obsolete]
		private static void OnScrollYCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is ScrollView target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.Scrolled += OnScrollYCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.Scrolled -= OnScrollYCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnScrollYCommandChanged(object o, Xamarin.Forms.ScrolledEventArgs eventArgs)
        {
            var command = GetScrollYCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.ScrollY))
                command.Execute(eventArgs.ScrollY);
        }
		#endregion
	}

	[Obsolete]
	public class ScrollViewScrollToRequested {

		#region Command
		[Obsolete]
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(ScrollViewScrollToRequested), null, propertyChanged:OnCommandChanged);

		[Obsolete]
        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

		[Obsolete]
		private static void OnCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is ScrollView target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.ScrollToRequested += OnCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.ScrollToRequested -= OnCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion

		#region ElementCommand
		[Obsolete]
        public static readonly BindableProperty ElementCommandProperty =
            BindableProperty.CreateAttached("ElementCommand", typeof(ICommand), typeof(ScrollViewScrollToRequested), null, propertyChanged:OnElementCommandChanged);

		[Obsolete]
        public static ICommand GetElementCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ElementCommandProperty);
        }

		[Obsolete]
		private static void OnElementCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is ScrollView target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.ScrollToRequested += OnElementCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.ScrollToRequested -= OnElementCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnElementCommandChanged(object o, Xamarin.Forms.ScrollToRequestedEventArgs eventArgs)
        {
            var command = GetElementCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Element))
                command.Execute(eventArgs.Element);
        }
		#endregion

		#region ModeCommand
		[Obsolete]
        public static readonly BindableProperty ModeCommandProperty =
            BindableProperty.CreateAttached("ModeCommand", typeof(ICommand), typeof(ScrollViewScrollToRequested), null, propertyChanged:OnModeCommandChanged);

		[Obsolete]
        public static ICommand GetModeCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ModeCommandProperty);
        }

		[Obsolete]
		private static void OnModeCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is ScrollView target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.ScrollToRequested += OnModeCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.ScrollToRequested -= OnModeCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnModeCommandChanged(object o, Xamarin.Forms.ScrollToRequestedEventArgs eventArgs)
        {
            var command = GetModeCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Mode))
                command.Execute(eventArgs.Mode);
        }
		#endregion

		#region PositionCommand
		[Obsolete]
        public static readonly BindableProperty PositionCommandProperty =
            BindableProperty.CreateAttached("PositionCommand", typeof(ICommand), typeof(ScrollViewScrollToRequested), null, propertyChanged:OnPositionCommandChanged);

		[Obsolete]
        public static ICommand GetPositionCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(PositionCommandProperty);
        }

		[Obsolete]
		private static void OnPositionCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is ScrollView target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.ScrollToRequested += OnPositionCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.ScrollToRequested -= OnPositionCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnPositionCommandChanged(object o, Xamarin.Forms.ScrollToRequestedEventArgs eventArgs)
        {
            var command = GetPositionCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Position))
                command.Execute(eventArgs.Position);
        }
		#endregion

		#region ScrollXCommand
		[Obsolete]
        public static readonly BindableProperty ScrollXCommandProperty =
            BindableProperty.CreateAttached("ScrollXCommand", typeof(ICommand), typeof(ScrollViewScrollToRequested), null, propertyChanged:OnScrollXCommandChanged);

		[Obsolete]
        public static ICommand GetScrollXCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ScrollXCommandProperty);
        }

		[Obsolete]
		private static void OnScrollXCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is ScrollView target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.ScrollToRequested += OnScrollXCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.ScrollToRequested -= OnScrollXCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnScrollXCommandChanged(object o, Xamarin.Forms.ScrollToRequestedEventArgs eventArgs)
        {
            var command = GetScrollXCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.ScrollX))
                command.Execute(eventArgs.ScrollX);
        }
		#endregion

		#region ScrollYCommand
		[Obsolete]
        public static readonly BindableProperty ScrollYCommandProperty =
            BindableProperty.CreateAttached("ScrollYCommand", typeof(ICommand), typeof(ScrollViewScrollToRequested), null, propertyChanged:OnScrollYCommandChanged);

		[Obsolete]
        public static ICommand GetScrollYCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ScrollYCommandProperty);
        }

		[Obsolete]
		private static void OnScrollYCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is ScrollView target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.ScrollToRequested += OnScrollYCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.ScrollToRequested -= OnScrollYCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnScrollYCommandChanged(object o, Xamarin.Forms.ScrollToRequestedEventArgs eventArgs)
        {
            var command = GetScrollYCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.ScrollY))
                command.Execute(eventArgs.ScrollY);
        }
		#endregion

		#region ShouldAnimateCommand
		[Obsolete]
        public static readonly BindableProperty ShouldAnimateCommandProperty =
            BindableProperty.CreateAttached("ShouldAnimateCommand", typeof(ICommand), typeof(ScrollViewScrollToRequested), null, propertyChanged:OnShouldAnimateCommandChanged);

		[Obsolete]
        public static ICommand GetShouldAnimateCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ShouldAnimateCommandProperty);
        }

		[Obsolete]
		private static void OnShouldAnimateCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is ScrollView target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.ScrollToRequested += OnShouldAnimateCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.ScrollToRequested -= OnShouldAnimateCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnShouldAnimateCommandChanged(object o, Xamarin.Forms.ScrollToRequestedEventArgs eventArgs)
        {
            var command = GetShouldAnimateCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.ShouldAnimate))
                command.Execute(eventArgs.ShouldAnimate);
        }
		#endregion
	}

	[Obsolete]
	public class SearchBarSearchButtonPressed {

		#region Command
		[Obsolete]
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(SearchBarSearchButtonPressed), null, propertyChanged:OnCommandChanged);

		[Obsolete]
        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

		[Obsolete]
		private static void OnCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is SearchBar target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.SearchButtonPressed += OnCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.SearchButtonPressed -= OnCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion
	}

	[Obsolete]
	public class SearchBarTextChanged {

		#region Command
		[Obsolete]
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(SearchBarTextChanged), null, propertyChanged:OnCommandChanged);

		[Obsolete]
        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

		[Obsolete]
		private static void OnCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is SearchBar target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.TextChanged += OnCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.TextChanged -= OnCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion

		#region NewTextValueCommand
		[Obsolete]
        public static readonly BindableProperty NewTextValueCommandProperty =
            BindableProperty.CreateAttached("NewTextValueCommand", typeof(ICommand), typeof(SearchBarTextChanged), null, propertyChanged:OnNewTextValueCommandChanged);

		[Obsolete]
        public static ICommand GetNewTextValueCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NewTextValueCommandProperty);
        }

		[Obsolete]
		private static void OnNewTextValueCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is SearchBar target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.TextChanged += OnNewTextValueCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.TextChanged -= OnNewTextValueCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnNewTextValueCommandChanged(object o, Xamarin.Forms.TextChangedEventArgs eventArgs)
        {
            var command = GetNewTextValueCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.NewTextValue))
                command.Execute(eventArgs.NewTextValue);
        }
		#endregion

		#region OldTextValueCommand
		[Obsolete]
        public static readonly BindableProperty OldTextValueCommandProperty =
            BindableProperty.CreateAttached("OldTextValueCommand", typeof(ICommand), typeof(SearchBarTextChanged), null, propertyChanged:OnOldTextValueCommandChanged);

		[Obsolete]
        public static ICommand GetOldTextValueCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(OldTextValueCommandProperty);
        }

		[Obsolete]
		private static void OnOldTextValueCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is SearchBar target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.TextChanged += OnOldTextValueCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.TextChanged -= OnOldTextValueCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnOldTextValueCommandChanged(object o, Xamarin.Forms.TextChangedEventArgs eventArgs)
        {
            var command = GetOldTextValueCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.OldTextValue))
                command.Execute(eventArgs.OldTextValue);
        }
		#endregion
	}

	[Obsolete]
	public class SliderValueChanged {

		#region Command
		[Obsolete]
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(SliderValueChanged), null, propertyChanged:OnCommandChanged);

		[Obsolete]
        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

		[Obsolete]
		private static void OnCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Slider target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.ValueChanged += OnCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.ValueChanged -= OnCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion

		#region NewValueCommand
		[Obsolete]
        public static readonly BindableProperty NewValueCommandProperty =
            BindableProperty.CreateAttached("NewValueCommand", typeof(ICommand), typeof(SliderValueChanged), null, propertyChanged:OnNewValueCommandChanged);

		[Obsolete]
        public static ICommand GetNewValueCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NewValueCommandProperty);
        }

		[Obsolete]
		private static void OnNewValueCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Slider target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.ValueChanged += OnNewValueCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.ValueChanged -= OnNewValueCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnNewValueCommandChanged(object o, Xamarin.Forms.ValueChangedEventArgs eventArgs)
        {
            var command = GetNewValueCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.NewValue))
                command.Execute(eventArgs.NewValue);
        }
		#endregion

		#region OldValueCommand
		[Obsolete]
        public static readonly BindableProperty OldValueCommandProperty =
            BindableProperty.CreateAttached("OldValueCommand", typeof(ICommand), typeof(SliderValueChanged), null, propertyChanged:OnOldValueCommandChanged);

		[Obsolete]
        public static ICommand GetOldValueCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(OldValueCommandProperty);
        }

		[Obsolete]
		private static void OnOldValueCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Slider target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.ValueChanged += OnOldValueCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.ValueChanged -= OnOldValueCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnOldValueCommandChanged(object o, Xamarin.Forms.ValueChangedEventArgs eventArgs)
        {
            var command = GetOldValueCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.OldValue))
                command.Execute(eventArgs.OldValue);
        }
		#endregion
	}

	[Obsolete]
	public class StepperValueChanged {

		#region Command
		[Obsolete]
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(StepperValueChanged), null, propertyChanged:OnCommandChanged);

		[Obsolete]
        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

		[Obsolete]
		private static void OnCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Stepper target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.ValueChanged += OnCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.ValueChanged -= OnCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion

		#region NewValueCommand
		[Obsolete]
        public static readonly BindableProperty NewValueCommandProperty =
            BindableProperty.CreateAttached("NewValueCommand", typeof(ICommand), typeof(StepperValueChanged), null, propertyChanged:OnNewValueCommandChanged);

		[Obsolete]
        public static ICommand GetNewValueCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NewValueCommandProperty);
        }

		[Obsolete]
		private static void OnNewValueCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Stepper target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.ValueChanged += OnNewValueCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.ValueChanged -= OnNewValueCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnNewValueCommandChanged(object o, Xamarin.Forms.ValueChangedEventArgs eventArgs)
        {
            var command = GetNewValueCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.NewValue))
                command.Execute(eventArgs.NewValue);
        }
		#endregion

		#region OldValueCommand
		[Obsolete]
        public static readonly BindableProperty OldValueCommandProperty =
            BindableProperty.CreateAttached("OldValueCommand", typeof(ICommand), typeof(StepperValueChanged), null, propertyChanged:OnOldValueCommandChanged);

		[Obsolete]
        public static ICommand GetOldValueCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(OldValueCommandProperty);
        }

		[Obsolete]
		private static void OnOldValueCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Stepper target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.ValueChanged += OnOldValueCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.ValueChanged -= OnOldValueCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnOldValueCommandChanged(object o, Xamarin.Forms.ValueChangedEventArgs eventArgs)
        {
            var command = GetOldValueCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.OldValue))
                command.Execute(eventArgs.OldValue);
        }
		#endregion
	}

	[Obsolete]
	public class SwitchToggled {

		#region Command
		[Obsolete]
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(SwitchToggled), null, propertyChanged:OnCommandChanged);

		[Obsolete]
        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

		[Obsolete]
		private static void OnCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Switch target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.Toggled += OnCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.Toggled -= OnCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion

		#region ValueCommand
		[Obsolete]
        public static readonly BindableProperty ValueCommandProperty =
            BindableProperty.CreateAttached("ValueCommand", typeof(ICommand), typeof(SwitchToggled), null, propertyChanged:OnValueCommandChanged);

		[Obsolete]
        public static ICommand GetValueCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ValueCommandProperty);
        }

		[Obsolete]
		private static void OnValueCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Switch target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.Toggled += OnValueCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.Toggled -= OnValueCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnValueCommandChanged(object o, Xamarin.Forms.ToggledEventArgs eventArgs)
        {
            var command = GetValueCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Value))
                command.Execute(eventArgs.Value);
        }
		#endregion
	}

	[Obsolete]
	public class SwitchCellOnChanged {

		#region Command
		[Obsolete]
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(SwitchCellOnChanged), null, propertyChanged:OnCommandChanged);

		[Obsolete]
        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

		[Obsolete]
		private static void OnCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is SwitchCell target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.OnChanged += OnCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.OnChanged -= OnCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion

		#region ValueCommand
		[Obsolete]
        public static readonly BindableProperty ValueCommandProperty =
            BindableProperty.CreateAttached("ValueCommand", typeof(ICommand), typeof(SwitchCellOnChanged), null, propertyChanged:OnValueCommandChanged);

		[Obsolete]
        public static ICommand GetValueCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ValueCommandProperty);
        }

		[Obsolete]
		private static void OnValueCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is SwitchCell target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.OnChanged += OnValueCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.OnChanged -= OnValueCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnValueCommandChanged(object o, Xamarin.Forms.ToggledEventArgs eventArgs)
        {
            var command = GetValueCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Value))
                command.Execute(eventArgs.Value);
        }
		#endregion
	}

	[Obsolete]
	public class TableViewModelChanged {

		#region Command
		[Obsolete]
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(TableViewModelChanged), null, propertyChanged:OnCommandChanged);

		[Obsolete]
        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

		[Obsolete]
		private static void OnCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is TableView target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.ModelChanged += OnCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.ModelChanged -= OnCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion
	}

	[Obsolete]
	public class TapGestureRecognizerTapped {

		#region Command
		[Obsolete]
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(TapGestureRecognizerTapped), null, propertyChanged:OnCommandChanged);

		[Obsolete]
        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

		[Obsolete]
		private static void OnCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is TapGestureRecognizer target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.Tapped += OnCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.Tapped -= OnCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion
	}

	[Obsolete]
	public class VisualElementBatchCommitted {

		#region Command
		[Obsolete]
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(VisualElementBatchCommitted), null, propertyChanged:OnCommandChanged);

		[Obsolete]
        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

		[Obsolete]
		private static void OnCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is VisualElement target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.BatchCommitted += OnCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.BatchCommitted -= OnCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion

		#region DataCommand
		[Obsolete]
        public static readonly BindableProperty DataCommandProperty =
            BindableProperty.CreateAttached("DataCommand", typeof(ICommand), typeof(VisualElementBatchCommitted), null, propertyChanged:OnDataCommandChanged);

		[Obsolete]
        public static ICommand GetDataCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(DataCommandProperty);
        }

		[Obsolete]
		private static void OnDataCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is VisualElement target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.BatchCommitted += OnDataCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.BatchCommitted -= OnDataCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnDataCommandChanged(object o, Xamarin.Forms.Internals.EventArg<Xamarin.Forms.VisualElement> eventArgs)
        {
            var command = GetDataCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Data))
                command.Execute(eventArgs.Data);
        }
		#endregion
	}

	[Obsolete]
	public class VisualElementChildrenReordered {

		#region Command
		[Obsolete]
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(VisualElementChildrenReordered), null, propertyChanged:OnCommandChanged);

		[Obsolete]
        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

		[Obsolete]
		private static void OnCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is VisualElement target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.ChildrenReordered += OnCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.ChildrenReordered -= OnCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion
	}

	[Obsolete]
	public class VisualElementFocusChangeRequested {

		#region Command
		[Obsolete]
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(VisualElementFocusChangeRequested), null, propertyChanged:OnCommandChanged);

		[Obsolete]
        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

		[Obsolete]
		private static void OnCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is VisualElement target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.FocusChangeRequested += OnCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.FocusChangeRequested -= OnCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion

		#region FocusCommand
		[Obsolete]
        public static readonly BindableProperty FocusCommandProperty =
            BindableProperty.CreateAttached("FocusCommand", typeof(ICommand), typeof(VisualElementFocusChangeRequested), null, propertyChanged:OnFocusCommandChanged);

		[Obsolete]
        public static ICommand GetFocusCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(FocusCommandProperty);
        }

		[Obsolete]
		private static void OnFocusCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is VisualElement target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.FocusChangeRequested += OnFocusCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.FocusChangeRequested -= OnFocusCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnFocusCommandChanged(object o, Xamarin.Forms.VisualElement.FocusRequestArgs eventArgs)
        {
            var command = GetFocusCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Focus))
                command.Execute(eventArgs.Focus);
        }
		#endregion

		#region ResultCommand
		[Obsolete]
        public static readonly BindableProperty ResultCommandProperty =
            BindableProperty.CreateAttached("ResultCommand", typeof(ICommand), typeof(VisualElementFocusChangeRequested), null, propertyChanged:OnResultCommandChanged);

		[Obsolete]
        public static ICommand GetResultCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ResultCommandProperty);
        }

		[Obsolete]
		private static void OnResultCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is VisualElement target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.FocusChangeRequested += OnResultCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.FocusChangeRequested -= OnResultCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnResultCommandChanged(object o, Xamarin.Forms.VisualElement.FocusRequestArgs eventArgs)
        {
            var command = GetResultCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Result))
                command.Execute(eventArgs.Result);
        }
		#endregion
	}

	[Obsolete]
	public class VisualElementFocused {

		#region Command
		[Obsolete]
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(VisualElementFocused), null, propertyChanged:OnCommandChanged);

		[Obsolete]
        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

		[Obsolete]
		private static void OnCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is VisualElement target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.Focused += OnCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.Focused -= OnCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion

		#region IsFocusedCommand
		[Obsolete]
        public static readonly BindableProperty IsFocusedCommandProperty =
            BindableProperty.CreateAttached("IsFocusedCommand", typeof(ICommand), typeof(VisualElementFocused), null, propertyChanged:OnIsFocusedCommandChanged);

		[Obsolete]
        public static ICommand GetIsFocusedCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(IsFocusedCommandProperty);
        }

		[Obsolete]
		private static void OnIsFocusedCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is VisualElement target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.Focused += OnIsFocusedCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.Focused -= OnIsFocusedCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnIsFocusedCommandChanged(object o, Xamarin.Forms.FocusEventArgs eventArgs)
        {
            var command = GetIsFocusedCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.IsFocused))
                command.Execute(eventArgs.IsFocused);
        }
		#endregion

		#region VisualElementCommand
		[Obsolete]
        public static readonly BindableProperty VisualElementCommandProperty =
            BindableProperty.CreateAttached("VisualElementCommand", typeof(ICommand), typeof(VisualElementFocused), null, propertyChanged:OnVisualElementCommandChanged);

		[Obsolete]
        public static ICommand GetVisualElementCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(VisualElementCommandProperty);
        }

		[Obsolete]
		private static void OnVisualElementCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is VisualElement target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.Focused += OnVisualElementCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.Focused -= OnVisualElementCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnVisualElementCommandChanged(object o, Xamarin.Forms.FocusEventArgs eventArgs)
        {
            var command = GetVisualElementCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.VisualElement))
                command.Execute(eventArgs.VisualElement);
        }
		#endregion
	}

	[Obsolete]
	public class VisualElementMeasureInvalidated {

		#region Command
		[Obsolete]
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(VisualElementMeasureInvalidated), null, propertyChanged:OnCommandChanged);

		[Obsolete]
        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

		[Obsolete]
		private static void OnCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is VisualElement target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.MeasureInvalidated += OnCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.MeasureInvalidated -= OnCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion
	}

	[Obsolete]
	public class VisualElementSizeChanged {

		#region Command
		[Obsolete]
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(VisualElementSizeChanged), null, propertyChanged:OnCommandChanged);

		[Obsolete]
        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

		[Obsolete]
		private static void OnCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is VisualElement target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.SizeChanged += OnCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.SizeChanged -= OnCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion
	}

	[Obsolete]
	public class VisualElementUnfocused {

		#region Command
		[Obsolete]
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(VisualElementUnfocused), null, propertyChanged:OnCommandChanged);

		[Obsolete]
        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

		[Obsolete]
		private static void OnCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is VisualElement target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.Unfocused += OnCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.Unfocused -= OnCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion

		#region IsFocusedCommand
		[Obsolete]
        public static readonly BindableProperty IsFocusedCommandProperty =
            BindableProperty.CreateAttached("IsFocusedCommand", typeof(ICommand), typeof(VisualElementUnfocused), null, propertyChanged:OnIsFocusedCommandChanged);

		[Obsolete]
        public static ICommand GetIsFocusedCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(IsFocusedCommandProperty);
        }

		[Obsolete]
		private static void OnIsFocusedCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is VisualElement target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.Unfocused += OnIsFocusedCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.Unfocused -= OnIsFocusedCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnIsFocusedCommandChanged(object o, Xamarin.Forms.FocusEventArgs eventArgs)
        {
            var command = GetIsFocusedCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.IsFocused))
                command.Execute(eventArgs.IsFocused);
        }
		#endregion

		#region VisualElementCommand
		[Obsolete]
        public static readonly BindableProperty VisualElementCommandProperty =
            BindableProperty.CreateAttached("VisualElementCommand", typeof(ICommand), typeof(VisualElementUnfocused), null, propertyChanged:OnVisualElementCommandChanged);

		[Obsolete]
        public static ICommand GetVisualElementCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(VisualElementCommandProperty);
        }

		[Obsolete]
		private static void OnVisualElementCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is VisualElement target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.Unfocused += OnVisualElementCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.Unfocused -= OnVisualElementCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnVisualElementCommandChanged(object o, Xamarin.Forms.FocusEventArgs eventArgs)
        {
            var command = GetVisualElementCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.VisualElement))
                command.Execute(eventArgs.VisualElement);
        }
		#endregion
	}

	[Obsolete]
	public class WebViewEvalRequested {

		#region Command
		[Obsolete]
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(WebViewEvalRequested), null, propertyChanged:OnCommandChanged);

		[Obsolete]
        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

		[Obsolete]
		private static void OnCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is WebView target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.EvalRequested += OnCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.EvalRequested -= OnCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion

		#region ScriptCommand
		[Obsolete]
        public static readonly BindableProperty ScriptCommandProperty =
            BindableProperty.CreateAttached("ScriptCommand", typeof(ICommand), typeof(WebViewEvalRequested), null, propertyChanged:OnScriptCommandChanged);

		[Obsolete]
        public static ICommand GetScriptCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ScriptCommandProperty);
        }

		[Obsolete]
		private static void OnScriptCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is WebView target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.EvalRequested += OnScriptCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.EvalRequested -= OnScriptCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnScriptCommandChanged(object o, Xamarin.Forms.Internals.EvalRequested eventArgs)
        {
            var command = GetScriptCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Script))
                command.Execute(eventArgs.Script);
        }
		#endregion
	}

	[Obsolete]
	public class WebViewGoBackRequested {

		#region Command
		[Obsolete]
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(WebViewGoBackRequested), null, propertyChanged:OnCommandChanged);

		[Obsolete]
        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

		[Obsolete]
		private static void OnCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is WebView target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.GoBackRequested += OnCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.GoBackRequested -= OnCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion
	}

	[Obsolete]
	public class WebViewGoForwardRequested {

		#region Command
		[Obsolete]
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(WebViewGoForwardRequested), null, propertyChanged:OnCommandChanged);

		[Obsolete]
        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

		[Obsolete]
		private static void OnCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is WebView target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.GoForwardRequested += OnCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.GoForwardRequested -= OnCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion
	}

	[Obsolete]
	public class WebViewNavigated {

		#region Command
		[Obsolete]
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(WebViewNavigated), null, propertyChanged:OnCommandChanged);

		[Obsolete]
        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

		[Obsolete]
		private static void OnCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is WebView target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.Navigated += OnCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.Navigated -= OnCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion

		#region ResultCommand
		[Obsolete]
        public static readonly BindableProperty ResultCommandProperty =
            BindableProperty.CreateAttached("ResultCommand", typeof(ICommand), typeof(WebViewNavigated), null, propertyChanged:OnResultCommandChanged);

		[Obsolete]
        public static ICommand GetResultCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ResultCommandProperty);
        }

		[Obsolete]
		private static void OnResultCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is WebView target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.Navigated += OnResultCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.Navigated -= OnResultCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnResultCommandChanged(object o, Xamarin.Forms.WebNavigatedEventArgs eventArgs)
        {
            var command = GetResultCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Result))
                command.Execute(eventArgs.Result);
        }
		#endregion

		#region NavigationEventCommand
		[Obsolete]
        public static readonly BindableProperty NavigationEventCommandProperty =
            BindableProperty.CreateAttached("NavigationEventCommand", typeof(ICommand), typeof(WebViewNavigated), null, propertyChanged:OnNavigationEventCommandChanged);

		[Obsolete]
        public static ICommand GetNavigationEventCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NavigationEventCommandProperty);
        }

		[Obsolete]
		private static void OnNavigationEventCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is WebView target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.Navigated += OnNavigationEventCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.Navigated -= OnNavigationEventCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnNavigationEventCommandChanged(object o, Xamarin.Forms.WebNavigatedEventArgs eventArgs)
        {
            var command = GetNavigationEventCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.NavigationEvent))
                command.Execute(eventArgs.NavigationEvent);
        }
		#endregion

		#region SourceCommand
		[Obsolete]
        public static readonly BindableProperty SourceCommandProperty =
            BindableProperty.CreateAttached("SourceCommand", typeof(ICommand), typeof(WebViewNavigated), null, propertyChanged:OnSourceCommandChanged);

		[Obsolete]
        public static ICommand GetSourceCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(SourceCommandProperty);
        }

		[Obsolete]
		private static void OnSourceCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is WebView target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.Navigated += OnSourceCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.Navigated -= OnSourceCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnSourceCommandChanged(object o, Xamarin.Forms.WebNavigatedEventArgs eventArgs)
        {
            var command = GetSourceCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Source))
                command.Execute(eventArgs.Source);
        }
		#endregion

		#region UrlCommand
		[Obsolete]
        public static readonly BindableProperty UrlCommandProperty =
            BindableProperty.CreateAttached("UrlCommand", typeof(ICommand), typeof(WebViewNavigated), null, propertyChanged:OnUrlCommandChanged);

		[Obsolete]
        public static ICommand GetUrlCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(UrlCommandProperty);
        }

		[Obsolete]
		private static void OnUrlCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is WebView target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.Navigated += OnUrlCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.Navigated -= OnUrlCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnUrlCommandChanged(object o, Xamarin.Forms.WebNavigatedEventArgs eventArgs)
        {
            var command = GetUrlCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Url))
                command.Execute(eventArgs.Url);
        }
		#endregion
	}

	[Obsolete]
	public class WebViewNavigating {

		#region Command
		[Obsolete]
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(WebViewNavigating), null, propertyChanged:OnCommandChanged);

		[Obsolete]
        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

		[Obsolete]
		private static void OnCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is WebView target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.Navigating += OnCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.Navigating -= OnCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion

		#region CancelCommand
		[Obsolete]
        public static readonly BindableProperty CancelCommandProperty =
            BindableProperty.CreateAttached("CancelCommand", typeof(ICommand), typeof(WebViewNavigating), null, propertyChanged:OnCancelCommandChanged);

		[Obsolete]
        public static ICommand GetCancelCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CancelCommandProperty);
        }

		[Obsolete]
		private static void OnCancelCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is WebView target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.Navigating += OnCancelCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.Navigating -= OnCancelCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnCancelCommandChanged(object o, Xamarin.Forms.WebNavigatingEventArgs eventArgs)
        {
            var command = GetCancelCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Cancel))
                command.Execute(eventArgs.Cancel);
        }
		#endregion

		#region NavigationEventCommand
		[Obsolete]
        public static readonly BindableProperty NavigationEventCommandProperty =
            BindableProperty.CreateAttached("NavigationEventCommand", typeof(ICommand), typeof(WebViewNavigating), null, propertyChanged:OnNavigationEventCommandChanged);

		[Obsolete]
        public static ICommand GetNavigationEventCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NavigationEventCommandProperty);
        }

		[Obsolete]
		private static void OnNavigationEventCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is WebView target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.Navigating += OnNavigationEventCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.Navigating -= OnNavigationEventCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnNavigationEventCommandChanged(object o, Xamarin.Forms.WebNavigatingEventArgs eventArgs)
        {
            var command = GetNavigationEventCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.NavigationEvent))
                command.Execute(eventArgs.NavigationEvent);
        }
		#endregion

		#region SourceCommand
		[Obsolete]
        public static readonly BindableProperty SourceCommandProperty =
            BindableProperty.CreateAttached("SourceCommand", typeof(ICommand), typeof(WebViewNavigating), null, propertyChanged:OnSourceCommandChanged);

		[Obsolete]
        public static ICommand GetSourceCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(SourceCommandProperty);
        }

		[Obsolete]
		private static void OnSourceCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is WebView target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.Navigating += OnSourceCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.Navigating -= OnSourceCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnSourceCommandChanged(object o, Xamarin.Forms.WebNavigatingEventArgs eventArgs)
        {
            var command = GetSourceCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Source))
                command.Execute(eventArgs.Source);
        }
		#endregion

		#region UrlCommand
		[Obsolete]
        public static readonly BindableProperty UrlCommandProperty =
            BindableProperty.CreateAttached("UrlCommand", typeof(ICommand), typeof(WebViewNavigating), null, propertyChanged:OnUrlCommandChanged);

		[Obsolete]
        public static ICommand GetUrlCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(UrlCommandProperty);
        }

		[Obsolete]
		private static void OnUrlCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is WebView target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.Navigating += OnUrlCommandChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.Navigating -= OnUrlCommandChanged;
                }
            }
		}

		[Obsolete]
        private static void OnUrlCommandChanged(object o, Xamarin.Forms.WebNavigatingEventArgs eventArgs)
        {
            var command = GetUrlCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Url))
                command.Execute(eventArgs.Url);
        }
		#endregion
	}

}
