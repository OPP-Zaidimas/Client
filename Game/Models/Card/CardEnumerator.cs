using System;
using System.Collections;
using System.Collections.Generic;

namespace Game.Models.Card
{
    public class CardEnumerator : IEnumerator<ICard>
    {
        public ICard Current => _cards[_position];
        object IEnumerator.Current => Current;

        private readonly ICard[] _cards;

        private int _position = -1;

        public CardEnumerator(ICard[] cards)
        {
            _cards = cards;
        }

        public bool MoveNext()
        {
            return ++_position < _cards.Length;
        }

        public void Reset()
        {
            _position = -1;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
