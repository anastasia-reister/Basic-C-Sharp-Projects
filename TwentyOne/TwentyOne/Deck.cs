using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Deck
    {
        //Constructor---------------------------------------
        public Deck()//construction name always same as name of class
        {
            Cards = new List<Card>(); //instantiating property Cards as an empty list
            List<string> Suits = new List<string>() { "Spades", "Clubs", "Hearts", "Diamonds" };
            List<string> Faces = new List<string>()
            {
                "Two", "Three", "Four", "Five", "Six", "Seven",
                "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"
            };

            foreach (string face in Faces)
            {
                foreach(string suit in Suits)
                {
                    Card card = new Card();
                    card.Suit = suit;
                    card.Face = face;
                    Cards.Add(card);
                }
            }

        }

        //Properties------------------------------------------
        public List<Card> Cards { get; set; } //property Cards  - list of type Card
        
        //Methods-------------------------------------------
        public void Shuffle(int times = 1) //removed 'static' -- now method applies to its own class
                                            //replaced Deck with void, because now doesn't need to return deck
        {
            for (int i = 0; i < times; i++)
            {
                List<Card> TempList = new List<Card>();
                Random random = new Random();

                while (Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, Cards.Count); //creates a random number between 0 and 52
                    TempList.Add(Cards[randomIndex]); //moves an item from list deck.Cards to Templist at randomNumber index
                    Cards.RemoveAt(randomIndex); //removes that item from Cards list
                }
                Cards = TempList; //assignes all values of TempList to deck.Cards
            }
        }
    }
}
