using System;

namespace Demo
{
    class Beauty
    {

        public string GetFirstName()
        {
            return FirstName;
        }

        public void SetFristName(string newFirstName)
        {
            FirstName = newFirstName;
        }

        private string FirstName;


    }

    class Beauty2
    {

        private string _FirstName;

        public string FirstName
        {
            get
            {
                return _FirstName;
            }
            set
            {
                _FirstName = value;
            }
        }
    }
    
    class Beauty3
    {
        public string FirstName { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Beauty lin = new Beauty();
            lin .SetFristName("Enya");
            lin .GetFirstName();
            Console.WriteLine(lin.GetFirstName());

            Beauty2 wang = new Beauty2();
            wang.FirstName="wang";
            Console.WriteLine(wang.FirstName);

            Beauty3 liu = new Beauty3();
            liu.FirstName = "liu";
            Console.WriteLine(liu.FirstName);
            Console.ReadLine();
        }
    }
}
