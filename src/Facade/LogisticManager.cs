using System;

namespace Facade
{
    public class LogisticManager
    {
        public void ShipProduct(string productName, string shipAddress)
        {
            Console.WriteLine($"Your product {productName} has been shipped at the following address: {shipAddress}");
        }
    }
}
