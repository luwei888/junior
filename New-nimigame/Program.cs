using System;

namespace New_nimigame
{
    class Program
    {
        static void Main(string[] args)
        {
            int random = new Random().Next(500);
            int number = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("请输入一个数：");
                number = Convert.ToInt32(Console.ReadLine());
                if (number == random)
                {
                    Console.WriteLine("恭喜你答对了！");
                    break;
                }
                else if (number > random)
                {
                    Console.WriteLine($"太大了，继续猜！只剩{9 - i}次了哦！");
                }
                else
                    Console.WriteLine($"太小了，继续猜！只剩{9 - i}次了哦！");
            }
            if(number!=random)
            {
                Console.WriteLine($"你太菜啦！这都不会，正确答案是{random}");
            }
            Console.ReadLine();
        }
    }
}
