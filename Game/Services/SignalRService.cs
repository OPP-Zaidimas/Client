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

        public SignalRService(HubConnection connection)
        {
            _connection = connection;

            _connection.On<int>("ReceiveCode", (code) => MatchIdReceived.Invoke(code));
        }

        public async Task Connect()
        {
            await _connection.StartAsync();
        }
        public async Task CreateNewGame()
        {
            await _connection.SendAsync("CreateNewGame");
        }
    }
}
