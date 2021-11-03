using System;
using System.Threading.Tasks;
using Game.Services.SignalR;
using Microsoft.AspNetCore.SignalR.Client;

namespace Game.Services
{
    public class SignalRService
    {
        private readonly HubConnection _connection;

        public event Action<int> MatchIdReceived;
        public event Action<string> OnGameJoinFailureReceived;
        public event Action<string, int> OnGameStartSignalReceived;
        public event Action<int[], int[], int[], int[]> OnReceiveCardDecks;
        public event Action<bool> OnReceiveEndTurn;

        public MatchStats MatchStats;

        public SignalRService(HubConnection connection)
        {
            _connection = connection;

            _connection.On<int>(NetworkCall.ReceiveCode,
                code => MatchIdReceived?.Invoke(code));

            _connection.On<string>(NetworkCall.ReceiveFailure,
                failureMsg => OnGameJoinFailureReceived?.Invoke(failureMsg));

            _connection.On<string, int>(NetworkCall.StartGame,
                (opponentUsername, matchId) => OnGameStartSignalReceived?.Invoke(opponentUsername, matchId));

            _connection.On<int[], int[], int[], int[]>(NetworkCall.ReceiveCardDecks,
                (heroCards, heroHPs, opponentCards, opponentHPs) => OnReceiveCardDecks?.Invoke(heroCards, heroHPs, opponentCards,opponentHPs));

            _connection.On<bool>(NetworkCall.ReceiveEndTurn, buttonStatus => OnReceiveEndTurn.Invoke(buttonStatus));
        }

        public async Task Connect()
        {
            await _connection.StartAsync();
        }

        public async Task CreateNewGame(string username)
        {
            await _connection.SendAsync(NetworkCall.CreateGame, username);
        }

        public async Task JoinGame(int matchId, string username)
        {
            await _connection.SendAsync(NetworkCall.JoinGame, matchId, username);
        }

        public async Task PlaceCard((int cardId, int cardHp) card)
        {
            await _connection.SendAsync(
                NetworkCall.PlaceCard,
                MatchStats.GetMatchId(),
                card.cardId,
                card.cardHp,
                MatchStats.GetHeroUsername()
            );
        }

        public async Task MonsterAttack(int attackerId, int attackerOffense, int deffenderId, int deffenderHp)
        {
            await _connection.SendAsync(NetworkCall.MonsterAttack,
                MatchStats.GetMatchId(),
                MatchStats.GetHeroUsername(),
                attackerId,
                attackerOffense,
                deffenderId,
                deffenderHp);
        }

        public async Task EndTurn()
        {
            await _connection.SendAsync(NetworkCall.EndTurn, MatchStats.GetMatchId());
        }

        public void RegisterMatchStats(MatchStats stats)
        {
            MatchStats = stats;
        }
    }
}
