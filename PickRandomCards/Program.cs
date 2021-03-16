using System;

namespace PickRandomCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of cards to pick: ");
            string line = Console.ReadLine();
            do
            {
                foreach (string card in CardPicker.PickSomeCards(numberOfCards))
                {
                    Console.WriteLine(card);
                }
            }
            while (int.TryParse(line, out int numberOfCards) != true) ;
            Console.WriteLine("Please enter a valid number. ");

        }
    }
}
