using System.Collections.Generic;

namespace Test.It.With.Amqp091.Protocol.Extensions
{
    public static class StringExtensions
    {
        public static string[] SplitOnUpperCase(this string str)
        {
            var strings = new List<string>();

            if (str == null)
            {
                return strings.ToArray();
            }

            var splitString = "";
            foreach (var chr in str)
            {
                if (splitString != "" && char.IsUpper(chr))
                {
                    strings.Add(splitString);
                    splitString = "";
                }

                splitString += chr;
            }

            if (splitString != "")
            {
                strings.Add(splitString);
            }

            return strings.ToArray();
        }
    }
}