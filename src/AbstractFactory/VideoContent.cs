namespace AbstractFactory
{
    public class VideoContent : IContent
    {
        public object CreateContent()
        {
            return "Sample video content has been created.";
        }
    }
}
