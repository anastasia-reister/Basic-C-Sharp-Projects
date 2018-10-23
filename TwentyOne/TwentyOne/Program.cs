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
            Deck deck = new Deck(); //instantiate deck
            deck = Shuffle(deck);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.Read();
        }

        public static Deck Shuffle(Deck deck)
        {
            List<Card> TempList = new List<Card>();
            Random random = new Random();

            while(deck.Cards.Count > 0)
            {
                int randomIndex = random.Next(0, deck.Cards.Count); //creates a random number between 0 and 52
                TempList.Add(deck.Cards[randomIndex]); //moves an item from list deck.Cards to Templist at randomNumber index
                deck.Cards.RemoveAt(randomIndex); //removes that item from Cards list
            }

            deck.Cards = TempList; //assignes all values of TempList to deck.Cards
            return deck;
        }
    }
}
