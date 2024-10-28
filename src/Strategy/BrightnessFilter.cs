namespace Strategy
{
    // concreate strategy type
    public class BrightnessFilter : IFilter
    {
        public void Apply(string fileName)
        {
            System.Console.WriteLine("Applying brightness filter");
        }
    }
}
