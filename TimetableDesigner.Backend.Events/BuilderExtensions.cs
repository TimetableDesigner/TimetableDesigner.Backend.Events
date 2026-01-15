using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace TimetableDesigner.Backend.Events;

public static class BuilderExtensions
{
    public static IServiceCollection AddEventQueue<T>(this IServiceCollection services, Action<T> configuration) where T : EventQueue, new()
    {
        T builder = new T();
        configuration(builder);
        builder.Setup(services);
        return services;
    }

    public static void AddEventHandler<T>(this WebApplication app, Func<T, Task> handler) where T : class
    {
        IEventQueueSubscriber subscriber = app.Services.GetService<IEventQueueSubscriber>()!;
        subscriber.Subscribe(handler);
    }
}