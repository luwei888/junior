﻿using BabyStoller.SDK;
using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.Lab2
{
   public class Cow:IAnimal
    {
        public void Voice(int times)
        {
            for (int i = 0; i < times; i++)
            {
                Console.WriteLine("Moo!");
            }
        }
    }
}
