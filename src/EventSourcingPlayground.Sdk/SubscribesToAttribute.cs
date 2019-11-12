using System;
using System.Collections.Generic;
using System.Text;

namespace EventSourcingPlayground
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
    public class SubscribesToAttribute : Attribute
    {
        public SubscribesToAttribute(Type @eventType)
        {

        }
    }
}
