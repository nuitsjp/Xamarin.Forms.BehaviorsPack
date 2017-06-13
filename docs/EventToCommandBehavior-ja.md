# EventToCommandBehavior  

EventToCommandBehaviorは、UIコントロール側で発生した任意のコマンドに応じて、バインドされたCommandを実行します。  
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
ItemTappedEventArgsには選択されたItemを保持する
Itempプロパティが存在するため、次のようにしている事でCommandに直接タップされた行にバインドされているオブジェクトを渡すことが可能です。  

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

詳細なサンプルは以下をご覧ください。  

[EventToCommandPage.xaml](https://github.com/nuitsjp/Xamarin.Forms.BehaviorsPack/blob/master/src/BehaviorsSampleApp/Views/EventToCommandPage.xaml)  
[EventToCommandPageViewModel.cs](https://github.com/nuitsjp/Xamarin.Forms.BehaviorsPack/blob/master/src/BehaviorsSampleApp/ViewModels/EventToCommandPageViewModel.cs)  

NotificationRequestについては、[こちら](NotificationRequest.md)ドキュメントを参照してください。  
