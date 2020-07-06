using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            var strs = new string[]
            {
                "flower",
                "flow",
                "flight"
            };

            var prg = new Program();
            Console.WriteLine(prg.LongestCommonPrefix(strs));
        }

        public string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0)
                return "";
            else if (strs.Length == 1)
                return strs[0];
            char ch;
            int min = Int32.MaxValue;
            foreach (var s in strs)
            {
                if (s.Length < min)
                    min = s.Length;
            }
            for (var i = 0; i < min; ++i)
            {
                ch = strs[0][i];
                for (var j = 1; j < strs.Length; ++j)
                {
                    if (strs[j][i] != ch)
                    {
                        return strs[0].Substring(0, i);
                    }
                }
            }
            return strs[0].Substring(0, min);
        }
    }
}