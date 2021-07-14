using System;
using System.Collections.Generic;



namespace Game.Player
{



    public class ComputerEqualPlayer : IPlayer
    {
        public string name { get; set; }

        private static int autoPlayer = 1;

        private Random comRandom = new  Random();

        public ComputerEqualPlayer()
        {
           

            lock (typeof(ComputerEqualPlayer))
            {
                this.name = $"COM{autoPlayer++}";
            }
        }


        ~ComputerEqualPlayer()
        {
            lock (typeof(ComputerEqualPlayer))
            {
                autoPlayer--;
            }
        }


        public string getName() => this.name;


        public GameCircle Select()
        {        
           var result =  (GameCircle) comRandom.Next(1, 5)  ;          
           return result;
        }


    }

}