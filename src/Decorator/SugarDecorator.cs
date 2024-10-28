using System;

namespace Decorator
{
    public class SugarDecorator : Decorator
    {
        public SugarDecorator(ICoffee coffee) : base(coffee)
        {
        }

        public override void Cook()
        {
            base.Cook();
            Console.WriteLine("Sugar added.");
        }
    }
}
