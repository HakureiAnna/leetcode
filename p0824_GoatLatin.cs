public class Solution {        public string ToGoatLatin(string S)
        {
            // 1st vowel append ma
            // 1st non-vowel move to end, append ma
            // add more a according to index
            var words = S.Split(' ');
            var vowels = new char[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            var sb = new StringBuilder();
            var aSB = new StringBuilder();
            for (var i=0; i<words.Length; ++i)
            {
                var isVowel = false;
                foreach (var v in vowels) { 
                    if (words[i][0] == v)
                    {
                        isVowel = true;
                        break;
                    }
                }
                sb.Append(words[i].Substring(isVowel ? 0 : 1));
                if (!isVowel)
                {
                    sb.Append(words[i][0]);
                }
                sb.Append("ma");
                aSB.Append("a");
                sb.Append(aSB.ToString());
                if (i < words.Length - 1)
                    sb.Append(" ");
            }
            return sb.ToString();
        }
}