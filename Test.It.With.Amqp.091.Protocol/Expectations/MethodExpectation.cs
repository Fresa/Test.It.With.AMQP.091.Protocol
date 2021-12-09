using System;
using System.Linq;

namespace Test.It.With.Amqp091.Protocol.Expectations
{
    internal class MethodExpectation : Expectation
    {
        public MethodExpectation(Type method, params Type[] expectedMethods) : base(method)
        {
            MethodResponses = expectedMethods.Distinct().ToArray();
        }

        public Type[] MethodResponses { get; }
    }

    internal class MethodExpectation<T> : MethodExpectation
    {
        public MethodExpectation() : base(null, typeof(T))
        {

        }

        public MethodExpectation(Type method) : base(method, typeof(T))
        {
            
        }
    }
}