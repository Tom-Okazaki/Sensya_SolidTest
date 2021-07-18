using System;
//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

namespace PlayerController
{
    interface IGameState{
        void GameState();
    }
    public class HowToControll : IGameState
    {
        public void GameState(){
            //ゲーム中か否かを判別する処理
        }
        //ゲーム中なら発動するinput 系の処理
    }
}