using Test.It.With.Amqp091.Protocol.Extensions;

namespace Test.It.With.Amqp091.Protocol.Expectations
{
    internal abstract class Expectation
    {
        public string Name => GetType().Name.SplitOnUpperCase().Join(" ").ToLower();
    }
}