using System;

namespace TemplateMethod.AnotherSample
{
    public class PaymentCompleteWindow : Window
    {
        protected override void OnClosed()
        {
            Console.WriteLine("Payment completed successfully!");
        }
    }
}