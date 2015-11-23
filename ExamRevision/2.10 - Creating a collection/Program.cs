using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._10
{
    class Program
    {

        class Card {
            public string name;

            public Card(string n){
                name = n;
            }
            
        }
        class Deck
        {
            public ICollection<Card> cards { get; private set; }

            public Deck(){
                cards = new List<Card>();
                cards.Add(new Card("Card 0"));
                cards.Add(new Card("Card 1"));
                cards.Add(new Card("Card 2"));
            }

            public Card this[int index]
            {
                get { return cards.ElementAt(index); }
            }
        }


        static void Main(string[] args)
        {
            Deck deck = new Deck();

            Console.WriteLine(deck[0].name);
            Console.WriteLine(deck[2].name);
            Console.WriteLine(deck[1].name);


            Console.Read();
        }
    }
}
