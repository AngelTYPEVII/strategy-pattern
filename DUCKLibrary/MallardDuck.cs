using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DUCKLibrary.Interface;

namespace DUCKLibrary
{
    public class MallardDuck : Duck, IQuackable, IFlyable
    {
        public override string Display()
        {
            return "MallardDuck" + " " + this.GetType();
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
