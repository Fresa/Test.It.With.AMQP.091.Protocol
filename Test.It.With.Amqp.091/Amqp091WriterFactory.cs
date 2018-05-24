using System.IO;
using Test.It.With.Amqp.Protocol;

namespace Test.It.With.Amqp091.Protocol
{
    internal class Amqp091WriterFactory : IAmqpWriterFactory
    {
        public IAmqpWriter Create(Stream stream)
        {
            return new Amqp091Writer(stream);
        }
    }
}