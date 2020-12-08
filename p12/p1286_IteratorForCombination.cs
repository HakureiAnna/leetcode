    public class CombinationIterator
    {
        string characters;
        int combinationLength;
        int[] limits;
        int[] indices;

        public CombinationIterator(string characters, int combinationLength)
        {
            this.characters = characters;
            this.combinationLength = combinationLength;

            limits = new int[combinationLength];
            indices = new int[combinationLength];
            for (var i=0;i<combinationLength; ++i)
            {
                limits[i] = characters.Length - combinationLength + i;
                indices[i] = i;
            }
        }

        public string Next()
        { 
            var sb = new StringBuilder();
            foreach (var id in indices)
                sb.Append(characters[id]);

            var i = combinationLength - 1;
            while (i >0 && indices[i] + 1 > limits[i])
                i--;
            indices[i]++;
            for (i++; i < indices.Length; ++i)
                indices[i] = indices[i - 1] + 1;

            return sb.ToString();

        }

        public bool HasNext()
        {
            return indices[0] <= limits[0];
        }
    }

/**
 * Your CombinationIterator object will be instantiated and called as such:
 * CombinationIterator obj = new CombinationIterator(characters, combinationLength);
 * string param_1 = obj.Next();
 * bool param_2 = obj.HasNext();
 */