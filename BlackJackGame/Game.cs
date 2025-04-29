using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace BlackJackGame
{
    internal class Game
    {
        public Deck deck = new Deck();
        public Hand player_hand = new Hand();
        public Hand dealer_hand = new Hand();
        Random rand = new Random();

        public void dealCardPlayer()
        {
            int index = rand.Next(deck.cards.Count);
            player_hand.hand_cards.Add(deck.cards[index]); 
            deck.cards.RemoveAt(index);

        }
        public void dealDealer(bool hidden)
        {
            int index = rand.Next(deck.cards.Count);
            deck.cards[index].hidden = hidden;
            dealer_hand.hand_cards.Add(deck.cards[index]);
            deck.cards.RemoveAt(index);
        }

        public int calculateTotal(Hand hand)
        {
            int total = hand.hand_cards.Sum(card => card.Value);
            int aceCount = hand.hand_cards.Count(c => c.Card_name == "Ace");
            while (total > 21 && aceCount > 0)
            {
                total -= 10;
                aceCount--;
            }
            return total;
        }

        


    }
}
