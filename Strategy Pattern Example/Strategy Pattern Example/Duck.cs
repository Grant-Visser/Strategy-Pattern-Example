using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern_Example
{
    public abstract class Duck
    {
        private FlyBehaviour flyBehaviour;
        private QuackBehaviour quackBehaviour;

        public Duck()
        {
          
        }

        public void SetFlyBehaviour(FlyBehaviour fb)
        {
            flyBehaviour = fb;
        }

        public void SetQuackBehaviour(QuackBehaviour qb)
        {
            quackBehaviour = qb;
        }

        public abstract void Display();

        public void PerformFly()
        {
            flyBehaviour.fly();
        }

        public void PerformQuack()
        {
            quackBehaviour.quack();
        }

        public void PerformSwim()
        {
            Console.Out.WriteLine("All Ducks Float");
        }
    }
}
