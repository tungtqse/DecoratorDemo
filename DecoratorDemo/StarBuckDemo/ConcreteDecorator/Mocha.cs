using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDemo.StarBuckDemo
{
    public class Mocha : CondimentDecorator
    {      

        public Mocha(Beverage beverage) : base(beverage)
        {            
        }

        public override double GetCost()
        {
            return base.GetCost() + 0.2;
        }

        public override string GetDescription()
        {
            return base.GetDescription() + ", Mocha";
        }
    }
}
