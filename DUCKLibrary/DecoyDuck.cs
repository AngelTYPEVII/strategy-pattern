﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DUCKLibrary
{
    public class DecoyDuck : Duck
    {
        public override string Display()
        {
            return "DecoyDuck" + " " + this.GetType();
        }
    }
}
