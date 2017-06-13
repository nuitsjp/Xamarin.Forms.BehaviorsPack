# Xamarin.Forms.BehaviorsPack

Xamarin.Forms.BehaviorsPackはXamarin.Forms用の汎用的なクラスライブラリです。  
このライブラリには次のようなBehavior実装が含まれます。  

* EventToCommandBehavior  
* DisplayActionSheetBehavior  
* DisplayAlertBehavior  
* NotificationBehavior  

これら以外に、Behavior実装を容易にするいくつかの抽象クラスを含みます。  

このライブラリはMVVMパターンを採用した際に、ViewとViewModel間の実装を容易にします。  
たとえばEventToCommandBehaviorは、Viewで発生したイベントに応じて、任意のICommandを実行します。  
またDisplayAlertBehaviorは、Viewで発生したイベントに応じてDisplayAlertを表示し、ユーザー操作に応じたICommandを実行します。    

## インストール  

NuGetからインストールします。  
NuGetパッケージマネージャーで次のコードを実行してください。  

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
