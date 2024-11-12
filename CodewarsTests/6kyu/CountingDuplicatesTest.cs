using Codewars._6kyu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodewarsTests._6kyu
{
    public class CountingDuplicatesTest
    {
        [Fact]
        public void KataTests()
        {
            Assert.Equal(0, CountingDuplicates.Run(""));
            Assert.Equal(0, CountingDuplicates.Run("abcde"));
            Assert.Equal(2, CountingDuplicates.Run("aabbcde"));
            Assert.Equal(2, CountingDuplicates.Run("aabBcde"));
            Assert.Equal(1, CountingDuplicates.Run("Indivisibility"));
            Assert.Equal(2, CountingDuplicates.Run("Indivisibilities"));
        }

        [Fact]
        public void RandomTests()
        {
            var random = new Random();
            string randomStr;

            for (int i = 0; i < 10; i++)
            {
                randomStr =
                  String.Join("", Enumerable.Range(0, 20).Select((o, x) => (char)random.Next('a', 'z') + (char)random.Next('A', 'Z')));

                var expected = Solution(randomStr);
                Assert.Equal(expected, CountingDuplicates.Run(randomStr));
            }
        }

        public static int Solution(string str)
        {
            str = String.Join("", str.ToLower().OrderBy(c => c));
            return Regex.Matches(str, @"(.)\1+").Count;
        }
    }
}
