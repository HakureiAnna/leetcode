public class Solution {
        public string IntToRoman(int num)
        {
            var symbols = new string[] {
                "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I"
            };
            var values = new int[] {
                1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1
            };
            var sb = new StringBuilder();
            var i = 0;

            while (num > 0)
            {
                if (num - values[i] >= 0)
                {
                    sb.Append(symbols[i]);
                    num -= values[i];
                } 
                else
                {
                    i++;
                }
            }
            return sb.ToString();
        }
    }