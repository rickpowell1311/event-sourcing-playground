using System.Threading;
using System.Threading.Tasks;

namespace EventSourcingPlayground
{
    public interface IEventHandler<TEvent, TAggregate>
        where TEvent : IEvent
        where TAggregate : IAggregate
    {
        Task Handle(TEvent @event, TAggregate aggregate, CancellationToken cancellationToken = default);
    }
}
