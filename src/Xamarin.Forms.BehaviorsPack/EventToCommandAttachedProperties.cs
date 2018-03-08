using System;
using System.Windows.Input;

namespace Xamarin.Forms.BehaviorsPack {
	public class Applications {
        public static readonly BindableProperty ModalPoppedToProperty =
            BindableProperty.CreateAttached("ModalPoppedTo", typeof(ICommand), typeof(Applications), null, propertyChanged:OnModalPoppedToChanged);

        public static ICommand GetModalPoppedTo(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ModalPoppedToProperty);
        }

		private static void OnModalPoppedToChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Application target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.ModalPopped += ApplicationOnModalPopped;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.ModalPopped -= ApplicationOnModalPopped;
                }
            }
		}

        private static void ApplicationOnModalPopped(object o, EventArgs eventArgs)
        {
            var command = GetModalPoppedTo((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }

        public static readonly BindableProperty ModalPoppingToProperty =
            BindableProperty.CreateAttached("ModalPoppingTo", typeof(ICommand), typeof(Applications), null, propertyChanged:OnModalPoppingToChanged);

        public static ICommand GetModalPoppingTo(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ModalPoppingToProperty);
        }

		private static void OnModalPoppingToChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Application target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.ModalPopping += ApplicationOnModalPopping;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.ModalPopping -= ApplicationOnModalPopping;
                }
            }
		}

        private static void ApplicationOnModalPopping(object o, EventArgs eventArgs)
        {
            var command = GetModalPoppingTo((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }

        public static readonly BindableProperty ModalPushedToProperty =
            BindableProperty.CreateAttached("ModalPushedTo", typeof(ICommand), typeof(Applications), null, propertyChanged:OnModalPushedToChanged);

        public static ICommand GetModalPushedTo(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ModalPushedToProperty);
        }

		private static void OnModalPushedToChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Application target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.ModalPushed += ApplicationOnModalPushed;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.ModalPushed -= ApplicationOnModalPushed;
                }
            }
		}

        private static void ApplicationOnModalPushed(object o, EventArgs eventArgs)
        {
            var command = GetModalPushedTo((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }

        public static readonly BindableProperty ModalPushingToProperty =
            BindableProperty.CreateAttached("ModalPushingTo", typeof(ICommand), typeof(Applications), null, propertyChanged:OnModalPushingToChanged);

        public static ICommand GetModalPushingTo(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ModalPushingToProperty);
        }

		private static void OnModalPushingToChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Application target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.ModalPushing += ApplicationOnModalPushing;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.ModalPushing -= ApplicationOnModalPushing;
                }
            }
		}

        private static void ApplicationOnModalPushing(object o, EventArgs eventArgs)
        {
            var command = GetModalPushingTo((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }

	}

	public class Buttons {
        public static readonly BindableProperty ClickedToProperty =
            BindableProperty.CreateAttached("ClickedTo", typeof(ICommand), typeof(Buttons), null, propertyChanged:OnClickedToChanged);

        public static ICommand GetClickedTo(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ClickedToProperty);
        }

		private static void OnClickedToChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Button target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.Clicked += ButtonOnClicked;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.Clicked -= ButtonOnClicked;
                }
            }
		}

        private static void ButtonOnClicked(object o, EventArgs eventArgs)
        {
            var command = GetClickedTo((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }

        public static readonly BindableProperty PressedToProperty =
            BindableProperty.CreateAttached("PressedTo", typeof(ICommand), typeof(Buttons), null, propertyChanged:OnPressedToChanged);

        public static ICommand GetPressedTo(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(PressedToProperty);
        }

		private static void OnPressedToChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Button target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.Pressed += ButtonOnPressed;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.Pressed -= ButtonOnPressed;
                }
            }
		}

        private static void ButtonOnPressed(object o, EventArgs eventArgs)
        {
            var command = GetPressedTo((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }

        public static readonly BindableProperty ReleasedToProperty =
            BindableProperty.CreateAttached("ReleasedTo", typeof(ICommand), typeof(Buttons), null, propertyChanged:OnReleasedToChanged);

        public static ICommand GetReleasedTo(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ReleasedToProperty);
        }

		private static void OnReleasedToChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Button target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.Released += ButtonOnReleased;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.Released -= ButtonOnReleased;
                }
            }
		}

        private static void ButtonOnReleased(object o, EventArgs eventArgs)
        {
            var command = GetReleasedTo((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }

	}

	public class Cells {
        public static readonly BindableProperty AppearingToProperty =
            BindableProperty.CreateAttached("AppearingTo", typeof(ICommand), typeof(Cells), null, propertyChanged:OnAppearingToChanged);

        public static ICommand GetAppearingTo(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(AppearingToProperty);
        }

		private static void OnAppearingToChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Cell target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.Appearing += CellOnAppearing;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.Appearing -= CellOnAppearing;
                }
            }
		}

        private static void CellOnAppearing(object o, EventArgs eventArgs)
        {
            var command = GetAppearingTo((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }

        public static readonly BindableProperty DisappearingToProperty =
            BindableProperty.CreateAttached("DisappearingTo", typeof(ICommand), typeof(Cells), null, propertyChanged:OnDisappearingToChanged);

        public static ICommand GetDisappearingTo(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(DisappearingToProperty);
        }

		private static void OnDisappearingToChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Cell target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.Disappearing += CellOnDisappearing;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.Disappearing -= CellOnDisappearing;
                }
            }
		}

        private static void CellOnDisappearing(object o, EventArgs eventArgs)
        {
            var command = GetDisappearingTo((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }

        public static readonly BindableProperty ForceUpdateSizeRequestedToProperty =
            BindableProperty.CreateAttached("ForceUpdateSizeRequestedTo", typeof(ICommand), typeof(Cells), null, propertyChanged:OnForceUpdateSizeRequestedToChanged);

        public static ICommand GetForceUpdateSizeRequestedTo(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ForceUpdateSizeRequestedToProperty);
        }

		private static void OnForceUpdateSizeRequestedToChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Cell target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.ForceUpdateSizeRequested += CellOnForceUpdateSizeRequested;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.ForceUpdateSizeRequested -= CellOnForceUpdateSizeRequested;
                }
            }
		}

        private static void CellOnForceUpdateSizeRequested(object o, EventArgs eventArgs)
        {
            var command = GetForceUpdateSizeRequestedTo((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }

        public static readonly BindableProperty TappedToProperty =
            BindableProperty.CreateAttached("TappedTo", typeof(ICommand), typeof(Cells), null, propertyChanged:OnTappedToChanged);

        public static ICommand GetTappedTo(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(TappedToProperty);
        }

		private static void OnTappedToChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Cell target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.Tapped += CellOnTapped;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.Tapped -= CellOnTapped;
                }
            }
		}

        private static void CellOnTapped(object o, EventArgs eventArgs)
        {
            var command = GetTappedTo((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }

	}

	public class ColumnDefinitions {
        public static readonly BindableProperty SizeChangedToProperty =
            BindableProperty.CreateAttached("SizeChangedTo", typeof(ICommand), typeof(ColumnDefinitions), null, propertyChanged:OnSizeChangedToChanged);

        public static ICommand GetSizeChangedTo(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(SizeChangedToProperty);
        }

		private static void OnSizeChangedToChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is ColumnDefinition target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.SizeChanged += ColumnDefinitionOnSizeChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.SizeChanged -= ColumnDefinitionOnSizeChanged;
                }
            }
		}

        private static void ColumnDefinitionOnSizeChanged(object o, EventArgs eventArgs)
        {
            var command = GetSizeChangedTo((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }

	}

	public class DatePickers {
        public static readonly BindableProperty DateSelectedToProperty =
            BindableProperty.CreateAttached("DateSelectedTo", typeof(ICommand), typeof(DatePickers), null, propertyChanged:OnDateSelectedToChanged);

        public static ICommand GetDateSelectedTo(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(DateSelectedToProperty);
        }

		private static void OnDateSelectedToChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is DatePicker target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.DateSelected += DatePickerOnDateSelected;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.DateSelected -= DatePickerOnDateSelected;
                }
            }
		}

        private static void DatePickerOnDateSelected(object o, EventArgs eventArgs)
        {
            var command = GetDateSelectedTo((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }

	}

	public class Editors {
        public static readonly BindableProperty CompletedToProperty =
            BindableProperty.CreateAttached("CompletedTo", typeof(ICommand), typeof(Editors), null, propertyChanged:OnCompletedToChanged);

        public static ICommand GetCompletedTo(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CompletedToProperty);
        }

		private static void OnCompletedToChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Editor target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.Completed += EditorOnCompleted;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.Completed -= EditorOnCompleted;
                }
            }
		}

        private static void EditorOnCompleted(object o, EventArgs eventArgs)
        {
            var command = GetCompletedTo((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }

        public static readonly BindableProperty TextChangedToProperty =
            BindableProperty.CreateAttached("TextChangedTo", typeof(ICommand), typeof(Editors), null, propertyChanged:OnTextChangedToChanged);

        public static ICommand GetTextChangedTo(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(TextChangedToProperty);
        }

		private static void OnTextChangedToChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Editor target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.TextChanged += EditorOnTextChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.TextChanged -= EditorOnTextChanged;
                }
            }
		}

        private static void EditorOnTextChanged(object o, EventArgs eventArgs)
        {
            var command = GetTextChangedTo((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }

	}

	public class Elements {
        public static readonly BindableProperty ChildAddedToProperty =
            BindableProperty.CreateAttached("ChildAddedTo", typeof(ICommand), typeof(Elements), null, propertyChanged:OnChildAddedToChanged);

        public static ICommand GetChildAddedTo(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ChildAddedToProperty);
        }

		private static void OnChildAddedToChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Element target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.ChildAdded += ElementOnChildAdded;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.ChildAdded -= ElementOnChildAdded;
                }
            }
		}

        private static void ElementOnChildAdded(object o, EventArgs eventArgs)
        {
            var command = GetChildAddedTo((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }

        public static readonly BindableProperty ChildRemovedToProperty =
            BindableProperty.CreateAttached("ChildRemovedTo", typeof(ICommand), typeof(Elements), null, propertyChanged:OnChildRemovedToChanged);

        public static ICommand GetChildRemovedTo(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ChildRemovedToProperty);
        }

		private static void OnChildRemovedToChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Element target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.ChildRemoved += ElementOnChildRemoved;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.ChildRemoved -= ElementOnChildRemoved;
                }
            }
		}

        private static void ElementOnChildRemoved(object o, EventArgs eventArgs)
        {
            var command = GetChildRemovedTo((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }

        public static readonly BindableProperty DescendantAddedToProperty =
            BindableProperty.CreateAttached("DescendantAddedTo", typeof(ICommand), typeof(Elements), null, propertyChanged:OnDescendantAddedToChanged);

        public static ICommand GetDescendantAddedTo(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(DescendantAddedToProperty);
        }

		private static void OnDescendantAddedToChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Element target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.DescendantAdded += ElementOnDescendantAdded;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.DescendantAdded -= ElementOnDescendantAdded;
                }
            }
		}

        private static void ElementOnDescendantAdded(object o, EventArgs eventArgs)
        {
            var command = GetDescendantAddedTo((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }

        public static readonly BindableProperty DescendantRemovedToProperty =
            BindableProperty.CreateAttached("DescendantRemovedTo", typeof(ICommand), typeof(Elements), null, propertyChanged:OnDescendantRemovedToChanged);

        public static ICommand GetDescendantRemovedTo(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(DescendantRemovedToProperty);
        }

		private static void OnDescendantRemovedToChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Element target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.DescendantRemoved += ElementOnDescendantRemoved;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.DescendantRemoved -= ElementOnDescendantRemoved;
                }
            }
		}

        private static void ElementOnDescendantRemoved(object o, EventArgs eventArgs)
        {
            var command = GetDescendantRemovedTo((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }

        public static readonly BindableProperty PlatformSetToProperty =
            BindableProperty.CreateAttached("PlatformSetTo", typeof(ICommand), typeof(Elements), null, propertyChanged:OnPlatformSetToChanged);

        public static ICommand GetPlatformSetTo(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(PlatformSetToProperty);
        }

		private static void OnPlatformSetToChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Element target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.PlatformSet += ElementOnPlatformSet;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.PlatformSet -= ElementOnPlatformSet;
                }
            }
		}

        private static void ElementOnPlatformSet(object o, EventArgs eventArgs)
        {
            var command = GetPlatformSetTo((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }

	}

	public class Entrys {
        public static readonly BindableProperty CompletedToProperty =
            BindableProperty.CreateAttached("CompletedTo", typeof(ICommand), typeof(Entrys), null, propertyChanged:OnCompletedToChanged);

        public static ICommand GetCompletedTo(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CompletedToProperty);
        }

		private static void OnCompletedToChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Entry target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.Completed += EntryOnCompleted;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.Completed -= EntryOnCompleted;
                }
            }
		}

        private static void EntryOnCompleted(object o, EventArgs eventArgs)
        {
            var command = GetCompletedTo((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }

        public static readonly BindableProperty TextChangedToProperty =
            BindableProperty.CreateAttached("TextChangedTo", typeof(ICommand), typeof(Entrys), null, propertyChanged:OnTextChangedToChanged);

        public static ICommand GetTextChangedTo(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(TextChangedToProperty);
        }

		private static void OnTextChangedToChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Entry target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.TextChanged += EntryOnTextChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.TextChanged -= EntryOnTextChanged;
                }
            }
		}

        private static void EntryOnTextChanged(object o, EventArgs eventArgs)
        {
            var command = GetTextChangedTo((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }

	}

	public class EntryCells {
        public static readonly BindableProperty CompletedToProperty =
            BindableProperty.CreateAttached("CompletedTo", typeof(ICommand), typeof(EntryCells), null, propertyChanged:OnCompletedToChanged);

        public static ICommand GetCompletedTo(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(CompletedToProperty);
        }

		private static void OnCompletedToChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is EntryCell target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.Completed += EntryCellOnCompleted;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.Completed -= EntryCellOnCompleted;
                }
            }
		}

        private static void EntryCellOnCompleted(object o, EventArgs eventArgs)
        {
            var command = GetCompletedTo((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }

	}

	public class Layouts {
        public static readonly BindableProperty LayoutChangedToProperty =
            BindableProperty.CreateAttached("LayoutChangedTo", typeof(ICommand), typeof(Layouts), null, propertyChanged:OnLayoutChangedToChanged);

        public static ICommand GetLayoutChangedTo(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(LayoutChangedToProperty);
        }

		private static void OnLayoutChangedToChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Layout target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.LayoutChanged += LayoutOnLayoutChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.LayoutChanged -= LayoutOnLayoutChanged;
                }
            }
		}

        private static void LayoutOnLayoutChanged(object o, EventArgs eventArgs)
        {
            var command = GetLayoutChangedTo((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }

	}

	public class ListViews {
        public static readonly BindableProperty ItemAppearingToProperty =
            BindableProperty.CreateAttached("ItemAppearingTo", typeof(ICommand), typeof(ListViews), null, propertyChanged:OnItemAppearingToChanged);

        public static ICommand GetItemAppearingTo(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ItemAppearingToProperty);
        }

		private static void OnItemAppearingToChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is ListView target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.ItemAppearing += ListViewOnItemAppearing;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.ItemAppearing -= ListViewOnItemAppearing;
                }
            }
		}

        private static void ListViewOnItemAppearing(object o, EventArgs eventArgs)
        {
            var command = GetItemAppearingTo((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }

        public static readonly BindableProperty ItemDisappearingToProperty =
            BindableProperty.CreateAttached("ItemDisappearingTo", typeof(ICommand), typeof(ListViews), null, propertyChanged:OnItemDisappearingToChanged);

        public static ICommand GetItemDisappearingTo(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ItemDisappearingToProperty);
        }

		private static void OnItemDisappearingToChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is ListView target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.ItemDisappearing += ListViewOnItemDisappearing;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.ItemDisappearing -= ListViewOnItemDisappearing;
                }
            }
		}

        private static void ListViewOnItemDisappearing(object o, EventArgs eventArgs)
        {
            var command = GetItemDisappearingTo((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }

        public static readonly BindableProperty ItemSelectedToProperty =
            BindableProperty.CreateAttached("ItemSelectedTo", typeof(ICommand), typeof(ListViews), null, propertyChanged:OnItemSelectedToChanged);

        public static ICommand GetItemSelectedTo(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ItemSelectedToProperty);
        }

		private static void OnItemSelectedToChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is ListView target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.ItemSelected += ListViewOnItemSelected;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.ItemSelected -= ListViewOnItemSelected;
                }
            }
		}

        private static void ListViewOnItemSelected(object o, EventArgs eventArgs)
        {
            var command = GetItemSelectedTo((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }

        public static readonly BindableProperty ItemTappedToProperty =
            BindableProperty.CreateAttached("ItemTappedTo", typeof(ICommand), typeof(ListViews), null, propertyChanged:OnItemTappedToChanged);

        public static ICommand GetItemTappedTo(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ItemTappedToProperty);
        }

		private static void OnItemTappedToChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is ListView target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.ItemTapped += ListViewOnItemTapped;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.ItemTapped -= ListViewOnItemTapped;
                }
            }
		}

        private static void ListViewOnItemTapped(object o, EventArgs eventArgs)
        {
            var command = GetItemTappedTo((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }

        public static readonly BindableProperty RefreshingToProperty =
            BindableProperty.CreateAttached("RefreshingTo", typeof(ICommand), typeof(ListViews), null, propertyChanged:OnRefreshingToChanged);

        public static ICommand GetRefreshingTo(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(RefreshingToProperty);
        }

		private static void OnRefreshingToChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is ListView target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.Refreshing += ListViewOnRefreshing;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.Refreshing -= ListViewOnRefreshing;
                }
            }
		}

        private static void ListViewOnRefreshing(object o, EventArgs eventArgs)
        {
            var command = GetRefreshingTo((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }

        public static readonly BindableProperty ScrollToRequestedToProperty =
            BindableProperty.CreateAttached("ScrollToRequestedTo", typeof(ICommand), typeof(ListViews), null, propertyChanged:OnScrollToRequestedToChanged);

        public static ICommand GetScrollToRequestedTo(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ScrollToRequestedToProperty);
        }

		private static void OnScrollToRequestedToChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is ListView target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.ScrollToRequested += ListViewOnScrollToRequested;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.ScrollToRequested -= ListViewOnScrollToRequested;
                }
            }
		}

        private static void ListViewOnScrollToRequested(object o, EventArgs eventArgs)
        {
            var command = GetScrollToRequestedTo((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }

	}

	public class MasterDetailPages {
        public static readonly BindableProperty BackButtonPressedToProperty =
            BindableProperty.CreateAttached("BackButtonPressedTo", typeof(ICommand), typeof(MasterDetailPages), null, propertyChanged:OnBackButtonPressedToChanged);

        public static ICommand GetBackButtonPressedTo(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(BackButtonPressedToProperty);
        }

		private static void OnBackButtonPressedToChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is MasterDetailPage target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.BackButtonPressed += MasterDetailPageOnBackButtonPressed;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.BackButtonPressed -= MasterDetailPageOnBackButtonPressed;
                }
            }
		}

        private static void MasterDetailPageOnBackButtonPressed(object o, EventArgs eventArgs)
        {
            var command = GetBackButtonPressedTo((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }

        public static readonly BindableProperty IsPresentedChangedToProperty =
            BindableProperty.CreateAttached("IsPresentedChangedTo", typeof(ICommand), typeof(MasterDetailPages), null, propertyChanged:OnIsPresentedChangedToChanged);

        public static ICommand GetIsPresentedChangedTo(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(IsPresentedChangedToProperty);
        }

		private static void OnIsPresentedChangedToChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is MasterDetailPage target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.IsPresentedChanged += MasterDetailPageOnIsPresentedChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.IsPresentedChanged -= MasterDetailPageOnIsPresentedChanged;
                }
            }
		}

        private static void MasterDetailPageOnIsPresentedChanged(object o, EventArgs eventArgs)
        {
            var command = GetIsPresentedChangedTo((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }

	}

	public class MenuItems {
        public static readonly BindableProperty ClickedToProperty =
            BindableProperty.CreateAttached("ClickedTo", typeof(ICommand), typeof(MenuItems), null, propertyChanged:OnClickedToChanged);

        public static ICommand GetClickedTo(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ClickedToProperty);
        }

		private static void OnClickedToChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is MenuItem target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.Clicked += MenuItemOnClicked;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.Clicked -= MenuItemOnClicked;
                }
            }
		}

        private static void MenuItemOnClicked(object o, EventArgs eventArgs)
        {
            var command = GetClickedTo((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }

	}

	public class NavigationPages {
        public static readonly BindableProperty InsertPageBeforeRequestedToProperty =
            BindableProperty.CreateAttached("InsertPageBeforeRequestedTo", typeof(ICommand), typeof(NavigationPages), null, propertyChanged:OnInsertPageBeforeRequestedToChanged);

        public static ICommand GetInsertPageBeforeRequestedTo(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(InsertPageBeforeRequestedToProperty);
        }

		private static void OnInsertPageBeforeRequestedToChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is NavigationPage target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.InsertPageBeforeRequested += NavigationPageOnInsertPageBeforeRequested;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.InsertPageBeforeRequested -= NavigationPageOnInsertPageBeforeRequested;
                }
            }
		}

        private static void NavigationPageOnInsertPageBeforeRequested(object o, EventArgs eventArgs)
        {
            var command = GetInsertPageBeforeRequestedTo((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }

        public static readonly BindableProperty PoppedToProperty =
            BindableProperty.CreateAttached("PoppedTo", typeof(ICommand), typeof(NavigationPages), null, propertyChanged:OnPoppedToChanged);

        public static ICommand GetPoppedTo(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(PoppedToProperty);
        }

		private static void OnPoppedToChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is NavigationPage target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.Popped += NavigationPageOnPopped;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.Popped -= NavigationPageOnPopped;
                }
            }
		}

        private static void NavigationPageOnPopped(object o, EventArgs eventArgs)
        {
            var command = GetPoppedTo((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }

        public static readonly BindableProperty PoppedToRootToProperty =
            BindableProperty.CreateAttached("PoppedToRootTo", typeof(ICommand), typeof(NavigationPages), null, propertyChanged:OnPoppedToRootToChanged);

        public static ICommand GetPoppedToRootTo(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(PoppedToRootToProperty);
        }

		private static void OnPoppedToRootToChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is NavigationPage target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.PoppedToRoot += NavigationPageOnPoppedToRoot;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.PoppedToRoot -= NavigationPageOnPoppedToRoot;
                }
            }
		}

        private static void NavigationPageOnPoppedToRoot(object o, EventArgs eventArgs)
        {
            var command = GetPoppedToRootTo((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }

        public static readonly BindableProperty PopRequestedToProperty =
            BindableProperty.CreateAttached("PopRequestedTo", typeof(ICommand), typeof(NavigationPages), null, propertyChanged:OnPopRequestedToChanged);

        public static ICommand GetPopRequestedTo(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(PopRequestedToProperty);
        }

		private static void OnPopRequestedToChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is NavigationPage target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.PopRequested += NavigationPageOnPopRequested;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.PopRequested -= NavigationPageOnPopRequested;
                }
            }
		}

        private static void NavigationPageOnPopRequested(object o, EventArgs eventArgs)
        {
            var command = GetPopRequestedTo((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }

        public static readonly BindableProperty PopToRootRequestedToProperty =
            BindableProperty.CreateAttached("PopToRootRequestedTo", typeof(ICommand), typeof(NavigationPages), null, propertyChanged:OnPopToRootRequestedToChanged);

        public static ICommand GetPopToRootRequestedTo(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(PopToRootRequestedToProperty);
        }

		private static void OnPopToRootRequestedToChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is NavigationPage target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.PopToRootRequested += NavigationPageOnPopToRootRequested;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.PopToRootRequested -= NavigationPageOnPopToRootRequested;
                }
            }
		}

        private static void NavigationPageOnPopToRootRequested(object o, EventArgs eventArgs)
        {
            var command = GetPopToRootRequestedTo((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }

        public static readonly BindableProperty PushedToProperty =
            BindableProperty.CreateAttached("PushedTo", typeof(ICommand), typeof(NavigationPages), null, propertyChanged:OnPushedToChanged);

        public static ICommand GetPushedTo(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(PushedToProperty);
        }

		private static void OnPushedToChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is NavigationPage target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.Pushed += NavigationPageOnPushed;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.Pushed -= NavigationPageOnPushed;
                }
            }
		}

        private static void NavigationPageOnPushed(object o, EventArgs eventArgs)
        {
            var command = GetPushedTo((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }

        public static readonly BindableProperty PushRequestedToProperty =
            BindableProperty.CreateAttached("PushRequestedTo", typeof(ICommand), typeof(NavigationPages), null, propertyChanged:OnPushRequestedToChanged);

        public static ICommand GetPushRequestedTo(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(PushRequestedToProperty);
        }

		private static void OnPushRequestedToChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is NavigationPage target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.PushRequested += NavigationPageOnPushRequested;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.PushRequested -= NavigationPageOnPushRequested;
                }
            }
		}

        private static void NavigationPageOnPushRequested(object o, EventArgs eventArgs)
        {
            var command = GetPushRequestedTo((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }

        public static readonly BindableProperty RemovePageRequestedToProperty =
            BindableProperty.CreateAttached("RemovePageRequestedTo", typeof(ICommand), typeof(NavigationPages), null, propertyChanged:OnRemovePageRequestedToChanged);

        public static ICommand GetRemovePageRequestedTo(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(RemovePageRequestedToProperty);
        }

		private static void OnRemovePageRequestedToChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is NavigationPage target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.RemovePageRequested += NavigationPageOnRemovePageRequested;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.RemovePageRequested -= NavigationPageOnRemovePageRequested;
                }
            }
		}

        private static void NavigationPageOnRemovePageRequested(object o, EventArgs eventArgs)
        {
            var command = GetRemovePageRequestedTo((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }

	}

	public class OpenGLViews {
        public static readonly BindableProperty DisplayRequestedToProperty =
            BindableProperty.CreateAttached("DisplayRequestedTo", typeof(ICommand), typeof(OpenGLViews), null, propertyChanged:OnDisplayRequestedToChanged);

        public static ICommand GetDisplayRequestedTo(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(DisplayRequestedToProperty);
        }

		private static void OnDisplayRequestedToChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is OpenGLView target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.DisplayRequested += OpenGLViewOnDisplayRequested;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.DisplayRequested -= OpenGLViewOnDisplayRequested;
                }
            }
		}

        private static void OpenGLViewOnDisplayRequested(object o, EventArgs eventArgs)
        {
            var command = GetDisplayRequestedTo((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }

	}

	public class Pages {
        public static readonly BindableProperty AppearingToProperty =
            BindableProperty.CreateAttached("AppearingTo", typeof(ICommand), typeof(Pages), null, propertyChanged:OnAppearingToChanged);

        public static ICommand GetAppearingTo(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(AppearingToProperty);
        }

		private static void OnAppearingToChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Page target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.Appearing += PageOnAppearing;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.Appearing -= PageOnAppearing;
                }
            }
		}

        private static void PageOnAppearing(object o, EventArgs eventArgs)
        {
            var command = GetAppearingTo((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }

        public static readonly BindableProperty DisappearingToProperty =
            BindableProperty.CreateAttached("DisappearingTo", typeof(ICommand), typeof(Pages), null, propertyChanged:OnDisappearingToChanged);

        public static ICommand GetDisappearingTo(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(DisappearingToProperty);
        }

		private static void OnDisappearingToChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Page target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.Disappearing += PageOnDisappearing;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.Disappearing -= PageOnDisappearing;
                }
            }
		}

        private static void PageOnDisappearing(object o, EventArgs eventArgs)
        {
            var command = GetDisappearingTo((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }

        public static readonly BindableProperty LayoutChangedToProperty =
            BindableProperty.CreateAttached("LayoutChangedTo", typeof(ICommand), typeof(Pages), null, propertyChanged:OnLayoutChangedToChanged);

        public static ICommand GetLayoutChangedTo(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(LayoutChangedToProperty);
        }

		private static void OnLayoutChangedToChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Page target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.LayoutChanged += PageOnLayoutChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.LayoutChanged -= PageOnLayoutChanged;
                }
            }
		}

        private static void PageOnLayoutChanged(object o, EventArgs eventArgs)
        {
            var command = GetLayoutChangedTo((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }

	}

	public class PanGestureRecognizers {
        public static readonly BindableProperty PanUpdatedToProperty =
            BindableProperty.CreateAttached("PanUpdatedTo", typeof(ICommand), typeof(PanGestureRecognizers), null, propertyChanged:OnPanUpdatedToChanged);

        public static ICommand GetPanUpdatedTo(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(PanUpdatedToProperty);
        }

		private static void OnPanUpdatedToChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is PanGestureRecognizer target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.PanUpdated += PanGestureRecognizerOnPanUpdated;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.PanUpdated -= PanGestureRecognizerOnPanUpdated;
                }
            }
		}

        private static void PanGestureRecognizerOnPanUpdated(object o, EventArgs eventArgs)
        {
            var command = GetPanUpdatedTo((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }

	}

	public class Pickers {
        public static readonly BindableProperty SelectedIndexChangedToProperty =
            BindableProperty.CreateAttached("SelectedIndexChangedTo", typeof(ICommand), typeof(Pickers), null, propertyChanged:OnSelectedIndexChangedToChanged);

        public static ICommand GetSelectedIndexChangedTo(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(SelectedIndexChangedToProperty);
        }

		private static void OnSelectedIndexChangedToChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Picker target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.SelectedIndexChanged += PickerOnSelectedIndexChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.SelectedIndexChanged -= PickerOnSelectedIndexChanged;
                }
            }
		}

        private static void PickerOnSelectedIndexChanged(object o, EventArgs eventArgs)
        {
            var command = GetSelectedIndexChangedTo((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }

	}

	public class PinchGestureRecognizers {
        public static readonly BindableProperty PinchUpdatedToProperty =
            BindableProperty.CreateAttached("PinchUpdatedTo", typeof(ICommand), typeof(PinchGestureRecognizers), null, propertyChanged:OnPinchUpdatedToChanged);

        public static ICommand GetPinchUpdatedTo(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(PinchUpdatedToProperty);
        }

		private static void OnPinchUpdatedToChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is PinchGestureRecognizer target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.PinchUpdated += PinchGestureRecognizerOnPinchUpdated;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.PinchUpdated -= PinchGestureRecognizerOnPinchUpdated;
                }
            }
		}

        private static void PinchGestureRecognizerOnPinchUpdated(object o, EventArgs eventArgs)
        {
            var command = GetPinchUpdatedTo((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }

	}

	public class RowDefinitions {
        public static readonly BindableProperty SizeChangedToProperty =
            BindableProperty.CreateAttached("SizeChangedTo", typeof(ICommand), typeof(RowDefinitions), null, propertyChanged:OnSizeChangedToChanged);

        public static ICommand GetSizeChangedTo(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(SizeChangedToProperty);
        }

		private static void OnSizeChangedToChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is RowDefinition target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.SizeChanged += RowDefinitionOnSizeChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.SizeChanged -= RowDefinitionOnSizeChanged;
                }
            }
		}

        private static void RowDefinitionOnSizeChanged(object o, EventArgs eventArgs)
        {
            var command = GetSizeChangedTo((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }

	}

	public class ScrollViews {
        public static readonly BindableProperty ScrolledToProperty =
            BindableProperty.CreateAttached("ScrolledTo", typeof(ICommand), typeof(ScrollViews), null, propertyChanged:OnScrolledToChanged);

        public static ICommand GetScrolledTo(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ScrolledToProperty);
        }

		private static void OnScrolledToChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is ScrollView target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.Scrolled += ScrollViewOnScrolled;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.Scrolled -= ScrollViewOnScrolled;
                }
            }
		}

        private static void ScrollViewOnScrolled(object o, EventArgs eventArgs)
        {
            var command = GetScrolledTo((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }

        public static readonly BindableProperty ScrollToRequestedToProperty =
            BindableProperty.CreateAttached("ScrollToRequestedTo", typeof(ICommand), typeof(ScrollViews), null, propertyChanged:OnScrollToRequestedToChanged);

        public static ICommand GetScrollToRequestedTo(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ScrollToRequestedToProperty);
        }

		private static void OnScrollToRequestedToChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is ScrollView target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.ScrollToRequested += ScrollViewOnScrollToRequested;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.ScrollToRequested -= ScrollViewOnScrollToRequested;
                }
            }
		}

        private static void ScrollViewOnScrollToRequested(object o, EventArgs eventArgs)
        {
            var command = GetScrollToRequestedTo((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }

	}

	public class SearchBars {
        public static readonly BindableProperty SearchButtonPressedToProperty =
            BindableProperty.CreateAttached("SearchButtonPressedTo", typeof(ICommand), typeof(SearchBars), null, propertyChanged:OnSearchButtonPressedToChanged);

        public static ICommand GetSearchButtonPressedTo(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(SearchButtonPressedToProperty);
        }

		private static void OnSearchButtonPressedToChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is SearchBar target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.SearchButtonPressed += SearchBarOnSearchButtonPressed;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.SearchButtonPressed -= SearchBarOnSearchButtonPressed;
                }
            }
		}

        private static void SearchBarOnSearchButtonPressed(object o, EventArgs eventArgs)
        {
            var command = GetSearchButtonPressedTo((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }

        public static readonly BindableProperty TextChangedToProperty =
            BindableProperty.CreateAttached("TextChangedTo", typeof(ICommand), typeof(SearchBars), null, propertyChanged:OnTextChangedToChanged);

        public static ICommand GetTextChangedTo(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(TextChangedToProperty);
        }

		private static void OnTextChangedToChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is SearchBar target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.TextChanged += SearchBarOnTextChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.TextChanged -= SearchBarOnTextChanged;
                }
            }
		}

        private static void SearchBarOnTextChanged(object o, EventArgs eventArgs)
        {
            var command = GetTextChangedTo((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }

	}

	public class Sliders {
        public static readonly BindableProperty ValueChangedToProperty =
            BindableProperty.CreateAttached("ValueChangedTo", typeof(ICommand), typeof(Sliders), null, propertyChanged:OnValueChangedToChanged);

        public static ICommand GetValueChangedTo(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ValueChangedToProperty);
        }

		private static void OnValueChangedToChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Slider target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.ValueChanged += SliderOnValueChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.ValueChanged -= SliderOnValueChanged;
                }
            }
		}

        private static void SliderOnValueChanged(object o, EventArgs eventArgs)
        {
            var command = GetValueChangedTo((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }

	}

	public class Steppers {
        public static readonly BindableProperty ValueChangedToProperty =
            BindableProperty.CreateAttached("ValueChangedTo", typeof(ICommand), typeof(Steppers), null, propertyChanged:OnValueChangedToChanged);

        public static ICommand GetValueChangedTo(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ValueChangedToProperty);
        }

		private static void OnValueChangedToChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Stepper target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.ValueChanged += StepperOnValueChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.ValueChanged -= StepperOnValueChanged;
                }
            }
		}

        private static void StepperOnValueChanged(object o, EventArgs eventArgs)
        {
            var command = GetValueChangedTo((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }

	}

	public class Switchs {
        public static readonly BindableProperty ToggledToProperty =
            BindableProperty.CreateAttached("ToggledTo", typeof(ICommand), typeof(Switchs), null, propertyChanged:OnToggledToChanged);

        public static ICommand GetToggledTo(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ToggledToProperty);
        }

		private static void OnToggledToChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Switch target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.Toggled += SwitchOnToggled;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.Toggled -= SwitchOnToggled;
                }
            }
		}

        private static void SwitchOnToggled(object o, EventArgs eventArgs)
        {
            var command = GetToggledTo((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }

	}

	public class SwitchCells {
        public static readonly BindableProperty OnChangedToProperty =
            BindableProperty.CreateAttached("OnChangedTo", typeof(ICommand), typeof(SwitchCells), null, propertyChanged:OnOnChangedToChanged);

        public static ICommand GetOnChangedTo(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(OnChangedToProperty);
        }

		private static void OnOnChangedToChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is SwitchCell target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.OnChanged += SwitchCellOnOnChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.OnChanged -= SwitchCellOnOnChanged;
                }
            }
		}

        private static void SwitchCellOnOnChanged(object o, EventArgs eventArgs)
        {
            var command = GetOnChangedTo((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }

	}

	public class TableViews {
        public static readonly BindableProperty ModelChangedToProperty =
            BindableProperty.CreateAttached("ModelChangedTo", typeof(ICommand), typeof(TableViews), null, propertyChanged:OnModelChangedToChanged);

        public static ICommand GetModelChangedTo(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ModelChangedToProperty);
        }

		private static void OnModelChangedToChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is TableView target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.ModelChanged += TableViewOnModelChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.ModelChanged -= TableViewOnModelChanged;
                }
            }
		}

        private static void TableViewOnModelChanged(object o, EventArgs eventArgs)
        {
            var command = GetModelChangedTo((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }

	}

	public class TapGestureRecognizers {
        public static readonly BindableProperty TappedToProperty =
            BindableProperty.CreateAttached("TappedTo", typeof(ICommand), typeof(TapGestureRecognizers), null, propertyChanged:OnTappedToChanged);

        public static ICommand GetTappedTo(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(TappedToProperty);
        }

		private static void OnTappedToChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is TapGestureRecognizer target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.Tapped += TapGestureRecognizerOnTapped;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.Tapped -= TapGestureRecognizerOnTapped;
                }
            }
		}

        private static void TapGestureRecognizerOnTapped(object o, EventArgs eventArgs)
        {
            var command = GetTappedTo((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }

	}

	public class ToolbarItems {
        public static readonly BindableProperty ActivatedToProperty =
            BindableProperty.CreateAttached("ActivatedTo", typeof(ICommand), typeof(ToolbarItems), null, propertyChanged:OnActivatedToChanged);

        public static ICommand GetActivatedTo(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ActivatedToProperty);
        }

		private static void OnActivatedToChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is ToolbarItem target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.Activated += ToolbarItemOnActivated;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.Activated -= ToolbarItemOnActivated;
                }
            }
		}

        private static void ToolbarItemOnActivated(object o, EventArgs eventArgs)
        {
            var command = GetActivatedTo((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }

	}

	public class VisualElements {
        public static readonly BindableProperty BatchCommittedToProperty =
            BindableProperty.CreateAttached("BatchCommittedTo", typeof(ICommand), typeof(VisualElements), null, propertyChanged:OnBatchCommittedToChanged);

        public static ICommand GetBatchCommittedTo(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(BatchCommittedToProperty);
        }

		private static void OnBatchCommittedToChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is VisualElement target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.BatchCommitted += VisualElementOnBatchCommitted;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.BatchCommitted -= VisualElementOnBatchCommitted;
                }
            }
		}

        private static void VisualElementOnBatchCommitted(object o, EventArgs eventArgs)
        {
            var command = GetBatchCommittedTo((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }

        public static readonly BindableProperty ChildrenReorderedToProperty =
            BindableProperty.CreateAttached("ChildrenReorderedTo", typeof(ICommand), typeof(VisualElements), null, propertyChanged:OnChildrenReorderedToChanged);

        public static ICommand GetChildrenReorderedTo(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(ChildrenReorderedToProperty);
        }

		private static void OnChildrenReorderedToChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is VisualElement target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.ChildrenReordered += VisualElementOnChildrenReordered;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.ChildrenReordered -= VisualElementOnChildrenReordered;
                }
            }
		}

        private static void VisualElementOnChildrenReordered(object o, EventArgs eventArgs)
        {
            var command = GetChildrenReorderedTo((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }

        public static readonly BindableProperty FocusChangeRequestedToProperty =
            BindableProperty.CreateAttached("FocusChangeRequestedTo", typeof(ICommand), typeof(VisualElements), null, propertyChanged:OnFocusChangeRequestedToChanged);

        public static ICommand GetFocusChangeRequestedTo(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(FocusChangeRequestedToProperty);
        }

		private static void OnFocusChangeRequestedToChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is VisualElement target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.FocusChangeRequested += VisualElementOnFocusChangeRequested;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.FocusChangeRequested -= VisualElementOnFocusChangeRequested;
                }
            }
		}

        private static void VisualElementOnFocusChangeRequested(object o, EventArgs eventArgs)
        {
            var command = GetFocusChangeRequestedTo((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }

        public static readonly BindableProperty FocusedToProperty =
            BindableProperty.CreateAttached("FocusedTo", typeof(ICommand), typeof(VisualElements), null, propertyChanged:OnFocusedToChanged);

        public static ICommand GetFocusedTo(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(FocusedToProperty);
        }

		private static void OnFocusedToChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is VisualElement target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.Focused += VisualElementOnFocused;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.Focused -= VisualElementOnFocused;
                }
            }
		}

        private static void VisualElementOnFocused(object o, EventArgs eventArgs)
        {
            var command = GetFocusedTo((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }

        public static readonly BindableProperty MeasureInvalidatedToProperty =
            BindableProperty.CreateAttached("MeasureInvalidatedTo", typeof(ICommand), typeof(VisualElements), null, propertyChanged:OnMeasureInvalidatedToChanged);

        public static ICommand GetMeasureInvalidatedTo(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(MeasureInvalidatedToProperty);
        }

		private static void OnMeasureInvalidatedToChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is VisualElement target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.MeasureInvalidated += VisualElementOnMeasureInvalidated;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.MeasureInvalidated -= VisualElementOnMeasureInvalidated;
                }
            }
		}

        private static void VisualElementOnMeasureInvalidated(object o, EventArgs eventArgs)
        {
            var command = GetMeasureInvalidatedTo((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }

        public static readonly BindableProperty SizeChangedToProperty =
            BindableProperty.CreateAttached("SizeChangedTo", typeof(ICommand), typeof(VisualElements), null, propertyChanged:OnSizeChangedToChanged);

        public static ICommand GetSizeChangedTo(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(SizeChangedToProperty);
        }

		private static void OnSizeChangedToChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is VisualElement target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.SizeChanged += VisualElementOnSizeChanged;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.SizeChanged -= VisualElementOnSizeChanged;
                }
            }
		}

        private static void VisualElementOnSizeChanged(object o, EventArgs eventArgs)
        {
            var command = GetSizeChangedTo((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }

        public static readonly BindableProperty UnfocusedToProperty =
            BindableProperty.CreateAttached("UnfocusedTo", typeof(ICommand), typeof(VisualElements), null, propertyChanged:OnUnfocusedToChanged);

        public static ICommand GetUnfocusedTo(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(UnfocusedToProperty);
        }

		private static void OnUnfocusedToChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is VisualElement target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.Unfocused += VisualElementOnUnfocused;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.Unfocused -= VisualElementOnUnfocused;
                }
            }
		}

        private static void VisualElementOnUnfocused(object o, EventArgs eventArgs)
        {
            var command = GetUnfocusedTo((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }

	}

	public class WebViews {
        public static readonly BindableProperty EvalRequestedToProperty =
            BindableProperty.CreateAttached("EvalRequestedTo", typeof(ICommand), typeof(WebViews), null, propertyChanged:OnEvalRequestedToChanged);

        public static ICommand GetEvalRequestedTo(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(EvalRequestedToProperty);
        }

		private static void OnEvalRequestedToChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is WebView target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.EvalRequested += WebViewOnEvalRequested;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.EvalRequested -= WebViewOnEvalRequested;
                }
            }
		}

        private static void WebViewOnEvalRequested(object o, EventArgs eventArgs)
        {
            var command = GetEvalRequestedTo((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }

        public static readonly BindableProperty GoBackRequestedToProperty =
            BindableProperty.CreateAttached("GoBackRequestedTo", typeof(ICommand), typeof(WebViews), null, propertyChanged:OnGoBackRequestedToChanged);

        public static ICommand GetGoBackRequestedTo(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(GoBackRequestedToProperty);
        }

		private static void OnGoBackRequestedToChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is WebView target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.GoBackRequested += WebViewOnGoBackRequested;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.GoBackRequested -= WebViewOnGoBackRequested;
                }
            }
		}

        private static void WebViewOnGoBackRequested(object o, EventArgs eventArgs)
        {
            var command = GetGoBackRequestedTo((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }

        public static readonly BindableProperty GoForwardRequestedToProperty =
            BindableProperty.CreateAttached("GoForwardRequestedTo", typeof(ICommand), typeof(WebViews), null, propertyChanged:OnGoForwardRequestedToChanged);

        public static ICommand GetGoForwardRequestedTo(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(GoForwardRequestedToProperty);
        }

		private static void OnGoForwardRequestedToChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is WebView target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.GoForwardRequested += WebViewOnGoForwardRequested;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.GoForwardRequested -= WebViewOnGoForwardRequested;
                }
            }
		}

        private static void WebViewOnGoForwardRequested(object o, EventArgs eventArgs)
        {
            var command = GetGoForwardRequestedTo((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }

        public static readonly BindableProperty NavigatedToProperty =
            BindableProperty.CreateAttached("NavigatedTo", typeof(ICommand), typeof(WebViews), null, propertyChanged:OnNavigatedToChanged);

        public static ICommand GetNavigatedTo(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NavigatedToProperty);
        }

		private static void OnNavigatedToChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is WebView target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.Navigated += WebViewOnNavigated;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.Navigated -= WebViewOnNavigated;
                }
            }
		}

        private static void WebViewOnNavigated(object o, EventArgs eventArgs)
        {
            var command = GetNavigatedTo((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }

        public static readonly BindableProperty NavigatingToProperty =
            BindableProperty.CreateAttached("NavigatingTo", typeof(ICommand), typeof(WebViews), null, propertyChanged:OnNavigatingToChanged);

        public static ICommand GetNavigatingTo(BindableObject bindableObject)
        {
            return (ICommand)bindableObject.GetValue(NavigatingToProperty);
        }

		private static void OnNavigatingToChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is WebView target)
            {
                if (oldValue == null && newValue != null)
                {
                    target.Navigating += WebViewOnNavigating;
                }
                else if (oldValue != null && newValue == null)
                {
                    target.Navigating -= WebViewOnNavigating;
                }
            }
		}

        private static void WebViewOnNavigating(object o, EventArgs eventArgs)
        {
            var command = GetNavigatingTo((BindableObject)o);
            if (command.CanExecute(eventArgs))
                command.Execute(eventArgs);
        }

	}

}
