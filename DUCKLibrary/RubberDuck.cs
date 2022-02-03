using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DUCKLibrary.Interface;

namespace DUCKLibrary
{
    public class RubberDuck : Duck, IQuackable
    {
        public override string Display()
        {
            return "RubberDuck" + " " + this.GetType();
        }
        public string Quack()
        {
            return "Quack" + " " + this.GetType();
        }
    }
}
