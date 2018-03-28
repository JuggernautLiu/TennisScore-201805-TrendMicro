using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;

namespace TennisScore
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        // 0,0 Love All
        public void Score_0_0_Love_All()
        {
            var gameId = 91;
            var firstPlayerScore = 0;
            var secondPlayerScore = 0;

            IRepository<Game> repo = Substitute.For<IRepository<Game>>();
            repo.GetGame(gameId).Returns(new Game { Id = gameId, FirstPlayerScore = firstPlayerScore, SecondPlayerScore = secondPlayerScore });


            TennisGame tennisGame = new TennisGame(repo);

            var scoreResult = tennisGame.ScoreResult(gameId);
            Assert.AreEqual("Love All", scoreResult);
        }

        [TestMethod]
        // 1,1 Fifteen All
        public void Score_1_1_Fifteen_All()
        {
            var gameId = 91;
            var firstPlayerScore = 1;
            var secondPlayerScore = 1;

            IRepository<Game> repo = Substitute.For<IRepository<Game>>();
            repo.GetGame(gameId).Returns(new Game { Id = gameId, FirstPlayerScore = firstPlayerScore, SecondPlayerScore = secondPlayerScore });


            TennisGame tennisGame = new TennisGame(repo);

            var scoreResult = tennisGame.ScoreResult(gameId);
            Assert.AreEqual("Fifteen All", scoreResult);
        }

        [TestMethod]
        // 2,2 Thirty All
        public void Score_2_2_Thirty_All()
        {
            var gameId = 91;
            var firstPlayerScore = 2;
            var secondPlayerScore = 2;

            IRepository<Game> repo = Substitute.For<IRepository<Game>>();
            repo.GetGame(gameId).Returns(new Game { Id = gameId, FirstPlayerScore = firstPlayerScore, SecondPlayerScore = secondPlayerScore });


            TennisGame tennisGame = new TennisGame(repo);

            var scoreResult = tennisGame.ScoreResult(gameId);
            Assert.AreEqual("Thirty All", scoreResult);
        }

        [TestMethod]
        // 0,1 Love Fifteen
        public void Score_0_1_Love_Fifteen()
        {
            var gameId = 91;
            var firstPlayerScore = 0;
            var secondPlayerScore = 1;

            IRepository<Game> repo = Substitute.For<IRepository<Game>>();
            repo.GetGame(gameId).Returns(new Game { Id = gameId, FirstPlayerScore = firstPlayerScore, SecondPlayerScore = secondPlayerScore });

            TennisGame tennisGame = new TennisGame(repo);

            var scoreResult = tennisGame.ScoreResult(gameId);
            Assert.AreEqual("Love Fifteen", scoreResult);
        }

        [TestMethod]
        // 0,2 Love_Thirty
        public void Score_0_2_Love_Thirty()
        {
            var gameId = 91;
            var firstPlayerScore = 0;
            var secondPlayerScore = 2;

            IRepository<Game> repo = Substitute.For<IRepository<Game>>();
            repo.GetGame(gameId).Returns(new Game { Id = gameId, FirstPlayerScore = firstPlayerScore, SecondPlayerScore = secondPlayerScore });

            TennisGame tennisGame = new TennisGame(repo);

            var scoreResult = tennisGame.ScoreResult(gameId);
            Assert.AreEqual("Love Thirty", scoreResult);
        }

        [TestMethod]
        // 2,0 Thirty Love
        public void Score_2_0_Love_Thirty()
        {
            var gameId = 91;
            var firstPlayerScore = 2;
            var secondPlayerScore = 0;

            IRepository<Game> repo = Substitute.For<IRepository<Game>>();
            repo.GetGame(gameId).Returns(new Game { Id = gameId, FirstPlayerScore = firstPlayerScore, SecondPlayerScore = secondPlayerScore });

            TennisGame tennisGame = new TennisGame(repo);

            var scoreResult = tennisGame.ScoreResult(gameId);
            Assert.AreEqual("Thirty Love", scoreResult);
        }

        [TestMethod]
        // 3,3 Deuce
        public void Score_3_3_Deuce()
        {
            var gameId = 91;
            var firstPlayerScore = 3;
            var secondPlayerScore = 3;

            IRepository<Game> repo = Substitute.For<IRepository<Game>>();
            repo.GetGame(gameId).Returns(new Game { Id = gameId, FirstPlayerScore = firstPlayerScore, SecondPlayerScore = secondPlayerScore });

            TennisGame tennisGame = new TennisGame(repo);

            var scoreResult = tennisGame.ScoreResult(gameId);
            Assert.AreEqual("Deuce", scoreResult);
        }

        [TestMethod]
        // 4,4 Deuce
        public void Score_4_4_Deuce()
        {
            var gameId = 91;
            var firstPlayerScore = 4;
            var secondPlayerScore = 4;

            IRepository<Game> repo = Substitute.For<IRepository<Game>>();
            repo.GetGame(gameId).Returns(new Game { Id = gameId, FirstPlayerScore = firstPlayerScore, SecondPlayerScore = secondPlayerScore });

            TennisGame tennisGame = new TennisGame(repo);

            var scoreResult = tennisGame.ScoreResult(gameId);
            Assert.AreEqual("Deuce", scoreResult);
        }
    }
}