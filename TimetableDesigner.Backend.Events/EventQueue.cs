using Microsoft.Extensions.DependencyInjection;

namespace TimetableDesigner.Backend.Events;

public abstract class EventQueue<TSelf> where TSelf : EventQueue<TSelf>
{
    public abstract void Setup<TBuilder>(IServiceCollection services, TBuilder configuration)
        where TBuilder : EventQueueBuilder<TSelf>;
    
    public abstract void Setup(IServiceCollection services, string connectionString);
}
