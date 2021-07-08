using TomideiProject;
using GrandiProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest
{
    [TestClass]
    public class WorldTest
    {
        [TestMethod]
        public void isWorldCreatedCorrectly()
        {
            var world = new WorldImpl();
            world.startNextLevel();
            Assert.IsTrue(world.GetLevelEntities().Count.Equals(2));
        }
    }
}
