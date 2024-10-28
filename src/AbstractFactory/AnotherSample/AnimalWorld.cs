namespace AbstractFactory.AnotherSample
{
    public class AnimalWorld
    {
        private readonly Herbivore _herbivore;
        private readonly Carnivore _carnivore;

        public AnimalWorld(ContinentFactory continentFactory)
        {
            _herbivore = continentFactory.CreateHerbivore();
            _carnivore = continentFactory.CreateCarnivore();
        }

        public void RunFoodChain()
        {
            _carnivore.Eat(_herbivore);
        }
    }
}