﻿using System;
using System.Collections.Generic;
using FluentAssertions;
using Test.It.With.Amqp091.Protocol;
using Test.It.With.XUnit;
using Xunit;

namespace Test.It.With.Amqp091.Protocol.Tests
{
    public class When_reading_a_short_unsigned_integer_via_amqp : XUnit2Specification
    {
        private Amqp091Reader _reader;
        private ushort _ushort;

        protected override void Given()
        {
            _reader = new Amqp091Reader(new byte[] { 0, 2 });
        }

        protected override void When()
        {
            _ushort = _reader.ReadShortUnsignedInteger();
        }

        [Fact]
        public void It_should_parse_correctly()
        {
            _ushort.Should().Be((ushort)2);
        }
    }

    public class When_reading_a_long_unsigned_integer_via_amqp : XUnit2Specification
    {
        private Amqp091Reader _reader;
        private uint _ushort;

        protected override void Given()
        {
            _reader = new Amqp091Reader(new byte[] { 0, 0, 0, 2 });
        }

        protected override void When()
        {
            _ushort = _reader.ReadLongUnsignedInteger();
        }

        [Fact]
        public void It_should_parse_correctly()
        {
            _ushort.Should().Be((uint)2);
        }
    }

    public class When_reading_a_long_long_unsigned_integer_via_amqp : XUnit2Specification
    {
        private Amqp091Reader _reader;
        private ulong _ushort;

        protected override void Given()
        {
            _reader = new Amqp091Reader(new byte[] { 0, 0, 0, 0, 0, 0, 0, 2 });
        }

        protected override void When()
        {
            _ushort = _reader.ReadLongLongUnsignedInteger();
        }

        [Fact]
        public void It_should_parse_correctly()
        {
            _ushort.Should().Be((ulong)2);
        }
    }

    public class When_reading_a_short_string_via_amqp : XUnit2Specification
    {
        private Amqp091Reader _reader;
        private string _parsedData;

        protected override void Given()
        {
            _reader = new Amqp091Reader(new byte[] { 5, 65, 66, 67, 68, 69, 6 });
        }

        protected override void When()
        {
            _parsedData = _reader.ReadShortString();
        }

        [Fact]
        public void It_should_parse_correctly()
        {
            _parsedData.Should().Be("ABCDE");
        }
    }

    public class When_reading_a_byte_via_amqp : XUnit2Specification
    {
        private Amqp091Reader _reader;
        private byte _parsedData;

        protected override void Given()
        {
            _reader = new Amqp091Reader(new byte[] { 16, 14 });
        }

        protected override void When()
        {
            _parsedData = _reader.ReadByte();
        }

        [Fact]
        public void It_should_parse_correctly()
        {
            _parsedData.Should().Be((byte)16);
        }
    }

    public class When_reading_a_boolean_via_amqp : XUnit2Specification
    {
        private Amqp091Reader _reader;
        private bool _readData;

        protected override void Given()
        {
            _reader = new Amqp091Reader(new byte[] { 1, 0 });
        }

        protected override void When()
        {
            _readData = _reader.ReadBoolean();
        }

        [Fact]
        public void It_should_parse_correctly()
        {
            _readData.Should().Be(true);
        }
    }

    public class When_reading_bytes_via_amqp : XUnit2Specification
    {
        private Amqp091Reader _reader;
        private byte[] _readData;

        protected override void Given()
        {
            _reader = new Amqp091Reader(new byte[] { 1, 0, 6 });
        }

        protected override void When()
        {
            _readData = _reader.ReadBytes(2);
        }

        [Fact]
        public void It_should_parse_correctly()
        {
            _readData.Should().BeEquivalentTo(new byte[] { 1, 0 });
        }
    }

    public class When_reading_long_string_via_amqp : XUnit2Specification
    {
        private Amqp091Reader _reader;
        private byte[] _readData;

        protected override void Given()
        {
            _reader = new Amqp091Reader(new byte[] { 0, 0, 0, 5, 0, 6, 1, 2, 3, 6 });
        }

        protected override void When()
        {
            _readData = _reader.ReadLongString();
        }

        [Fact]
        public void It_should_parse_correctly()
        {
            _readData.Should().BeEquivalentTo(new byte[] { 0, 6, 1, 2, 3 });
        }
    }

