using System;

using Game.Player;
using Game.HowWin;

namespace Game
{

    public class Game
    {
        private readonly IPlayer player_one;
        private readonly IPlayer player_two;

        private readonly IHowToWin how_win;

        public Game(IPlayer aPlayerOne, IPlayer aPlayerTwo, IHowToWin aHowToWin)
        {
            this.player_one = aPlayerOne;
            this.player_two = aPlayerTwo;

            this.how_win = aHowToWin;
        }



        public void Play( )
        {
            Console.WriteLine("New Game!");

            var p1 = player_one.Select();
            var p2 = player_two.Select();

            Console.WriteLine($"{player_one.getName()} select a '{p1}'!") ;
            Console.WriteLine($"{player_two.getName()} select a '{p2}'!") ;

            var winOrNot = how_win.itWinsTo( p1, p2 );
            
            Console.WriteLine($"The player {player_one.getName()} get {winOrNot} from {player_two.getName()}." );
            Console.WriteLine($"...because of {how_win.explain( p1, p2 )}.");
            Console.WriteLine("Finish!");
        }

    }
}