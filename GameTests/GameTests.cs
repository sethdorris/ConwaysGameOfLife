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
            Assert.AreEqual(false, game.caseOne(0, 0));
        }

        [TestMethod]
        public void TestingTwoOrThreeLiveNeighborsLivesOn()
        {
            myGame game = new myGame();
            Assert.AreEqual(true, game.caseOne(0, 1));
        }

        [TestMethod]
        public void TestingLiveCellWithThreeOrMoreNeighborsDies()
        {
            myGame game = new myGame();
            Assert.AreEqual(true, game.caseOne(1, 2));
        }

        [TestMethod]
        public void TestingDeadCellExactlyThreeLiveNeighborsLives()
        {
            myGame game = new myGame();
            Assert.AreEqual(true, game.caseOne(1, 0));
        }

        [TestMethod]
        public void CaseOneCellTouchesTwoLiveCells()
        {
            myGame game = new myGame();
            Assert.AreEqual(false, game.caseOne(0,0));
        }

        [TestMethod]
        public void LivesOnToNextGeneration()
        {
            myGame game = new myGame();
            Assert.AreEqual(true, game.caseOne(1, 1));
        }
    }
}
