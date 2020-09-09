using System.Collections.Generic;

namespace ABC
{
    public class LetterBlock
    {
        public LetterBlock(char firstLetter, char secondLetter)
        {
            this.Letters = new List<char>() {
                firstLetter, 
                secondLetter
            };
            this.Length = 2;
        }

        public List<char> Letters { get; private set; }
        public int Length { get; private set; }
    }
}