    public class When_reading_character_via_amqp : XUnit2Specification
    {
        private Amqp091Reader _reader;
        private char _readData;

        protected override void Given()
        {
            _reader = new Amqp091Reader(new byte[] { 14, 9, 5 });
        }

        protected override void When()
        {
            _readData = _reader.ReadCharacter();
        }

        [Fact]
        public void It_should_parse_correctly()
        {
            _readData.Should().Be('ऎ');
        }
    }

    public class When_reading_short_short_integer_via_amqp : XUnit2Specification
    {
        private Amqp091Reader _reader;
        private sbyte _readData;

        protected override void Given()
        {
            _reader = new Amqp091Reader(new byte[] { 65 });
        }

        protected override void When()
        {
            _readData = _reader.ReadShortShortInteger();
        }

        [Fact]
        public void It_should_parse_correctly()
        {
            _readData.Should().Be((sbyte)65);
        }
    }

    public class When_reading_long_long_integer_via_amqp : XUnit2Specification
    {
        private Amqp091Reader _reader;
        private long _readData;

        protected override void Given()
        {
            _reader = new Amqp091Reader(new byte[] { 0,0,0,0,0,0,0,65 });
        }

        protected override void When()
        {
            _readData = _reader.ReadLongLongInteger();
        }

        [Fact]
        public void It_should_parse_correctly()
        {
            _readData.Should().Be((long)65);
        }
    }

    public class When_reading_decimal_via_amqp : XUnit2Specification
    {
        private Amqp091Reader _reader;
        private decimal _readData;

        protected override void Given()
        {
            _reader = new Amqp091Reader(new byte[] { 2, 0, 0, 0, 4, 5 });
        }

        protected override void When()
        {
            _readData = _reader.ReadDecimal();
        }

        [Fact]
        public void It_should_parse_correctly()
        {
            _readData.Should().Be((decimal)0.04);
        }
    }

    public class When_reading_a_negative_decimal_via_amqp : XUnit2Specification
    {
        private Amqp091Reader _reader;
        private object _readData;

        protected override void Given()
        {
            _reader = new Amqp091Reader(new byte[] { 2, 255, 255, 255, 252, 5 });
        }

        protected override void When()
        {
            _readData = _reader.ReadDecimal();
        }

        [Fact]
        public void It_should_parse_correctly()
        {
            _readData.Should().Be((decimal)-0.04);
        }
    }

    public class When_reading_long_integer_via_amqp : XUnit2Specification
    {
        private Amqp091Reader _reader;
        private int _readData;

        protected override void Given()
        {
            _reader = new Amqp091Reader(new byte[] { 0, 0, 1, 1, 4, 5 });
        }

        protected override void When()
        {
            _readData = _reader.ReadLongInteger();
        }

        [Fact]
        public void It_should_parse_correctly()
        {
            _readData.Should().Be(257);
        }
    }

    public class When_reading_short_integer_via_amqp : XUnit2Specification
    {
        private Amqp091Reader _reader;
        private int _readData;

        protected override void Given()
        {
            _reader = new Amqp091Reader(new byte[] { 1, 0, 1, 1, 4, 5 });
        }

        protected override void When()
        {
            _readData = _reader.ReadShortInteger();
        }

        [Fact]
        public void It_should_parse_correctly()
        {
            _readData.Should().Be(256);
        }
    }

    public class When_reading_a_floating_point_number_via_amqp : XUnit2Specification
    {
        private Amqp091Reader _reader;
        private float _readData;

        protected override void Given()
        {
            _reader = new Amqp091Reader(new byte[] { 65, 112, 0, 0 });
        }

        protected override void When()
        {
            _readData = _reader.ReadFloatingPointNumber();
        }

        [Fact]
        public void It_should_parse_correctly()
        {
            _readData.Should().Be((float)1.5000000E+001);
        }
    }

    public class When_reading_a_long_floating_point_number_via_amqp : XUnit2Specification
    {
        private Amqp091Reader _reader;
        private double _readData;

        protected override void Given()
        {
            _reader = new Amqp091Reader(new byte[] { 64, 111, 224, 0, 0, 0, 0, 0 });
        }

        protected override void When()
        {
            _readData = _reader.ReadLongFloatingPointNumber();
        }

        [Fact]
        public void It_should_parse_correctly()
        {
            _readData.Should().Be(2.5500000000000000E+002);
        }
    }

