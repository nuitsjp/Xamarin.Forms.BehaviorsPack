# NotificationBehavior

コード（主にViewModel）からの要求をイベントとして通知します。    
主にViewModelの状態変化などに応じて、Viewの共通化しづらい実装を呼び出すことに利用します。  

ログイン画面からメイン画面への遷移後に、ログイン画面をNavigationStackから削除する。といった用途に利用できます。  
