■これなに？

VRMにパーツを付け足すことが出来ます。

■使い方１

1.VRM_PartsAdder.exeを起動します。
2.画面左上の「VRM読み込み」ボタンでVRMファイルを読み込みます。
3.画面左上の「パーツ読み込み」ボタンでパーツのファイルを読み込みます。※1
4.読み込んだパーツの水色半透明領域をクリックすることでパーツを選択します。
5.パーツの位置、向き、大きさを調整します。※2
6.画面右下の各部位のボタンでパーツの装着先を設定します。
7.画面左上の「VRM書き出し」ボタンでVRMファイルを書き出します。

※1.対応形式は主にFBXとGLBです。
　　「パーツ読み込み」ボタンの下に3つのトグルボタンがあります。
　　パーツのテクスチャに合わせて以下のように選択します。
　　テクスチャに透明部分がない場合は「透明なし」を選択
　　テクスチャに透明部分がある場合は「透明あり」を選択
　　テクスチャに半透明部分がある場合は「半透明あり」を選択
※2.画面左上の「移動」「回転」「大きさ」チェックボックスで操作方法を変更出来ます。

動画
https://youtu.be/LRE6teJd70Y

■使い方２（テクスチャが白い問題の解決）

付け足したパーツが白い場合は以下のツールで対応します。
VRMテクスチャ差し替えるやつ
https://120byte.booth.pm/items/2177538

こちらのツールで真っ白になっているテクスチャを探し
付け足したパーツのテクスチャを選択します。

■使い方３（他モデルからのパーツ移植）

他モデルからパーツを移植することが出来ます。
VRMの初期状態変えるやつ
https://120byte.booth.pm/items/3737951

こちらのツールで他モデルのパーツのみが表示されているVRMを作成します。
※注意：対象のパーツがメッシュで分かれている必要があります。
作成したパーツだけのVRMを「UniVRM」にチェックを入れた状態にして
「パーツ読み込み」ボタンで読み込み装着します。

例
https://twitter.com/120byte/status/1535635325271277568

■おまけ

uniRibbonフォルダにサンプルパーツが同梱されています。
こちらのサンプルパーツで操作をお試し頂けます。

サンプルパーツのライセンス
© Unity Technologies Japan／UCL
https://unity-chan.com/contents/guideline/

■作った人

120
https://twitter.com/120byte

■免責

本ソフトウェアの利用により発生した問題は、
本ソフトウェア利用者の責任とし、
本ソフトウェア作成者は一切の責任を負わないものとします。

■改版履歴

20220401
初版

20220405
パーツ未選択状態で削除ボタンを押すと水色キューブが残ってしまう不具合修正
パーツのテクスチャに合わせた読み込みに対応

20220612
UniVRM式の読み込み対応

■ライセンス

---------------------------------------------------------------------------------------------------
UniVRM
---------------------------------------------------------------------------------------------------

MIT License

Copyright (c) 2020 VRM Consortium
Copyright (c) 2018 Masataka SUMI for MToon

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

---------------------------------------------------------------------------------------------------
UnityStandaloneFileBrowser
---------------------------------------------------------------------------------------------------

MIT License

Copyright (c) 2017 Gökhan Gökçe

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

---------------------------------------------------------------------------------------------------
