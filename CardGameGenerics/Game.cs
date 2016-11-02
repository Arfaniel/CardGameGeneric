using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameGenerics
{
    class Game
    {
        public CardDeck deck = new CardDeck();
        List<Player> gamers = new List<Player>();

        public Game()
        {
            Player one = new Player();
            Player two = new Player();
            gamers.Add(one);
            gamers.Add(two);
        }
        public void CardDistribution()
        {
            for (int i = 0; i < (deck.Count + 1) / 2; i++)
            {
                gamers[0].takeCard(deck.NextCard);
                gamers[1].takeCard(deck.NextCard);
            }
        }
        public void Print()
        {
            for (int i = 0; i < gamers[0].myCards.Count; i++)
            {
                Console.WriteLine(gamers[0].myCards[i]);
            }
            for (int i = 0; i < gamers[1].myCards.Count; i++)
            {
                Console.WriteLine(gamers[1].myCards[i]);
            }
        }
        public void Play()
        {

            for(;;)
            {
                if (gamers[0].myCards.Count == 0 || gamers[1].myCards.Count == 0)
                    break;
                if (gamers[0].myCards[0].Value >= gamers[1].myCards[0].Value)
                {
                    gamers[0].myCards.Add(gamers[1].myCards[0]);
                    gamers[1].myCards.RemoveAt(0);
                    continue;
                }
                if (gamers[0].myCards[0].Value < gamers[1].myCards[0].Value)
                {
                    gamers[1].myCards.Add(gamers[0].myCards[0]);
                    gamers[0].myCards.RemoveAt(0);
                    continue;
                }
            }
        }
        public void Winner()
        {
            if(gamers[1].myCards.Count == 0)
                Console.WriteLine("Победил Первый игрок");
            if (gamers[0].myCards.Count == 0)
                Console.WriteLine("Победил Второй игрок");
        }
    }
}
