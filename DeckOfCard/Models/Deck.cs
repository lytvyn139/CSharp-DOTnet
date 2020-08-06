using System;
using System.Collections.Generic;

namespace CardDeck.models
{
    public class Deck
    {
        //Give the Deck class a property called "cards" which is a list of Card objects.
        public List<Card> cards = new List<Card> { };

        ///When initializing the deck, make sure that it has a list of 52 unique cards as its "cards" property.
        public Deck()
        {
            string[] stringvals = new string[] { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
            string[] suits = new string[] { "Clubs", "Spades", "Hearts", "Diamonds" };
            for (int j = 0; j < suits.Length; j++)
            {
                for (int i = 0; i < stringvals.Length; i++)
                {
                    cards.Add(new Card(stringvals[i], suits[j], i + 1));
                }
            }
        }
        //Give the Deck a deal method that selects the "top-most" card, removes it from the list of cards, and returns the Card.
        public Deck PickCard()
        {
            if (cards.Count == 0)
            {
                Console.WriteLine("no cards left");
            }
            else
            {
                Console.WriteLine($"There are now {cards.Count} cards left in the stack");
                cards.Remove(cards[0]);
            }
            return this;
        }

        //Give the Deck a reset method that resets the cards property to contain the original 52 cards.
        public Deck Reset()
        {
            Deck newdeck = new Deck();
            cards = newdeck.cards;
            Console.WriteLine("---- deck was reseted");
            return this;
        }

        //Give the Deck a shuffle method that randomly reorders the deck's cards.
        public Deck Shuffle()
        {
            Console.WriteLine("Shuffling cards");
            Random rand = new Random();
            for (int i = 0; i < cards.Count; i++)
            {
                int index = rand.Next(cards.Count);
                Card temp = cards[i];
                cards[i] = cards[index];
                cards[index] = temp;
            }
            return this;
        }
    }
}