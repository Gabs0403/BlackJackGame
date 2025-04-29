using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackGame
{
    internal class Hand
    {

        public List<Card> hand_cards { get; set; }
        public Hand() {
            hand_cards = new List<Card>();
        }



    }
}
