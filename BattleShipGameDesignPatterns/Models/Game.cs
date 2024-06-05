using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleShipGameDesignPatterns.Observer;

namespace BattleShipGameDesignPatterns.Models
{

    public class Game
    {
        private readonly List<IObserver> _observers = new List<IObserver>();

        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void NotifyObservers(string message)
        {
            foreach (var observer in _observers)
            {
                observer.Update(message);
            }
        }

        public void StartGame()
        {
            NotifyObservers("The game has started! Lets'a Go!");
        }
    }
}
