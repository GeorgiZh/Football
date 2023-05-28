using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    public class Game
    {
        private Team teamOne;
        private Team teamTwo;
        private Referee referee;
        private List<Referee> assistantReferee;
        private Goal goals;
        private GameResult gameResult;
        private Team winner;

        public Game(Team teamOne, Team teamTwo, Referee referee, List<Referee> assistantReferee, Goal goals, GameResult gameResult, Team winner)
        {
            this.teamOne = teamOne;
            this.teamTwo = teamTwo;
            this.referee = referee;
            this.assistantReferee = assistantReferee;
            this.goals = goals;
            this.gameResult = gameResult;
            this.winner = winner;
        }

        public Team GetTeamOne()
        {
            return teamOne;
        }

        public void SetTeamOne(Team teamOne)
        {
            this.teamOne = teamOne;
        }

        public Team GetTeamTwo()
        {
            return teamTwo;
        }

        public void SetTeamTwo(Team teamTwo)
        {
            this.teamTwo = teamTwo;
        }

        public Referee GetReferee()
        {
            return referee;
        }

        public void SetReferee(Referee referee)
        {
            this.referee = referee;
        }

        public List<Referee> GetAssistantReferee()
        {
            return assistantReferee;
        }

        public void SetAssistantReferee(List<Referee> assistantReferee)
        {
            this.assistantReferee = assistantReferee;
        }

        public Goal GetGoals()
        {
            return goals;
        }

        public void SetGoals(Goal goals)
        {
            this.goals = goals;
        }

        public GameResult GetGameResult()
        {
            return gameResult;
        }

        public void SetGameResult(GameResult gameResult)
        {
            this.gameResult = gameResult;
        }

        public Team GetWinner()
        {
            return winner;
        }

        public void SetWinner(Team winner)
        {
            this.winner = winner;
        }

        public override string ToString()
        {
            return "Game{" +
                "teamOne=" + teamOne +
                ", teamTwo=" + teamTwo +
                ", referee=" + referee +
                ", assistantReferee=" + assistantReferee +
                ", goals=" + goals +
                ", gameResult=" + gameResult +
                ", winner=" + winner +
                '}';
        }

        public class Goal
        {
            public double Minute { get; set; }
            public FootballPlayer Player { get; set; }

            public Goal(double minute, FootballPlayer player)
            {
                Minute = minute;
                Player = player;
            }

            public override string ToString()
            {
                return "Goal{" +
                    "minute=" + Minute +
                    ", player=" + Player +
                    '}';
            }
        }

        public class GameResult
        {
            public int TeamOneScore { get; set; }
            public int TeamTwoScore { get; set; }

            public GameResult(int teamOneScore, int teamTwoScore)
            {
                TeamOneScore = teamOneScore;
                TeamTwoScore = teamTwoScore;
            }

            public override string ToString()
            {
                return "GameResult{" +
                    "teamOneScore=" + TeamOneScore +
                    ", teamTwoScore=" + TeamTwoScore +
                    '}';
            }
        }
    }
}
