using System;

namespace tryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            object o2 = null;
            try
            {
                int i2 = (int)o2;   // Error
            }
            catch(Exception e)
            {
                Console.WriteLine("Error"+e);
            }
            Console.Read();
        }
    }
}
