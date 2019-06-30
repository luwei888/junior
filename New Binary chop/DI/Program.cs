using System;

namespace DI
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new PhionUser(new NokiaPhion());
            user.UsePhone();
            Console.Read();
        }
    }

    class PhionUser
    {
        private IPhone _phone;
        public PhionUser(IPhone phone)
        {
            _phone = phone;
        }

        public void UsePhone()
        {
            _phone.Dail();
            _phone.Pickup();
            _phone.Send();
            _phone.Receive();
        }

    }

    interface IPhone
    {
        void Dail();
        void Pickup();
        void Send();
        void Receive();
    }

    class NokiaPhion : IPhone
    {
        public void Dail()
        {
            Console.WriteLine("Noika calling...");
        }

        public void Pickup()
        {
            Console.WriteLine("Hello！This is Tim");
        }

        public void Receive()
        {
            Console.WriteLine("Nokia message ring...");
        }

        public void Send()
        {
            Console.WriteLine("Hello!");
        }
    }

    class EricssonPhion : IPhone
    {
        public void Dail()
        {
            Console.WriteLine("Ericsson calling ...");
        }

        public void Pickup()
        {
            Console.WriteLine("Hi! This's Tim!");
        }

        public void Receive()
        {
            Console.WriteLine("Ericssion is ring ...");
        }

        public void Send()
        {
            Console.WriteLine("Good evening!");
        }
    }
}