    public class When_reading_a_timestamp_via_amqp : XUnit2Specification
    {
        private Amqp091Reader _reader;
        private DateTime _readData;

        protected override void Given()
        {
            _reader = new Amqp091Reader(new byte[] { 0, 0, 0, 0, 1, 0, 0, 5 });
        }

        protected override void When()
        {
            _readData = _reader.ReadTimestamp();
        }

        [Fact]
        public void It_should_parse_correctly()
        {
            _readData.Should().Be(new DateTime(1970, 7, 14, 4, 20, 21));
        }
    }

    public class When_reading_a_table_via_amqp : XUnit2Specification
    {
        private Amqp091Reader _reader;
        private IDictionary<string, object> _readData;

        protected override void Given()
        {
            _reader = new Amqp091Reader(new byte[] { 0, 0, 0, 8, 5, 65, 66, 67, 68, 69, (byte)'t', 1 });
        }

        protected override void When()
        {
            _readData = _reader.ReadTable();
        }

        [Fact]
        public void It_should_parse_correctly()
        {
            _readData
                .Should().HaveCount(1).And
                .ContainInOrder(new KeyValuePair<string, object>("ABCDE", true));
        }
    }

    public class When_reading_boolean_field_value_via_amqp : XUnit2Specification
    {
        private Amqp091Reader _reader;
        private object _readData;

        protected override void Given()
        {
            _reader = new Amqp091Reader(new byte[] { (byte)'t', 1 });
        }

        protected override void When()
        {
            _readData = _reader.ReadFieldValue();
        }

        [Fact]
        public void It_should_parse_correctly()
        {
            _readData.Should().Be(true);
        }
    }

    public class When_reading_short_short_integer_field_value_via_amqp : XUnit2Specification
    {
        private Amqp091Reader _reader;
        private object _readData;

        protected override void Given()
        {
            _reader = new Amqp091Reader(new byte[] { (byte)'b', 5, 6 });
        }

        protected override void When()
        {
            _readData = _reader.ReadFieldValue();
        }

        [Fact]
        public void It_should_parse_correctly()
        {
            _readData.Should().Be((sbyte)5);
        }
    }

    public class When_reading_a_byte_field_value_via_amqp : XUnit2Specification
    {
        private Amqp091Reader _reader;
        private object _readData;

        protected override void Given()
        {
            _reader = new Amqp091Reader(new byte[] { (byte)'B', 5, 6 });
        }

        protected override void When()
        {
            _readData = _reader.ReadFieldValue();
        }

        [Fact]
        public void It_should_parse_correctly()
        {
            _readData.Should().Be((byte)5);
        }
    }

    public class When_reading_a_short_integer_field_value_via_amqp : XUnit2Specification
    {
        private Amqp091Reader _reader;
        private object _readData;

        protected override void Given()
        {
            _reader = new Amqp091Reader(new byte[] { (byte)'U', 1, 6 });
        }

        protected override void When()
        {
            _readData = _reader.ReadFieldValue();
        }

        [Fact]
        public void It_should_parse_correctly()
        {
            _readData.Should().Be((short)262);
        }
    }

    public class When_reading_a_short_unsigned_integer_field_value_via_amqp : XUnit2Specification
    {
        private Amqp091Reader _reader;
        private object _readData;

        protected override void Given()
        {
            _reader = new Amqp091Reader(new byte[] { (byte)'u', 1, 6 });
        }

        protected override void When()
        {
            _readData = _reader.ReadFieldValue();
        }

        [Fact]
        public void It_should_parse_correctly()
        {
            _readData.Should().Be((ushort)262);
        }
    }

    public class When_reading_a_long_integer_field_value_via_amqp : XUnit2Specification
    {
        private Amqp091Reader _reader;
        private object _readData;

        protected override void Given()
        {
            _reader = new Amqp091Reader(new byte[] { (byte)'I', 0, 0, 1, 6 });
        }

        protected override void When()
        {
            _readData = _reader.ReadFieldValue();
        }

        [Fact]
        public void It_should_parse_correctly()
        {
            _readData.Should().Be(262);
        }
    }

    public class When_reading_a_long_unsigned_integer_field_value_via_amqp : XUnit2Specification
    {
        private Amqp091Reader _reader;
        private object _readData;

