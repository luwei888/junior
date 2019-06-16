using System;
using System.IO;

namespace advanceGrammarDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //CreatDoubleLink.Call();

            while (true)
            {
                //老程调用InputScore()，发现
                //1、该方法可能抛出异常，
                //2、且不愿让异常导致程序崩溃
                //于是只能try...catch进行处理
                try
                {
                   throwDemo.InputScore();
                }
                catch (Exception e)
                {
                    File.AppendAllText("E:\\homework\\lc-error.log", e.ToString());
                    //给用户一个友好提示
                    Console.WriteLine("程序遇到了未处理的异常情况，请稍后重试或者联系我们……");
                    Console.WriteLine();
                    //因为这里是入口（顶级）函数，不需要再throw;了
                }
            }
        }
    }
}
