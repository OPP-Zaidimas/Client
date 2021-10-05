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
        public event Action<string> OnGameStartSignalReceived;

        public SignalRService(HubConnection connection)
        {
            _connection = connection;

            _connection.On<int>(NetworkCall.ReceiveCode,
                code => MatchIdReceived?.Invoke(code));

            _connection.On<string>(NetworkCall.ReceiveFailure,
                failureMsg => OnGameJoinFailureReceived?.Invoke(failureMsg));

            _connection.On<string>(NetworkCall.StartGame,
                opponentUsername => OnGameStartSignalReceived?.Invoke(opponentUsername));
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
    }
}
