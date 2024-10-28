using System;

namespace AbstractFactory.AnotherSample
{
    public class Lion : Carnivore
    {
        public override void Eat(Herbivore h)
        {
            //Eats Wildebeest

            Console.WriteLine($"{this.GetType().Name} eats {h.GetType().Name}");
        }
    }
}