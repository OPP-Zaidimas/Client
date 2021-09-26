using Game.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Game.Commands
{
    class CreateGameCommand : ICommand
    {
        public SignalRService _service;
        public CreateGameCommand(SignalRService service)
        {
            _service = service;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public async void Execute(object parameter)
        {
            await _service.CreateNewGame();
        }
    }
}
