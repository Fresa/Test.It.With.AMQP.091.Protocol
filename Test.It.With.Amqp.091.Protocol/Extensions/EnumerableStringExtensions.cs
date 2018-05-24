using System.Collections.Generic;

namespace Test.It.With.Amqp091.Protocol.Extensions
{
    internal static class EnumerableStringExtensions
    {
        public static string Join(this IEnumerable<string> strings, string separator)
        {
            return string.Join(separator, strings);
        }
    }
}