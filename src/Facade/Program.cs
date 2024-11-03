using System;
using Facade.AnotherExample;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            // example 1
            var shoppingFacade = new ShoppingFacade();

            var orderDetailsModel = new OrderDetailsModel
            {
                AddressLine = "Educational Arena",
                CardNo = "0000 00001 00002 00003",
                Discount = 190,
                PinCode = 53353,
                Price = 438,
                ProductName = "A Book"
            };

            shoppingFacade.FinalizeShopping(new OrderDetails(orderDetailsModel));

            Console.WriteLine();

            // example 2
            var demo = new Demo();
            demo.Run();
        }
    }
}