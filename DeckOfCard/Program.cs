using System;

namespace CardDeck.models
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Card game");
            Deck NewDeck = new Deck();
            Player Player1 = new Player("Player1");
            Player Player2 = new Player("Player2");
            NewDeck.Shuffle();
            Player1.SelectCard(NewDeck);
            Player1.SelectCard(NewDeck);
            Player1.SelectCard(NewDeck);
            Player1.showHand();
            Player2.SelectCard(NewDeck);
            Player2.SelectCard(NewDeck);
            Player2.SelectCard(NewDeck);
            Player2.showHand();


            //d1.PickCard();
            //d1.Reset();
            //Console.WriteLine(d1.cards.Count);
            // Player1.SelectCard(NewDeck);
            // Player1.SelectCard(NewDeck);
            // Player1.SelectCard(NewDeck);
            // Player1.SelectCard(NewDeck);
            // Player1.SelectCard(NewDeck);
            // Player1.showHand();
            // Player2.SelectCard(NewDeck);
            // Player2.SelectCard(NewDeck);
            // Player2.SelectCard(NewDeck);
            // Player2.SelectCard(NewDeck);
            // Player2.SelectCard(NewDeck);
            // Player2.showHand();
            // Player1.Discard(2);
            // Player1.SelectCard(NewDeck);
            // Player1.showHand();
            // Player2.Discard(3);
            // Player2.SelectCard(NewDeck);
            // Player2.showHand();
            // NewDeck.Shuffle();
            // NewDeck.Reset();
        }
    }
}
