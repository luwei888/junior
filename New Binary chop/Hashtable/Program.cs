using System;
using System.Collections;

namespace CollectionsApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();


            ht.Add("001", "luwei");
            ht.Add("002", "feige");
            ht.Add("003", "xiaolong");
            ht.Add("004", "laocheng");
            ht.Add("005", "M. Amlan");
            ht.Add("006", "M. Arif");
            ht.Add("007", "Ritesh Saikia");

            if (ht.ContainsValue("laozhao"))
            {
                Console.WriteLine("this list have laozhao!");
            }
            else
            {
                ht.Add("008", "laozhao");
            }

            ICollection key = ht.Keys;

            foreach (string k in key)
            {
                Console.WriteLine(k+""+ht[k]);
            }
            Console.Read();
        }
    }
}