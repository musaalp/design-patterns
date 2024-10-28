using System;

namespace Decorator
{
    public class AromaDecorator : Decorator
    {
        public AromaDecorator(ICoffee coffee) : base(coffee)
        {
        }

        public override void Cook()
        {
            base.Cook();
            Console.WriteLine("Aroma added");
        }
    }
}
