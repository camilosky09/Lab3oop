﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3oop
{
    class Cat : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Cats eat mice");
        }
    }
}
