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

        static char[][] blockCollection = {
            new char[] {'B','O'},
            new char[] {'X','K'},
            new char[] {'D','Q'},
            new char[] {'C','P'},
            new char[] {'N','A'},
            new char[] {'G','T'},
            new char[] {'R','E'},
            new char[] {'T','G'},
            new char[] {'Q','D'},
            new char[] {'F','S'},
            new char[] {'J','W'},
            new char[] {'H','U'},
            new char[] {'V','I'},
            new char[] {'A','N'},
            new char[] {'O','B'},
            new char[] {'E','R'},
            new char[] {'F','S'},
            new char[] {'L','Y'},
            new char[] {'P','C'},
            new char[] {'Z','M'}
        };
        
        private static void can_make_word(string word)
        {
            List<int> blockTracker = new List<int>();

            foreach( char letter in word)
            {
                bool letterFound = false;
            
                for(int i = 0; i < blockCollection.Length; i++)
                {
                    for(int j = 0; j < blockCollection[i].Length; j++)
                    {
                        letterFound = assessLetter(letter, blockCollection[i][j], i, blockTracker);
                        if (letterFound == true)
                        {
                            break;
                        }
                    }
                    if (letterFound == true)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine(word.Length == blockTracker.Count);
        }

        private static bool assessLetter(char letter, char blockLetter, int blockPosition, List<int> blockTracker)
        {
            if(letter == blockLetter && !blockTracker.Contains(blockPosition))
            {
                blockTracker.Add(blockPosition);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
