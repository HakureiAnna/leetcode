public class Solution {
 


        public int[] TopKFrequent(int[] nums, int k)
        {
            var freqTbl = new Dictionary<int, int>();
            int i = 0;
            for (i=0; i<nums.Length; ++i)
            {
                if (freqTbl.ContainsKey(nums[i]))
                {
                    freqTbl[nums[i]]++;
                } else
                {
                    freqTbl[nums[i]] = 1;
                }
            }

            var topK = new LinkedList<KeyValuePair<int, int>>();
            LinkedListNode<KeyValuePair<int, int>> current = null;

            foreach (var freq in freqTbl)
            {
                if (topK.Count == 0)
                {
                    topK.AddFirst(freq);
                }
                else
                {                    
                    current = topK.First;
                    while (current != null && current.Value.Value < freq.Value)
                    {
                        current = current.Next;
                    }
                    if (current != null)
                        topK.AddBefore(current, freq);
                    else
                        topK.AddLast(freq);
                    if (topK.Count > k)
                        topK.RemoveFirst();
                }
            }

            var topKs = new int[k];
            current = topK.First;
            i = 0;
            while (current != null)
            {
                topKs[i++] = current.Value.Key;
                current = current.Next;
            }
            return topKs;
        }
}