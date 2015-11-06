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
        public void TestingMyInitialCounter()
        {
            myGame game = new myGame();
            int expected = 2;
            Assert.AreEqual(expected, game.Checker());
        }

        [TestMethod]
        public void CreationOfCellsInstance()
        {
            Cells cell = new Cells();
            Assert.IsNotNull(cell);
        }
    }
}
