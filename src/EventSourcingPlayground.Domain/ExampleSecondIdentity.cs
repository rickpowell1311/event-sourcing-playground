using System;

namespace EventSourcingPlayground.Domain
{
    public class ExampleSecondIdentity : Identity<Guid>
    {
        public ExampleSecondIdentity(Guid value) : base(value) { }

        public ExampleSecondIdentity() : this(Guid.NewGuid()) { }
    }
}
