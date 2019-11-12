using System.Threading;
using System.Threading.Tasks;

namespace EventSourcingPlayground
{
    public interface ISubscribe<TEvent>
        where TEvent : IEvent
    {
        Task Handle(TEvent @event, CancellationToken cancellationToken = default);
    }
}
