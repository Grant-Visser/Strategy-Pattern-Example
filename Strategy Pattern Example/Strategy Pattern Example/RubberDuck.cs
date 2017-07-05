using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategy_Pattern_Example.Fly;
using Strategy_Pattern_Example.Quack;

namespace Strategy_Pattern_Example
{
    class RubberDuck: Duck
    {
        public RubberDuck()
        {
            SetQuackBehaviour(new Squeak());//Okay :  ^)
            SetFlyBehaviour(new FlyNoWay());
        }

        public override void Display()
        {
            Console.Out.WriteLine("I'm a rubber duck");
            PerformQuack();
            PerformFly();
            PerformSwim();
            Console.Out.WriteLine("------------------");
        }
    }
}
