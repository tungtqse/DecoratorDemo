using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDemo.StarBuckDemo
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            Description = "Espresso";
        }

        public override double GetCost()
        {
            return 1.99;
        }

        public override string GetDescription()
        {
            return Description;
        }
    }
}
