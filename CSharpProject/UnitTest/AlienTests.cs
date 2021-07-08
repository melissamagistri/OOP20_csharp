using GuidazziProject;
using GrandiProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest
{
    [TestClass]
    class AlienTests
    {
        [TestMethod]
        public void IsAlienAlive()
        {
            Alien alien = new Alien(0, 0, GrandiProject.SpecificEntityType.ALIEN_1);
            Assert.IsTrue(alien.IsAlive());
        }

        [TestMethod]
        public void IsAlienDead()
        {
            Alien alien = new Alien(0, 0, GrandiProject.SpecificEntityType.ALIEN_1);
            while (alien.GetHits() <= alien.GetMaxHits())
            {
                alien.IncHits();
            }
            Assert.IsFalse(alien.IsAlive());
        }

        [TestMethod]
        public void IsAlienMovingCorrectly()
        {
            Alien alien = new Alien(0, 0, GrandiProject.SpecificEntityType.ALIEN_1);
            alien.UpdateEntityPosition();
            Assert.IsTrue(alien.GetPos().Equals(
                new Pair<double, double>(0.0 + alien.GetMuX(), alien.GetY())));
        }
    }
}