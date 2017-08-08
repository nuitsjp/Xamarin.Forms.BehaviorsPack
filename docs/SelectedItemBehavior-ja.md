# SelectedItemBehavior

ListViewで選択された行のItemを引数にCommandを実行するシンプルなBehaviorです。
EventToCommandBehaviorでも似たことはできますが、SelectedItemBehaviorはCommand実行後にSelectedItemを解除することができる点が異なります。
解除の有無はClearSelectedプロパティで制御することができ、falseを設定するとCommand実行後も選択されたままになります。  
ClearSelectedプロパティのデフォルト値はtrueです（つまり選択はクリアされます）。

以下がサンプルコードとなります。

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

また、PropertyNameプロパティを指定することで、選択されたItemのプロパティ値を直接渡すことも可能です。  

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
