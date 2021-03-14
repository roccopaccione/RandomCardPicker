using System;
namespace PickRandomCards
{
    public class CardPicker
    {
        public CardPicker()
        {
            static Random random = new Random();

            public static string[] PickSomeCards(int numberOfCards)
            {
                string[] pickedCards = new string[numberOfCards];
                for (int i = 0; i < numberOfCards; i++)
                {
                    pickedCards[i] = RandomValue() + " of " + RandomSuit();
                }
                return pickedCards;
            }
        }

        private static string RandomSuit()
        {
            throw new NotImplementedException();
        }

        private static string RandomValue()
        {
            throw new NotImplementedException();
        }
    }
}
