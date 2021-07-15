﻿using System;

public class EnemyType
{
    public string Name{ get; set; }
    public int MoveSpeed{ get; set; }
    public int AttackType{ get; set; }
    public int Image { get; set; }

    public EnemyType(string name, int MS, int AT, int IM){
        this.Name = name;
        this.MoveSpeed = MS;
        this.AttackType = AT;
        this.Image = IM;
    }
    public void Show(){
        Console.WriteLine("名：{0} 速さ:{1} 攻撃タイプ:{2} 画像{3}", Name, MoveSpeed, AttackType,Image);
    }
}

public class EnemyRegister{
    static void Main(){
        EnemyType E1 = new EnemyType("ふつうの敵", 10, 1, 1);
        EnemyType E2 = new EnemyType("はやいてき", 50, 1, 2);
        EnemyType E3 = new EnemyType("変な攻撃の敵", 10, 2, 3);
        E1.Show();
        E2.Show();
        E3.Show();
    }
}