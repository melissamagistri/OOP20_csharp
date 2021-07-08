using GrandiProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest
{
    [TestClass]
    class BossTests
    {
        [TestMethod]
        public void IsBossAlive()
        {
            Boss1 boss = new Boss1(0.0, 0.0);
            Assert.IsTrue(boss.IsAlive());
        }

        [TestMethod]
        public void IsBossDead()
        {
            Boss1 boss = new Boss1(0.0, 0.0);
            while (boss.GetHits() <= boss.GetMaxHits())
            {
                boss.IncHits();
            }
            Assert.IsFalse(boss.IsAlive());
        }

        [TestMethod]
        public void IsBossMovingCorrectly()
        {
            Boss1 boss = new Boss1(0.0, 0.0);
            boss.UpdateEntityPosition();
            Assert.IsTrue(boss.GetPos().Equals(
                new Pair<double, double>(0.0 + boss.GetMuX(), 0.0)));
        }
    }
}
