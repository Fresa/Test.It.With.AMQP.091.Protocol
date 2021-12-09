using System;

namespace Test.It.With.Amqp091.Protocol.Expectations
{
    internal class ContentBodyExpectation : Expectation
    {
        public ContentBodyExpectation(Type method, long size) : base(method)
        {
            Size = size;
        }

        public long Size { get; }
    }
}