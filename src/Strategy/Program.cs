using Strategy.AnotherSample;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            //sample 1
            var client = new ChatClientContext(new AESEncryptor());
            client.Send("Hello world");

            //sample 2
            var fileName = "sampleImage.jpeg";

            var strategyContext = new ImageStoreContext();

            strategyContext.Store(fileName, new JpegCompressor(), new BlackAndWhiteFilter());

            strategyContext.Store(fileName, new BmpCompressor(), new BrightnessFilter());
        }
    }
}
