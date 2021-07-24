using System;

namespace KADAI2
{
    public class Kadai2{
        public class Player{
            public class Bullet{
                public string Name { get; set; }
                public int AttackPoint { get; set; }
                public Bullet(string name, int attackpoint){
                    this.Name = name;
                    this.AttackPoint = attackpoint;
                }
                public class BulletHit{
                    public int HIT(string Name,int HP,int AttackPoint){
                    int x;
                    x = HP - AttackPoint;
                    Console.WriteLine("プレイヤーの弾が{0}に当たりました",Name);
                    return x;
                    }
                }
            }//Bullet
        }//Player

        public class Enemy{
            public string Name{ get; set; }
            public int HP { get; set; }

            public Enemy(string name,int hp){
            this.Name = name;
            this.HP = hp;
            }

        }
        public class Boss{
            public string Name{ get; set; }
            public int HP { get; set; }

            public Boss(string name, int hp){
                this.Name = name;
                this.HP = hp;
            }

        }
        public static void Main(){
            Player.Bullet B1 = new Player.Bullet("普通の弾",25);
            Enemy E1 = new Enemy("エネミー１",200);
            Boss BOS1 = new Boss("１面のボス", 500);
            Kadai2.Player.Bullet.BulletHit BH = new Kadai2.Player.Bullet.BulletHit();

            Console.WriteLine("エネミーのHPは{0}, 球の攻撃力は{1}",E1.HP,B1.AttackPoint);
            Console.WriteLine("エネミーの残りHPは" + BH.HIT(E1.Name,E1.HP,B1.AttackPoint));
            Console.WriteLine("BOSSのHPは{0}, 弾の攻撃力は{1}",BOS1.HP,B1.AttackPoint);
            Console.WriteLine("BOSの残りHPは" + BH.HIT(BOS1.Name,BOS1.HP,B1.AttackPoint));
        }
    }
}