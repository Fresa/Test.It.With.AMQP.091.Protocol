using System;

namespace Test.It.With.Amqp091.Protocol.Expectations.MethodExpectationBuilders
{
    internal abstract class ExpectedMethodBuilder
    {
        public abstract Type[] Types { get; }
    }
}