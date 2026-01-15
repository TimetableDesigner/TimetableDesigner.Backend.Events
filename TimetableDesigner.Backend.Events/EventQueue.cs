using Microsoft.Extensions.DependencyInjection;

namespace TimetableDesigner.Backend.Events;

public abstract class EventQueue
{
    public abstract void Setup(IServiceCollection services);
}
