
using interim;
using System;

class Program
{

    static void enemyFighter(AirDefense airDefense)
    {
        //其他code

        //FindEnemy();          发现敌机
        airDefense.Shoot();     //究竟是什么airDefense开火由传入参数决定
                                //notifyHeadquater();   通知指挥部

        //其他code....
    }



    static void Main(string[] args)
    {
        int matcher = 500;

        ArraySeek arrarSeek = new ArraySeek();

        //使用飞哥方法！
        BinarySeek binarySeek = new FeiGeBinSeek();
        arrarSeek.Target(binarySeek,matcher);
        Console.WriteLine();

        //使用路炜方法！
        binarySeek = new LuWeiBinSeek();
        arrarSeek.Target(binarySeek, matcher);




        //东方一号导弹发射
        AirDefense airDefense = new MissleAirDefense();
        enemyFighter(airDefense);

        //高射炮开火
        airDefense = new FlakAirDefense();
        enemyFighter(airDefense);


        Console.ReadLine();
    }
}