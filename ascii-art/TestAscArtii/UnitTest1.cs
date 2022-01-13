using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ascii_art;
using System;
using System.Diagnostics;

namespace TestAscArtii
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodLetterE()
        {
            var heigth = 5;
            var lenght = 4;
            var input = "E";
            var rowInputs = new List<string>
            {
                " #  ##   ## ##  ### ###  ## # # ###  ## # # #   # # ###  #  ##   #  ##   ## ### # # # # # # # # # # ### ### ",
                "# # # # #   # # #   #   #   # #  #    # # # #   ### # # # # # # # # # # #    #  # # # # # # # # # #   #   # ",
                "### ##  #   # # ##  ##  # # ###  #    # ##  #   ### # # # # ##  # # ##   #   #  # # # # ###  #   #   #   ## ",
                "# # # # #   # # #   #   # # # #  #  # # # # #   # # # # # # #    ## # #   #  #  # # # # ### # #  #  #       ",
                "# # ##   ## ##  ### #    ## # # ###  #  # # ### # # # #  #  #     # # # ##   #  ###  #  # # # #  #  ###  #  "
            };

            var rowOutput = new string[]
            {
                "### ",
                "#   ",
                "##  ",
                "#   ",
                "### "
            };

            var result = Solution.GenerateAsciiOutput(lenght, heigth, input, rowInputs);

            for (int i = 0; i < heigth; i++)
            {
                Assert.AreEqual(result[i], rowOutput[i]);
            }
        }

        [TestMethod]
        public void TestMethodMANHATTAN()
        {
            var heigth = 5;
            var lenght = 4;
            var input = "MANHATTAN";
            var rowInputs = new List<string>
            {
                " #  ##   ## ##  ### ###  ## # # ###  ## # # #   # # ###  #  ##   #  ##   ## ### # # # # # # # # # # ### ### ",
                "# # # # #   # # #   #   #   # #  #    # # # #   ### # # # # # # # # # # #    #  # # # # # # # # # #   #   # ",
                "### ##  #   # # ##  ##  # # ###  #    # ##  #   ### # # # # ##  # # ##   #   #  # # # # ###  #   #   #   ## ",
                "# # # # #   # # #   #   # # # #  #  # # # # #   # # # # # # #    ## # #   #  #  # # # # ### # #  #  #       ",
                "# # ##   ## ##  ### #    ## # # ###  #  # # ### # # # #  #  #     # # # ##   #  ###  #  # # # #  #  ###  #  "
            };

            var rowOutput = new string[]
            {
                "# #  #  ### # #  #  ### ###  #  ### ",
                "### # # # # # # # #  #   #  # # # # ",
                "### ### # # ### ###  #   #  ### # # ",
                "# # # # # # # # # #  #   #  # # # # ",
                "# # # # # # # # # #  #   #  # # # # "
            };

            var result = Solution.GenerateAsciiOutput(lenght, heigth, input, rowInputs);
            
            for (int i = 0; i < heigth; i++)
            {
                Assert.AreEqual(rowOutput[i], result[i]);
            }
        }
    }
}
