using System;
using System.Linq;

namespace Test.It.With.Amqp091.Protocol.Generator.Transformation.Extensions
{
    public static class TypeExtensions
    {
        public static string GetPrettyFullName(this Type type)
        {
            var prettyName = type.FullName;
            if (type.IsGenericType == false)
            {
                return prettyName;
            }

            if (prettyName?.IndexOf('`') > 0)
            {
                prettyName = prettyName.Remove(prettyName.IndexOf('`'));
            }

            var genericArguments = type.GetGenericArguments()
                .Select(GetPrettyFullName);

            return $"{prettyName}<{string.Join(", ", genericArguments)}>";
        }

        public static bool IsNullable(this Type type)
        {
            return !type.IsValueType || Nullable.GetUnderlyingType(type) != null;
        }
    }
}