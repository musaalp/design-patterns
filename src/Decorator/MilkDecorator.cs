using System;

namespace Decorator
{
    public class MilkDecorator : Decorator
    {
        public MilkDecorator(ICoffee coffee) : base(coffee)
        {
        }

        public override void Cook()
        {
            base.Cook();
            Console.WriteLine("Milk added.");
        }
    }
}
