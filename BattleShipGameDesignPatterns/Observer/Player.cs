using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShipGameDesignPatterns.Observer
{

    // Observer Design Pattern
    public class Player : IObserver
    {
        public string Name { get; }

        public Player(string name)
        {
            Name = name;
        }

        public void Update(string message)
        {
            Console.WriteLine($"{Name} received update: {message}");
        }
    }
}
