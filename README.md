# 概要
SharpOpenJTalk.Langを利用したサンプルプロジェクト。
  
以下の記事で行なっていることを基本的にしています。  
https://www.hanachiru-blog.com/entry/2022/06/20/120000

## フォルダ構成
Assets
|--- Plugins
|    |--- SharpOpenJTalk
|        |--- NativePlugins(OpenJTalk)
|--- Scripts
|    |--- SharpOpenJTalk(C#ラッパー)
|    |--- Test.cs(SharpOpenJTalkを利用したサンプルコード)
|---- StreamingAssets
     |--- dic_utf_8(辞書)
     
## SharpOpenJTalkの変更点
Unityでの仕様上、iOSビルドをする際に<code>DllName</code>を<code>__Internal</code>に変更しています。
https://github.com/hanachiru/SharpOpenJTalkTest/blob/b24c437fc28940af4227371241bcb4044d914673/Assets/Scripts/SharpOpenJTalk/Native/CoreDefinitions.cs#L8-L14

https://docs.unity3d.com/ja/2021.2/Manual/PluginsForIOS.html

## ビルド後のファイル
容量の関係上、以下に格納しました。
Andriod : 
iOS(XCode) : 
