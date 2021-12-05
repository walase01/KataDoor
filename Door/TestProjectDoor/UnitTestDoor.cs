using Microsoft.VisualStudio.TestTools.UnitTesting;
using Door;

namespace TestProjectDoor
{
    [TestClass]
    public class UnitTestDoor
    {
        [TestMethod]
        public void TestMethodtoCreateDoorAndVerifyOpen()
        {
            string key = "JoseKey";

            Door.Door door = new Door.Door(false, false, false, false);
            door.ClosedAndUnlocked(key);

            Assert.AreEqual(true, door.OpenDoor());
            
        }
    }
}
