namespace StrategyDesignPattern
{
    //strategy context
    public class ImageStoreContext
    {
        public void Store(string fileName, ICompressor compressor, IFilter filter)
        {
            compressor.Compress(fileName);

            filter.Apply(fileName);
        }
    }
}
