using System;
using System.Collections.Generic;
using System.Text;

namespace PickRandomCards
{
    class CardPicker
    {
        static Random random = new Random();

        /// <summary>
        /// Picks a number of cards, and returns them.
        /// </summary>
        /// <param name="numberOfCards">The number of cards to pick.</param>
        /// <returns>An array of strings containing the card names.</returns>
        public static string[] PickSomeCards(int numberOfCards)
        {
            string[] pickedCards = new string[numberOfCards];
            for (int i = 0; i < numberOfCards; i++)
            {
                pickedCards[i] = RandomValue() + " of " + RandomSuit();
            }
            return pickedCards;
        }

        private static string RandomValue()
        {
            // Random number from 1 - 13
            int value = random.Next(1, 14);
            // if 1 then return string Ace
            if (value == 1) return "Ace";
            // if 11 then return string Jack
            if (value == 11) return "Jack";
            // if 12 then return string Queen
            if (value == 12) return "Queen";
            // if 13 then return string King
            if (value == 13) return "King";
            // return all other values as string type
            return value.ToString();
        }

        private static string RandomSuit()
        {
            // Get random number from 1 - 4
            int value = random.Next(1, 5);
            // if it's 1 then return string Spades
            if (value == 1) return "Spades";
            // if it's 2 then return string Hearts
            if (value == 2) return "Hearts";
            // if it's 3 then return string Clubs
            if (value == 3) return "Clubs";
            // if nothing returned yet, return string Diamonds
            return "Diamonds";
        }
    }
}
