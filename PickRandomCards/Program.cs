using System;

namespace PickRandomCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type in the number of cards to pick: ");
            string line = Console.ReadLine();

            if (int.TryParse(line, out int numberOfCards))
            {
                // executed if line COULD be converted to int that is stored in var numberOfCards
                foreach (string card in CardPicker.PickSomeCards(numberOfCards))
                {
                    Console.WriteLine(card);
                }

            }
            else
            {
                // executed if line could NOT be converted to int
                Console.WriteLine("Invalid input. Please try again.");
            }

            Console.ReadLine();
        }
    }
}
