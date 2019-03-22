using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDemo.StarBuckDemo
{
    public abstract class CondimentDecorator : Beverage
    {
        private Beverage _beverage;

        public CondimentDecorator(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription();
        }

        public override double GetCost()
        {
            return _beverage.GetCost();
        }
    }
}
