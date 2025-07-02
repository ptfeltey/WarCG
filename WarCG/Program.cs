using System;
using WarCG;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var CurrentCard = new Card();
            CurrentCard.CardVal = Card.Value.Queen;
            Console.WriteLine(CurrentCard.CardVal);
            
            var Deck = new Deck();

            return;
        }
    }
};