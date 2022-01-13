using System;
using System.Collections.Generic;
using System.Linq;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
namespace ascii_art
{
    public class Solution
    {
        private static readonly List<char> CharMap = new List<char> { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '?' };

        static void Main(string[] args)
        {
            var length = int.Parse(Console.ReadLine() ?? "0");
            var height = int.Parse(Console.ReadLine() ?? "0");

            var input = Console.ReadLine();

            var linesArtInput = new List<string>();

            for (var i = 0; i < height; i++)
            {
                var line = Console.ReadLine() ?? string.Empty;
                linesArtInput.Add(line);
            }

            var output = GenerateAsciiOutput(length, height, input, linesArtInput);

            foreach (var text in output)
            {
                Console.WriteLine(text);
            }
        }

        public static string[] GenerateAsciiOutput(int length, int height, string input, List<string> artInputList)
        {
            input = input.ToUpper();
            var artList = new List<List<string>>(height);

            for (var i = 0; i < height; i++)
            {
                artList.Add(new List<string>());
                var line = artInputList[i] ?? string.Empty;

                var lineSplited = Enumerable.Range(0, line.Length / length).Select(x => line.Substring(x * length, length));

                foreach (var partialLine in lineSplited)
                {
                    artList[i].Add(partialLine);
                }
            }

            var outLine = new string[height];

            for (var i = 0; i < height; i++)
            {
                foreach (var letter in input)
                {
                    var letterIndex = CharMap.IndexOf(letter);

                    if (letterIndex < 0)
                    {
                        letterIndex = CharMap.IndexOf('?');
                    }

                    outLine[i] = ($"{outLine[i]}{artList[i][letterIndex]}");
                }
            }

            return outLine;
        }
    }
}