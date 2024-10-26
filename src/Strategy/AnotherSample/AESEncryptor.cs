using System;

namespace Strategy.AnotherSample
{
    // concreate strategy type
    public class AESEncryptor : IEncryptor
    {
        public void Encrypt(string message)
        {
            Console.WriteLine("Encrypting message using AES");
        }
    }
}
