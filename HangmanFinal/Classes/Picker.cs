using System;
using System.Collections.Generic;

namespace HangmanFinal.Classes
{
    public static class Picker
    {
        //we only need one instance of the random object...
        private static readonly Random random = new Random();
        //this is our synchronize object...
        private static readonly object syncLock = new object();

        private static List<string> Words = new List<string>
            {
                "CAPITAL",
                "CRASH",
                "BURN",
                "ANGEL",
                "BLACKJACKS",
                "JACKHAMMER",
                "CHRISTMAS",
                "ZULU",
                "BOAT",
                "TRAVERSE"
            };

        public static string selectedWord = "";


        // SET SELECTED WORD TO A RANDOM WORD FROM THE LIST...
        public static string SelectWord()
        {
            int i = RandomNumberGen();
            selectedWord = Words[i];
            RemoveWordFromList(i);
            return selectedWord;
        }

        //remove word from the array...
        private static void RemoveWordFromList(int i)
        {
            Words.Remove(Words[i]);
        }


        private static int RandomNumberGen()
        {
            //this is so we dont access the same thread at the same time...
            lock (syncLock)
            {
                return random.Next(0, Words.Count);
            }

        }

    }
}
