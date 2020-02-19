using System;

namespace Server
{
    public abstract class AbstractClass
    {
        public abstract void DoSomething(ExternalDependency dependency);

        internal abstract void DoSomething(InternalDependency dependency);
    }
}
