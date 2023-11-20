using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2_ConsoleApp;

namespace Task2_NUnitTest
{
    public class TestTask3
    {
         [TestCase(10.7, 10.8, "Mimi", "RockyBurrow",eCoziness.Rocky, 1, false)]
        /* [TestCase(double longitude, double latitude, string name, eCoziness cozinessLvel, int numberOfRooms, bool isSelfMade, List<string>toys)]
         [TestCase(double longitude, double latitude, string name, eCoziness cozinessLvel, int numberOfRooms, bool isSelfMade, List<string>toys)]*/
        [Test] 
        public void Check_CreatesObject_IsDescriptionCorrect(double longtitude, double latitude, string name, string houseName, eCoziness cozinessLvel, int numberOfRooms, bool isSelfMade) 
        {
            Hamster hamster = new Hamster(name, new Burrow(longtitude, latitude, houseName, cozinessLvel, numberOfRooms, isSelfMade));
           string result= hamster.GetBurrowDescription(true);
           string expected = "Mimi has a burrow at longitude 10,70 and latitude 10,80. the hamster gave its house the name RockyBurrowand it thinks the house is Rocky. the burrow is not self made and it has 1 room";
            Assert.AreEqual(expected, result);


        }
    }
}
