using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameGenerics
{
    class CardDeck : List<Card>
    {
        private static Random rand = new Random();
        private int _count = 0;
        public CardDeck()
        {
            for (int i = 0; i < 35; i++)
            {
                Add(new Card{ Value = i});
            }

            Shuffle();

        }
        private void Shuffle()
        {
            for (int i = 0; i < Count; i++)
            {
                int rnd = rand.Next(35);
                Card temp = this[i];
                this[i] = this[rnd];
                this[rnd] = temp;
            }
        }
        public Card NextCard
        {
            get
            {
                if(_count == Count)
                {
                    _count = 0;
                    Shuffle();
                    
                }
                return this[_count++];
            }
        }

    }
}
