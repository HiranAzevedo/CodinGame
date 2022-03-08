using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace WarTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var p1ListOfCards = new List<string>
            {
                "AD",
                "KC",
                "QC",
            };

            var p2ListOfCards = new List<string>
            {
                "KH",
                "QS",
                "JC",
            };

            var pWinner = Solution.MakeTheGame(p1ListOfCards, p2ListOfCards);

            var result = $"{pWinner} {Solution.RoundCounter}";

            Assert.AreEqual("1 3", result);
        }

        [TestMethod]
        public void TestMethodOneGameOneBattle()
        {
            var p1ListOfCards = new List<string>
            {
"10H",
"KD",
"6C",
"10S",
"8S",
"AD",
"QS",
"3D",
"7H",
"KH",
"9D",
"2D",
"JC",
"KS",
"3S",
"2S",
"QC",
"AC",
"JH",
"7D",
"KC",
"10D",
"4C",
"AS",
"5D",
"5S",

            };

            var p2ListOfCards = new List<string>
            {
"2H",
"9C",
"8C",
"4S",
"5C",
"AH",
"JD",
"QH",
"7C",
"5H",
"4H",
"6H",
"6S",
"QD",
"9H",
"10C",
"4D",
"JS",
"6D",
"3H",
"8H",
"3C",
"7S",
"9S",
"8D",
"2C",
            };

            var pWinner = Solution.MakeTheGame(p1ListOfCards, p2ListOfCards);

            var result = $"{pWinner} {Solution.RoundCounter}";

            Assert.AreEqual("1 52", result);
        }


        [TestMethod]
        public void TestMethodLongGame()
        {
            var p1ListOfCards = new List<string>
            {
"AH",
"4H",
"5D",
"6D",
"QC",
"JS",
"8S",
"2D",
"7D",
"JD",
"JC",
"6C",
"KS",
"QS",
"9D",
"2C",
"5S",
"9S",
"6S",
"8H",
"AD",
"4D",
"2H",
"2S",
"7S",
"8C",
            };

            var p2ListOfCards = new List<string>
            {
"10H",
"4C",
"6H",
"3C",
"KC",
"JH",
"10C",
"AS",
"5H",
"KH",
"10S",
"9H",
"9C",
"8D",
"5C",
"AC",
"3H",
"4S",
"KD",
"7C",
"3S",
"QH",
"10D",
"3D",
"7H",
"QD",
            };

            var pWinner = Solution.MakeTheGame(p1ListOfCards, p2ListOfCards);

            var result = $"{pWinner} {Solution.RoundCounter}";

            Assert.AreEqual("2 1262", result);
        }
    }
}