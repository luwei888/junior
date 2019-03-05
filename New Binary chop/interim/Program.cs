
using interim;
using System;

class Program
{
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

        Console.ReadLine();
    }
    
}