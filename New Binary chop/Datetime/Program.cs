using System;
namespace Datetime
{
    class Program
    {
        int number =8;
        static void datetime1(int year, int month, int day)
        {
            DateTime dateTime = new DateTime(year, month, day);
            Console.WriteLine($"当前日期为：{dateTime.Year}年{dateTime.Month}月{dateTime.Day}日");
        }
        protected  enum Date
            {
                周=1 ,
                天=3 ,
                月
            }
        static void Main(string[] args)
        {
            Console.WriteLine("输入当前日期：年/月/日");
            //输入年月日到datetime 函数之中
            Console.Write("年：");
            int year =Convert.ToInt32( Console.ReadLine());
            Console.Write("月：");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.Write("日：");
            int day = Convert.ToInt32(Console.ReadLine());
            datetime1(year, month, day);

            Console.WriteLine("请输入：XX天/周/月,然后回车");
            string Get;
            Get = Console.ReadLine();
            string Unit;
            Unit = Get.Substring(Get.Length - 1, 1);
            string Amount;
            Amount = Get.Substring(0,Get.Length-1);
            int amount = Convert.ToInt32(Amount);

            DateTime dateTime = new DateTime(year, month, day);
            DateTime dateToDisplay;
            
            Enum.TryParse<Date>(Unit, out Date unit);

            switch (unit)
            {
                case Date.周:
                    break;
                case Date.天:
                    break;
                case Date.月:
                    break;
                default:
                    break;
            }

            if (Unit=="天")
            {
                 dateToDisplay = dateTime.AddDays(amount);
            }
            else if (Unit=="周")
            {
                 dateToDisplay = dateTime.AddDays(amount*7);
            }
            else
            {
                 dateToDisplay = dateTime.AddMonths(amount);
            }
            Console.WriteLine($"{amount}{Unit}过后的日期为: {dateToDisplay.Year}年{dateToDisplay.Month}月{dateToDisplay.Day}日");
            Console.WriteLine();
            Console.WriteLine("按回车键退出");
            Console.ReadLine();
        }
    }
}
