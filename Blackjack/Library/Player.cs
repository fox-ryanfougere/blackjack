using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Library
{
    class Player
    {
        public string name { get; set; }
        public Deck hand = new Deck();
    }
}
