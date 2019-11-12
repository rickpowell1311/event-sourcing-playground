using System;
using System.Collections.Generic;

namespace EventSourcingPlayground
{
    public abstract class Identity<T> : ValueObject
    {
        public T Value { get; }

        protected Identity(T value)
        {
            Value = value;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}
