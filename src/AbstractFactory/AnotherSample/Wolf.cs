using System;

namespace AbstractFactory.AnotherSample
{
    public class Wolf : Carnivore
    {
        public override void Eat(Herbivore h)
        {
            // Eats Bison

            Console.WriteLine($"{this.GetType().Name} eats {h.GetType().Name}");
        }
    }
}