using System;
using System.IO;
using FluentAssertions;
using Test.It.With.XUnit;
using Xunit;
using Xunit.Abstractions;

namespace Test.It.With.Amqp091.Protocol.Tests
{
    public class When_writing_a_content_header : XUnit2Specification
    {
        private Basic.ContentHeader _header;
        private readonly MemoryStream _buffer = new MemoryStream();
        private Amqp091Writer _writer;
        private Amqp091Reader _reader;
        private Basic.ContentHeader _headerRead;

        public When_writing_a_content_header(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
        {

        }

        protected override void Given()
        {
            _writer = new Amqp091Writer(_buffer);
            _header = new Basic.ContentHeader
            {
                Type = Shortstr.From("type1")
            };
        }

        protected override void When()
        {
            _header.WriteTo(_writer);
            _reader = new Amqp091Reader(_buffer.ToArray());
            _headerRead = new Basic.ContentHeader();
            _reader.ReadShortUnsignedInteger();
            _reader.ReadShortUnsignedInteger();
            _headerRead.ReadFrom(_reader);
        }

        [Fact]
        public void It_should_write_type()
        {
            _headerRead.HasType.Should().BeTrue();
            _headerRead.Type.Should().Be(Shortstr.From("type1"));
        }

        [Fact]
        public void There_should_be_no_data_left_to_read()
        {
            new Action(() => _reader.ThrowIfMoreData())
                .Should()
                .NotThrow();
        }
    }
}