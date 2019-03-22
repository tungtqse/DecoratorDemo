using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDemo.StarBuckDemo
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            Description = "House Blend Coffe";
        }

        public override double GetCost()
        {
            return 2.99;
        }

        public override string GetDescription()
        {
            return Description;
        }
    }
}
