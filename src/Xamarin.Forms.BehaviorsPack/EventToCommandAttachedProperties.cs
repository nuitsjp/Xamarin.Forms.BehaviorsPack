using System;
using System.Windows.Input;
using Xamarin.Forms.Internals;

namespace Xamarin.Forms.BehaviorsPack {
	public partial class ApplicationModalPopped {

		#region Command
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(ApplicationModalPopped), null, propertyChanged:OnCommandChanged);

        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

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

        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion

		#region ModalCommand
        public static readonly BindableProperty ModalCommandProperty =
            BindableProperty.CreateAttached("ModalCommand", typeof(ICommand), typeof(ApplicationModalPopped), null, propertyChanged:OnModalCommandChanged);

        public static ICommand GetModalCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ModalCommandProperty);
        }

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

        private static void OnModalCommandChanged(object o, Xamarin.Forms.ModalPoppedEventArgs eventArgs)
        {
            var command = GetModalCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Modal))
                command.Execute(eventArgs.Modal);
        }
		#endregion
	}

	public partial class ApplicationModalPopping {

		#region Command
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(ApplicationModalPopping), null, propertyChanged:OnCommandChanged);

        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

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

        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion

		#region CancelCommand
        public static readonly BindableProperty CancelCommandProperty =
            BindableProperty.CreateAttached("CancelCommand", typeof(ICommand), typeof(ApplicationModalPopping), null, propertyChanged:OnCancelCommandChanged);

        public static ICommand GetCancelCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CancelCommandProperty);
        }

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

        private static void OnCancelCommandChanged(object o, Xamarin.Forms.ModalPoppingEventArgs eventArgs)
        {
            var command = GetCancelCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Cancel))
                command.Execute(eventArgs.Cancel);
        }
		#endregion

		#region ModalCommand
        public static readonly BindableProperty ModalCommandProperty =
            BindableProperty.CreateAttached("ModalCommand", typeof(ICommand), typeof(ApplicationModalPopping), null, propertyChanged:OnModalCommandChanged);

        public static ICommand GetModalCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ModalCommandProperty);
        }

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

        private static void OnModalCommandChanged(object o, Xamarin.Forms.ModalPoppingEventArgs eventArgs)
        {
            var command = GetModalCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Modal))
                command.Execute(eventArgs.Modal);
        }
		#endregion
	}

	public partial class ApplicationModalPushed {

		#region Command
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(ApplicationModalPushed), null, propertyChanged:OnCommandChanged);

        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

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

        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion

		#region ModalCommand
        public static readonly BindableProperty ModalCommandProperty =
            BindableProperty.CreateAttached("ModalCommand", typeof(ICommand), typeof(ApplicationModalPushed), null, propertyChanged:OnModalCommandChanged);

        public static ICommand GetModalCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ModalCommandProperty);
        }

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

        private static void OnModalCommandChanged(object o, Xamarin.Forms.ModalPushedEventArgs eventArgs)
        {
            var command = GetModalCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Modal))
                command.Execute(eventArgs.Modal);
        }
		#endregion
	}

	public partial class ApplicationModalPushing {

		#region Command
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(ApplicationModalPushing), null, propertyChanged:OnCommandChanged);

        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

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

        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion

		#region ModalCommand
        public static readonly BindableProperty ModalCommandProperty =
            BindableProperty.CreateAttached("ModalCommand", typeof(ICommand), typeof(ApplicationModalPushing), null, propertyChanged:OnModalCommandChanged);

        public static ICommand GetModalCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ModalCommandProperty);
        }

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

        private static void OnModalCommandChanged(object o, Xamarin.Forms.ModalPushingEventArgs eventArgs)
        {
            var command = GetModalCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Modal))
                command.Execute(eventArgs.Modal);
        }
		#endregion
	}

	public partial class ButtonClicked {

		#region Command
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(ButtonClicked), null, propertyChanged:OnCommandChanged);

        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

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

        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion
	}

	public partial class ButtonPressed {

		#region Command
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(ButtonPressed), null, propertyChanged:OnCommandChanged);

        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

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

        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion
	}

	public partial class ButtonReleased {

		#region Command
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(ButtonReleased), null, propertyChanged:OnCommandChanged);

        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

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

        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion
	}

	public partial class CellAppearing {

		#region Command
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(CellAppearing), null, propertyChanged:OnCommandChanged);

        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

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

        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion
	}

	public partial class CellDisappearing {

		#region Command
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(CellDisappearing), null, propertyChanged:OnCommandChanged);

        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

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

        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion
	}

	public partial class CellForceUpdateSizeRequested {

		#region Command
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(CellForceUpdateSizeRequested), null, propertyChanged:OnCommandChanged);

        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

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

        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion
	}

	public partial class CellTapped {

		#region Command
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(CellTapped), null, propertyChanged:OnCommandChanged);

        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

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

        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion
	}

	public partial class ColumnDefinitionSizeChanged {

		#region Command
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(ColumnDefinitionSizeChanged), null, propertyChanged:OnCommandChanged);

        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

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

        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion
	}

	public partial class DatePickerDateSelected {

		#region Command
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(DatePickerDateSelected), null, propertyChanged:OnCommandChanged);

        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

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

        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion

		#region NewDateCommand
        public static readonly BindableProperty NewDateCommandProperty =
            BindableProperty.CreateAttached("NewDateCommand", typeof(ICommand), typeof(DatePickerDateSelected), null, propertyChanged:OnNewDateCommandChanged);

        public static ICommand GetNewDateCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NewDateCommandProperty);
        }

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

        private static void OnNewDateCommandChanged(object o, Xamarin.Forms.DateChangedEventArgs eventArgs)
        {
            var command = GetNewDateCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.NewDate))
                command.Execute(eventArgs.NewDate);
        }
		#endregion

		#region OldDateCommand
        public static readonly BindableProperty OldDateCommandProperty =
            BindableProperty.CreateAttached("OldDateCommand", typeof(ICommand), typeof(DatePickerDateSelected), null, propertyChanged:OnOldDateCommandChanged);

        public static ICommand GetOldDateCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(OldDateCommandProperty);
        }

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

        private static void OnOldDateCommandChanged(object o, Xamarin.Forms.DateChangedEventArgs eventArgs)
        {
            var command = GetOldDateCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.OldDate))
                command.Execute(eventArgs.OldDate);
        }
		#endregion
	}

	public partial class EditorCompleted {

		#region Command
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(EditorCompleted), null, propertyChanged:OnCommandChanged);

        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

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

        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion
	}

	public partial class EditorTextChanged {

		#region Command
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(EditorTextChanged), null, propertyChanged:OnCommandChanged);

        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

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

        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion

		#region NewTextValueCommand
        public static readonly BindableProperty NewTextValueCommandProperty =
            BindableProperty.CreateAttached("NewTextValueCommand", typeof(ICommand), typeof(EditorTextChanged), null, propertyChanged:OnNewTextValueCommandChanged);

        public static ICommand GetNewTextValueCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NewTextValueCommandProperty);
        }

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

        private static void OnNewTextValueCommandChanged(object o, Xamarin.Forms.TextChangedEventArgs eventArgs)
        {
            var command = GetNewTextValueCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.NewTextValue))
                command.Execute(eventArgs.NewTextValue);
        }
		#endregion

		#region OldTextValueCommand
        public static readonly BindableProperty OldTextValueCommandProperty =
            BindableProperty.CreateAttached("OldTextValueCommand", typeof(ICommand), typeof(EditorTextChanged), null, propertyChanged:OnOldTextValueCommandChanged);

        public static ICommand GetOldTextValueCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(OldTextValueCommandProperty);
        }

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

        private static void OnOldTextValueCommandChanged(object o, Xamarin.Forms.TextChangedEventArgs eventArgs)
        {
            var command = GetOldTextValueCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.OldTextValue))
                command.Execute(eventArgs.OldTextValue);
        }
		#endregion
	}

	public partial class ElementChildAdded {

		#region Command
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(ElementChildAdded), null, propertyChanged:OnCommandChanged);

        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

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

        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion

		#region ElementCommand
        public static readonly BindableProperty ElementCommandProperty =
            BindableProperty.CreateAttached("ElementCommand", typeof(ICommand), typeof(ElementChildAdded), null, propertyChanged:OnElementCommandChanged);

        public static ICommand GetElementCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ElementCommandProperty);
        }

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

        private static void OnElementCommandChanged(object o, Xamarin.Forms.ElementEventArgs eventArgs)
        {
            var command = GetElementCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Element))
                command.Execute(eventArgs.Element);
        }
		#endregion
	}

	public partial class ElementChildRemoved {

		#region Command
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(ElementChildRemoved), null, propertyChanged:OnCommandChanged);

        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

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

        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion

		#region ElementCommand
        public static readonly BindableProperty ElementCommandProperty =
            BindableProperty.CreateAttached("ElementCommand", typeof(ICommand), typeof(ElementChildRemoved), null, propertyChanged:OnElementCommandChanged);

        public static ICommand GetElementCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ElementCommandProperty);
        }

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

        private static void OnElementCommandChanged(object o, Xamarin.Forms.ElementEventArgs eventArgs)
        {
            var command = GetElementCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Element))
                command.Execute(eventArgs.Element);
        }
		#endregion
	}

	public partial class ElementDescendantAdded {

		#region Command
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(ElementDescendantAdded), null, propertyChanged:OnCommandChanged);

        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

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

        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion

		#region ElementCommand
        public static readonly BindableProperty ElementCommandProperty =
            BindableProperty.CreateAttached("ElementCommand", typeof(ICommand), typeof(ElementDescendantAdded), null, propertyChanged:OnElementCommandChanged);

        public static ICommand GetElementCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ElementCommandProperty);
        }

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

        private static void OnElementCommandChanged(object o, Xamarin.Forms.ElementEventArgs eventArgs)
        {
            var command = GetElementCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Element))
                command.Execute(eventArgs.Element);
        }
		#endregion
	}

	public partial class ElementDescendantRemoved {

		#region Command
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(ElementDescendantRemoved), null, propertyChanged:OnCommandChanged);

        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

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

        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion

		#region ElementCommand
        public static readonly BindableProperty ElementCommandProperty =
            BindableProperty.CreateAttached("ElementCommand", typeof(ICommand), typeof(ElementDescendantRemoved), null, propertyChanged:OnElementCommandChanged);

        public static ICommand GetElementCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ElementCommandProperty);
        }

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

        private static void OnElementCommandChanged(object o, Xamarin.Forms.ElementEventArgs eventArgs)
        {
            var command = GetElementCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Element))
                command.Execute(eventArgs.Element);
        }
		#endregion
	}

	public partial class ElementPlatformSet {

		#region Command
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(ElementPlatformSet), null, propertyChanged:OnCommandChanged);

        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

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

        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion
	}

	public partial class EntryCompleted {

		#region Command
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(EntryCompleted), null, propertyChanged:OnCommandChanged);

        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

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

        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion
	}

	public partial class EntryTextChanged {

		#region Command
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(EntryTextChanged), null, propertyChanged:OnCommandChanged);

        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

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

        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion

		#region NewTextValueCommand
        public static readonly BindableProperty NewTextValueCommandProperty =
            BindableProperty.CreateAttached("NewTextValueCommand", typeof(ICommand), typeof(EntryTextChanged), null, propertyChanged:OnNewTextValueCommandChanged);

        public static ICommand GetNewTextValueCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NewTextValueCommandProperty);
        }

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

        private static void OnNewTextValueCommandChanged(object o, Xamarin.Forms.TextChangedEventArgs eventArgs)
        {
            var command = GetNewTextValueCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.NewTextValue))
                command.Execute(eventArgs.NewTextValue);
        }
		#endregion

		#region OldTextValueCommand
        public static readonly BindableProperty OldTextValueCommandProperty =
            BindableProperty.CreateAttached("OldTextValueCommand", typeof(ICommand), typeof(EntryTextChanged), null, propertyChanged:OnOldTextValueCommandChanged);

        public static ICommand GetOldTextValueCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(OldTextValueCommandProperty);
        }

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

        private static void OnOldTextValueCommandChanged(object o, Xamarin.Forms.TextChangedEventArgs eventArgs)
        {
            var command = GetOldTextValueCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.OldTextValue))
                command.Execute(eventArgs.OldTextValue);
        }
		#endregion
	}

	public partial class EntryCellCompleted {

		#region Command
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(EntryCellCompleted), null, propertyChanged:OnCommandChanged);

        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

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

        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion
	}

	public partial class LayoutLayoutChanged {

		#region Command
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(LayoutLayoutChanged), null, propertyChanged:OnCommandChanged);

        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

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

        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion
	}

	public partial class ListViewItemAppearing {

		#region Command
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(ListViewItemAppearing), null, propertyChanged:OnCommandChanged);

        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

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

        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion

		#region ItemCommand
        public static readonly BindableProperty ItemCommandProperty =
            BindableProperty.CreateAttached("ItemCommand", typeof(ICommand), typeof(ListViewItemAppearing), null, propertyChanged:OnItemCommandChanged);

        public static ICommand GetItemCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ItemCommandProperty);
        }

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

        private static void OnItemCommandChanged(object o, Xamarin.Forms.ItemVisibilityEventArgs eventArgs)
        {
            var command = GetItemCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Item))
                command.Execute(eventArgs.Item);
        }
		#endregion
	}

	public partial class ListViewItemDisappearing {

		#region Command
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(ListViewItemDisappearing), null, propertyChanged:OnCommandChanged);

        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

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

        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion

		#region ItemCommand
        public static readonly BindableProperty ItemCommandProperty =
            BindableProperty.CreateAttached("ItemCommand", typeof(ICommand), typeof(ListViewItemDisappearing), null, propertyChanged:OnItemCommandChanged);

        public static ICommand GetItemCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ItemCommandProperty);
        }

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

        private static void OnItemCommandChanged(object o, Xamarin.Forms.ItemVisibilityEventArgs eventArgs)
        {
            var command = GetItemCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Item))
                command.Execute(eventArgs.Item);
        }
		#endregion
	}

	public partial class ListViewItemSelected {

		#region Command
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(ListViewItemSelected), null, propertyChanged:OnCommandChanged);

        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

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

        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion

		#region SelectedItemCommand
        public static readonly BindableProperty SelectedItemCommandProperty =
            BindableProperty.CreateAttached("SelectedItemCommand", typeof(ICommand), typeof(ListViewItemSelected), null, propertyChanged:OnSelectedItemCommandChanged);

        public static ICommand GetSelectedItemCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(SelectedItemCommandProperty);
        }

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

        private static void OnSelectedItemCommandChanged(object o, Xamarin.Forms.SelectedItemChangedEventArgs eventArgs)
        {
            var command = GetSelectedItemCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.SelectedItem))
                command.Execute(eventArgs.SelectedItem);
        }
		#endregion
	}

	public partial class ListViewItemTapped {

		#region Command
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(ListViewItemTapped), null, propertyChanged:OnCommandChanged);

        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

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

        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion

		#region GroupCommand
        public static readonly BindableProperty GroupCommandProperty =
            BindableProperty.CreateAttached("GroupCommand", typeof(ICommand), typeof(ListViewItemTapped), null, propertyChanged:OnGroupCommandChanged);

        public static ICommand GetGroupCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(GroupCommandProperty);
        }

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

        private static void OnGroupCommandChanged(object o, Xamarin.Forms.ItemTappedEventArgs eventArgs)
        {
            var command = GetGroupCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Group))
                command.Execute(eventArgs.Group);
        }
		#endregion

		#region ItemCommand
        public static readonly BindableProperty ItemCommandProperty =
            BindableProperty.CreateAttached("ItemCommand", typeof(ICommand), typeof(ListViewItemTapped), null, propertyChanged:OnItemCommandChanged);

        public static ICommand GetItemCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ItemCommandProperty);
        }

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

        private static void OnItemCommandChanged(object o, Xamarin.Forms.ItemTappedEventArgs eventArgs)
        {
            var command = GetItemCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Item))
                command.Execute(eventArgs.Item);
        }
		#endregion
	}

	public partial class ListViewRefreshing {

		#region Command
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(ListViewRefreshing), null, propertyChanged:OnCommandChanged);

        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

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

        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion
	}

	public partial class ListViewScrollToRequested {

		#region Command
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(ListViewScrollToRequested), null, propertyChanged:OnCommandChanged);

        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

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

        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion

		#region ElementCommand
        public static readonly BindableProperty ElementCommandProperty =
            BindableProperty.CreateAttached("ElementCommand", typeof(ICommand), typeof(ListViewScrollToRequested), null, propertyChanged:OnElementCommandChanged);

        public static ICommand GetElementCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ElementCommandProperty);
        }

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

        private static void OnElementCommandChanged(object o, Xamarin.Forms.ScrollToRequestedEventArgs eventArgs)
        {
            var command = GetElementCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Element))
                command.Execute(eventArgs.Element);
        }
		#endregion

		#region ModeCommand
        public static readonly BindableProperty ModeCommandProperty =
            BindableProperty.CreateAttached("ModeCommand", typeof(ICommand), typeof(ListViewScrollToRequested), null, propertyChanged:OnModeCommandChanged);

        public static ICommand GetModeCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ModeCommandProperty);
        }

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

        private static void OnModeCommandChanged(object o, Xamarin.Forms.ScrollToRequestedEventArgs eventArgs)
        {
            var command = GetModeCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Mode))
                command.Execute(eventArgs.Mode);
        }
		#endregion

		#region PositionCommand
        public static readonly BindableProperty PositionCommandProperty =
            BindableProperty.CreateAttached("PositionCommand", typeof(ICommand), typeof(ListViewScrollToRequested), null, propertyChanged:OnPositionCommandChanged);

        public static ICommand GetPositionCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(PositionCommandProperty);
        }

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

        private static void OnPositionCommandChanged(object o, Xamarin.Forms.ScrollToRequestedEventArgs eventArgs)
        {
            var command = GetPositionCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Position))
                command.Execute(eventArgs.Position);
        }
		#endregion

		#region ScrollXCommand
        public static readonly BindableProperty ScrollXCommandProperty =
            BindableProperty.CreateAttached("ScrollXCommand", typeof(ICommand), typeof(ListViewScrollToRequested), null, propertyChanged:OnScrollXCommandChanged);

        public static ICommand GetScrollXCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ScrollXCommandProperty);
        }

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

        private static void OnScrollXCommandChanged(object o, Xamarin.Forms.ScrollToRequestedEventArgs eventArgs)
        {
            var command = GetScrollXCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.ScrollX))
                command.Execute(eventArgs.ScrollX);
        }
		#endregion

		#region ScrollYCommand
        public static readonly BindableProperty ScrollYCommandProperty =
            BindableProperty.CreateAttached("ScrollYCommand", typeof(ICommand), typeof(ListViewScrollToRequested), null, propertyChanged:OnScrollYCommandChanged);

        public static ICommand GetScrollYCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ScrollYCommandProperty);
        }

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

        private static void OnScrollYCommandChanged(object o, Xamarin.Forms.ScrollToRequestedEventArgs eventArgs)
        {
            var command = GetScrollYCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.ScrollY))
                command.Execute(eventArgs.ScrollY);
        }
		#endregion

		#region ShouldAnimateCommand
        public static readonly BindableProperty ShouldAnimateCommandProperty =
            BindableProperty.CreateAttached("ShouldAnimateCommand", typeof(ICommand), typeof(ListViewScrollToRequested), null, propertyChanged:OnShouldAnimateCommandChanged);

        public static ICommand GetShouldAnimateCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ShouldAnimateCommandProperty);
        }

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

        private static void OnShouldAnimateCommandChanged(object o, Xamarin.Forms.ScrollToRequestedEventArgs eventArgs)
        {
            var command = GetShouldAnimateCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.ShouldAnimate))
                command.Execute(eventArgs.ShouldAnimate);
        }
		#endregion
	}

	public partial class MasterDetailPageBackButtonPressed {

		#region Command
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(MasterDetailPageBackButtonPressed), null, propertyChanged:OnCommandChanged);

        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

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

        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion

		#region HandledCommand
        public static readonly BindableProperty HandledCommandProperty =
            BindableProperty.CreateAttached("HandledCommand", typeof(ICommand), typeof(MasterDetailPageBackButtonPressed), null, propertyChanged:OnHandledCommandChanged);

        public static ICommand GetHandledCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(HandledCommandProperty);
        }

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

        private static void OnHandledCommandChanged(object o, Xamarin.Forms.BackButtonPressedEventArgs eventArgs)
        {
            var command = GetHandledCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Handled))
                command.Execute(eventArgs.Handled);
        }
		#endregion
	}

	public partial class MasterDetailPageIsPresentedChanged {

		#region Command
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(MasterDetailPageIsPresentedChanged), null, propertyChanged:OnCommandChanged);

        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

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

        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion
	}

	public partial class MenuItemClicked {

		#region Command
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(MenuItemClicked), null, propertyChanged:OnCommandChanged);

        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

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

        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion
	}

	public partial class NavigationPageInsertPageBeforeRequested {

		#region Command
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(NavigationPageInsertPageBeforeRequested), null, propertyChanged:OnCommandChanged);

        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

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

        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion

		#region AnimatedCommand
        public static readonly BindableProperty AnimatedCommandProperty =
            BindableProperty.CreateAttached("AnimatedCommand", typeof(ICommand), typeof(NavigationPageInsertPageBeforeRequested), null, propertyChanged:OnAnimatedCommandChanged);

        public static ICommand GetAnimatedCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(AnimatedCommandProperty);
        }

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

        private static void OnAnimatedCommandChanged(object o, Xamarin.Forms.Internals.NavigationRequestedEventArgs eventArgs)
        {
            var command = GetAnimatedCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Animated))
                command.Execute(eventArgs.Animated);
        }
		#endregion

		#region BeforePageCommand
        public static readonly BindableProperty BeforePageCommandProperty =
            BindableProperty.CreateAttached("BeforePageCommand", typeof(ICommand), typeof(NavigationPageInsertPageBeforeRequested), null, propertyChanged:OnBeforePageCommandChanged);

        public static ICommand GetBeforePageCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(BeforePageCommandProperty);
        }

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

        private static void OnBeforePageCommandChanged(object o, Xamarin.Forms.Internals.NavigationRequestedEventArgs eventArgs)
        {
            var command = GetBeforePageCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.BeforePage))
                command.Execute(eventArgs.BeforePage);
        }
		#endregion

		#region RealizeCommand
        public static readonly BindableProperty RealizeCommandProperty =
            BindableProperty.CreateAttached("RealizeCommand", typeof(ICommand), typeof(NavigationPageInsertPageBeforeRequested), null, propertyChanged:OnRealizeCommandChanged);

        public static ICommand GetRealizeCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(RealizeCommandProperty);
        }

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

        private static void OnRealizeCommandChanged(object o, Xamarin.Forms.Internals.NavigationRequestedEventArgs eventArgs)
        {
            var command = GetRealizeCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Realize))
                command.Execute(eventArgs.Realize);
        }
		#endregion

		#region TaskCommand
        public static readonly BindableProperty TaskCommandProperty =
            BindableProperty.CreateAttached("TaskCommand", typeof(ICommand), typeof(NavigationPageInsertPageBeforeRequested), null, propertyChanged:OnTaskCommandChanged);

        public static ICommand GetTaskCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(TaskCommandProperty);
        }

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

        private static void OnTaskCommandChanged(object o, Xamarin.Forms.Internals.NavigationRequestedEventArgs eventArgs)
        {
            var command = GetTaskCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Task))
                command.Execute(eventArgs.Task);
        }
		#endregion

		#region PageCommand
        public static readonly BindableProperty PageCommandProperty =
            BindableProperty.CreateAttached("PageCommand", typeof(ICommand), typeof(NavigationPageInsertPageBeforeRequested), null, propertyChanged:OnPageCommandChanged);

        public static ICommand GetPageCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(PageCommandProperty);
        }

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

        private static void OnPageCommandChanged(object o, Xamarin.Forms.Internals.NavigationRequestedEventArgs eventArgs)
        {
            var command = GetPageCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Page))
                command.Execute(eventArgs.Page);
        }
		#endregion
	}

	public partial class NavigationPagePopped {

		#region Command
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(NavigationPagePopped), null, propertyChanged:OnCommandChanged);

        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

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

        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion

		#region PageCommand
        public static readonly BindableProperty PageCommandProperty =
            BindableProperty.CreateAttached("PageCommand", typeof(ICommand), typeof(NavigationPagePopped), null, propertyChanged:OnPageCommandChanged);

        public static ICommand GetPageCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(PageCommandProperty);
        }

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

        private static void OnPageCommandChanged(object o, Xamarin.Forms.NavigationEventArgs eventArgs)
        {
            var command = GetPageCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Page))
                command.Execute(eventArgs.Page);
        }
		#endregion
	}

	public partial class NavigationPagePoppedToRoot {

		#region Command
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(NavigationPagePoppedToRoot), null, propertyChanged:OnCommandChanged);

        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

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

        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion

		#region PageCommand
        public static readonly BindableProperty PageCommandProperty =
            BindableProperty.CreateAttached("PageCommand", typeof(ICommand), typeof(NavigationPagePoppedToRoot), null, propertyChanged:OnPageCommandChanged);

        public static ICommand GetPageCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(PageCommandProperty);
        }

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

        private static void OnPageCommandChanged(object o, Xamarin.Forms.NavigationEventArgs eventArgs)
        {
            var command = GetPageCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Page))
                command.Execute(eventArgs.Page);
        }
		#endregion
	}

	public partial class NavigationPagePopRequested {

		#region Command
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(NavigationPagePopRequested), null, propertyChanged:OnCommandChanged);

        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

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

        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion

		#region AnimatedCommand
        public static readonly BindableProperty AnimatedCommandProperty =
            BindableProperty.CreateAttached("AnimatedCommand", typeof(ICommand), typeof(NavigationPagePopRequested), null, propertyChanged:OnAnimatedCommandChanged);

        public static ICommand GetAnimatedCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(AnimatedCommandProperty);
        }

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

        private static void OnAnimatedCommandChanged(object o, Xamarin.Forms.Internals.NavigationRequestedEventArgs eventArgs)
        {
            var command = GetAnimatedCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Animated))
                command.Execute(eventArgs.Animated);
        }
		#endregion

		#region BeforePageCommand
        public static readonly BindableProperty BeforePageCommandProperty =
            BindableProperty.CreateAttached("BeforePageCommand", typeof(ICommand), typeof(NavigationPagePopRequested), null, propertyChanged:OnBeforePageCommandChanged);

        public static ICommand GetBeforePageCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(BeforePageCommandProperty);
        }

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

        private static void OnBeforePageCommandChanged(object o, Xamarin.Forms.Internals.NavigationRequestedEventArgs eventArgs)
        {
            var command = GetBeforePageCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.BeforePage))
                command.Execute(eventArgs.BeforePage);
        }
		#endregion

		#region RealizeCommand
        public static readonly BindableProperty RealizeCommandProperty =
            BindableProperty.CreateAttached("RealizeCommand", typeof(ICommand), typeof(NavigationPagePopRequested), null, propertyChanged:OnRealizeCommandChanged);

        public static ICommand GetRealizeCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(RealizeCommandProperty);
        }

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

        private static void OnRealizeCommandChanged(object o, Xamarin.Forms.Internals.NavigationRequestedEventArgs eventArgs)
        {
            var command = GetRealizeCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Realize))
                command.Execute(eventArgs.Realize);
        }
		#endregion

		#region TaskCommand
        public static readonly BindableProperty TaskCommandProperty =
            BindableProperty.CreateAttached("TaskCommand", typeof(ICommand), typeof(NavigationPagePopRequested), null, propertyChanged:OnTaskCommandChanged);

        public static ICommand GetTaskCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(TaskCommandProperty);
        }

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

        private static void OnTaskCommandChanged(object o, Xamarin.Forms.Internals.NavigationRequestedEventArgs eventArgs)
        {
            var command = GetTaskCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Task))
                command.Execute(eventArgs.Task);
        }
		#endregion

		#region PageCommand
        public static readonly BindableProperty PageCommandProperty =
            BindableProperty.CreateAttached("PageCommand", typeof(ICommand), typeof(NavigationPagePopRequested), null, propertyChanged:OnPageCommandChanged);

        public static ICommand GetPageCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(PageCommandProperty);
        }

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

        private static void OnPageCommandChanged(object o, Xamarin.Forms.Internals.NavigationRequestedEventArgs eventArgs)
        {
            var command = GetPageCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Page))
                command.Execute(eventArgs.Page);
        }
		#endregion
	}

	public partial class NavigationPagePopToRootRequested {

		#region Command
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(NavigationPagePopToRootRequested), null, propertyChanged:OnCommandChanged);

        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

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

        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion

		#region AnimatedCommand
        public static readonly BindableProperty AnimatedCommandProperty =
            BindableProperty.CreateAttached("AnimatedCommand", typeof(ICommand), typeof(NavigationPagePopToRootRequested), null, propertyChanged:OnAnimatedCommandChanged);

        public static ICommand GetAnimatedCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(AnimatedCommandProperty);
        }

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

        private static void OnAnimatedCommandChanged(object o, Xamarin.Forms.Internals.NavigationRequestedEventArgs eventArgs)
        {
            var command = GetAnimatedCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Animated))
                command.Execute(eventArgs.Animated);
        }
		#endregion

		#region BeforePageCommand
        public static readonly BindableProperty BeforePageCommandProperty =
            BindableProperty.CreateAttached("BeforePageCommand", typeof(ICommand), typeof(NavigationPagePopToRootRequested), null, propertyChanged:OnBeforePageCommandChanged);

        public static ICommand GetBeforePageCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(BeforePageCommandProperty);
        }

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

        private static void OnBeforePageCommandChanged(object o, Xamarin.Forms.Internals.NavigationRequestedEventArgs eventArgs)
        {
            var command = GetBeforePageCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.BeforePage))
                command.Execute(eventArgs.BeforePage);
        }
		#endregion

		#region RealizeCommand
        public static readonly BindableProperty RealizeCommandProperty =
            BindableProperty.CreateAttached("RealizeCommand", typeof(ICommand), typeof(NavigationPagePopToRootRequested), null, propertyChanged:OnRealizeCommandChanged);

        public static ICommand GetRealizeCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(RealizeCommandProperty);
        }

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

        private static void OnRealizeCommandChanged(object o, Xamarin.Forms.Internals.NavigationRequestedEventArgs eventArgs)
        {
            var command = GetRealizeCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Realize))
                command.Execute(eventArgs.Realize);
        }
		#endregion

		#region TaskCommand
        public static readonly BindableProperty TaskCommandProperty =
            BindableProperty.CreateAttached("TaskCommand", typeof(ICommand), typeof(NavigationPagePopToRootRequested), null, propertyChanged:OnTaskCommandChanged);

        public static ICommand GetTaskCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(TaskCommandProperty);
        }

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

        private static void OnTaskCommandChanged(object o, Xamarin.Forms.Internals.NavigationRequestedEventArgs eventArgs)
        {
            var command = GetTaskCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Task))
                command.Execute(eventArgs.Task);
        }
		#endregion

		#region PageCommand
        public static readonly BindableProperty PageCommandProperty =
            BindableProperty.CreateAttached("PageCommand", typeof(ICommand), typeof(NavigationPagePopToRootRequested), null, propertyChanged:OnPageCommandChanged);

        public static ICommand GetPageCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(PageCommandProperty);
        }

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

        private static void OnPageCommandChanged(object o, Xamarin.Forms.Internals.NavigationRequestedEventArgs eventArgs)
        {
            var command = GetPageCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Page))
                command.Execute(eventArgs.Page);
        }
		#endregion
	}

	public partial class NavigationPagePushed {

		#region Command
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(NavigationPagePushed), null, propertyChanged:OnCommandChanged);

        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

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

        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion

		#region PageCommand
        public static readonly BindableProperty PageCommandProperty =
            BindableProperty.CreateAttached("PageCommand", typeof(ICommand), typeof(NavigationPagePushed), null, propertyChanged:OnPageCommandChanged);

        public static ICommand GetPageCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(PageCommandProperty);
        }

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

        private static void OnPageCommandChanged(object o, Xamarin.Forms.NavigationEventArgs eventArgs)
        {
            var command = GetPageCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Page))
                command.Execute(eventArgs.Page);
        }
		#endregion
	}

	public partial class NavigationPagePushRequested {

		#region Command
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(NavigationPagePushRequested), null, propertyChanged:OnCommandChanged);

        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

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

        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion

		#region AnimatedCommand
        public static readonly BindableProperty AnimatedCommandProperty =
            BindableProperty.CreateAttached("AnimatedCommand", typeof(ICommand), typeof(NavigationPagePushRequested), null, propertyChanged:OnAnimatedCommandChanged);

        public static ICommand GetAnimatedCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(AnimatedCommandProperty);
        }

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

        private static void OnAnimatedCommandChanged(object o, Xamarin.Forms.Internals.NavigationRequestedEventArgs eventArgs)
        {
            var command = GetAnimatedCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Animated))
                command.Execute(eventArgs.Animated);
        }
		#endregion

		#region BeforePageCommand
        public static readonly BindableProperty BeforePageCommandProperty =
            BindableProperty.CreateAttached("BeforePageCommand", typeof(ICommand), typeof(NavigationPagePushRequested), null, propertyChanged:OnBeforePageCommandChanged);

        public static ICommand GetBeforePageCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(BeforePageCommandProperty);
        }

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

        private static void OnBeforePageCommandChanged(object o, Xamarin.Forms.Internals.NavigationRequestedEventArgs eventArgs)
        {
            var command = GetBeforePageCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.BeforePage))
                command.Execute(eventArgs.BeforePage);
        }
		#endregion

		#region RealizeCommand
        public static readonly BindableProperty RealizeCommandProperty =
            BindableProperty.CreateAttached("RealizeCommand", typeof(ICommand), typeof(NavigationPagePushRequested), null, propertyChanged:OnRealizeCommandChanged);

        public static ICommand GetRealizeCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(RealizeCommandProperty);
        }

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

        private static void OnRealizeCommandChanged(object o, Xamarin.Forms.Internals.NavigationRequestedEventArgs eventArgs)
        {
            var command = GetRealizeCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Realize))
                command.Execute(eventArgs.Realize);
        }
		#endregion

		#region TaskCommand
        public static readonly BindableProperty TaskCommandProperty =
            BindableProperty.CreateAttached("TaskCommand", typeof(ICommand), typeof(NavigationPagePushRequested), null, propertyChanged:OnTaskCommandChanged);

        public static ICommand GetTaskCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(TaskCommandProperty);
        }

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

        private static void OnTaskCommandChanged(object o, Xamarin.Forms.Internals.NavigationRequestedEventArgs eventArgs)
        {
            var command = GetTaskCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Task))
                command.Execute(eventArgs.Task);
        }
		#endregion

		#region PageCommand
        public static readonly BindableProperty PageCommandProperty =
            BindableProperty.CreateAttached("PageCommand", typeof(ICommand), typeof(NavigationPagePushRequested), null, propertyChanged:OnPageCommandChanged);

        public static ICommand GetPageCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(PageCommandProperty);
        }

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

        private static void OnPageCommandChanged(object o, Xamarin.Forms.Internals.NavigationRequestedEventArgs eventArgs)
        {
            var command = GetPageCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Page))
                command.Execute(eventArgs.Page);
        }
		#endregion
	}

	public partial class NavigationPageRemovePageRequested {

		#region Command
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(NavigationPageRemovePageRequested), null, propertyChanged:OnCommandChanged);

        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

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

        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion

		#region AnimatedCommand
        public static readonly BindableProperty AnimatedCommandProperty =
            BindableProperty.CreateAttached("AnimatedCommand", typeof(ICommand), typeof(NavigationPageRemovePageRequested), null, propertyChanged:OnAnimatedCommandChanged);

        public static ICommand GetAnimatedCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(AnimatedCommandProperty);
        }

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

        private static void OnAnimatedCommandChanged(object o, Xamarin.Forms.Internals.NavigationRequestedEventArgs eventArgs)
        {
            var command = GetAnimatedCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Animated))
                command.Execute(eventArgs.Animated);
        }
		#endregion

		#region BeforePageCommand
        public static readonly BindableProperty BeforePageCommandProperty =
            BindableProperty.CreateAttached("BeforePageCommand", typeof(ICommand), typeof(NavigationPageRemovePageRequested), null, propertyChanged:OnBeforePageCommandChanged);

        public static ICommand GetBeforePageCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(BeforePageCommandProperty);
        }

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

        private static void OnBeforePageCommandChanged(object o, Xamarin.Forms.Internals.NavigationRequestedEventArgs eventArgs)
        {
            var command = GetBeforePageCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.BeforePage))
                command.Execute(eventArgs.BeforePage);
        }
		#endregion

		#region RealizeCommand
        public static readonly BindableProperty RealizeCommandProperty =
            BindableProperty.CreateAttached("RealizeCommand", typeof(ICommand), typeof(NavigationPageRemovePageRequested), null, propertyChanged:OnRealizeCommandChanged);

        public static ICommand GetRealizeCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(RealizeCommandProperty);
        }

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

        private static void OnRealizeCommandChanged(object o, Xamarin.Forms.Internals.NavigationRequestedEventArgs eventArgs)
        {
            var command = GetRealizeCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Realize))
                command.Execute(eventArgs.Realize);
        }
		#endregion

		#region TaskCommand
        public static readonly BindableProperty TaskCommandProperty =
            BindableProperty.CreateAttached("TaskCommand", typeof(ICommand), typeof(NavigationPageRemovePageRequested), null, propertyChanged:OnTaskCommandChanged);

        public static ICommand GetTaskCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(TaskCommandProperty);
        }

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

        private static void OnTaskCommandChanged(object o, Xamarin.Forms.Internals.NavigationRequestedEventArgs eventArgs)
        {
            var command = GetTaskCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Task))
                command.Execute(eventArgs.Task);
        }
		#endregion

		#region PageCommand
        public static readonly BindableProperty PageCommandProperty =
            BindableProperty.CreateAttached("PageCommand", typeof(ICommand), typeof(NavigationPageRemovePageRequested), null, propertyChanged:OnPageCommandChanged);

        public static ICommand GetPageCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(PageCommandProperty);
        }

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

        private static void OnPageCommandChanged(object o, Xamarin.Forms.Internals.NavigationRequestedEventArgs eventArgs)
        {
            var command = GetPageCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Page))
                command.Execute(eventArgs.Page);
        }
		#endregion
	}

	public partial class OpenGLViewDisplayRequested {

		#region Command
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(OpenGLViewDisplayRequested), null, propertyChanged:OnCommandChanged);

        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

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

        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion
	}

	public partial class PageAppearing {

		#region Command
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(PageAppearing), null, propertyChanged:OnCommandChanged);

        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

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

        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion
	}

	public partial class PageDisappearing {

		#region Command
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(PageDisappearing), null, propertyChanged:OnCommandChanged);

        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

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

        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion
	}

	public partial class PageLayoutChanged {

		#region Command
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(PageLayoutChanged), null, propertyChanged:OnCommandChanged);

        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

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

        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion
	}

	public partial class PanGestureRecognizerPanUpdated {

		#region Command
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(PanGestureRecognizerPanUpdated), null, propertyChanged:OnCommandChanged);

        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

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

        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion

		#region GestureIdCommand
        public static readonly BindableProperty GestureIdCommandProperty =
            BindableProperty.CreateAttached("GestureIdCommand", typeof(ICommand), typeof(PanGestureRecognizerPanUpdated), null, propertyChanged:OnGestureIdCommandChanged);

        public static ICommand GetGestureIdCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(GestureIdCommandProperty);
        }

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

        private static void OnGestureIdCommandChanged(object o, Xamarin.Forms.PanUpdatedEventArgs eventArgs)
        {
            var command = GetGestureIdCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.GestureId))
                command.Execute(eventArgs.GestureId);
        }
		#endregion

		#region StatusTypeCommand
        public static readonly BindableProperty StatusTypeCommandProperty =
            BindableProperty.CreateAttached("StatusTypeCommand", typeof(ICommand), typeof(PanGestureRecognizerPanUpdated), null, propertyChanged:OnStatusTypeCommandChanged);

        public static ICommand GetStatusTypeCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(StatusTypeCommandProperty);
        }

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

        private static void OnStatusTypeCommandChanged(object o, Xamarin.Forms.PanUpdatedEventArgs eventArgs)
        {
            var command = GetStatusTypeCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.StatusType))
                command.Execute(eventArgs.StatusType);
        }
		#endregion

		#region TotalXCommand
        public static readonly BindableProperty TotalXCommandProperty =
            BindableProperty.CreateAttached("TotalXCommand", typeof(ICommand), typeof(PanGestureRecognizerPanUpdated), null, propertyChanged:OnTotalXCommandChanged);

        public static ICommand GetTotalXCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(TotalXCommandProperty);
        }

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

        private static void OnTotalXCommandChanged(object o, Xamarin.Forms.PanUpdatedEventArgs eventArgs)
        {
            var command = GetTotalXCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.TotalX))
                command.Execute(eventArgs.TotalX);
        }
		#endregion

		#region TotalYCommand
        public static readonly BindableProperty TotalYCommandProperty =
            BindableProperty.CreateAttached("TotalYCommand", typeof(ICommand), typeof(PanGestureRecognizerPanUpdated), null, propertyChanged:OnTotalYCommandChanged);

        public static ICommand GetTotalYCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(TotalYCommandProperty);
        }

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

        private static void OnTotalYCommandChanged(object o, Xamarin.Forms.PanUpdatedEventArgs eventArgs)
        {
            var command = GetTotalYCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.TotalY))
                command.Execute(eventArgs.TotalY);
        }
		#endregion
	}

	public partial class PickerSelectedIndexChanged {

		#region Command
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(PickerSelectedIndexChanged), null, propertyChanged:OnCommandChanged);

        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

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

        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion
	}

	public partial class PinchGestureRecognizerPinchUpdated {

		#region Command
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(PinchGestureRecognizerPinchUpdated), null, propertyChanged:OnCommandChanged);

        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

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

        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion

		#region ScaleCommand
        public static readonly BindableProperty ScaleCommandProperty =
            BindableProperty.CreateAttached("ScaleCommand", typeof(ICommand), typeof(PinchGestureRecognizerPinchUpdated), null, propertyChanged:OnScaleCommandChanged);

        public static ICommand GetScaleCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ScaleCommandProperty);
        }

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

        private static void OnScaleCommandChanged(object o, Xamarin.Forms.PinchGestureUpdatedEventArgs eventArgs)
        {
            var command = GetScaleCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Scale))
                command.Execute(eventArgs.Scale);
        }
		#endregion

		#region ScaleOriginCommand
        public static readonly BindableProperty ScaleOriginCommandProperty =
            BindableProperty.CreateAttached("ScaleOriginCommand", typeof(ICommand), typeof(PinchGestureRecognizerPinchUpdated), null, propertyChanged:OnScaleOriginCommandChanged);

        public static ICommand GetScaleOriginCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ScaleOriginCommandProperty);
        }

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

        private static void OnScaleOriginCommandChanged(object o, Xamarin.Forms.PinchGestureUpdatedEventArgs eventArgs)
        {
            var command = GetScaleOriginCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.ScaleOrigin))
                command.Execute(eventArgs.ScaleOrigin);
        }
		#endregion

		#region StatusCommand
        public static readonly BindableProperty StatusCommandProperty =
            BindableProperty.CreateAttached("StatusCommand", typeof(ICommand), typeof(PinchGestureRecognizerPinchUpdated), null, propertyChanged:OnStatusCommandChanged);

        public static ICommand GetStatusCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(StatusCommandProperty);
        }

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

        private static void OnStatusCommandChanged(object o, Xamarin.Forms.PinchGestureUpdatedEventArgs eventArgs)
        {
            var command = GetStatusCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Status))
                command.Execute(eventArgs.Status);
        }
		#endregion
	}

	public partial class RowDefinitionSizeChanged {

		#region Command
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(RowDefinitionSizeChanged), null, propertyChanged:OnCommandChanged);

        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

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

        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion
	}

	public partial class ScrollViewScrolled {

		#region Command
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(ScrollViewScrolled), null, propertyChanged:OnCommandChanged);

        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

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

        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion

		#region ScrollXCommand
        public static readonly BindableProperty ScrollXCommandProperty =
            BindableProperty.CreateAttached("ScrollXCommand", typeof(ICommand), typeof(ScrollViewScrolled), null, propertyChanged:OnScrollXCommandChanged);

        public static ICommand GetScrollXCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ScrollXCommandProperty);
        }

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

        private static void OnScrollXCommandChanged(object o, Xamarin.Forms.ScrolledEventArgs eventArgs)
        {
            var command = GetScrollXCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.ScrollX))
                command.Execute(eventArgs.ScrollX);
        }
		#endregion

		#region ScrollYCommand
        public static readonly BindableProperty ScrollYCommandProperty =
            BindableProperty.CreateAttached("ScrollYCommand", typeof(ICommand), typeof(ScrollViewScrolled), null, propertyChanged:OnScrollYCommandChanged);

        public static ICommand GetScrollYCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ScrollYCommandProperty);
        }

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

        private static void OnScrollYCommandChanged(object o, Xamarin.Forms.ScrolledEventArgs eventArgs)
        {
            var command = GetScrollYCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.ScrollY))
                command.Execute(eventArgs.ScrollY);
        }
		#endregion
	}

	public partial class ScrollViewScrollToRequested {

		#region Command
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(ScrollViewScrollToRequested), null, propertyChanged:OnCommandChanged);

        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

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

        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion

		#region ElementCommand
        public static readonly BindableProperty ElementCommandProperty =
            BindableProperty.CreateAttached("ElementCommand", typeof(ICommand), typeof(ScrollViewScrollToRequested), null, propertyChanged:OnElementCommandChanged);

        public static ICommand GetElementCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ElementCommandProperty);
        }

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

        private static void OnElementCommandChanged(object o, Xamarin.Forms.ScrollToRequestedEventArgs eventArgs)
        {
            var command = GetElementCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Element))
                command.Execute(eventArgs.Element);
        }
		#endregion

		#region ModeCommand
        public static readonly BindableProperty ModeCommandProperty =
            BindableProperty.CreateAttached("ModeCommand", typeof(ICommand), typeof(ScrollViewScrollToRequested), null, propertyChanged:OnModeCommandChanged);

        public static ICommand GetModeCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ModeCommandProperty);
        }

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

        private static void OnModeCommandChanged(object o, Xamarin.Forms.ScrollToRequestedEventArgs eventArgs)
        {
            var command = GetModeCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Mode))
                command.Execute(eventArgs.Mode);
        }
		#endregion

		#region PositionCommand
        public static readonly BindableProperty PositionCommandProperty =
            BindableProperty.CreateAttached("PositionCommand", typeof(ICommand), typeof(ScrollViewScrollToRequested), null, propertyChanged:OnPositionCommandChanged);

        public static ICommand GetPositionCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(PositionCommandProperty);
        }

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

        private static void OnPositionCommandChanged(object o, Xamarin.Forms.ScrollToRequestedEventArgs eventArgs)
        {
            var command = GetPositionCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Position))
                command.Execute(eventArgs.Position);
        }
		#endregion

		#region ScrollXCommand
        public static readonly BindableProperty ScrollXCommandProperty =
            BindableProperty.CreateAttached("ScrollXCommand", typeof(ICommand), typeof(ScrollViewScrollToRequested), null, propertyChanged:OnScrollXCommandChanged);

        public static ICommand GetScrollXCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ScrollXCommandProperty);
        }

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

        private static void OnScrollXCommandChanged(object o, Xamarin.Forms.ScrollToRequestedEventArgs eventArgs)
        {
            var command = GetScrollXCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.ScrollX))
                command.Execute(eventArgs.ScrollX);
        }
		#endregion

		#region ScrollYCommand
        public static readonly BindableProperty ScrollYCommandProperty =
            BindableProperty.CreateAttached("ScrollYCommand", typeof(ICommand), typeof(ScrollViewScrollToRequested), null, propertyChanged:OnScrollYCommandChanged);

        public static ICommand GetScrollYCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ScrollYCommandProperty);
        }

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

        private static void OnScrollYCommandChanged(object o, Xamarin.Forms.ScrollToRequestedEventArgs eventArgs)
        {
            var command = GetScrollYCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.ScrollY))
                command.Execute(eventArgs.ScrollY);
        }
		#endregion

		#region ShouldAnimateCommand
        public static readonly BindableProperty ShouldAnimateCommandProperty =
            BindableProperty.CreateAttached("ShouldAnimateCommand", typeof(ICommand), typeof(ScrollViewScrollToRequested), null, propertyChanged:OnShouldAnimateCommandChanged);

        public static ICommand GetShouldAnimateCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ShouldAnimateCommandProperty);
        }

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

        private static void OnShouldAnimateCommandChanged(object o, Xamarin.Forms.ScrollToRequestedEventArgs eventArgs)
        {
            var command = GetShouldAnimateCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.ShouldAnimate))
                command.Execute(eventArgs.ShouldAnimate);
        }
		#endregion
	}

	public partial class SearchBarSearchButtonPressed {

		#region Command
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(SearchBarSearchButtonPressed), null, propertyChanged:OnCommandChanged);

        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

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

        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion
	}

	public partial class SearchBarTextChanged {

		#region Command
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(SearchBarTextChanged), null, propertyChanged:OnCommandChanged);

        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

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

        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion

		#region NewTextValueCommand
        public static readonly BindableProperty NewTextValueCommandProperty =
            BindableProperty.CreateAttached("NewTextValueCommand", typeof(ICommand), typeof(SearchBarTextChanged), null, propertyChanged:OnNewTextValueCommandChanged);

        public static ICommand GetNewTextValueCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NewTextValueCommandProperty);
        }

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

        private static void OnNewTextValueCommandChanged(object o, Xamarin.Forms.TextChangedEventArgs eventArgs)
        {
            var command = GetNewTextValueCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.NewTextValue))
                command.Execute(eventArgs.NewTextValue);
        }
		#endregion

		#region OldTextValueCommand
        public static readonly BindableProperty OldTextValueCommandProperty =
            BindableProperty.CreateAttached("OldTextValueCommand", typeof(ICommand), typeof(SearchBarTextChanged), null, propertyChanged:OnOldTextValueCommandChanged);

        public static ICommand GetOldTextValueCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(OldTextValueCommandProperty);
        }

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

        private static void OnOldTextValueCommandChanged(object o, Xamarin.Forms.TextChangedEventArgs eventArgs)
        {
            var command = GetOldTextValueCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.OldTextValue))
                command.Execute(eventArgs.OldTextValue);
        }
		#endregion
	}

	public partial class SliderValueChanged {

		#region Command
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(SliderValueChanged), null, propertyChanged:OnCommandChanged);

        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

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

        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion

		#region NewValueCommand
        public static readonly BindableProperty NewValueCommandProperty =
            BindableProperty.CreateAttached("NewValueCommand", typeof(ICommand), typeof(SliderValueChanged), null, propertyChanged:OnNewValueCommandChanged);

        public static ICommand GetNewValueCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NewValueCommandProperty);
        }

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

        private static void OnNewValueCommandChanged(object o, Xamarin.Forms.ValueChangedEventArgs eventArgs)
        {
            var command = GetNewValueCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.NewValue))
                command.Execute(eventArgs.NewValue);
        }
		#endregion

		#region OldValueCommand
        public static readonly BindableProperty OldValueCommandProperty =
            BindableProperty.CreateAttached("OldValueCommand", typeof(ICommand), typeof(SliderValueChanged), null, propertyChanged:OnOldValueCommandChanged);

        public static ICommand GetOldValueCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(OldValueCommandProperty);
        }

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

        private static void OnOldValueCommandChanged(object o, Xamarin.Forms.ValueChangedEventArgs eventArgs)
        {
            var command = GetOldValueCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.OldValue))
                command.Execute(eventArgs.OldValue);
        }
		#endregion
	}

	public partial class StepperValueChanged {

		#region Command
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(StepperValueChanged), null, propertyChanged:OnCommandChanged);

        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

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

        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion

		#region NewValueCommand
        public static readonly BindableProperty NewValueCommandProperty =
            BindableProperty.CreateAttached("NewValueCommand", typeof(ICommand), typeof(StepperValueChanged), null, propertyChanged:OnNewValueCommandChanged);

        public static ICommand GetNewValueCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NewValueCommandProperty);
        }

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

        private static void OnNewValueCommandChanged(object o, Xamarin.Forms.ValueChangedEventArgs eventArgs)
        {
            var command = GetNewValueCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.NewValue))
                command.Execute(eventArgs.NewValue);
        }
		#endregion

		#region OldValueCommand
        public static readonly BindableProperty OldValueCommandProperty =
            BindableProperty.CreateAttached("OldValueCommand", typeof(ICommand), typeof(StepperValueChanged), null, propertyChanged:OnOldValueCommandChanged);

        public static ICommand GetOldValueCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(OldValueCommandProperty);
        }

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

        private static void OnOldValueCommandChanged(object o, Xamarin.Forms.ValueChangedEventArgs eventArgs)
        {
            var command = GetOldValueCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.OldValue))
                command.Execute(eventArgs.OldValue);
        }
		#endregion
	}

	public partial class SwitchToggled {

		#region Command
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(SwitchToggled), null, propertyChanged:OnCommandChanged);

        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

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

        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion

		#region ValueCommand
        public static readonly BindableProperty ValueCommandProperty =
            BindableProperty.CreateAttached("ValueCommand", typeof(ICommand), typeof(SwitchToggled), null, propertyChanged:OnValueCommandChanged);

        public static ICommand GetValueCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ValueCommandProperty);
        }

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

        private static void OnValueCommandChanged(object o, Xamarin.Forms.ToggledEventArgs eventArgs)
        {
            var command = GetValueCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Value))
                command.Execute(eventArgs.Value);
        }
		#endregion
	}

	public partial class SwitchCellOnChanged {

		#region Command
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(SwitchCellOnChanged), null, propertyChanged:OnCommandChanged);

        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

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

        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion

		#region ValueCommand
        public static readonly BindableProperty ValueCommandProperty =
            BindableProperty.CreateAttached("ValueCommand", typeof(ICommand), typeof(SwitchCellOnChanged), null, propertyChanged:OnValueCommandChanged);

        public static ICommand GetValueCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ValueCommandProperty);
        }

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

        private static void OnValueCommandChanged(object o, Xamarin.Forms.ToggledEventArgs eventArgs)
        {
            var command = GetValueCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Value))
                command.Execute(eventArgs.Value);
        }
		#endregion
	}

	public partial class TableViewModelChanged {

		#region Command
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(TableViewModelChanged), null, propertyChanged:OnCommandChanged);

        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

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

        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion
	}

	public partial class TapGestureRecognizerTapped {

		#region Command
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(TapGestureRecognizerTapped), null, propertyChanged:OnCommandChanged);

        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

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

        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion
	}

	public partial class VisualElementBatchCommitted {

		#region Command
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(VisualElementBatchCommitted), null, propertyChanged:OnCommandChanged);

        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

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

        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion

		#region DataCommand
        public static readonly BindableProperty DataCommandProperty =
            BindableProperty.CreateAttached("DataCommand", typeof(ICommand), typeof(VisualElementBatchCommitted), null, propertyChanged:OnDataCommandChanged);

        public static ICommand GetDataCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(DataCommandProperty);
        }

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

        private static void OnDataCommandChanged(object o, Xamarin.Forms.Internals.EventArg<Xamarin.Forms.VisualElement> eventArgs)
        {
            var command = GetDataCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Data))
                command.Execute(eventArgs.Data);
        }
		#endregion
	}

	public partial class VisualElementChildrenReordered {

		#region Command
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(VisualElementChildrenReordered), null, propertyChanged:OnCommandChanged);

        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

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

        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion
	}

	public partial class VisualElementFocusChangeRequested {

		#region Command
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(VisualElementFocusChangeRequested), null, propertyChanged:OnCommandChanged);

        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

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

        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion

		#region FocusCommand
        public static readonly BindableProperty FocusCommandProperty =
            BindableProperty.CreateAttached("FocusCommand", typeof(ICommand), typeof(VisualElementFocusChangeRequested), null, propertyChanged:OnFocusCommandChanged);

        public static ICommand GetFocusCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(FocusCommandProperty);
        }

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

        private static void OnFocusCommandChanged(object o, Xamarin.Forms.VisualElement.FocusRequestArgs eventArgs)
        {
            var command = GetFocusCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Focus))
                command.Execute(eventArgs.Focus);
        }
		#endregion

		#region ResultCommand
        public static readonly BindableProperty ResultCommandProperty =
            BindableProperty.CreateAttached("ResultCommand", typeof(ICommand), typeof(VisualElementFocusChangeRequested), null, propertyChanged:OnResultCommandChanged);

        public static ICommand GetResultCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ResultCommandProperty);
        }

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

        private static void OnResultCommandChanged(object o, Xamarin.Forms.VisualElement.FocusRequestArgs eventArgs)
        {
            var command = GetResultCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Result))
                command.Execute(eventArgs.Result);
        }
		#endregion
	}

	public partial class VisualElementFocused {

		#region Command
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(VisualElementFocused), null, propertyChanged:OnCommandChanged);

        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

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

        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion

		#region IsFocusedCommand
        public static readonly BindableProperty IsFocusedCommandProperty =
            BindableProperty.CreateAttached("IsFocusedCommand", typeof(ICommand), typeof(VisualElementFocused), null, propertyChanged:OnIsFocusedCommandChanged);

        public static ICommand GetIsFocusedCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(IsFocusedCommandProperty);
        }

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

        private static void OnIsFocusedCommandChanged(object o, Xamarin.Forms.FocusEventArgs eventArgs)
        {
            var command = GetIsFocusedCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.IsFocused))
                command.Execute(eventArgs.IsFocused);
        }
		#endregion

		#region VisualElementCommand
        public static readonly BindableProperty VisualElementCommandProperty =
            BindableProperty.CreateAttached("VisualElementCommand", typeof(ICommand), typeof(VisualElementFocused), null, propertyChanged:OnVisualElementCommandChanged);

        public static ICommand GetVisualElementCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(VisualElementCommandProperty);
        }

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

        private static void OnVisualElementCommandChanged(object o, Xamarin.Forms.FocusEventArgs eventArgs)
        {
            var command = GetVisualElementCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.VisualElement))
                command.Execute(eventArgs.VisualElement);
        }
		#endregion
	}

	public partial class VisualElementMeasureInvalidated {

		#region Command
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(VisualElementMeasureInvalidated), null, propertyChanged:OnCommandChanged);

        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

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

        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion
	}

	public partial class VisualElementSizeChanged {

		#region Command
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(VisualElementSizeChanged), null, propertyChanged:OnCommandChanged);

        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

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

        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion
	}

	public partial class VisualElementUnfocused {

		#region Command
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(VisualElementUnfocused), null, propertyChanged:OnCommandChanged);

        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

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

        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion

		#region IsFocusedCommand
        public static readonly BindableProperty IsFocusedCommandProperty =
            BindableProperty.CreateAttached("IsFocusedCommand", typeof(ICommand), typeof(VisualElementUnfocused), null, propertyChanged:OnIsFocusedCommandChanged);

        public static ICommand GetIsFocusedCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(IsFocusedCommandProperty);
        }

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

        private static void OnIsFocusedCommandChanged(object o, Xamarin.Forms.FocusEventArgs eventArgs)
        {
            var command = GetIsFocusedCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.IsFocused))
                command.Execute(eventArgs.IsFocused);
        }
		#endregion

		#region VisualElementCommand
        public static readonly BindableProperty VisualElementCommandProperty =
            BindableProperty.CreateAttached("VisualElementCommand", typeof(ICommand), typeof(VisualElementUnfocused), null, propertyChanged:OnVisualElementCommandChanged);

        public static ICommand GetVisualElementCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(VisualElementCommandProperty);
        }

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

        private static void OnVisualElementCommandChanged(object o, Xamarin.Forms.FocusEventArgs eventArgs)
        {
            var command = GetVisualElementCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.VisualElement))
                command.Execute(eventArgs.VisualElement);
        }
		#endregion
	}

	public partial class WebViewEvalRequested {

		#region Command
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(WebViewEvalRequested), null, propertyChanged:OnCommandChanged);

        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

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

        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion

		#region ScriptCommand
        public static readonly BindableProperty ScriptCommandProperty =
            BindableProperty.CreateAttached("ScriptCommand", typeof(ICommand), typeof(WebViewEvalRequested), null, propertyChanged:OnScriptCommandChanged);

        public static ICommand GetScriptCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ScriptCommandProperty);
        }

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

        private static void OnScriptCommandChanged(object o, Xamarin.Forms.Internals.EvalRequested eventArgs)
        {
            var command = GetScriptCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Script))
                command.Execute(eventArgs.Script);
        }
		#endregion
	}

	public partial class WebViewGoBackRequested {

		#region Command
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(WebViewGoBackRequested), null, propertyChanged:OnCommandChanged);

        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

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

        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion
	}

	public partial class WebViewGoForwardRequested {

		#region Command
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(WebViewGoForwardRequested), null, propertyChanged:OnCommandChanged);

        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

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

        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion
	}

	public partial class WebViewNavigated {

		#region Command
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(WebViewNavigated), null, propertyChanged:OnCommandChanged);

        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

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

        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion

		#region ResultCommand
        public static readonly BindableProperty ResultCommandProperty =
            BindableProperty.CreateAttached("ResultCommand", typeof(ICommand), typeof(WebViewNavigated), null, propertyChanged:OnResultCommandChanged);

        public static ICommand GetResultCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ResultCommandProperty);
        }

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

        private static void OnResultCommandChanged(object o, Xamarin.Forms.WebNavigatedEventArgs eventArgs)
        {
            var command = GetResultCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Result))
                command.Execute(eventArgs.Result);
        }
		#endregion

		#region NavigationEventCommand
        public static readonly BindableProperty NavigationEventCommandProperty =
            BindableProperty.CreateAttached("NavigationEventCommand", typeof(ICommand), typeof(WebViewNavigated), null, propertyChanged:OnNavigationEventCommandChanged);

        public static ICommand GetNavigationEventCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NavigationEventCommandProperty);
        }

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

        private static void OnNavigationEventCommandChanged(object o, Xamarin.Forms.WebNavigatedEventArgs eventArgs)
        {
            var command = GetNavigationEventCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.NavigationEvent))
                command.Execute(eventArgs.NavigationEvent);
        }
		#endregion

		#region SourceCommand
        public static readonly BindableProperty SourceCommandProperty =
            BindableProperty.CreateAttached("SourceCommand", typeof(ICommand), typeof(WebViewNavigated), null, propertyChanged:OnSourceCommandChanged);

        public static ICommand GetSourceCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(SourceCommandProperty);
        }

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

        private static void OnSourceCommandChanged(object o, Xamarin.Forms.WebNavigatedEventArgs eventArgs)
        {
            var command = GetSourceCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Source))
                command.Execute(eventArgs.Source);
        }
		#endregion

		#region UrlCommand
        public static readonly BindableProperty UrlCommandProperty =
            BindableProperty.CreateAttached("UrlCommand", typeof(ICommand), typeof(WebViewNavigated), null, propertyChanged:OnUrlCommandChanged);

        public static ICommand GetUrlCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(UrlCommandProperty);
        }

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

        private static void OnUrlCommandChanged(object o, Xamarin.Forms.WebNavigatedEventArgs eventArgs)
        {
            var command = GetUrlCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Url))
                command.Execute(eventArgs.Url);
        }
		#endregion
	}

	public partial class WebViewNavigating {

		#region Command
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(WebViewNavigating), null, propertyChanged:OnCommandChanged);

        public static ICommand GetCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CommandProperty);
        }

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

        private static void OnCommandChanged(object o, EventArgs eventArgs)
        {
            var command = GetCommand((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }
		#endregion

		#region CancelCommand
        public static readonly BindableProperty CancelCommandProperty =
            BindableProperty.CreateAttached("CancelCommand", typeof(ICommand), typeof(WebViewNavigating), null, propertyChanged:OnCancelCommandChanged);

        public static ICommand GetCancelCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CancelCommandProperty);
        }

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

        private static void OnCancelCommandChanged(object o, Xamarin.Forms.WebNavigatingEventArgs eventArgs)
        {
            var command = GetCancelCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Cancel))
                command.Execute(eventArgs.Cancel);
        }
		#endregion

		#region NavigationEventCommand
        public static readonly BindableProperty NavigationEventCommandProperty =
            BindableProperty.CreateAttached("NavigationEventCommand", typeof(ICommand), typeof(WebViewNavigating), null, propertyChanged:OnNavigationEventCommandChanged);

        public static ICommand GetNavigationEventCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NavigationEventCommandProperty);
        }

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

        private static void OnNavigationEventCommandChanged(object o, Xamarin.Forms.WebNavigatingEventArgs eventArgs)
        {
            var command = GetNavigationEventCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.NavigationEvent))
                command.Execute(eventArgs.NavigationEvent);
        }
		#endregion

		#region SourceCommand
        public static readonly BindableProperty SourceCommandProperty =
            BindableProperty.CreateAttached("SourceCommand", typeof(ICommand), typeof(WebViewNavigating), null, propertyChanged:OnSourceCommandChanged);

        public static ICommand GetSourceCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(SourceCommandProperty);
        }

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

        private static void OnSourceCommandChanged(object o, Xamarin.Forms.WebNavigatingEventArgs eventArgs)
        {
            var command = GetSourceCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Source))
                command.Execute(eventArgs.Source);
        }
		#endregion

		#region UrlCommand
        public static readonly BindableProperty UrlCommandProperty =
            BindableProperty.CreateAttached("UrlCommand", typeof(ICommand), typeof(WebViewNavigating), null, propertyChanged:OnUrlCommandChanged);

        public static ICommand GetUrlCommand(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(UrlCommandProperty);
        }

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

        private static void OnUrlCommandChanged(object o, Xamarin.Forms.WebNavigatingEventArgs eventArgs)
        {
            var command = GetUrlCommand((BindableObject)o);
            if (command.CanExecute(eventArgs.Url))
                command.Execute(eventArgs.Url);
        }
		#endregion
	}

}
