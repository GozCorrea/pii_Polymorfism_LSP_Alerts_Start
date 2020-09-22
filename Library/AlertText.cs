using System;

namespace LSPLibrary
{
    public class Alert_Text : IAlert
    {
        public void Send(string type, string text)
        {
            Console.WriteLine(text);
        
        }
    }
}