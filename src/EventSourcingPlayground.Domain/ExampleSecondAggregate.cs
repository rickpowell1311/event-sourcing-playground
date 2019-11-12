using System.Threading;
using System.Threading.Tasks;

namespace EventSourcingPlayground.Domain
{
    public class ExampleSecondAggregate : IAggregate
    {
        public ExampleSecondIdentity Id { get; }

        public ExampleSecondAggregate()
        {
            Id = new ExampleSecondIdentity();
        }

        public Task DoSomething(IExampleService exampleService)
        {
            return this.Raise(new ExampleSecondEvent());
        }

        public Task Handle(IExampleService exampleService, ExampleFirstEvent @event, CancellationToken cancellationToken = default)
        {
            return DoSomething(exampleService);
        }
    }
}
