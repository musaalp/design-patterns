namespace AbstractFactory.AnotherSample
{
    public class Demo
    {
        public void Run()
        {
            var africa = new AfricaFactory();
            var animalWorld = new AnimalWorld(africa);
            animalWorld.RunFoodChain();

            var america = new AmericaFactory();
            animalWorld = new AnimalWorld(america);
            animalWorld.RunFoodChain();
        }
    }
}