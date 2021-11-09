using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Services.SignalR
{
    interface IService
    {


        public async Task Connect()
        {
        }

        public async Task CreateNewGame(string username)
        {
        }

        public async Task JoinGame(int matchId, string username)
        {
        }

        public async Task PlaceCard((int cardId, int cardHp) card)
        {
        }

        public async Task MonsterAttack(int attackerId, int attackerOffense, int deffenderId, int deffenderHp)
        {
        }

        public async Task EndTurn()
        {
        }

        public void RegisterMatchStats(MatchStats stats)
        {
        }
    }
}
