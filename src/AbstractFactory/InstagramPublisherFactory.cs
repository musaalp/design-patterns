namespace AbstractFactory
{
    public class InstagramPublisherFactory : IPublisherFactory
    {
        public IContent CreateContentObject()
        {
            return new ImageContent();
        }

        public IPublisher CreatePublisher()
        {
            return new InstagramPublisher
            {
                PublisherAddress = "http://www.instagram.com"
            };
        }
    }
}
