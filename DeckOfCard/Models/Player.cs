using System;
using System.Collections.Generic;

namespace CardDeck.models
{

    public class Player
    {
        //Give the Player class a name property.
        public string Name;
        //Give the Player a hand property that is a List of type Card
        public List<Card> hand = new List<Card> { };


        public Deck playerDeck = new Deck();
        public Player(string name)
        {
            Name = name;
        }
        /* 
        Give the Player a draw method of which draws a card from a deck, adds it to the player's hand and returns the Card.
        Note this method will require reference to a deck object */
        public Player SelectCard(Deck playerDeck)
        {
            Console.WriteLine("Picking up card");
            hand.Add(playerDeck.cards[0]);
            playerDeck.PickCard();
            //Console.WriteLine($"{Name} has  card");
            return this;

        }
        public void showHand()
        {
            if (hand.Count == 0)
            {
                System.Console.WriteLine($"{Name}'s hand is empty");
            }
            else
            {
                System.Console.WriteLine($"{Name} has {hand.Count} cards:");
                foreach (Card card in hand)
                {
                    card.ReadCard();
                }

            }
        }

        //Give the Player a discard method which discards the Card at the specified index from the player's hand and returns this Card or null if the index does not exist.
        public Player Discard(int index)
        {
            if (hand.Count == 0)
            {
                System.Console.WriteLine($"{Name} has nothing to discard");
            }
            else
            {
                if (index > hand.Count - 1)
                {
                    return null;
                }
                else
                {
                    System.Console.Write($"{Name} discarded ");
                    hand[index].ReadCard();
                    hand.RemoveAt(index);

                }
            }
            return this;
        }
    }

}