# Xamarin.Forms.BehaviorsPack

Xamarin.Forms.BehaviorsPackはXamarin.Forms用の汎用的なクラスライブラリです。  
このライブラリには次のようなBehavior実装が含まれます。  

|名称|概要|
|:--|:--|
|[EventToCommandBehavior](docs/EventToCommandBehavior-ja.md)|画面要素で発生した任意のイベントに応じて、対応するCommandを実行します|
|[DisplayActionSheetBehavior](docs/DisplayActionSheetBehavior-ja.md)|ActionSheetを表示し、ユーザー操作に対応するCommandを実行します|
|[DisplayAlertBehavior](doc/DisplayAlertBehavior-ja.md)|Alertを表示し、ユーザー操作に対応するCommandを実行します|
|NotificationBehavior|コード（主にViewModel）からの要求をイベントとして通知します|

これら以外に、Behavior実装を容易にするいくつかの抽象クラスを含みます。  

このライブラリはMVVMパターンを採用した際に、ViewとViewModel間の相互作用の実装を容易にします。  
たとえばEventToCommandBehaviorは、Viewで発生したイベントに応じて、ViewModel上のICommandを実行します。  
またDisplayAlertBehaviorは、Viewで発生したイベントに応じてDisplayAlertを表示し、ユーザー操作に応じたICommandを実行します。    

## インストール  

NuGetからインストールします。  

```
> Install-Package Xamarin.Forms.BehaviorsPack
```

[https://www.nuget.org/packages/Xamarin.Forms.BehaviorsPack](https://www.nuget.org/packages/Xamarin.Forms.BehaviorsPack)

## 前提条件  

本ライブラリのサンプルコードでは、XAMLの冒頭に次のように名前空間を宣言してあることを前提とします。  

```xml
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://xamarin.com/schemas/2014/forms"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:behaviorsPack="clr-namespace:Xamarin.Forms.BehaviorsPack;assembly=Xamarin.Forms.BehaviorsPack"
```

## 利用方法  

各Behaviorの利用方法は以下を参照ください。  

* [EventToCommandBehavior](docs/EventToCommandBehavior-ja.md)  
* [DisplayActionSheetBehavior](docs/DisplayActionSheetBehavior-ja.md)  
* [DisplayAlertBehavior](doc/DisplayAlertBehavior-ja.md)

また併せてつぎもご覧ください。  

* [Commandの実行仕様について](CommandExecutionSpecifation-ja.md)  