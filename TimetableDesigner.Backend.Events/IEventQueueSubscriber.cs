namespace TimetableDesigner.Backend.Events;

public interface IEventQueueSubscriber
{
    void Subscribe<T>(Func<T, Task> handler) where T : class;
}