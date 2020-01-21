using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Library
{
    class Deck
    {
        public List<Card> AllCards = new List<Card>();


        public void AddCard(string suit, string face, int value)
        {
            var card = new Card();

            card.suit = suit;
            card.face = face;
            card.value = value;

            AllCards.Add(card);
        }

        public void AddCard(Card card)
        {
            AllCards.Add(card);
        }

        public Card NextCard()
        {
            Card topcard = AllCards.ElementAt(0);

            AllCards.RemoveAt(0);

            return topcard;
        }

        public void FillDeck()
        {
            AddCard("D", "1", 11);
            AddCard("D", "2", 2);
            AddCard("D", "3", 3);
            AddCard("D", "4", 4);
            AddCard("D", "5", 5);
            AddCard("D", "6", 6);
            AddCard("D", "7", 7);
            AddCard("D", "8", 8);
            AddCard("D", "9", 9);
            AddCard("D", "10", 10);
            AddCard("D", "11", 10);
            AddCard("D", "12", 10);
            AddCard("D", "13", 10);

            AddCard("S", "1", 11);
            AddCard("S", "2", 2);
            AddCard("S", "3", 3);
            AddCard("S", "4", 4);
            AddCard("S", "5", 5);
            AddCard("S", "6", 6);
            AddCard("S", "7", 7);
            AddCard("S", "8", 8);
            AddCard("S", "9", 9);
            AddCard("S", "10", 10);
            AddCard("S", "11", 10);
            AddCard("S", "12", 10);
            AddCard("S", "13", 10);

            AddCard("H", "1", 11);
            AddCard("H", "2", 2);
            AddCard("H", "3", 3);
            AddCard("H", "4", 4);
            AddCard("H", "5", 5);
            AddCard("H", "6", 6);
            AddCard("H", "7", 7);
            AddCard("H", "8", 8);
            AddCard("H", "9", 9);
            AddCard("H", "10", 10);
            AddCard("H", "11", 10);
            AddCard("H", "12", 10);
            AddCard("H", "13", 10);

            AddCard("C", "1", 11);
            AddCard("C", "2", 2);
            AddCard("C", "3", 3);
            AddCard("C", "4", 4);
            AddCard("C", "5", 5);
            AddCard("C", "6", 6);
            AddCard("C", "7", 7);
            AddCard("C", "8", 8);
            AddCard("C", "9", 9);
            AddCard("C", "10", 10);
            AddCard("C", "11", 10);
            AddCard("C", "12", 10);
            AddCard("C", "13", 10);
        }

        public void ShuffleDeck()
        {
            Utilities.Shuffle(AllCards);


            //}
        }
    }
}
