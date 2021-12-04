using System.Collections.Generic;
using Game.Interfaces;
using Game.Models.Card;

namespace Game.ViewModels
{
    public class HandViewModel : IObservable
    {
        public CardList Cards { get; }

        private readonly List<IObserver> _observers;

        public HandViewModel(int length)
        {
            Cards = new CardList(length);

            _observers = new List<IObserver>();
        }

        public void AddCard(ICard card)
        {
            Cards.Add(card);
            Notify();
        }

        public (int, int) IdAt(int index)
        {
            return (Cards[index].Id, Cards[index].CurrentHp);
        }

        public void RemoveCard(int index)
        {
            Cards.RemoveAt(index);
            Notify();
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
