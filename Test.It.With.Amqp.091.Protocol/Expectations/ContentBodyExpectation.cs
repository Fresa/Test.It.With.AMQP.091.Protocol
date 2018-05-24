namespace Test.It.With.Amqp091.Protocol.Expectations
{
    internal class ContentBodyExpectation : Expectation
    {
        public ContentBodyExpectation(long size)
        {
            Size = size;
        }

        public long Size { get; }
    }
}