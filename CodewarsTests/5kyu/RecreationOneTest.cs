using Codewars._5kyu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodewarsTests._5kyu
{
    public class RecreationOneTest
    {
        [Fact]
        public void Test01()
        {
            Assert.Equal("[[1, 1], [42, 2500], [246, 84100]]", RecreationOne.Run(1, 250));
        }

        [Fact]
        public void Test02()
        {
            Assert.Equal("[[42, 2500], [246, 84100]]", RecreationOne.Run(42, 250));
        }

        [Fact]
        public void Test03()
        {
            Assert.Equal("[[287, 84100]]", RecreationOne.Run(250, 500));
        }

        [Fact]
        public void Test04()
        {
            Assert.Equal("[]", RecreationOne.Run(300, 600));
        }

        [Fact]
        public void Test05()
        {
            Assert.Equal("[[728, 722500], [1434, 2856100]]", RecreationOne.Run(600, 1500));
        }

        [Fact]
        public void Test06()
        {
            Assert.Equal("[[1673, 2856100]]", RecreationOne.Run(1500, 1800));
        }

        [Fact]
        public void Test07()
        {
            Assert.Equal("[[1880, 4884100]]", RecreationOne.Run(1800, 2000));
        }

        [Fact]
        public void Test08()
        {
            Assert.Equal("[]", RecreationOne.Run(2000, 2200));
        }

        [Fact]
        public void Test09()
        {
            Assert.Equal("[[4264, 24304900]]", RecreationOne.Run(2200, 5000));
        }

        [Fact]
        public void Test10()
        {
            Assert.Equal("[[6237, 45024100], [9799, 96079204], [9855, 113635600]]", RecreationOne.Run(5000, 10000));
        }
    }
}
