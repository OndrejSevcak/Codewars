using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars._6kyu
{
    //Write a function that will return the count of distinct case-insensitive alphabetic characters
    //and numeric digits that occur more than once in the input string.
    //The input string can be assumed to contain only alphabets (both uppercase and lowercase) and numeric digits.

    //"abcde" -> 0
    //"aabBcde" -> 2
    //"Indivisibilities" -> 2

    public class CountingDuplicates
    {
        public static int Run(string input)
        {
            return input.ToLower().ToCharArray().GroupBy(c => c).Where(g => g.Count() > 1).Count();
        }
    }
}