        protected override void Given()
        {
            _reader = new Amqp091Reader(new byte[] { (byte)'i', 0, 0, 1, 6 });
        }

        protected override void When()
        {
            _readData = _reader.ReadFieldValue();
        }

        [Fact]
        public void It_should_parse_correctly()
        {
            _readData.Should().Be((uint)262);
        }
    }

    public class When_reading_a_long_long_integer_field_value_via_amqp : XUnit2Specification
    {
        private Amqp091Reader _reader;
        private object _readData;

        protected override void Given()
        {
            _reader = new Amqp091Reader(new byte[] { (byte)'L', 0, 0, 0, 0, 0, 0, 1, 6 });
        }

        protected override void When()
        {
            _readData = _reader.ReadFieldValue();
        }

        [Fact]
        public void It_should_parse_correctly()
        {
            _readData.Should().Be((long)262);
        }
    }

    public class When_reading_a_long_long_unsigned_integer_field_value_via_amqp : XUnit2Specification
    {
        private Amqp091Reader _reader;
        private object _readData;

        protected override void Given()
        {
            _reader = new Amqp091Reader(new byte[] { (byte)'l', 0, 0, 0, 0, 0, 0, 1, 6 });
        }

        protected override void When()
        {
            _readData = _reader.ReadFieldValue();
        }

        [Fact]
        public void It_should_parse_correctly()
        {
            _readData.Should().Be((ulong)262);
        }
    }

    public class When_reading_a_floating_point_number_field_value_via_amqp : XUnit2Specification
    {
        private Amqp091Reader _reader;
        private object _readData;

        protected override void Given()
        {
            _reader = new Amqp091Reader(new byte[] { (byte)'f', 65, 112, 0, 0 });
        }

        protected override void When()
        {
            _readData = _reader.ReadFieldValue();
        }

        [Fact]
        public void It_should_parse_correctly()
        {
            _readData.Should().Be((float)1.5000000E+001);
        }
    }

    public class When_reading_a_long_floating_point_number_field_value_via_amqp : XUnit2Specification
    {
        private Amqp091Reader _reader;
        private object _readData;

        protected override void Given()
        {
            _reader = new Amqp091Reader(new byte[] { (byte)'d', 64, 111, 224, 0, 0, 0, 0, 0 });
        }

        protected override void When()
        {
            _readData = _reader.ReadFieldValue();
        }

        [Fact]
        public void It_should_parse_correctly()
        {
            _readData.Should().Be(2.5500000000000000E+002);
        }
    }

    public class When_reading_a_decimal_field_value_via_amqp : XUnit2Specification
    {
        private Amqp091Reader _reader;
        private object _readData;

        protected override void Given()
        {
            _reader = new Amqp091Reader(new byte[] { (byte)'D', 2, 0, 0, 0, 4, 5 });
        }

        protected override void When()
        {
            _readData = _reader.ReadFieldValue();
        }

        [Fact]
        public void It_should_parse_correctly()
        {
            _readData.Should().Be((decimal)0.04);
        }
    }

    public class When_reading_a_negative_decimal_field_value_via_amqp : XUnit2Specification
    {
        private Amqp091Reader _reader;
        private object _readData;

        protected override void Given()
        {
            _reader = new Amqp091Reader(new byte[] { (byte)'D', 2, 255, 255, 255, 252, 5 });
        }

        protected override void When()
        {
            _readData = _reader.ReadFieldValue();
        }

        [Fact]
        public void It_should_parse_correctly()
        {
            _readData.Should().Be((decimal)-0.04);
        }
    }

    public class When_reading_a_short_string_field_value_via_amqp : XUnit2Specification
    {
        private Amqp091Reader _reader;
        private object _readData;

        protected override void Given()
        {
            _reader = new Amqp091Reader(new byte[] { (byte)'s', 5, 65, 66, 67, 68, 69, 6 });
        }

        protected override void When()
        {
            _readData = _reader.ReadFieldValue();
        }

        [Fact]
        public void It_should_parse_correctly()
        {
            _readData.Should().Be("ABCDE");
        }
    }

    public class When_reading_a_long_string_field_value_via_amqp : XUnit2Specification
    {
        private Amqp091Reader _reader;
        private object _readData;

