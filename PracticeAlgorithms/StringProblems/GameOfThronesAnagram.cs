using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProblems
{
    public class GameOfThronesAnagram
    {
        public Dictionary<char, int> LetterCount
        {
            get
            {
                return letterCount;
            }

        }

        public void PopulateLetterCount(string words)
        {
            var keys = letterCount.Keys;

            foreach (char letter in words)
            {
                if (keys.Contains(letter))
                {
                    letterCount[letter] += 1;
                }
                else
                {
                    letterCount[letter] = 1;
                }
            }
        }

        public string IsAnagram(string words)
        {
            PopulateLetterCount(words);
            int totalChars = words.Length;
            int oddTotal = totalChars % 2;
            var counts = letterCount.Values;
            int oddCount = 0;

            foreach (var lc in counts)
            {
                int oddLc = lc % 2;
                if (oddLc == 1)
                {
                    oddCount += 1;
                }
            }

            string isAnagram = "NO";
            if (oddTotal == 1)
            {
                if (oddCount == 1)
                {
                    isAnagram = "YES";
                }
            }

            if (oddTotal == 0)
            {
                if (oddCount == 0)
                {
                    isAnagram = "YES";
                }
            }

            return isAnagram;
        }
        private Dictionary<char, int> letterCount = new Dictionary<char, int>();
    }
}
