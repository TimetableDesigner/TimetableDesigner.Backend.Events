namespace TimetableDesigner.Backend.Events;

public interface IEventQueuePublisher
{
    public Task PublishAsync<T>(T data) where T : class;
    public Task PublishAsync<T>(string data, Type dataType) where T : class;
}