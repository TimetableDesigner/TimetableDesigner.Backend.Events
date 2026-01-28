using System.Text.Json;
using System.Text.Json.Nodes;

namespace TimetableDesigner.Backend.Events;

public interface IEventQueuePublisher
{
    public sealed Task PublishAsync<T>(T data) where T : class => PublishAsync(JsonSerializer.Serialize(data), data.GetType());
    public Task PublishAsync(string data, Type dataType);
}