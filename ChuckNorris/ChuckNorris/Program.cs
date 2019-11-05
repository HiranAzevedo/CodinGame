using System;
using System.Text;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
namespace ChuckNorris
{
    public class Solution
    {
        private static void Main(string[] args)
        {
            var message = Console.ReadLine();
            var result = ConvertToUnary(message);
            Console.WriteLine(result);
        }

        public static string ConvertToUnary(string message)
        {
            var sb = new StringBuilder();
            var unaryMessage = new StringBuilder();
            const char zero = '0';
            const char one = '1';

            foreach (var letter in message)
            {
                var byteConverted = Convert.ToString(letter, 2);

                if (byteConverted.Length < 7)
                {
                    byteConverted = new string('0', 7 - byteConverted.Length) + byteConverted;
                }

                sb.Append(byteConverted);
            }

            var lastBinary = char.MaxValue;

            foreach (var binaryChar in sb.ToString().ToCharArray())
            {
                if (binaryChar == zero)
                {
                    unaryMessage.Append(lastBinary == zero ? "0" : " 00 0");
                }
                else
                {
                    unaryMessage.Append(lastBinary == one ? "0" : " 0 0");
                }

                lastBinary = binaryChar;
            }

            return unaryMessage.ToString().Trim();
        }
    }
}