using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDemo.StarBuckDemo
{
    public abstract class Beverage
    {
        public string Description = "Unknow Beverage";

        public abstract string GetDescription();

        public abstract double GetCost();
    }
}
