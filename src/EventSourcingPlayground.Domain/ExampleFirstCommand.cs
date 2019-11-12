using System.Threading;
using System.Threading.Tasks;

namespace EventSourcingPlayground.Domain
{
    public class ExampleFirstCommand : ICommand
    {
        public bool IsEnabled { get; set; }
    }

    public class ExampleFirstHandler : ICommandHandler<ExampleFirstCommand, ExampleFirstAggregate>
    {
        private readonly IExampleService exampleService;

        public ExampleFirstHandler(IExampleService exampleService)
        {
            this.exampleService = exampleService;
        }

        public Task Handle(ExampleFirstCommand command, ExampleFirstAggregate aggregate, CancellationToken cancellationToken = default)
        {
            return aggregate.DoSomething(this.exampleService, cancellationToken);
        }
    }
}
