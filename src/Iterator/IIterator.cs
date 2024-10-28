namespace Iterator
{
    public interface IIterator<T>
    {
        bool Next();
        T CurrentItem { get; }
    }
}
