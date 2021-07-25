using System;

namespace KADAI2
{
    public class Kadai2{

        interface IEnemies{
            string Name{ get; set; }
            int HP { get; set; }
        }
        interface IBullets{
            string Name { get; set; }
            int AttackPoint { get; set; }
        }
        interface IHIT{
            int HIT(string Name, int HP, int AttackPoint);
        }
        public class Player{
            public class Bullet : IBullets{
                public string Name { get; set; }
                public int AttackPoint { get; set; }
                public Bullet(string name, int attackpoint){
                    this.Name = name;
                    this.AttackPoint = attackpoint;
                }
                public class BulletHit : IHIT{
                    public int HIT(string Name,int HP,int AttackPoint){
                    HP -= AttackPoint;
                    Console.WriteLine("プレイヤーの弾が{0}に当たりました",Name);
                    return HP;
                    }
                }
            }//Bullet
        }//Player
        public class Enemy : IEnemies{
            public string Name{ get; set; }
            public int HP { get; set; }

            public Enemy(string name,int hp){
            this.Name = name;
            this.HP = hp;
            }

        }
        public class Boss : IEnemies{
            public string Name{ get; set; }
            public int HP { get; set; }

            public Boss(string name, int hp){
                this.Name = name;
                this.HP = hp;
            }
        }
        public class Test{
            public static void Main(){
            IBullets B1 = new Player.Bullet("普通の弾",25);
            IEnemies E1 = new Enemy("エネミー１",200);
            IEnemies BOS1 = new Boss("１面のボス", 500);
            IHIT IHIT = new Kadai2.Player.Bullet.BulletHit();

            Console.WriteLine("{0}のHPは{1}, 弾の攻撃力は{2}",E1.Name,E1.HP,B1.AttackPoint);
            E1.HP = IHIT.HIT(E1.Name,E1.HP,B1.AttackPoint);
            Console.WriteLine("{0}の残りHPは{1}",E1.Name ,E1.HP);
            
            Console.WriteLine("{0}のHPは{1}, 弾の攻撃力は{2}",BOS1.Name,BOS1.HP,B1.AttackPoint);
            BOS1.HP = IHIT.HIT(BOS1.Name,BOS1.HP,B1.AttackPoint);
            Console.WriteLine("{0}の残りHPは{1}",BOS1.Name ,BOS1.HP);
            BOS1.HP = IHIT.HIT(BOS1.Name,BOS1.HP,B1.AttackPoint);
            Console.WriteLine("{0}の残りHPは{1}",BOS1.Name ,BOS1.HP);
            }
        }
    }
}