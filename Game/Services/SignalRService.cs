using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            _connection.On<int>("ReceiveCode", 
                (code) => MatchIdReceived(code));

            _connection.On<string>("ReceiveFailure", 
                (failureMsg) => OnGameJoinFailureReceived(failureMsg));
            
            _connection.On<string>("StartGame", 
                (opponentUsername) => OnGameStartSignalReceived(opponentUsername));
        }

        public async Task Connect()
        {
            await _connection.StartAsync();
        }
        public async Task CreateNewGame(string username)
        {
            await _connection.SendAsync("CreateNewGame", username);
        }
        public async Task JoinGame(int matchId, string username)
        {
            await _connection.SendAsync("JoinGame", matchId, username);
        }
    }
}
