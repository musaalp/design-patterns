using System;

namespace TemplateMethod.AnotherSample
{
    public class Window
    {
        // template method
        public void Close()
        {
            OnClosing();
            
            Console.WriteLine("Closing the window from the screen");
            
            OnClosed();
        }

        protected virtual void OnClosing()
        {
            
        }

        protected virtual void OnClosed()
        {
            
        }
    }
}