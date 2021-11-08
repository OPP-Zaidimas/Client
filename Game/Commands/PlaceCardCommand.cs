using Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Commands
{
    class PlaceCardCommand : IUndoableCommand
    {
        public Task<bool> Execute()
        {
            throw new NotImplementedException();
        }

        public void undo()
        {
            
        }
    }
}
