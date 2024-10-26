namespace Strategy.AnotherSample
{

    // strategy context
    public class ChatClientContext
    {
        private readonly IEncryptor _encryptor;

        public ChatClientContext(IEncryptor encryptor)
        {
            _encryptor = encryptor;
        }

        public void Send(string message)
        {
            _encryptor.Encrypt(message);

            System.Console.WriteLine("Message has been sent");
        }
    }
}
