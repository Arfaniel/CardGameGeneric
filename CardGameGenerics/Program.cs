using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            Game igra = new Game();
            igra.CardDistribution();
            igra.Play();
            igra.Winner();
        }
    }
}
