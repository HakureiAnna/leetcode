public class Solution {
        public bool WordPattern(string pattern, string str)
        {
            var refTable = new Dictionary<char, string>();
            var words = str.Split(" ");
            var i = 0;
            var len = words.Length;
            if (words.Length != pattern.Length)
                return false;
            while (i < len)
            {
                Console.WriteLine(words[i]);
                if (!refTable.ContainsKey(pattern[i]))
                {
                    if (!refTable.ContainsValue(words[i]))
                    {
                        refTable[pattern[i]] = words[i];
                        i++;
                        continue;
                    }
                    else
                    {
                        refTable[pattern[i]] = "";
                    }
                }
                if (refTable[pattern[i]].CompareTo(words[i]) != 0) 
                    return false;
                ++i;
            }
            return true;
        }
}