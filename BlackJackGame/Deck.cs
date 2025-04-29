using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackGame
{
    internal class Deck
    {
        public List<Card> cards { get; set; }

        public Deck()
        {
            cards = new List<Card>();

            string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
            string[] names = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };
            int[] values = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 11 };

            foreach (string suit in suits)
            {
                for (int i = 0; i < names.Length; i++)
                {
                    cards.Add(new Card(suit, names[i], values[i], false));
                }
            }
        }

    }

}
