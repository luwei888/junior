using System;

namespace How_many_english_word
{
    class Program
    {
        static void Main(string[] args)
        {
            string demo = "Yuanzhan, one of the most famous training course，" +
                "who aim to provide the best service for those who want to change their" +
                " life by learning computer program skill was created by Mr.YeFei, a who  " +
                " first was a lawyer after graduted  from the Southwest University of Political " +
                "Science and Law with the Economic and Law bachelor degrees in 20 02 but   " +
                "at last came into the IT field as a software developer in 200 7.... ..";
            int number = 0;
            int i = 0;
            int temp = 0;
            char[] check = new char[demo.Length];
            foreach (char ch in demo)
            {
                check[i] = Convert.ToChar(ch);
                temp = Convert.ToInt32(ch);
                if (!((temp >= 65 & temp <= 90) | (temp >= 97 & temp <= 122)))
                {
                    temp = Convert.ToInt32(check[i - 1]);
                    if ((temp >= 65 & temp <= 90) | (temp >= 97 & temp <= 122))
                    {
                        number++;
                    }
                }
                i++;
            }
            Console.WriteLine();
            Console.WriteLine($"英文单词数量为：{number}");
            Console.ReadLine();
        }
    }
}
