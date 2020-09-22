namespace LSPLibrary
{
    public class Event_Severe : IEvent
    {
        public string EventName { get; set; }
        public string EventType { get; set; }

        public void Notify()
        {
            new Alert_Text ().Send("text", this.EventName);
            new Alert_Trello().Send("trello", this.EventName);
        }
    }
}
