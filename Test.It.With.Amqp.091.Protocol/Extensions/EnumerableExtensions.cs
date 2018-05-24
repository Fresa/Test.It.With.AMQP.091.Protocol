using System;
using System.Collections.Generic;
using System.Linq;

namespace Test.It.With.Amqp091.Protocol.Extensions
{
    internal static class EnumerableExtensions
    {
        public static string Join<T>(this IEnumerable<T> enumerable, string delimiter, string lastDelimiter, Func<T, string> converter)
        {
            var list = enumerable.ToList();
            if (list.Any() == false)
            {
                return string.Empty;
            }

            if (list.Count == 1)
            {
                return converter(list.First());
            }

            return string.Join(delimiter, list.Take(list.Count - 1).Select(converter)) + lastDelimiter + converter(list.Last());
        }
    }
}