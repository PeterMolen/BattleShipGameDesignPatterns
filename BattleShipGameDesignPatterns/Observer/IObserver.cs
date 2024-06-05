using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShipGameDesignPatterns.Observer
{
    // Observer Design Pattern
    public interface IObserver
    {
        void Update(string message);
    }
}
