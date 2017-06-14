# ICommand execution common specification  

Xamarin.Forms.BehaviorsPack, when executing a Command bind to Behavior, it decide the argument of the CanExecute and Execute method of Command according to the following priority order.  

1. CommandParameter
2. EventArgs of events that were a factor in executing behavior.

However, to apply arguments from EventArgs, you must specify one of the following:    
1. EventArgsCoverter  
2. EventArgsPropertyPath  

Priorities are as above.  
When converting EventArgs by IValueConverter, the EventArgsConverterParameter is passed to convert method. 