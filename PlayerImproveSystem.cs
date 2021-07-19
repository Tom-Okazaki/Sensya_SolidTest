using System;

namespace PlayerImproveSystem
{
    //自分の機体の強化を司る関数です
    class TEST{
        //ここがメインで、プレイヤーに選択させる　⇨　それをもとに実際に強化を反映　⇨　チェック　の順番です
            static void Main(string[] args){
            FacedeOfPlayerImproveSystem FacedeOfPlayerImproveSystem = new FacedeOfPlayerImproveSystem();
            FacedeOfPlayerImproveSystem.PlayerSellectImprove();
            FacedeOfPlayerImproveSystem.Improver();
            FacedeOfPlayerImproveSystem.CHECK();
        }

    }
    class FacedeOfPlayerImproveSystem{
        //Facedeクラス。ここで各関数に送ります　これがあることによって修正や機能増やしが楽になる？
        //このクラスは、いろいろな関数をまとめてくれる、という役割のクラス
        alotofMethod aoM = new alotofMethod();
        public void PlayerSellectImprove(){
            aoM.PSImethod();
        }
        public void Improver(){
            aoM.Improvemethod();
        }
        public void CHECK(){
            aoM.CHECKmethod();
        }
    }

    class alotofMethod{
        //この中身をさらに分けた方が単一責任原則には当てはまる
        //C#はパブリック変数が使えないので、戻り値をうまく使わないと分けられない？
        public int tamanohayasa = 1;
        public int tamanokazu = 1;
        public int idounohayasa = 1;

        public int UserSelectNo = 0;

        public void PSImethod(){
            int x;
            //playerが強化したいものを選ばせる関数、それを数字で返す
            //ここでは代わりにランダム
            Random RD = new System.Random();
            x = RD.Next(1,4);

            UserSelectNo = x;
        }
        public void Improvemethod(){
            if (UserSelectNo == 0){　Console.WriteLine("error UserSelectNO == 0");　}

            else if(UserSelectNo == 1){
                tamanohayasa = tamanohayasa + 1;
                Console.WriteLine("tamanohayasa + 1");
            }
            else if(UserSelectNo == 2){
                tamanokazu = tamanokazu + 1;
                Console.WriteLine("tamanokazu + 1");
            }
            else if(UserSelectNo == 3){
                idounohayasa = idounohayasa + 1;
                Console.WriteLine("idounohayasa + 1");
            }
        }

        public void CHECKmethod(){
            Console.WriteLine("{0},{1},{2}",tamanohayasa, tamanokazu, idounohayasa);
        }
        
    }
}