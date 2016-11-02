using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameGenerics
{
    class Player
    {
        public List<Card> myCards = new List<Card>();
        public int _counter = 0;

        public void takeCard (Card toBottom)
        {
            myCards.Add(toBottom);
            _counter++;
        }
        public void ShowCard()
        {
            Console.WriteLine(myCards[0]);
        }
    }
}
