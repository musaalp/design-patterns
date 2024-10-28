namespace Iterator
{
    public interface IAggregate<T>
    {
        IIterator<T> GetIterator();
    }
}
