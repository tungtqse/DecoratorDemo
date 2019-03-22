using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDemo.StarBuckDemo
{
    public class Decaf : Beverage
    {
        public Decaf()
        {
            Description = "Decaf Coffe";
        }

        public override double GetCost()
        {
            return 3.99;
        }

        public override string GetDescription()
        {
            return Description;
        }
    }
}
