using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    enum orientation : byte
    {
        北 = 1,
        南 = 2,
        东 = 3,
        西 = 4
    }

    struct route
    {
        public orientation direction;
        public double distance;
    }
    class Program
    {
        static void Main(string[] args)
        {
            route myRoute;
            int myDirection = -1;
            double myDistance;
            Console.WriteLine(" 1)北\n 2)南\n 3)东\n 4)西\n");
            do
            {
                Console.WriteLine("选择一个方向:");
                myDirection = Convert.ToInt16(Console.ReadLine());
            } while (myDirection < 1 || myDirection > 4);

            Console.WriteLine("输入一个距离:");
            myDistance = Convert.ToDouble(Console.ReadLine());

            myRoute.direction = (orientation)myDirection;
            myRoute.distance = myDistance;

            Console.WriteLine("方向是{0},距离是{1}!", myRoute.direction, myRoute.distance);

            Console.ReadKey();
        }
    }
}