        protected override void Given()
        {
            _reader = new Amqp091Reader(new byte[] { (byte)'S', 0, 0, 0, 5, 65, 66, 67, 68, 69, 6 });
        }

        protected override void When()
        {
            _readData = _reader.ReadFieldValue();
        }

        [Fact]
        public void It_should_parse_correctly()
        {
            _readData.Should().BeEquivalentTo(new byte[] { 65, 66, 67, 68, 69 });
        }
    }

    public class When_reading_a_timestamp_field_value_via_amqp : XUnit2Specification
    {
        private Amqp091Reader _reader;
        private object _readData;

        protected override void Given()
        {
            _reader = new Amqp091Reader(new byte[] { (byte)'T', 0, 0, 0, 0, 1, 0, 0, 5 });
        }

        protected override void When()
        {
            _readData = _reader.ReadFieldValue();
        }

        [Fact]
        public void It_should_parse_correctly()
        {
            _readData.Should().Be(new DateTime(1970, 7, 14, 4, 20, 21));
        }
    }

    public class When_reading_a_table_field_value_via_amqp : XUnit2Specification
    {
        private Amqp091Reader _reader;
        private IDictionary<string, object> _readData;

        protected override void Given()
        {
            _reader = new Amqp091Reader(new byte[] { (byte)'F', 0, 0, 0, 8, 5, 65, 66, 67, 68, 69, (byte)'t', 1 });
        }

        protected override void When()
        {
            _readData = (IDictionary<string, object>)_reader.ReadFieldValue();
        }

        [Fact]
        public void It_should_parse_correctly()
        {
            _readData
                .Should().HaveCount(1).And
                .ContainInOrder(new KeyValuePair<string, object>("ABCDE", true));
        }
    }

    public class When_reading_an_array_field_value_via_amqp : XUnit2Specification
    {
        private Amqp091Reader _reader;
        private object[] _readData;

        protected override void Given()
        {
            _reader = new Amqp091Reader(new byte[] { (byte)'A', 0, 0, 0, 2, (byte)'t', 1 });
        }

        protected override void When()
        {
            _readData = (object[])_reader.ReadFieldValue();
        }

        [Fact]
        public void It_should_parse_correctly()
        {
            _readData
                .Should().HaveCount(1).And
                .ContainInOrder(true);
        }
    }

    public class When_reading_no_field_field_value_via_amqp : XUnit2Specification
    {
        private Amqp091Reader _reader;
        private object _readData;

        protected override void Given()
        {
            _reader = new Amqp091Reader(new[] { (byte)'V' });
        }

        protected override void When()
        {
            _readData = _reader.ReadFieldValue();
        }

        [Fact]
        public void It_should_parse_correctly()
        {
            _readData
                .Should().Be(null);
        }
    }
    
    public class When_reading_one_property_flag_set : XUnit2Specification
    {
        private Amqp091Reader _reader;
        private bool[] _readData;

        protected override void Given()
        {
            _reader = new Amqp091Reader(new byte[] { 0, 2 });
        }

        protected override void When()
        {
            _readData = _reader.ReadPropertyFlags();
        }

        [Fact]
        public void It_should_parse_correctly()
        {
            _readData
                .Should().BeEquivalentTo(new[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, true });
        }
    }

    public class When_reading_multiple_property_flag_sets : XUnit2Specification
    {
        private Amqp091Reader _reader;
        private bool[] _readData;

        protected override void Given()
        {
            _reader = new Amqp091Reader(new byte[] { 0, 3, 128, 0 });
        }

        protected override void When()
        {
            _readData = _reader.ReadPropertyFlags();
        }

        [Fact]
        public void It_should_parse_correctly()
        {
            _readData
                .Should().BeEquivalentTo(new[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false });
        }
    }

    public class When_cloning_the_reader : XUnit2Specification
    {
        private Amqp091Reader _reader;
        private byte[] _readData;

        protected override void Given()
        {
            _reader = new Amqp091Reader(new byte[] { 0, 3, 128, 0 });
        }

        protected override void When()
        {
            _reader.ReadByte();
            var clonedReader = _reader.Clone();
            _readData = _reader.ReadBytes(clonedReader.Length);
        }

        [Fact]
        public void It_should_have_cloned_the_data_not_read()
        {
            _readData
                .Should().BeEquivalentTo(new byte[] { 3, 128, 0 });
        }
    }
}