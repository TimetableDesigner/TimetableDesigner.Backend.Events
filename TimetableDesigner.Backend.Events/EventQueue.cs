using Microsoft.Extensions.DependencyInjection;

namespace TimetableDesigner.Backend.Events;

public abstract class EventQueue
{
    internal abstract void Setup(IServiceCollection services);
}