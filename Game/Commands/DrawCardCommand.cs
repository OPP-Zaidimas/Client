using Game.Interfaces;
using Game.Models;
using Game.Views.User_Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Commands
{
    class DrawCardCommand : ICommand
    {

        private readonly Deck _deck;

        private HandView _handView;

        public DrawCardCommand(Deck deck, HandView handView)
        {
            _handView = handView;
            _deck = deck;
        }

        public void execute()
        {
            var card = _deck.Draw();

            _handView.AddCard(card);
        }
    }
}
