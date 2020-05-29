using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace TwentyOne
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        public void Deal(List<Card> Hand)
        {
            Hand.Add(Deck.Cards.First());
            string card = string.Format(Deck.Cards.First().ToString() + "\n");//writes to log
            Console.WriteLine(card);
            using (StreamWriter file = new StreamWriter(@"C:\Users\Public\Documents\log.txt", true))//cleans up memory
            {
                file.WriteLine(card);
            }
                Deck.Cards.RemoveAt(0);
        }
    }
}
