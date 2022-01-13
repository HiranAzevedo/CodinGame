using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace TestRun
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var rotorlist = new List<List<char>>
            {
                new List<char>("BDFHJLCPRTXVZNYEIWGAKMUSQO".ToCharArray()),
                new List<char>("AJDKSIRUXBLHWTMCQGZNPYFVOE".ToCharArray()),
                new List<char>("EKMFLGDQVZNTOWYHXUSPAIBRCJ".ToCharArray())
            };
            string message = "WEATHERREPORTWINDYTODAY";
            var result = Solution.Encode(7, rotorlist, message);

            Assert.AreEqual(result, "ALWAURKQEQQWLRAWZHUYKVN");
        }

        [TestMethod]
        public void TestMethod2()
        {
            var rotorlist = new List<List<char>>
            {
                new List<char>("BDFHJLCPRTXVZNYEIWGAKMUSQO".ToCharArray()),
                new List<char>("AJDKSIRUXBLHWTMCQGZNPYFVOE".ToCharArray()),
                new List<char>("EKMFLGDQVZNTOWYHXUSPAIBRCJ".ToCharArray())
            };
            string message = "AAA";
            var result = Solution.Encode(4, rotorlist, message);

            Assert.AreEqual(result, "KQF");
        }

        [TestMethod]
        public void TestMethod3()
        {
            var rotorlist = new List<List<char>>
            {
                new List<char>("BDFHJLCPRTXVZNYEIWGAKMUSQO".ToCharArray()),
                new List<char>("AJDKSIRUXBLHWTMCQGZNPYFVOE".ToCharArray()),
                new List<char>("EKMFLGDQVZNTOWYHXUSPAIBRCJ".ToCharArray())
            };
            string message = "KQF";
            var result = Solution.Decode(4, rotorlist, message);

            Assert.AreEqual(result, "AAA");
        }

        [TestMethod]
        public void TestMethod4()
        {
            var rotorlist = new List<List<char>>
            {
                new List<char>("BDFHJLCPRTXVZNYEIWGAKMUSQO".ToCharArray()),
                new List<char>("AJDKSIRUXBLHWTMCQGZNPYFVOE".ToCharArray()),
                new List<char>("EKMFLGDQVZNTOWYHXUSPAIBRCJ".ToCharArray())
            };
            string message = "XPCXAUPHYQALKJMGKRWPGYHFTKRFFFNOUTZCABUAEHQLGXREZ";
            var result = Solution.Decode(5, rotorlist, message);

            Assert.AreEqual(result, "THEQUICKBROWNFOXJUMPSOVERALAZYSPHINXOFBLACKQUARTZ");
        }
    }
}