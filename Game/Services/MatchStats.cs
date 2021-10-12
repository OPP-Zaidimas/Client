using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Services
{
    public class MatchStats
    {
        private int _matchId;
        private string _heroUsername;
        private string _enemyUsername;

        public MatchStats(int matchId, string heroUsername, string enemyUsername)
        {
            _matchId = matchId;
            _heroUsername = heroUsername;
            _enemyUsername = enemyUsername;
        }

        public int GetMatchId() { return _matchId; }
        public string GetHeroUsername() { return _heroUsername; }
        public string GetEnemyUsername() { return _enemyUsername; }
    }
}
