using System;
using Game.Models.Card;
using Game.Services;
using Game.Services.AbstractFactory;

namespace Game.Models
{
    public class Deck
    {
        private readonly ICardFactory _factory;
        private readonly CardBuilder _builder;
        private readonly Random _rnd;

        public Deck(ICardFactory factory, CardBuilder builder)
        {
            _factory = factory;
            _builder = builder;

            _rnd = new Random();
        }

        public ICard Draw()
        {
            int id = _rnd.Next(1, 5);
            var card = _builder.CreateCard(id);

            return card;
        }
    }
}
