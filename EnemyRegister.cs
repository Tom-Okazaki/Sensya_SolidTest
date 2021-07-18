using System;

/* ソリッド原則を意識

ブランチtest1でこの文を追加

git merge (test1 から　master に反映）のときこの文を追加*/

namespace EnemyMove{
public interface Itest{
    void test();
}

public class  EnemyType
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

public class EnemyRegister : Itest{
    public void test(){

        Console.WriteLine("aiueo");
    }
    

    public static void Main(){ 
        EnemyRegister EnRg = new EnemyRegister();
        EnRg.test();

        EnemyType E1 = new EnemyType("ふつうの敵", 10, 1, 1);
        EnemyType E2 = new EnemyType("はやいてき", 50, 1, 2);
        EnemyType E3 = new EnemyType("変な攻撃の敵", 10, 2, 3);
        EnemyType E4 = new EnemyType("test", 7, 7, 7);

        E1.Show();
        Console.WriteLine(E1.Name);

    }
}
}