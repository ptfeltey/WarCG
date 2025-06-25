using System;
namespace WarCG
{
	public class Card
	{
		public enum Value
		{
			Two,
			Three,
			Four,
			Five,
			Six,
			Seven,
			Eight,
			Nine,
			Ten,
			Jack,
			Queen,
			King,
			Ace
		}

		public enum Suit
		{
			Spade,
			Heart,
			Club,
			Diamond
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

