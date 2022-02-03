﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DUCKLibrary.Interface;

namespace DUCKLibrary
{
    public class RedheadDuck : Duck, IQuackable, IFlyable
    {
        public override string Display()
        {
            return "RedheadDuck" + " " + this.GetType();
        }
        public string Quack()
        {
            return "Quack" + " " + this.GetType();
        }
        public string Fly()
        {
            return "Fly" + " " + this.GetType();
        }
    }
}
