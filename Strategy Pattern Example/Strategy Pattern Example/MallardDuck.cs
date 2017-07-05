using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategy_Pattern_Example.Fly;

namespace Strategy_Pattern_Example
{
    class MallardDuck: Duck
    {
        public MallardDuck()
        {
            SetQuackBehaviour(new Quack.Quack());//Because I named the containing folder the same as the class name. D'oh.
            SetFlyBehaviour(new FlyWithWings());
        }

        public override void Display()
        {
            Console.Out.WriteLine("I'm a mallard duck");
            PerformQuack();
            PerformFly();
            PerformSwim();
            Console.Out.WriteLine("------------------");
        }
    }
}
