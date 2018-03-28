using System;
using System.Collections.Generic;

namespace TennisScore
{
    public class TennisGame
    {
        private readonly IRepository<Game> _repo;
        private readonly string LOVE = "Love";
        private readonly string ALL = "All";
        private readonly string FIFTEEN = "Fifteen";
        private readonly string THIRTY = "Thirty";
        private readonly string DEUCE = "Deuce";

        public TennisGame(IRepository<Game> repo)
        {
            _repo = repo;
        }

        private Dictionary<int, String> ScoreStr = new Dictionary<int, string>();

        public void InitScoreStr()
        {
            ScoreStr.Add(0, LOVE);
            ScoreStr.Add(1, FIFTEEN);
            ScoreStr.Add(2, THIRTY);
            //ScoreStr.Add(3, );
            //ScoreStr.Add(4, LOVE);
        }

        

        public string ScoreResult(int gameId)
        {
            var game = this._repo.GetGame(gameId);
            var result = String.Empty;
            var player1score = game.FirstPlayerScore;
            var player2score = game.SecondPlayerScore;
            InitScoreStr();

            if (player1score == player2score)
            {
                // player1 , player2  all < 3
                if (player1score == 0)
                {
                    result = LOVE + " " + ALL;
                }
                else if (player1score == 1)
                {
                    result = FIFTEEN + " " + ALL;
                }
                else if (player1score == 2)
                {
                    result = THIRTY + " " + ALL;
                }
                // deuce
                if (player1score >= 3 && player2score >= 3)
                {
                    result = DEUCE;
                }
            }
            else
            {
                // before deuce
                if (player1score <= 2 && player2score <= 2)
                {
                    result = ScoreStr[player1score] + " " + ScoreStr[player2score];
                }
                else
                { 
                    // after deuce
                    if (player1score >= 3 || player2score >= 3)
                    {
                        result = DEUCE;
                    }
                }

                //if (0 == player1score && 1 == player2score)
                //{
                //    result = LOVE + " " + FIFTEEN;
                //}

               
                
            }
            
           
            
            return result;
        }

        
    }
}