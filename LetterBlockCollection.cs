using System.Collections.Generic;
using System.Collections.ObjectModel;
namespace ABC
{
    public class LetterBlockCollection
    {
        public LetterBlockCollection()
        {
            this.Collection = CreateLetterBlockCollection();
        }

        public List<LetterBlock> Collection;

        public List<LetterBlock> CreateLetterBlockCollection()
        {
            List<LetterBlock> blockCollection = new List<LetterBlock>();
            blockCollection.Add(new LetterBlock('B','O'));
            blockCollection.Add(new LetterBlock('X','K'));
            blockCollection.Add(new LetterBlock('D','Q'));
            blockCollection.Add(new LetterBlock('C','P'));
            blockCollection.Add(new LetterBlock('N','A'));
            blockCollection.Add(new LetterBlock('G','T'));
            blockCollection.Add(new LetterBlock('R','E'));
            blockCollection.Add(new LetterBlock('T','G'));
            blockCollection.Add(new LetterBlock('Q','D'));
            blockCollection.Add(new LetterBlock('F','S'));
            blockCollection.Add(new LetterBlock('J','W'));
            blockCollection.Add(new LetterBlock('H','U'));
            blockCollection.Add(new LetterBlock('V','I'));
            blockCollection.Add(new LetterBlock('A','N'));
            blockCollection.Add(new LetterBlock('O','B'));
            blockCollection.Add(new LetterBlock('E','R'));
            blockCollection.Add(new LetterBlock('F','S'));
            blockCollection.Add(new LetterBlock('L','Y'));
            blockCollection.Add(new LetterBlock('P','C'));
            blockCollection.Add(new LetterBlock('Z','M'));
            return blockCollection;
        }
    }
}