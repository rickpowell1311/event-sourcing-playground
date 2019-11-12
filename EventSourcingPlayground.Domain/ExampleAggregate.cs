using System;
using System.Threading;
using System.Threading.Tasks;

namespace EventSourcingPlayground.Domain
{
    public class ExampleAggregate : IAggregate, ISubscribe<ExampleSecondEvent>
    {
        public ExampleAggregate()
        {
        }

        public Task DoSomething()
        {
            return this.Raise(new ExampleFirstEvent());
        }

        public Task Handle(ExampleSecondEvent @event, CancellationToken cancellationToken = default)
        {
            return Task.CompletedTask;
        }
    }
}
