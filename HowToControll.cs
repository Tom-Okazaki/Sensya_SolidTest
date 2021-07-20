using System;
//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

namespace PlayerController
{
    interface IGameState{//これがあることによりゲーム中かどうかの判定の処理を書き換える時もかんたん
        void GameState();
    }
    public class HowToControll : IGameState
    {
        int nowgame = 0;//ゲーム中か否かを判別する変数
        public void GameState(){
            //ゲーム中か否かを判別する処理
        }
        //ゲーム中なら発動するinput系の処理やポーズ画面の時のベクトル保存などのクラスも作れる
        //死亡時のレンダー変更やシーン遷移クラスも作れそう（同じネームスペースで別.CS）
    }
}