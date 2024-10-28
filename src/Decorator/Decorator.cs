namespace Decorator
{
    public abstract class Decorator : ICoffee
    {
        private readonly ICoffee _coffee;

        public Decorator(ICoffee coffee)
        {
            _coffee = coffee;
        }

        public virtual void Cook()
        {
            _coffee.Cook();
        }
    }
}
