using Game.Interfaces;
using Game.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Commands
{
    class EndTurnCommand : ICommand
    {
        private SignalRService service;

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
