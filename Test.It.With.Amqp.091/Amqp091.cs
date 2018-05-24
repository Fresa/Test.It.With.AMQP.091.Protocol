using Test.It.With.Amqp.Protocol;

namespace Test.It.With.Amqp091.Protocol
{
    public static class Amqp091
    {
        public static IProtocolResolver ProtocolResolver => Amqp091ProtocolResolver.Create();
    }
}