using Test.It.With.Amqp.Protocol;

namespace Test.It.With.Amqp091.Protocol
{
    internal class Amqp091ReaderFactory : IAmqpReaderFactory
    {
        public IAmqpReader Create(byte[] data)
        {
            return new Amqp091Reader(data);
        }
    }
}