using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public static class StringExtensions
    {
        public static string Left(this string value, int length)
        {
            if (string.IsNullOrEmpty(value)) return string.Empty;
            if (length <= 0) return string.Empty;
            if (value.Length <= length) return value;

            return value.Substring(0, length);
        }

    }
}
