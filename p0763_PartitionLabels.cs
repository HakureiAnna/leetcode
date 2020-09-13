public class Solution {  
    public IList<int> PartitionLabels(string S)
        {
            var s = S.ToCharArray();
            var start = 0;
            var limit = 1;
            var len = S.Length;
            var remaining = len;
            var result = new List<int>();
            while (remaining > 0)
            {
                // get first character in current interval
                var current = s[start];
                //Console.WriteLine("initial char: {0}", current);
                for (var i=start; i<len; ++i)
                {
                    if (s[i] == current)
                    {
                        s[i] = '-';
                        limit = i + 1;
                        remaining--;
                    }
                }
                // find subsequent characters in current interval
                while (true)
                {
                    current = '-';
                    for (var i = start; i < limit; ++i)
                    {
                        if (s[i] != '-')
                        {
                            current = s[i];
                            break;
                        }
                    }

                    if (current == '-')
                    {
                        result.Add(limit - start);
                        //Console.WriteLine("start: {0}, limit: {1}, s: {2}", start, limit, new String(s));
                        start = limit;
                        break;
                    }

                    //Console.WriteLine("alt char: {0}", current);
                    for (var i = start; i < len; ++i)
                    {
                        if (s[i] == current)
                        {
                            s[i] = '-';
                            limit = Math.Max(limit, i + 1);
                            remaining--;
                        }
                    }
                }
                
            }
            return result;
        }
}