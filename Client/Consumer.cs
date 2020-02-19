using Server;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Client
{
    //[SuppressMessage("Microsoft.Design", "CS0534", Justification = "Internal members cannot be overridden")]
    public class Consumer : AbstractClass
    {
        public override void DoSomething(ExternalDependency dependency)
        {
            throw new NotImplementedException();
        }

        // CodeAnalysis incorrectly generates this method when running "Implement Abstract Class".
        // Removing the method doesn't remove the error. Adding SuppressMessageAttribute with
        // CS0534 suppresses the error in design view, but the project still doesn't compile.

        //internal override void DoSomething(InternalDependency dependency)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
