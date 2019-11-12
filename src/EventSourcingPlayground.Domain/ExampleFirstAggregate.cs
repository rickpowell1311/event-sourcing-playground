using System.Threading;
using System.Threading.Tasks;

namespace EventSourcingPlayground.Domain
{
    public class ExampleFirstAggregate : IAggregate
    {
        public ExampleFirstIdentity Id { get; }

        public ExampleFirstAggregate()
        {
            Id = new ExampleFirstIdentity();
        }

        public Task DoSomething(IExampleService exampleService, CancellationToken cancellationToken = default)
        {
            return this.Raise(new ExampleFirstEvent());
        }

        public Task Handle(ExampleSecondEvent @event, IExampleService exampleService, CancellationToken cancellationToken = default)
        {
            return Task.CompletedTask;
        }
    }
}
