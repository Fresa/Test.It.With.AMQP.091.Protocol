using FluentAssertions;
using Test.It.With.Amqp091.Protocol.Extensions;
using Test.It.With.XUnit;
using Xunit;

namespace Test.It.With.Amqp091.Protocol.Tests
{
    public class When_splitting_a_string_on_uppercase : XUnit2Specification
    {
        private string _str;
        private string[] _result;

        protected override void Given()
        {
            _str = "THisIsAStRing";
        }

        protected override void When()
        {
            _result = _str.SplitOnUpperCase();
        }

        [Fact]
        public void It_should_result_in_an_array_with_strings_splitted_on_uppercase()
        {
            _result.Should().HaveCount(6);
            _result.Should().ContainInOrder("T", "His", "Is", "A", "St", "Ring");
        }
    }
}