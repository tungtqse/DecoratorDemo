using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDemo.StarBuckDemo
{
    public class Soya : CondimentDecorator
    {        

        public Soya(Beverage beverage) : base(beverage)
        {
        }

        public override double GetCost()
        {
            return base.GetCost() + 0.15;
        }       

        public override string GetDescription()
        {
            return base.GetDescription() + ", Soya";
        }
    }
}
