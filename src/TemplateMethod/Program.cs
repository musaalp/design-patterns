using System;
using TemplateMethod.AnotherSample;

namespace TemplateMethodDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var window = new Window();
            
            window = new CheckoutWindow();
            window.Close();

            window = new PaymentCompleteWindow();
            window.Close();
        }
    }
}
