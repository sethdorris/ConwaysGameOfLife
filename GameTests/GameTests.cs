using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConwaysGameOfLife;


namespace GameTests
{
    [TestClass]
    public class GameTests
    {
        [TestMethod]
        public void CreateAnInstanceOfGameClass()
        {
            myGame game = new myGame();
            Assert.IsNotNull(game);
        }

        [TestMethod]
        public void CanAccessMyIndex()
        {
            myGame game = new myGame();
            int expected = 0;
            Assert.AreEqual(expected, game.getIndex());
        }

        [TestMethod]
        public void CanSetMyIndex()
        {
            myGame game = new myGame();
            int expected = 1;
            game.setIndex(1);
            Assert.AreEqual(expected, game.getIndex());
        }

        [TestMethod]
        public void TestingLessThanTwoNeighborsDies()
        {
            myGame game = new myGame();
            Assert.AreEqual(false, game.caseOne());
        }

        [TestMethod]
        public void TestingTwoOrThreeLiveNeighborsLivesOn()
        {
            myGame game = new myGame();
            Assert.AreEqual(true, game.caseTwo());
        }

        [TestMethod]
        public void TestingThreeOrMoreNeighborsDies()
        {
            myGame game = new myGame();
            Assert.AreEqual(true, game.caseThree());
        }

        [TestMethod]
        public void TestingExactlyThreeLiveNeighborsLives()
        {
            myGame game = new myGame();
            Assert.AreEqual(false, game.caseFour());
        }

        [TestMethod]
        public void TestingLoopThroughCells()   
        {
            myGame game = new myGame();
            Assert.IsNotNull(game.LoopThroughCells());
        }
    }
}
