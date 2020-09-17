using System;
using System.Diagnostics;
using System.Globalization;
using System.Text;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "Hello Batman ";
            string mickey = "Hello Mickey Mouse";


            string result = myString + mickey;
            //for (int i = 0; i < 100000; i++)
            //{
            //  Console.WriteLine(i);
            //}
            //Console.WriteLine(result);

            Stopwatch stopwatch2 = new Stopwatch();
            stopwatch2.Start();
            StringBuilder builder = new StringBuilder();
            builder.Append(result);

            for (int i = 0; i < 100000; i++)
            {
                builder.Append(i);
                
            }
            stopwatch2.Stop();
            Console.WriteLine(stopwatch2.Elapsed);
          

            string longString = "a, b, c, ddd, s, s          ";
            Console.WriteLine(longString);
            string replaceString = longString.Replace(",", ";");
            Console.WriteLine(replaceString);

            Console.WriteLine(myString.Remove(6, 6));
            Console.WriteLine(longString.Trim());

            Console.WriteLine(myString.Length);
            Console.WriteLine(myString[0]);
            Console.WriteLine(myString.Contains("m"));

            decimal number = 1224214352134;
            CultureInfo culture = new CultureInfo("en-us");
            Console.WriteLine(number.ToString("c", culture));

            CultureInfo cultureIndian = new CultureInfo("en-GB");
            Console.WriteLine(number.ToString("c", cultureIndian));
        }
    }
}
