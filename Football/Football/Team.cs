using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    public class Team
    {
        private Coach couch;
        private List<FootballPlayer> players;
        private double averageAge;

        public Coach GetCouch()
        {
            return couch;
        }

        public void SetCouch(Coach couch)
        {
            this.couch = couch;
        }

        public List<FootballPlayer> GetPlayers()
        {
            return players;
        }

        public void SetPlayers(List<FootballPlayer> players)
        {
            this.players = players;
        }

        public double GetAverageAge()
        {
            return averageAge;
        }

        public void SetAverageAge(double averageAge)
        {
            this.averageAge = averageAge;
        }

        public override string ToString()
        {
            return "Team{" +
                "couch=" + couch +
                ", players=" + players +
                ", averageAge=" + averageAge +
                '}';
        }
    }
}
