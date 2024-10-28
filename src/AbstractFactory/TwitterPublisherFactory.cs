namespace AbstractFactory
{
    public class TwitterPublisherFactory : IPublisherFactory
    {
        public IContent CreateContentObject()
        {
            return new BlogContent();
        }

        public IPublisher CreatePublisher()
        {
            return new TwitterPublish()
            {
                PublisherAddress = "http://www.twitter.com"
            };
        }
    }
}
