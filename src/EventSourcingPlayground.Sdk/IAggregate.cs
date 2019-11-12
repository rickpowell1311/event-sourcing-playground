using System.Threading.Tasks;

namespace EventSourcingPlayground
{
    public interface IAggregate
    {
    }

    public static class AggregateExtensions
    {
        public static Task Raise<TEvent>(this IAggregate aggregate, TEvent @event) 
            where TEvent : IEvent
        {
            return Task.CompletedTask;
        }
    }
}
