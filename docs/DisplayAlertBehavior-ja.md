# DisplayAlertBehavior

DisplayAlertを表示し、ユーザー操作にもとづき定義されたCommandを実行します。    
指定したイベントの発生時に表示する方法と、NotificationRequestを利用して（主に）ViewModel側から表示する方法の２種類があります。  

## イベントに応じて表示する  

ユーザーのButtonなどのクリックなどの振る舞いに応じてDisplayAlertを表示し、DisplayAlert上のユーザー操作にもとづきCommandを実行します。  
Buttonのクリック時にDisplayAlertを表示する例を下に示します。  

```xml
<Button Text="Show Display Alert">
    <Button.Behaviors>
        <behaviorsPack:DisplayAlertBehavior
            EventName="Clicked"
            Title="Alert Title"
            Message="Please select either."
            Accept="OK"
            AcceptCommand="{Binding AcceptCommand}"
            Cancel="Cancel"
            CancelCommand="{Binding CancelCommand}"/>
    </Button.Behaviors>
</Button>
```

Buttonをクリックすると次のように振る舞います。  

## NotificationRequestに応じて表示する  

（主に）ViewModel側でのコード実行後にDisplayAlertを表示するために、NotificationRequestを利用することができます。  
この時、XAML上で表示状態を全て定義しておく方法と、NotificationRequestの呼び出し時に一部もしくは全てのDisplayAlertの状態を指定して表示状態をコントロールする、ふたつの選択肢があります。  

### XAML上に定義された状態で表示する  

コード側にNotificationRequestを定義し、必要時にリクエストします。  
まずはコード側を見てみましょう。  

```cs
public NotificationRequest DisplayRequest { get; } = new NotificationRequest();

private void Foo()
{
    ...
    DisplayRequest.Raise();
}
```

このようにNotificationRequestをプロパティとして定義し、必要となった際にRaiseイベントを呼び出してActionSheetを表示します。  
XAML側では、先程はEventNameを指定していましたが、こちらはNotificationRequestプロパティへ、前で定義されたDisplayRequestをバインドします。  
こうすることで、DisplayRequest.Raise()の呼び出し時に、XAMLの定義に従ってActionSheetが表示されます。

```xml
<Button Text="Show Display Alert">
    <Button.Behaviors>
        <behaviorsPack:DisplayAlertBehavior
            NotificationRequest="DisplayRequest"
            Title="Alert Title"
            Message="Please select either."
            Accept="OK"
            AcceptCommand="{Binding AcceptCommand}"
            Cancel="Cancel"
            CancelCommand="{Binding CancelCommand}"/>
    </Button.Behaviors>
</Button>
```

### コード側で表示をコントロールする  

DisplayAlertRequestを利用することで、コード側からActionSheetの表示状態を一部、もしくは全てをコントロールすることが可能です。  
実際に例を見てみましょう。  
コード側では次のようにDisplayAlertRequestを利用します。  

```cs
public DisplayAlertRequest DisplayRequest { get; } = new DisplayAlertRequest();

private void Foo()
{
    ...
	request.Raise(
        "Alert Title", 
        "Please select either.", 
        "OK", 
        "Cancel");
}
```

そしてXAMLには、つぎのように記述します。  

```xml
<Button Text="Show Display Alert">
    <Button.Behaviors>
        <behaviorsPack:DisplayAlertBehavior
            NotificationRequest="DisplayRequest"
            AcceptCommand="{Binding AcceptCommand}"
            CancelCommand="{Binding CancelCommand}"/>
    </Button.Behaviors>
</Button>
```

先ほどのXAMLで定義されたケースと同等のDisplayAlertが表示されます。  
動的にDisplayAlertの表示をコントロールしたい場合は、こちらの方法を利用すると良いでしょう。  

なお、XAML上でも各プロパティが指定されていた場合、DisplayAlertRequestの値が優先されてます。  
DisplayAlertRequest側でnullが指定されていて、XAML上で値が指定されている項目についてはXAML側の定義に従います。  
XAML上で定義されたDisplayAlertBehaviorの振る舞いの全て、もしくは一部をDisplayAlertRequestで変更することが可能です。  
