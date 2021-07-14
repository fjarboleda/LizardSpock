using System;
using System.Collections.Generic;



namespace Game.Player
{

    public class HumanPlayer : IPlayer
    {
        public readonly string name;


        public HumanPlayer(string aName)
        {
            this.name = aName;
        }

        public string getName() => this.name;
       

        private static IDictionary<char,GameCircle> selection = 
            new  Dictionary<char,GameCircle>()
            {
                ['R'] = GameCircle.Rock,
                ['S'] = GameCircle.Scissor,
                ['P'] = GameCircle.Paper,
                ['L'] = GameCircle.Lizard,
                ['K'] = GameCircle.Spock,
            };


        private GameCircle getSelection( char Key)
        {
            var result = selection.ContainsKey(Key) ? selection[Key] : GameCircle.Error;
            return result;
        } 

        private static readonly string NOT_EMPTY_INPUT = "X";

        public  GameCircle Select()
        {
            var result = GameCircle.Error;

            while(true) 
            {
                Console.WriteLine($"{this.name}, select the Element:");
                Console.Write("\t[R]ock, [P]aper, [S]cissor, [L]izard or Spoc[K] > ");

                var selected = Console.ReadLine() ?? string.Empty;
                var my_char = char.ToUpper( (selected + NOT_EMPTY_INPUT ).Trim()[0]);

                result = getSelection( my_char ); 

                #region OUT_POINT
                if( GameCircle.Error != result) 
                {
                    return result;
                }
                #endregion OUT_POINT

                Console.WriteLine($"Error when you enter '{selected}'.");

            }
           
        }


    }




}
