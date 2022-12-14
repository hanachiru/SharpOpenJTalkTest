# 概要
[SharpOpenJTalk.Lang](https://github.com/yamachu/SharpOpenJTalk/tree/master/library/lang)を利用したサンプルプロジェクト。
  
以下の記事で行なっていることを基本的にしています。  
https://www.hanachiru-blog.com/entry/2022/06/20/120000

## 環境
Unity2021.3.0f1

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

## 利用ファイル
Androidの場合は<code>linux (.so)</code>を、iOSの場合は<code>browser-wasm (.a)</code>を利用させていただいています。


## Unityを用いた場合の注意点
Unityには、<code>IL2CPP</code>という<code>iOS</code>ビルドをする途中で<code>IL</code>から<code>C++</code>に変換をする機能があります。
https://docs.unity3d.com/ja/2019.4/Manual/IL2CPP.html

<code>iOS</code>ではこの機能を有効にしなければならないため、<code>C#</code>で書かれた<code>SharpOpenJTalk</code>のコードも対象になっているので注意してください。
https://docs.unity3d.com/ja/2021.3/Manual/ScriptingRestrictions.html

<code>Android</code>では<code>IL2CPP</code>を使わずにビルドすることができます。
  
  
また<code>Android</code>の場合は<code>apk/jar(zip)</code>に圧縮されているため、<code>OpenJTalk</code>のファイル読み込みが正しく動作するのか少し疑問があります。  
(<code>Open_JTalk_load_u16</code>にバイナリを渡せたらよい？)

## xcodeprojに構造について
<code>OpenJTalk</code>は<code>Unity-iPhone/Libraries/Plugins/SharpOpenJTalk</code>に入っています。

## ビルド後のファイル
容量の関係上、以下に格納しました。  
Andriod : https://drive.google.com/drive/folders/11XkyFkTGyxd80b5Ve5Ybs4EtBsJrqDZi?usp=sharing  
iOS(XCode) : https://drive.google.com/drive/folders/11XkyFkTGyxd80b5Ve5Ybs4EtBsJrqDZi?usp=sharing  

### 表示されるエラー
#### Android(ランタイム時)
```
openjtalk-lang assembly:<unknown assembly>type:<unknown type>member(null)
at (wrapper managed-to-native) SharpOpenJTalk.Lang.Native.CoreDefinisions.Open_JTalk_initialize()
at SharpOpenJTalk.Lang.Native.Core.OpenJTalkInitialize () [0x00000] in <7509f7e98da2426bb76f53330369fd5d>:0
at SharpOpenJTalk.Lang.OpenJTalkAPI.Initialize(System.String dictPath, System.String userDictPath)[0x00000] in <7509f7e98da2426bb76f53330369fd5d>:0
at Test.Start()[0x00016] in <7509f7e98da2426bb76f53330369fd5d>:0
```

#### iOS(XCodeビルド時)
```
Undefined symbol: _Open_JTalk_clear
Undefined symbol: _Open_JTalk_dict_gen_u16
Undefined symbol: _Open_JTalk_extract_label_u16
Undefined symbol: _Open_JTalk_initialize
Undefined symbol: _Open_JTalk_load_u16
```

### 補足
エラーメッセージ的にどちらも正しく<code>OpenJTalk</code>を読み込めていないことが原因な気がします。

Unity上の実装の問題である可能性もあります。その場合は申し訳ないです...。

## 参考
[Unity公式のNativePluginsに関するドキュメント](https://docs.unity.cn/ja/2020.3/Manual/NativePlugins.html)  
[AndroidのNativePluginsに関するドキュメント](https://docs.unity3d.com/ja/2019.4/Manual/AndroidNativePlugins.html)  
[iOSのNativePluginsに関するドキュメント](https://docs.unity3d.com/ja/2021.2/Manual/PluginsForIOS.html)
