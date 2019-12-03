# EnmityPlugin

## 新OverlayPluginへの対応について

最新の OverlayPlugin は新たに Fork された [ngld/OverlayPlugin](https://github.com/ngld/OverlayPlugin) です。  
[ngld/OverlayPlugin](https://github.com/ngld/OverlayPlugin) は以前のものと互換性がないため、  
ここで公開されている EnmityPlugin を使用することが出来ません。  
したがって、このプラグインの開発も終了しますが、  
敵視情報を取得する機能は [ngld/OverlayPlugin](https://github.com/ngld/OverlayPlugin) で標準搭載されています。

[ngld/OverlayPlugin](https://github.com/ngld/OverlayPlugin) にもいくつかのレガシーな敵視オーバーレイがバンドルもされています。  
また、いままでここで公開されていた EnmityPlugin のオーバーレイを使用したい場合は、  
今後 [qitana/ACT_Overlays](https://github.com/qitana/ACT_Overlays) で公開していきますので、そちらを確認して下さい。

## EffectiveDistance について

魔法やウェポンスキルの距離判定に使用される EffectiveDistance が  
[ngld/OverlayPlugin](https://github.com/ngld/OverlayPlugin) では取得できないという声を聞きましたので、  
[PR#62](https://github.com/ngld/OverlayPlugin/pull/62) を提出しました。

本家のリリースを待ちきれない場合は  
https://github.com/qitana/OverlayPlugin/releases/tag/v0.11.2-tmp-191204  
を使用して下さい。

なお、[qitana/ACT_Overlays](https://github.com/qitana/ACT_Overlays) で公開しているオーバーレイは  
EffectiveDistance の表示に対応しました。

