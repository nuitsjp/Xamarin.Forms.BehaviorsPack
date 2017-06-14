# DisplayActionSheetBehavior

Display ActionSheet and execute ICommand corresponding to user operation.   
DisplayActionSheetBehavior can select from several display trigger and visibility.

1. Display in a state defined in XAML, depending on UI Control events
2. Display on request from code  
    1. Display in a state defined in XAML  
    2. Specify display state from code  

## Display in a state defined in XAML, depending on UI Control events  

Displays the Actionsheet, depending on the user's button click etc, and executes the command based on the user operation on the Actionsheet.  
Example to display ActionSheet when the button is clicked.  

```xml
<Button Text="Show ActionSheet">
    <Button.Behaviors>
        <behaviorsPack:DisplayActionSheetBehavior
            EventName="Clicked"
            Title="ActionSheet Title"
            Cancel="Cancel"
            CancelCommand="{Binding CancelCommand}"
            Destruction="Delete"
            DestructionCommand="{Binding DestructionCommand}">
            <behaviorsPack:ActionSheetButton 
                Message="First Action Sheet Item"
                Command="{Binding FirstActionSheetCommand}"/>
            <behaviorsPack:ActionSheetButton 
                Message="Second Action Sheet Item"
                Command="{Binding SecondActionSheetCommand}"/>
        </behaviorsPack:DisplayActionSheetBehavior>
    </Button.Behaviors>
</Button>
```

Click the button to display the following Actionsheet.  

![](images/DisplayActionSheetBehavior.png)

## Display on request from code  

DisplayActionSheetBehavior can display Actionsheet on request from code.  
State of ActionSheet to display at this time can be specified in two ways.  
1. Display in a state defined in XAML  
2. Specify display state from code  

### Display in a state defined in XAML  

Define the Notificationrequest in the code and raise it when necessary.    

```cs
public NotificationRequest DisplayRequest { get; } = new NotificationRequest();

private void Foo()
{
    ...
    DisplayRequest.Raise();
}
```

Bind the DisplayRequest property to NotificationRequest properties of DisplayActionSheetBehavior on XAML.  

```xml
<Button Text="Show ActionSheet">
    <Button.Behaviors>
        <behaviorsPack:DisplayActionSheetBehavior
            NotificationRequest="{Binding DisplayRequest}"
            Title="ActionSheet Title"
            Cancel="Cancel"
            CancelCommand="{Binding CancelCommand}"
            Destruction="Delete"
            DestructionCommand="{Binding DestructionCommand}">
            <behaviorsPack:ActionSheetButton 
                Message="First Action Sheet Item"
                Command="{Binding FirstActionSheetCommand}"/>
            <behaviorsPack:ActionSheetButton 
                Message="Second Action Sheet Item"
                Command="{Binding SecondActionSheetCommand}"/>
        </behaviorsPack:DisplayActionSheetBehavior>
    </Button.Behaviors>
</Button>
```

### Specify display state from code  

By using DisplayActionSheetRequest, it is possible to control some or all of the display state of ActionSheet from the code.  

Use the following DisplayActionSheetRequest in the code.  

```cs
public DisplayActionSheetRequest DisplayRequest { get; } = new DisplayActionSheetRequest();

private void Foo()
{
    ...
    var cancel = 
        new ActionSheetButtonAction 
        { 
            Message = "Cancel", 
            Action = () => {
                // Process on Cancel Click
                ...
            }
        };
	var destruction = 
        new ActionSheetButtonAction 
        { 
            Message = "Delete", 
            Action = () => {
                // Process on Delete Click
                ...
            }
	var firstActionSheetButton = 
        new ActionSheetButtonAction 
        { 
            Message = "First Action Sheet Item", 
            Action = () => {
                // Process on "First Action Sheet Item" Click
                ...
            } 
        };
    var seciondActionSheetButton = 
        new ActionSheetButtonAction 
        { 
            Message = "Second Action Sheet Item", 
            Action = () => {
                // Process on "Second Action Sheet Item" Click
                ...
            } 
        };

	request.Raise(
        "Title", cancel, destruction, firstActionSheetButton, seciondActionSheetButton);
}
```

XAML is written as:  

```xml
<ContentPage.Behaviors>
    <behaviorsPack:DisplayActionSheetBehavior
        NotificationRequest="{Binding DisplayRequest}"/>
</ContentPage.Behaviors>
```

Displays the same Actionsheet as the case defined in the previous XAML.  

If each property was specified in XAML, the value of DisplayActionSheetreRequest is overridden.  
If NULL is specified on the DisplayActionSheetreRequest side, it follows the definition of XAML.  
DisplayActionSheetreRequest can change all or part of the DisplayActionSheetBehavior defined in XAML.  

## Related References

* [ICommand execution common specification](CommandExecutionSpecifation.md)  
