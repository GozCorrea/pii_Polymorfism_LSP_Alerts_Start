using System;

namespace LSPLibrary
{
    public class Alert_Trello : IAlert
    {
        public void Send(string type, string text)
        {
            new TrelloCardCreator().CreateCard(text);
        }
    }
}