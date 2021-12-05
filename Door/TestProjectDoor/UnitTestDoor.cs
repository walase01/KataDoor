using Microsoft.VisualStudio.TestTools.UnitTesting;
using Door;

namespace TestProjectDoor
{
    [TestClass]
    public class UnitTestDoor
    {

        public const string key = "JoseKey";

        Door.Door door = new Door.Door(false, false, false, false);


        [TestMethod]
        public void TestMethodtoCreateDoorAndVerifyOpen()
        {           
            door.ClosedAndUnlocked(key);
            door.OpenDoor();
            Assert.AreEqual(true, door.isOpen());
        }

        [TestMethod]
        public void testMethodCreateDoorandVerifyClose()
        {
            door.OpenAndUnlocked(key);
            door.CloseDoor();
            Assert.AreEqual(true, door.isClose());
        }

        [TestMethod]
        public void testMethodCreateDoorVerifyLocked()
        {
            door.ClosedAndUnlocked(key);
            door.LockedDoor();
            Assert.AreEqual(true, door.isLocked());
        }

        [TestMethod]
        public void testMethodCreateVerifyunLoked()
        {
            door.OpenAndUnlocked(key);
            door.CloseDoor();
            door.LockedDoor();
            Assert.AreEqual(true, door.isLocked());
        }

    }
}
