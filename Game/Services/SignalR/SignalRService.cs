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
        public event Action<int[], int[]> OnReceiveCardDecks;

        public MatchStats matchStats;

        public SignalRService(HubConnection connection)
        {
            _connection = connection;

            _connection.On<int>(NetworkCall.ReceiveCode,
                code => MatchIdReceived?.Invoke(code));

            _connection.On<string>(NetworkCall.ReceiveFailure,
                failureMsg => OnGameJoinFailureReceived?.Invoke(failureMsg));

            _connection.On<string,int>(NetworkCall.StartGame,
                (opponentUsername, matchId) => OnGameStartSignalReceived?.Invoke(opponentUsername, matchId));

            _connection.On<int[], int[]>(NetworkCall.ReceiveCardDecks, 
                (heroCards, opponentCards) => OnReceiveCardDecks?.Invoke(heroCards, opponentCards));
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
        public async Task PlaceCard(int matchId, int cardId, string username)
        {
            await _connection.SendAsync(NetworkCall.PlaceCard, matchId, cardId, username);
        }
        public void RegisterMatchStats(MatchStats stats)
        {
            matchStats = stats;
        }

    }
}
