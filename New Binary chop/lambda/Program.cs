using System;

namespace lambda
{

    public class Button
    {
        public event EventHandler Onclick;
        public void click()
        {
            if (Onclick!=null)
            {
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
