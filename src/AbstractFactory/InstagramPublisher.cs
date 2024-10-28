using System;

namespace AbstractFactory
{
    public class InstagramPublisher : IPublisher
    {
        public string PublisherAddress { get; set; }

        public void Publish(IContent content)
        {
            var createdContent = content.CreateContent();
            Console.WriteLine($"{createdContent} Published on {PublisherAddress}");
        }
    }
}
