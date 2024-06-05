using BattleShipGameDesignPatterns.Adapters;
using BattleShipGameDesignPatterns.Models;
using BattleShipGameDesignPatterns.Observer;
using BattleShipGameDesignPatterns.Strategies;

namespace BattleShipGameDesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create players
            var player1 = new Player("Player 1");
            var player2 = new Player("Player 2");

            // Create game and add players as observers
            var game = new Game();
            game.AddObserver(player1);
            game.AddObserver(player2);

            // Start game
            game.StartGame();

            // Select attack strategy
            IAttackStrategy randomStrategy = new RandomAttackStrategy();
            IAttackStrategy targetedStrategy = new TargetedAttackStrategy();

            // Create adapter for the attack strategy
            IGameAdapter adapter = new GameAdapter(randomStrategy);

            // Execute attack using adapter
            adapter.ExecuteAttack(2, 3);

            // Change strategy and execute another attack
            adapter = new GameAdapter(targetedStrategy);
            adapter.ExecuteAttack(5, 6);
        }
    }
}
