using System;
using System.Collections.Generic;

namespace Generic
{
    public class Article<T>
    {
        internal T Author;
        internal T Title;
        internal T Body;
        internal int agree;
        internal int disagree;
        internal Appraise<T> appraise;
        public List<Comment<string>> ProComment = new List<Comment<string>>();
        public List<Keyword<T>> keywords = new List<Keyword<T>>();

        internal Article(T author, T title, T body)
        {
            Author = author;
            Title = title;
            Body = body;
            agree = 0;
            disagree = 0;
        }

        internal void publish()
        {
            Console.WriteLine("作者:" + Author);
            Console.WriteLine("标题:" + Title);
            Console.WriteLine("正文:" + Body);
        }

        internal void Agree()
        {
            agree++;
        }

        internal void Disagree()
        {
            disagree++;
        }

    }

    public class Comment<T>
    {
        internal T Author;
        internal T Title;
        internal T Body;
        internal int agree;
        internal int disagree;
        internal Article<T> article;
        internal Appraise<T> appraise;

        internal Comment(T author, T title, T body, Article<T> art)
        {
            Author = author;
            Title = title;
            Body = body;
            agree = 0;
            disagree = 0;
            article = art;
        }

        internal void publish()
        {
            Console.WriteLine("作者:" + Author);
            Console.WriteLine("标题:" + Title);
            Console.WriteLine("正文:" + Body);
            Console.WriteLine("文章" + article);
        }

        internal void Agree()
        {
            agree++;
        }

        internal void Disagree()
        {
            disagree++;
        }
    }

    public class Appraise<T>
    {

        internal T Author;
        internal T Title;
        internal T Body;
        internal int agree;
        internal int disagree;

        internal Appraise(T author, T title, T body)
        {
            Author = author;
            Title = title;
            Body = body;
            agree = 0;
            disagree = 0;
        }

        internal void publish()
        {
            Console.WriteLine("作者:" + Author);
            Console.WriteLine("标题:" + Title);
            Console.WriteLine("正文:" + Body);
        }

        internal void Agree()
        {
            agree++;
        }

        internal void Disagree()
        {
            disagree++;
        }

    }

    public class Keyword<T>
    {
        internal T keyword;
        public List<Article<T>> articles = new List<Article<T>>();

        internal Keyword(T key)
        {
            keyword = key;
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            Article<string> SQL = new Article<string>("luwei", "SQL语言", "SQL server");
            SQL.publish();
            SQL.Agree();
            SQL.Agree();
            Console.WriteLine(SQL.agree);

            Comment<string> useSql = new Comment<string>("xiaolong", "SQL sever", "How to use SQL sever", SQL);
            useSql.publish();
            SQL.ProComment.Add(useSql);

            Comment<string> learnSql = new Comment<string>("laocheng", "SQL sever", "How to learn SQL sever", SQL);
            learnSql.publish();
            SQL.ProComment.Add(learnSql);

            foreach (var item in SQL.ProComment)
            {
                Console.WriteLine(item.Body);
            }

            Console.Read();
        }
    }
}
