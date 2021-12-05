using Game.Interfaces;
using System.Threading.Tasks;
using Game.Services.SignalR;

namespace Game.Commands
{
    public class EndTurnCommand : ICommand
    {
        private readonly SignalRService service;

        public EndTurnCommand(SignalRService service)
        {
            this.service = service;
        }

        public async Task<bool> Execute()
        {
            //logic for ending the turn
            await service.EndTurn();
            return true;
        }
    }
}
