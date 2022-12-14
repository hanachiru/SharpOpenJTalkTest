# 概要
[SharpOpenJTalk.Lang](https://github.com/yamachu/SharpOpenJTalk/tree/master/library/lang)を利用したサンプルプロジェクト。
  
以下の記事で行なっていることを基本的にしています。  
https://www.hanachiru-blog.com/entry/2022/06/20/120000

## Unityのフォルダ構成
```
Assets
|--- Plugins
|    |--- SharpOpenJTalk
|        |--- NativePlugins(OpenJTalk)
|--- Scripts
|    |--- SharpOpenJTalk(C#ラッパー)
|    |--- Test.cs(SharpOpenJTalkを利用したサンプルコード)
|---- StreamingAssets
     |--- dic_utf_8(辞書)
```

## SharpOpenJTalkの変更点
Unityでの仕様上、iOSビルドをする際に<code>DllName</code>を<code>__Internal</code>に変更しています。
https://github.com/hanachiru/SharpOpenJTalkTest/blob/b24c437fc28940af4227371241bcb4044d914673/Assets/Scripts/SharpOpenJTalk/Native/CoreDefinitions.cs#L8-L14

https://docs.unity3d.com/ja/2021.2/Manual/PluginsForIOS.html

## 利用拡張子
Androidの場合は<code>linux (.so)</code>を、iOSの場合は<code>browser-wasm (.a)</code>を利用させていただいています。


## Unityを用いた場合の注意点
Unityには、<code>IL2CPP</code>という<code>iOS</code>ビルドをする途中で<code>IL</code>から<code>C++</code>に変換をする機能があります。
https://docs.unity3d.com/ja/2019.4/Manual/IL2CPP.html

<code>iOS</code>ではこの機能が有効にしなければならないため、<code>C#</code>で書かれた<code>SharpOpenJTalk</code>のコードも対象なっているので注意してください。
https://docs.unity3d.com/ja/2021.3/Manual/ScriptingRestrictions.html

<code>Android</code>では<code>IL2CPP</code>を使わずにビルドすることができます。

## xcodeprojに構造について
<code>OpenJTalk</code>は<code>Unity-iPhone/Libraries/Plugins/SharpOpenJTalk</code>に入っています。

## ビルド後のファイル
容量の関係上、以下に格納しました。  
Andriod :   
iOS(XCode) :   

## 参考
[Unity公式のNativePluginsに関するドキュメント](https://docs.unity.cn/ja/2020.3/Manual/NativePlugins.html)
