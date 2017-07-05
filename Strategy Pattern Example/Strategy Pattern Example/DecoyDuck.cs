using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategy_Pattern_Example.Fly;
using Strategy_Pattern_Example.Quack;

namespace Strategy_Pattern_Example
{
    class DecoyDuck: Duck
    {
        public DecoyDuck()
        {
            SetQuackBehaviour(new MuteQuack());//Okay :  ^)
            SetFlyBehaviour(new FlyWithRocket());
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
