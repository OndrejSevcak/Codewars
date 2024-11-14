using Codewars._4kyu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodewarsTests._4kyu
{
    public class SnailTest
    {
        [Fact]
        public void SnailTest1()
        {
            int[][] array =
            {
                new []{1, 2, 3},
                new []{4, 5, 6},
                new []{7, 8, 9}
            };

            var r = new[] { 1, 2, 3, 6, 9, 8, 7, 4, 5 };
            Assert.Equal(Snail.Run(array), r);
        }

        [Fact]
        public void SnailTest2()
        {
            int[][] array =
            {
                new []{1, 2, 3, 4},
                new []{5, 6, 7, 8},
                new []{9, 10, 11, 12},
                new []{13, 14, 15, 16}
            };

            var r = new[] { 1, 2, 3, 4, 8, 12, 16, 15, 14, 13, 9, 5, 6, 7, 11, 10 };
            Assert.Equal(Snail.Run(array), r);
        }
    }
}
