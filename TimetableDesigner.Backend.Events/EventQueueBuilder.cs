namespace TimetableDesigner.Backend.Events;

public abstract class EventQueueBuilder<TQueue> where TQueue : EventQueue<TQueue>
{
    public abstract IDictionary<string, string> GetConnectionParameters();
}