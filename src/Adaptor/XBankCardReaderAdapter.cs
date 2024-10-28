namespace Adaptor
{
    public class XBankCardReaderAdapter : ICardReaderAdapter
    {
        public string ReadCardData()
        {
            var reader = new XBankPOSReader();
            return reader.ReadFromCard();
        }
    }
}
