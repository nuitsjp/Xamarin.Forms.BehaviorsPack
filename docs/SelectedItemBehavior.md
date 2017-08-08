# SelectedItemBehavior

SelectedItemBehavior to execute the command when the SelectedItem event occurs in ListView.
Pass the item selected in ListView to Command.
If ClearSelected property is true, SelectedItem property of ListView is cleared after command execution.
Default ClearSelected property value is true.

XAML Sample.
```xml
<ListView ItemsSource="{Binding Fruits}">
    <ListView.Behaviors>
        <behaviorsPack:SelectedItemBehavior Command="{Binding SelectedFruitCommand}"/>
    </ListView.Behaviors>
```

C#(ViewModel) Sample
```cs
public IList<Fruit> Fruits { get; } = new List<Fruit>();

public ICommand SelectedFruitCommand => new Command<Fruit>(fruit =>
{
    ....
});
```

You can also pass the property value of the selected item directly by specifying the PropertyName property.  

XAML Sample.
```xml
<ListView ItemsSource="{Binding Fruits}">
    <ListView.Behaviors>
        <behaviorsPack:SelectedItemBehavior Command="{Binding SelectedFruitCommand}" PropertyName="Name"/>
    </ListView.Behaviors>
```

C#(ViewModel) Sample
```cs
public IList<Fruit> Fruits { get; } = new List<Fruit>();

public ICommand SelectedFruitCommand => new Command<string>(fruitName =>
{
    ....
});
```
