using System.Collections.Generic;
using Game.Interfaces;

namespace Game.ViewModels
{
    public class ArenaSideViewModel : IObservable
    {
        public (int cardId, int cardHp)[] Cards { get => _cards; set
            {
                _cards = value;
            }
        }

        private bool[] _cardStatus;

        private (int cardId, int cardHp)[] _cards;

        private readonly List<IObserver> _observers;

        public ArenaSideViewModel(int length)
        {
            _observers = new List<IObserver>();
            Cards = new (int,int)[length];
            _cardStatus = new bool[length];
            ResetCardStatus();
        }

        public void UpdateCards(int[] cards, int[] hps)
        {
            for(int i = 0; i < cards.Length; i++)
            {
                Cards[i] = (cards[i], hps[i]);
            }
            Notify();
        }

        public void ResetCardStatus()
        {
            for(int i = 0; i < _cardStatus.Length; i++)
            {
                _cardStatus[i] = false;
            }
            Notify();
        }

        public void SetCardStatus(int id, bool value)
        {
            _cardStatus[id] = value;
        }

        public bool GetStatusAtId(int id)
        {
            return _cardStatus[id];
        }

        public void Subscribe(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Unsubscribe(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }
    }
}
