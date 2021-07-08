using MagistriProject;
using GrandiProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest
{
  
    [TestClass]
    class PlayerTests
    {
        [TestMethod]
        public void IsPlayerAlive()
        {
            Player player = new Player1(SpecificEntityType.PLAYER_1, 0.0, 0.0 );
            Assert.IsTrue(player.IsAlive());
        }

        [TestMethod]
        public void IsPlayerDead()
        {
            Player player = new Player1(SpecificEntityType.PLAYER_1, 0.0, 0.0);
            while (player.GetHits() <= player.GetMaxHits())
            {
                player.IncHits();
            }
            Assert.IsFalse(player.IsAlive());
        }

        [TestMethod]
        public void IsAlienMovingCorrectly()
        {
            Player player = new Player1(SpecificEntityType.PLAYER_1, 0.0, 0.0);
            player.UpdateEntityPosition(GameEvent.RIGHT, 2);
            Assert.IsTrue(player.GetPos().Equals(
                new Pair<double, double>(0.0 + player.GetMuX(), player.GetY())));
        }

    }
}
