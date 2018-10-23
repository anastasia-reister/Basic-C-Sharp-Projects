﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Deck
    {
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
        public List<Card> Cards { get; set; } //property Cards  - list of type Card
    }
}