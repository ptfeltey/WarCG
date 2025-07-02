  using System;
namespace WarCG
{
	public class Card
	{
		public enum Value
		{
			Two,   // 0
			Three, // 1
			Four,  // 2
            Five,  // 3
            Six,   // 4
            Seven, // 5
            Eight, // 6
            Nine,  // 7
            Ten,   // 8
            Jack,  // 9
            Queen, // 10
            King,  // 11
            Ace    // 12
        }

		public enum Suit
		{
			Spade,   // 0
			Heart,   // 1
            Club,    // 2
            Diamond  // 3
		}

		private Value _cardVal { get; set; }
		public Value CardVal
		{
			get
			{
				return _cardVal;
			}

			set

			{
				_cardVal = value;
			}
		}
		private Suit _cardSuit { get; set; }
        public Suit CardSuit
        {
            get
            {
                return _cardSuit;
            }

            set

            {
                _cardSuit = value;
            }
        }

        public Card()
		{

		}

	}
}

