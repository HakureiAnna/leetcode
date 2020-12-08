public class Solution {
        public int RomanToInt(string s)
        {
            // M - 1000
            // D - 500
            // C - 100
            // L - 50
            // X - 10
            // V - 5
            // I - 1

            var symbols = new List<Symbol>()
            {
                new Symbol
                {
                    symbol = 'M',
                    value = 1000,
                    prefix = 'C',
                    prefixedValue = 900
                },
                new Symbol
                {
                    symbol = 'D',
                    value = 500,
                    prefix = 'C',
                    prefixedValue = 400
                },
                new Symbol
                {
                    symbol = 'C',
                    value = 100,
                    prefix = 'X',
                    prefixedValue = 90
                },
                new Symbol
                {
                    symbol = 'L',
                    value = 50,
                    prefix = 'X',
                    prefixedValue = 40
                },
                new Symbol
                {
                    symbol = 'X',
                    value = 10,
                    prefix = 'I',
                    prefixedValue = 9
                },
                new Symbol
                {
                    symbol = 'V',
                    value = 5,
                    prefix = 'I',
                    prefixedValue = 4
                },
                new Symbol
                {
                    symbol = 'I',
                    value = 1,
                    prefix = ' ',
                    prefixedValue = 0
                },
            };

            var currentSymbolId = 0;
            var value = 0;
            var currentSymbol = symbols[currentSymbolId];
            for (var i=0; i< s.Length; ++i)
            {
                if (s[i] == currentSymbol.symbol)
                {
                    value += currentSymbol.value;
                } else if (i < s.Length - 1 && s[i] == currentSymbol.prefix && s[i+1] == currentSymbol.symbol)
                {
                    value += currentSymbol.prefixedValue;
                    i++;
                } else
                {
                    currentSymbolId++;
                    currentSymbol = symbols[currentSymbolId];
                    i--;
                }
            }
            return value;
        }

    }

    class Symbol
    {
        public char symbol;
        public char prefix;
        public int value;
        public int prefixedValue;
    }