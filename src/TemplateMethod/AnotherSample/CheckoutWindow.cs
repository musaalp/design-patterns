using System;

namespace TemplateMethod.AnotherSample
{
    public class CheckoutWindow : Window
    {
        protected override void OnClosing()
        {
            Console.WriteLine("Are you sure you want to leave?");
        }
    }
}