using Microsoft.Extensions.DependencyInjection;

namespace TimetableDesigner.Backend.Events;

public abstract class EventQueue<TSelf> where TSelf : EventQueue<TSelf>
{
    public void Setup<TBuilder>(IServiceCollection services, TBuilder configuration)
        where TBuilder : EventQueueBuilder<TSelf> =>
        Setup(services, configuration.GetConnectionParameters());

    public void Setup(IServiceCollection services, string connectionString)
        => Setup(services, connectionString.Split(';')
                                                             .Select(x => x.Split('='))
                                                             .ToDictionary(x => x.First(), x => x.Last()));

    protected abstract void Setup(IServiceCollection services, IDictionary<string, string> connectionParameters);
}
