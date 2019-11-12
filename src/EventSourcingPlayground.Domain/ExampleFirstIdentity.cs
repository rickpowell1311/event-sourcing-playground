using System;

namespace EventSourcingPlayground.Domain
{
    public class ExampleFirstIdentity : Identity<Guid>
    {
        public ExampleFirstIdentity(Guid value) : base(value) { }

        public ExampleFirstIdentity() : this(Guid.NewGuid()) { }
    }
}
