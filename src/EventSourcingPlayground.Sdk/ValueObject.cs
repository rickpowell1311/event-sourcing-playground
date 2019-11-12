using System.Collections.Generic;
using System.Linq;

namespace EventSourcingPlayground
{
    public abstract class ValueObject
    {
        protected static bool EqualOperator(ValueObject left, ValueObject right)
        {
#pragma warning disable IDE0041 // Use 'is null' check
            if (ReferenceEquals(left, null) ^ ReferenceEquals(right, null))
#pragma warning restore IDE0041 // Use 'is null' check
            {
                return false;
            }

#pragma warning disable IDE0041 // Use 'is null' check
            return ReferenceEquals(left, null) || left.Equals(right);
#pragma warning restore IDE0041 // Use 'is null' check
        }

        protected static bool NotEqualOperator(ValueObject left, ValueObject right)
        {
            return !(EqualOperator(left, right));
        }

        protected abstract IEnumerable<object> GetEqualityComponents();

        public override bool Equals(object obj)
        {
            if (obj == null || obj.GetType() != GetType())
            {
                return false;
            }

            ValueObject other = (ValueObject)obj;
            IEnumerator<object> thisValues = GetEqualityComponents().GetEnumerator();
            IEnumerator<object> otherValues = other.GetEqualityComponents().GetEnumerator();
            while (thisValues.MoveNext() && otherValues.MoveNext())
            {
#pragma warning disable IDE0041 // Use 'is null' check
                if (ReferenceEquals(thisValues.Current, null) ^
#pragma warning restore IDE0041 // Use 'is null' check
#pragma warning disable IDE0041 // Use 'is null' check
                    ReferenceEquals(otherValues.Current, null))
#pragma warning restore IDE0041 // Use 'is null' check
                {
                    return false;
                }

                if (thisValues.Current != null &&
                    !thisValues.Current.Equals(otherValues.Current))
                {
                    return false;
                }
            }
            return !thisValues.MoveNext() && !otherValues.MoveNext();
        }

        public override int GetHashCode()
        {
            return GetEqualityComponents()
                .Select(x => x != null ? x.GetHashCode() : 0)
                .Aggregate((x, y) => x ^ y);
        }
    }
}
