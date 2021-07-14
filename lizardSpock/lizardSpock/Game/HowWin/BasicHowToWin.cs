
using System;
using System.Collections.Generic;
using System.Linq;


namespace Game.HowWin
{


    public class BasicHowToWin : IHowToWin
    {
        private static readonly IDictionary<GameCircle,GameCircle[]> winTo = 
            new  Dictionary<GameCircle,GameCircle[]>()
            {
                [GameCircle.Rock]    =  new [] {GameCircle.Lizard, GameCircle.Scissor},
                [GameCircle.Paper]   =  new [] {GameCircle.Rock, GameCircle.Spock},
                [GameCircle.Scissor] =  new [] {GameCircle.Lizard, GameCircle.Paper},
                [GameCircle.Lizard]  =  new [] {GameCircle.Paper, GameCircle.Spock},
                [GameCircle.Spock]   =  new [] {GameCircle.Rock, GameCircle.Scissor},
            };

       

        public GameResult itWinsTo( GameCircle one, GameCircle other )
        {
            if(one == other) 
            { 
                return GameResult.Draw; 
            }

            var isOneWinner = winTo[one].ToList().Contains(other);
            
            var result = (isOneWinner) ? GameResult.Win: GameResult.Lose;
            return result;
        }


        ///Scissors cuts paper. Paper covers rock. Rock crushes lizard. Lizard poisons Spock. Spock smashes scissors. Scissors decapitates lizard. Lizard eats paper. Paper disproves Spock. Spock vaporizes rock. Rock crushes scissors.


        private static readonly IDictionary<string, string> rules =
         new Dictionary<string, string>(){
            ["ScissorsPaper"] = "Scissors cuts paper",
            ["RockLizard"] ="Rock crushes lizard.",
            ["LizardSpock"] = "Lizard poisons Spock",
            ["PaperRock"] = "Paper covers rock",
            ["SpockScissors"] = "Spock smashes scissors",
            ["ScissorsLizard"] = "Scissors decapitates lizard."
            
         };

        public  string explain(GameCircle one, GameCircle other)
        {
            if(one == other) return "Are equals!";

            var key = $"{one}{other}";
            var result = rules.ContainsKey(key)? rules[key] : "I don't know";
            return result;
        }

    }


}