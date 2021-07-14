
using Game.Player;
using Game.HowWin;

namespace lizardSpock
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new Game.Game( new HumanPlayer("Lupe"), new ComputerEqualPlayer(), new BasicHowToWin());
            game.Play();
        }
    }
}
