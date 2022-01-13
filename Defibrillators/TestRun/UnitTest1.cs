using DefibrillatorsSolution;
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
            var clientLongitude = "3,879483";
            var clientLatitude = "43,608177";

            var desfibList = new List<string>()
            {
                "1; Maison de la Prevention Sante; 6 rue Maguelone 340000 Montpellier; ; 3,87952263361082; 43,6071285339217",
                "2; Hotel de Ville; 1 place Georges Freche 34267 Montpellier; ; 3,89652239197876; 43,5987299452849",
                "3; Zoo de Lunaret; 50 avenue Agropolis 34090 Mtp; ; 3,87388031141133; 43,6395872778854"
            };

            var result = Solution.SelectDesfib(clientLongitude, clientLatitude, desfibList);

            Assert.AreEqual(" Maison de la Prevention Sante", result);
        }
    }
}




