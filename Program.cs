using System;
using System.Collections.Generic;

namespace ABC
{
    class Program
    {
        static void Main(string[] args)
        {
            can_make_word("A");
            can_make_word("BARK");
            can_make_word("BOOK");
            can_make_word("TREAT");
            can_make_word("COMMON");
            can_make_word("SQUAD");
            can_make_word("CONFUSE");
        }


        private static LetterBlockCollection blockCollection = new LetterBlockCollection();
        
        private static void can_make_word(string word)
        {
            List<int> blockTracker = new List<int>();
            AssessEachLetterInWord(word, blockTracker);
            DisplayResult(word, blockTracker);
        }

        private static void AssessEachLetterInWord(string word, List<int> blockTracker)
        {
            foreach( char letter in word)
            {
                AssessLetterAgainstBlockCollection(letter, blockTracker);
            }
        }

        private static void AssessLetterAgainstBlockCollection(char letter, List<int> blockTracker)
        {
            bool letterIsFound = false;
            for(int i = 0; i < blockCollection.Collection.Count; i++)
            {
                for(int j = 0; j < blockCollection.Collection[i].Length; j++)
                {
                    letterIsFound = IsLetterInLetterBlock(letter, blockCollection.Collection[i].Letters[j], i, blockTracker);
                    if (letterIsFound)
                    {
                        AddBlockPositionToTracker(i, blockTracker);
                        break;
                    }
                }
                if (letterIsFound) break;
            }
        }

        private static void CheckAgainstEachBlockLetter()
        {
            
        }

        private static bool IsLetterInLetterBlock(char letter, char blockLetter, int blockPosition, List<int> blockTracker)
        {
            return (letter == blockLetter && !blockTracker.Contains(blockPosition)) ? true : false;
        }

        private static void AddBlockPositionToTracker(int blockPosition, List<int> blockTracker)
        {
            blockTracker.Add(blockPosition);
        }

        private static void DisplayResult(string word, List<int> blockTracker)
        {
            Console.WriteLine(word.Length == blockTracker.Count);
        }
    }
}
