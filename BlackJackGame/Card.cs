using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackGame
{
    class Card
    {
        public string Suit { get; set; }
        public string Card_name { get; set; }
        public int Value { get; set; }
        public bool used { get; set; }

        public bool hidden { get; set; }

        public Card(string suit, string card_name, int value, bool used, bool hidden)
        {
            this.Suit = suit;
            this.Card_name = card_name;
            this.Value = value;
            this.used = used;
            this.hidden = hidden;

        }
    }
}
