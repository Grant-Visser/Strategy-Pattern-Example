using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Duck> duckList = new List<Duck>();
            duckList.Add(new MallardDuck());
            duckList.Add(new DecoyDuck());
            duckList.Add(new RubberDuck());
            foreach (Duck d in duckList)
            {
                d.Display();
            }
            Console.Out.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
