using Codewars._6kyu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodewarsTests._6kyu
{
    public class EqualSidesOfAnArrayTest
    {
        [Fact]
        public void Tests()
        {
            Assert.Equal(3,  EqualSidesOfAnArray.FindEvenIndex1(new int[] { 1, 2, 3, 4, 3, 2, 1 }));
            Assert.Equal(1,  EqualSidesOfAnArray.FindEvenIndex1(new int[] { 1, 100, 50, -51, 1, 1 }));
            Assert.Equal(-1, EqualSidesOfAnArray.FindEvenIndex1(new int[] { 1, 2, 3, 4, 5, 6 }));
            Assert.Equal(3,  EqualSidesOfAnArray.FindEvenIndex1(new int[] { 20, 10, 30, 10, 10, 15, 35 }));
            Assert.Equal(-1, EqualSidesOfAnArray.FindEvenIndex1(new int[] { 8, 8 }));
            Assert.Equal(0,  EqualSidesOfAnArray.FindEvenIndex1(new int[] { 8, 0 }));
            Assert.Equal(1,  EqualSidesOfAnArray.FindEvenIndex1(new int[] { 0, 8 }));
            Assert.Equal(0,  EqualSidesOfAnArray.FindEvenIndex1(new int[] { 7, 3, -3 }));
            Assert.Equal(0,  EqualSidesOfAnArray.FindEvenIndex1(new int[] { 8 }));
            Assert.Equal(0,  EqualSidesOfAnArray.FindEvenIndex1(new int[] { 0, 0, 0, 0, 0 }));
            Assert.Equal(2,  EqualSidesOfAnArray.FindEvenIndex1(new int[] { -1, 1, 0, -1, 1, 0, -1, 1, 0, 0 }));

            Assert.Equal(3, EqualSidesOfAnArray.FindEvenIndex2(new int[] { 1, 2, 3, 4, 3, 2, 1 }));
            Assert.Equal(1, EqualSidesOfAnArray.FindEvenIndex2(new int[] { 1, 100, 50, -51, 1, 1 }));
            Assert.Equal(-1,EqualSidesOfAnArray.FindEvenIndex2(new int[] { 1, 2, 3, 4, 5, 6 }));
            Assert.Equal(3, EqualSidesOfAnArray.FindEvenIndex2(new int[] { 20, 10, 30, 10, 10, 15, 35 }));
            Assert.Equal(-1,EqualSidesOfAnArray.FindEvenIndex2(new int[] { 8, 8 }));
            Assert.Equal(0, EqualSidesOfAnArray.FindEvenIndex2(new int[] { 8, 0 }));
            Assert.Equal(1, EqualSidesOfAnArray.FindEvenIndex2(new int[] { 0, 8 }));
            Assert.Equal(0, EqualSidesOfAnArray.FindEvenIndex2(new int[] { 7, 3, -3 }));
            Assert.Equal(0, EqualSidesOfAnArray.FindEvenIndex2(new int[] { 8 }));
            Assert.Equal(0, EqualSidesOfAnArray.FindEvenIndex2(new int[] { 0, 0, 0, 0, 0 }));
            Assert.Equal(2, EqualSidesOfAnArray.FindEvenIndex2(new int[] { -1, 1, 0, -1, 1, 0, -1, 1, 0, 0 }));


            Assert.Equal(3, EqualSidesOfAnArray.FindEvenIndex3(new int[] { 1, 2, 3, 4, 3, 2, 1 }));
            Assert.Equal(1, EqualSidesOfAnArray.FindEvenIndex3(new int[] { 1, 100, 50, -51, 1, 1 }));
            Assert.Equal(-1,EqualSidesOfAnArray.FindEvenIndex3(new int[] { 1, 2, 3, 4, 5, 6 }));
            Assert.Equal(3, EqualSidesOfAnArray.FindEvenIndex3(new int[] { 20, 10, 30, 10, 10, 15, 35 }));
            Assert.Equal(-1,EqualSidesOfAnArray.FindEvenIndex3(new int[] { 8, 8 }));
            Assert.Equal(0, EqualSidesOfAnArray.FindEvenIndex3(new int[] { 8, 0 }));
            Assert.Equal(1, EqualSidesOfAnArray.FindEvenIndex3(new int[] { 0, 8 }));
            Assert.Equal(0, EqualSidesOfAnArray.FindEvenIndex3(new int[] { 7, 3, -3 }));
            Assert.Equal(0, EqualSidesOfAnArray.FindEvenIndex3(new int[] { 8 }));
            Assert.Equal(0, EqualSidesOfAnArray.FindEvenIndex3(new int[] { 0, 0, 0, 0, 0 }));
            Assert.Equal(2, EqualSidesOfAnArray.FindEvenIndex3(new int[] { -1, 1, 0, -1, 1, 0, -1, 1, 0, 0 }));
        }    
    }
}
