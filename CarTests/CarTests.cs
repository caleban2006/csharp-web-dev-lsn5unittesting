using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarNS;
using System.IO;

namespace CarTests
{
    [TestClass]
    public class CarTests
    {
        //TODO: add emptyTest so we can configure our runtime environment (remove this test before pushing to your personal GitHub account)
        //TODO: constructor sets gasTankLevel properly
        //TODO: gasTankLevel is accurate after driving within tank range
        [TestMethod]
        public void GasTankLevelTest()
        {
            Car test_car = new Car("Toyota", "Prius", 10, 50);
            test_car.Drive(50);
            Assert.AreEqual(9, test_car.GasTankLevel, .001);
        }
        //TODO: gasTankLevel is accurate after attempting to drive past tank range
        //TODO: can't have more gas than tank size, expect an exception

    }
}
