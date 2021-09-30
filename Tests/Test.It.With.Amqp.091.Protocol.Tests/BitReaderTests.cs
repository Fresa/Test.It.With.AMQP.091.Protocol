using System.Collections.Generic;
using FakeItEasy;
using FluentAssertions;
using Test.It.With.XUnit;
using Xunit;

namespace Test.It.With.Amqp091.Protocol.Tests
{
    namespace Given_a_bit_reader
    {
        public class When_reading_multiple_bits : XUnit2Specification
        {
            private IByteReader _byteReader;
            private BitReader _reader;
            private readonly List<bool> _bitsRead = new List<bool>();

            protected override void Given()
            {
                _byteReader = A.Fake<Protocol.IByteReader>();
                var bytesToRead = new Queue<byte>(new[] { (byte)5, (byte)7 });
                A.CallTo<byte>(() => _byteReader.ReadByte()).ReturnsLazily(() => bytesToRead.Dequeue());

                _reader = new BitReader(_byteReader);
            }

            protected override void When()
            {
                for (var i = 0; i < 16; i++)
                {
                    _bitsRead.Add(_reader.Read());
                }
            }

            [Fact]
            public void It_should_have_read_correct_bits()
            {
                _bitsRead.Should().ContainInOrder(true, false, true, false, false, false, false, false, true, true, true, false, false, false, false, false);
            }
        }
    }
}