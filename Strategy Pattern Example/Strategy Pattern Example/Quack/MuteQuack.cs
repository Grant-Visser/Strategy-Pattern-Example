using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern_Example.Quack
{
    class MuteQuack: QuackBehaviour
    {
        public void quack()
        {
            Console.Out.WriteLine("...");
        }
    }
}
