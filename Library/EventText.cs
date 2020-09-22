namespace LSPLibrary
{
    public class Event_Text : IEvent
    {
        public string EventName { get; set; }
        public string EventType { get; set; }

        public void Notify()
        {
            new Alert_Text().Send("text", this.EventName);
        }
    }
}
