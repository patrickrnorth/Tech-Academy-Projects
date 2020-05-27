using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {                                   
            Deck deck = new Deck();

            //int count = deck.Cards.Count(x => x.Face == Face.Two);

            //List<Card> newList = deck.Cards.Where(x => x.Face == Face.King).ToList();
            //List<int> numList = new List<int>() { 1, 2, 3, 4, 5, 6, 45 };
            //int sum = numList.Where(x => x >20).Sum();
            //Console.WriteLine(sum);
            
            
            //foreach (Card card in newList)
            //{
            //    Console.WriteLine(card.Face);
            //}
            
            
            //deck.Shuffle(3);

            //foreach (Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);
            //}
            //Console.WriteLine(deck.Cards.Count);
            //Console.ReadLine();
        }
    }
}
