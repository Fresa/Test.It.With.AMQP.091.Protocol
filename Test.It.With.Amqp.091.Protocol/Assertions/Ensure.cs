using System;

namespace Test.It.With.Amqp091.Protocol.Assertions
{
    internal static class Ensure
    {
        public static void Range(bool condition, string parameterName)
        {
            if (condition)
            {
                return;
            }

            throw new ArgumentOutOfRangeException(parameterName);
        }

        public static void That(bool condition, string parameterName, string message)
        {
            if (condition)
            {
                return;
            }

            throw new ArgumentException(message, parameterName);
        }

        public static void NotNull<T>(T value, string parameterName)
        {
            if (value != null)
            {
                return;
            }

            throw new ArgumentNullException(parameterName);
        }
    }
}