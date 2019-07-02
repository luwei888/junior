using System;

namespace IspExample3
{
    class Program
    {
        static void Main(string[] args)
        {
            var killer = new GentiemanKiller();
            killer.Love();
            var man = killer as IKiller;
            man.Kill();
            Console.Read();
        }
    }

    interface IGentieman
    {
        void Love();
    }

    interface IKiller
    {
        void Kill();
    }

    class GentiemanKiller : IGentieman, IKiller
    {
        public void Love()
        {
            Console.WriteLine("love");
        }

        void IKiller.Kill()
        {
            Console.WriteLine("Kill");
        }
    }
}
