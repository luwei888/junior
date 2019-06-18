using System;
using System.IO;
using System.Linq;
using System.Threading;
using System.Xml.Linq;

namespace advanceGrammarDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //CreatDoubleLink.Call();

            //while (true)
            //{
            //    //老程调用InputScore()，发现
            //    //1、该方法可能抛出异常，
            //    //2、且不愿让异常导致程序崩溃
            //    //于是只能try...catch进行处理
            //    try
            //    {
            //        throwDemo.InputScore();
            //    }
            //    catch (Exception e)
            //    {
            //        File.AppendAllText("E:\\homework\\lc-error.log", e.ToString());
            //        //给用户一个友好提示
            //        Console.WriteLine("程序遇到了未处理的异常情况，请稍后重试或者联系我们……");
            //        Console.WriteLine();
            //        //因为这里是入口（顶级）函数，不需要再throw;了
            //    }
            //}

            //student yuanzhan = new student();

            //foreach (var item in yuanzhan)
            //{
            //    Console.WriteLine(item);
            //}



            //LinqToXML Xml = new LinqToXML();

            ////Console.WriteLine(Xml.luckystack);

            //XDocument document = new XDocument(
            //    new XDeclaration("1.0", "utf-8", "yes")
            //    , Xml.luckystack);

            //document.Save("E:\\homework\\luckystack.xml");

            //XElement element = XElement.Load("E:\\homework\\luckystack.xml");

            //var rootNode = element.FirstNode.NextNode;

            //rootNode.AddAfterSelf(new XElement("article", new XElement("id"),
            //    new XElement("title", "新加的内容"), new XElement("authorId")));

            //var id = from x in element.Descendants()
            //         where x.Name == "id"
            //         where x.Value == "1"
            //         select x;
            //var article = from x in element.Descendants()
            //              where x.Name == "article"
            //              where x.FirstNode == id.First()
            //              select x;

            //article.First().Remove();
            //Console.WriteLine(element);
            //Console.Read();



        }

    }
}
