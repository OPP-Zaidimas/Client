using System.Collections;
using System.Collections.Generic;

namespace Game.Models.Card
{
    public class CardList : IReadOnlyList<ICard>
    {
        public int Count => _cards.Length;

        private readonly ICard[] _cards;

        public CardList(int length)
        {
            _cards = new ICard[length];
        }

        public void Add(ICard card)
        {
            for (int i = 0; i < _cards.Length; i++)
            {
                if (_cards[i] != null) continue;

                _cards[i] = card;
                return;
            }
        }

        public ICard this[int index] => At(index);

        public ICard At(int index)
        {
            return _cards[index];
        }

        public void RemoveAt(int index)
        {
            _cards[index] = null;
        }

        public IEnumerator<ICard> GetEnumerator()
        {
            return new CardEnumerator(_cards);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
