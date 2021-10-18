using System;
using System.Collections.Generic;
using Game.Interfaces;

namespace Game.ViewModels
{
    public class ArenaSideViewModel : IObservable
    {
        public int[] _cards { get; }

        private readonly List<IObserver> _observers;

        public ArenaSideViewModel(int length)
        {
            _cards = new int[length];
            _observers = new List<IObserver>();
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
