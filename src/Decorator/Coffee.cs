using System;

namespace Decorator
{
    public class Coffee : ICoffee
    {
        public void Cook()
        {
            Console.WriteLine("A coffee cooked.");
        }
    }
}
