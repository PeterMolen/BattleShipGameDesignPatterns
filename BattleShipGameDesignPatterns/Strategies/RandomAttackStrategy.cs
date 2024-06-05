using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShipGameDesignPatterns.Strategies
{
    // Strategy Design Pattern
    public class RandomAttackStrategy : IAttackStrategy
    {
        public void Attack(int x, int y)
        {
            Console.WriteLine($"Randomly attacking at ({x}, {y})");
        }
    }
}
