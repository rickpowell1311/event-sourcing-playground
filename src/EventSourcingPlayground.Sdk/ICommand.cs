using System.Threading;
using System.Threading.Tasks;

namespace EventSourcingPlayground
{
    public interface ICommand
    {
    }

    public interface ICommandHandler<TCommand, TAggregate> 
        where TCommand : ICommand
        where TAggregate : IAggregate
    {
        Task Handle(TCommand command, TAggregate aggregate, CancellationToken cancellationToken = default);
    }
}
