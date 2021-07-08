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
            Alien boss = new Alien(0, 0, GrandiProject.SpecificEntityType.ALIEN_1);
            Assert.IsTrue(boss.IsAlive());
        }

        [TestMethod]
        public void IsAlienDead()
        {
            Alien boss = new Alien(0, 0, GrandiProject.SpecificEntityType.ALIEN_1);
            while (boss.GetHits() <= boss.GetMaxHits())
            {
                boss.IncHits();
            }
            Assert.IsFalse(boss.IsAlive());
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