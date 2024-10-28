namespace AbstractFactory
{
    public interface IPublisherFactory
    {
        IContent CreateContentObject();
        IPublisher CreatePublisher();
    }
}
