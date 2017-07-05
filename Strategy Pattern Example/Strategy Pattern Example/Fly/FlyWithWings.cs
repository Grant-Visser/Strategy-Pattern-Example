using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern_Example.Fly
{
    class FlyWithWings: FlyBehaviour
    {
        public void fly()
        {
            Console.Out.WriteLine("Im flying with wings");
        }
    }
}
