using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace advanceGrammarDemo
{
    public static class throwDemo
    {
        //小马负责这个方法
        public static SLevel Map(int score)
        {
            if (score > 100 || score < 0)
            {
                //小马完全不知道这个方法会被谁调用
                //于是当输入值不符合要求时，直接抛出异常
                throw new ArgumentOutOfRangeException("");
            }

            //if (score >= 90)
            //{
            //return SLevel.Perfect;
            //}
            else if (score >= 80)
            {
                return SLevel.Excellent;
            }
            else if (score >= 60)
            {
                return SLevel.Passed;
            }
            else
            {
                return SLevel.Failed;
            }
        }

        //文轩负责该部分模块
        public static void Congratulate(int score)
        {
            try
            {
                SLevel level = Map(score);
                switch (level)
                {
                    case SLevel.Excellent:
                    case SLevel.Passed:
                        Console.WriteLine($"恭喜你获得{level}级勋章！");
                        break;
                    case SLevel.Failed:
                        Console.WriteLine($"很遗憾，你没有通过测试哟！");
                        break;
                    default:
                        //因为文轩的谨慎，在此后代码发生改动时，及时的暴露了改动造成的问题（演示）
                        throw new NotImplementedException($"输入了{level}级的未处理成绩");
                }
            }
            catch (Exception e)
            {
                //需要记录这些异常信息，看看究竟传入的是什么参数
                File.AppendAllText("E:\\homework\\wx-error.log",
                    $"{DateTime.Now}：输入的{score}未能成功转换");
                //但还是无权吞掉（swallow）这个异常，并且认为这是一个无效转换的异常
                throw new InvalidCastException($"score（${score}）未能成功转换成等级", e);
            }
        }

        //小龙复杂该部分模块
        public static void InputScore()
        {
            //假设没有int.TryParse()方法
            //遇到无法转换成整数的情况，就会抛出异常
            //小龙也不知道该如何处理，所以不予处理
            int score = Convert.ToInt32(Console.ReadLine());
            Congratulate(score);
        }

        public enum SLevel
        {
            //Perfect,
            Excellent,
            Passed,
            Failed
        }
    }
}
