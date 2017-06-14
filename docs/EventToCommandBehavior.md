# EventToCommandBehavior  

Execute ICommand when an event fires in UI Controls.

For example, ItemTapped event of ListView does not provide a property to bind Command.  
The following code executes ICommand when firing the Itemtapped event.  

```xml
<ListView ItemsSource="{Binding Fruits}">
    <ListView.Behaviors>
        <behaviorsPack:EventToCommandBehavior
            EventName="ItemTapped"
            Command="{Binding SelectedFruitCommand}"/>
    </ListView.Behaviors>
```

You can also pass any property of EventArgs to the ICommand by specifying the event's properties.  
[ItemTappedEventArgs](https://developer.xamarin.com/api/type/Xamarin.Forms.ItemTappedEventArgs/) is fired when the ListView's ItemTapped event occurs.
ItemTappedEventArgs has Item property that holds the tapped item.
Therefore, by specifying EventArgsPropertyPath, it is possible to pass tapped objects to ICommand.

```xml
<ListView ItemsSource="{Binding Fruits}">
    <ListView.Behaviors>
        <behaviorsPack:EventToCommandBehavior
            EventName="ItemTapped"
            Command="{Binding SelectedFruitCommand}"
            EventArgsPropertyPath="Item"/>
    </ListView.Behaviors>
```

```cs
public ICommand SelectedFruitCommand => new Command<Fruit>(fruits =>
{
    ...
});
```

## Related References

* [ICommand execution common specification](CommandExecutionSpecifation.md)  

## Sample Codes

[EventToCommandPage.xaml](https://github.com/nuitsjp/Xamarin.Forms.BehaviorsPack/blob/master/src/BehaviorsSampleApp/Views/EventToCommandPage.xaml)  
[EventToCommandPageViewModel.cs](https://github.com/nuitsjp/Xamarin.Forms.BehaviorsPack/blob/master/src/BehaviorsSampleApp/ViewModels/EventToCommandPageViewModel.cs)  
