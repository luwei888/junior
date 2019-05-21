using System;
using System.Collections;

namespace CollectionsApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable
            {
                { "001", "Zara Ali" },
                { "002", "Abida Rehman" },
                { "003", "Joe Holzner" },
                { "004", "Mausam Benazir Nur" },
                { "005", "M. Amlan" },
                { "006", "M. Arif" },
                { "007", "Ritesh Saikia" }
            };

            if (ht.ContainsValue("Nuha Ali"))
            {
                Console.WriteLine("This student name is already in the list");
            }
            else
            {
                ht.Add("008", "Nuha Ali");
            }
            // 获取键的集合
            ICollection key = ht.Keys;



            foreach (string k in key)
            {
                Console.WriteLine(k + ": " + ht[k]);  
            }
            Console.ReadKey();
        }
    }
}