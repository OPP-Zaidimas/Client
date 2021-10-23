using System.Collections.Generic;
using Game.Interfaces;
using Game.Models.Card;

namespace Game.ViewModels
{
    public class HandViewModel : IObservable
    {
        public ICard[] Cards { get; }


        private readonly List<IObserver> _observers;

        public HandViewModel(int length)
        {
            Cards = new ICard[length];

            _observers = new List<IObserver>();
        }

        public void AddCard(ICard card)
        {
            for (int i = 0; i < Cards.Length; i++)
            {
                if (Cards[i] != null)
                {
                    continue;
                }

                Cards[i] = card;
                Notify();
                return;
            }
        }

        public int IdAt(int index)
        {
            return Cards[index].Id;
        }

        public void RemoveCard(int index)
        {
            Cards[index] = null;
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
