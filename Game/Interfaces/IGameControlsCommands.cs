using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Interfaces
{
    interface IGameControlsCommands
    {
        void OnGameFailureReceived(string failureMsg);
        void OnGameStartReceived(string opponentUsername, int matchId);
    }
}
