# EventToCommandBehavior  

画面要素で発生した任意のイベントに応じて、対応するCommandを実行します。  

たとえば、ListViewのItemTappedイベントには、Commandをバインドするプロパティは用意されていません。  
つぎのように実装することで、ItemTappedイベント発生時にバインドされたCommandを実行します。  

```xml
<ListView ItemsSource="{Binding Fruits}">
    <ListView.Behaviors>
        <behaviorsPack:EventToCommandBehavior
            EventName="ItemTapped"
            Command="{Binding SelectedFruitCommand}"/>
    </ListView.Behaviors>
```

また、Eventのプロパティを指定することで、CommandにEventの任意のプロパティを渡すことができます。  
ListViewのItemTappedイベント発生時は、[ItemTappedEventArgs](https://developer.xamarin.com/api/type/Xamarin.Forms.ItemTappedEventArgs/)が発行されます。  
ItemTappedEventArgsには選択されたItemを保持するItemプロパティが存在します。  
このためEventArgsPropertyPathを指定することで、タップされた行にバインドされているオブジェクトをICommandへ直接渡すことが可能です。

```xml
<ListView ItemsSource="{Binding Fruits}">
    <ListView.Behaviors>
        <behaviorsPack:EventToCommandBehavior
            EventName="ItemTapped"
            Command="{Binding SelectedFruitCommand}"
            EventArgsPropertyPath="Item"/>
    </ListView.Behaviors>
```

引数を受け取るためにはCommandを次のように実装します。  

```cs
public ICommand SelectedFruitCommand => new Command<Fruit>(fruits =>
{
    ...
});
```

上の例では、ListViewにはFruitクラスの集合がバインドされており、Commandの引数では選択されたFruitオブジェクトが受け渡されます。  

コマンド引数についての詳細な仕様は、つぎをご覧ください。  

* [Commandの実行仕様について](CommandExecutionSpecifation-ja.md)  

また、詳細なサンプルは以下をご覧ください。  

[EventToCommandPage.xaml](https://github.com/nuitsjp/Xamarin.Forms.BehaviorsPack/blob/master/src/BehaviorsSampleApp/Views/EventToCommandPage.xaml)  
[EventToCommandPageViewModel.cs](https://github.com/nuitsjp/Xamarin.Forms.BehaviorsPack/blob/master/src/BehaviorsSampleApp/ViewModels/EventToCommandPageViewModel.cs)  
