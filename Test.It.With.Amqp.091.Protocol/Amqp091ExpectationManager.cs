using Test.It.With.Amqp091.Protocol;
using Test.It.With.Amqp091.Protocol.Expectations;
using Test.It.With.Amqp091.Protocol.Expectations.Managers;
using Test.It.With.Amqp091.Protocol.Generator;

namespace Test.It.With.Amqp091.Protocol
{
    internal class Amqp091ExpectationManager : BaseExpectationManager
    {
        protected override Expectation Create(int channel)
        {
            switch (channel)
            {
                case 0:
                    return new ProtocolHeaderExpectation();
                default:
                    return new MethodExpectation<Channel.Open>();
            }
        }

        protected override void ThrowUnexpectedFrameException(string message)
        {
            throw new UnexpectedFrameException(message);
        }
    }
}