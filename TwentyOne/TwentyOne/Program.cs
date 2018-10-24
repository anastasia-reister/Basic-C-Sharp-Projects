using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {


            //parent  =     Child
            Game game = new TwentyOneGame(); //has to be initialized with polymorphism so the TwentyOne game is of type Game, 
            //therefore can be used in operator method that expects object of type Game
            //operator method now can be used for any child of class Game.

            game.Players = new List<Player>(); //List instantiated. Without this it only existed as a property of Game class 
            //and could not be accesed. 
            Player player = new Player();
            player.Name = "Jesse";
            game += player;
            game -= player;
           

            

            Deck deck = new Deck(); //instantiate deck
            deck.Shuffle();

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.Read();
        }

       

        
    }
}
