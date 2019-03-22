using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDemo.StarBuckDemo
{
    public class Whip : CondimentDecorator
    {

        public Whip(Beverage beverage):base(beverage)
        {
        }

        public override double GetCost()
        {
            return base.GetCost() + 0.1;
        }

        public override string GetDescription()
        {
            return base.GetDescription() + ", Whip";
        }
    }
}
