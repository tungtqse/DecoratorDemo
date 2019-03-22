using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDemo.StarBuckDemo
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            Description = "Dark Roast Coffe";
        }

        public override double GetCost()
        {
            return 0.99;
        }

        public override string GetDescription()
        {
            return Description;
        }
    }
}
