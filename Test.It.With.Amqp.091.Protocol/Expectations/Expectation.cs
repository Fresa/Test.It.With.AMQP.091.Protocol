using System;
using Test.It.With.Amqp091.Protocol.Extensions;

namespace Test.It.With.Amqp091.Protocol.Expectations
{
    internal abstract class Expectation
    {
        protected Expectation(Type methodName)
        {
            Name = methodName?.FullName ?? string.Empty;
        }
        public string Name { get; }
    }
}