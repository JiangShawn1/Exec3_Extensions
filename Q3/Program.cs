using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {//針對 string 寫一個擴充方法 ToInt(this string value, int
         //defaultValue), 可以將 string 轉換成 int 型別, 如果無法轉型成
         //功, 傳回 defaultValue

            string value = "answer";
            string number = "12345";

            int value1 = value.ToInt(54321);
            int number1 = number.ToInt(54321);
            
            Console.WriteLine(value1);
            Console.WriteLine(number1);
        }
    }
    public static class StringExtensions
    {
        public static int ToInt(this string value, int defaultValue)
        {
            
            bool isInt = int.TryParse(value, out int number); ;

            return isInt ? number : defaultValue;
        }

    }

}
