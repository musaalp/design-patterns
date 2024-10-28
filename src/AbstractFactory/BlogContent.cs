namespace AbstractFactory
{
    public class BlogContent : IContent
    {
        public object CreateContent()
        {
            return "Sample blog content has been created.";
        }
    }
}
